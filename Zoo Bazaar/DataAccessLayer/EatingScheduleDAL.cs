using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BusinessLogicLayer;
using System.Data;
using System.Collections;
using System.Transactions;
using System.Data.Common;

namespace DataAccessLayer
{
    public class EatingScheduleDAL : IEatingScheduleDAL
    {
        public string DeleteEatingScheduleByAnimal(int id)
        {
            string deleteTimeSlotsQuery = "DELETE FROM eating_schedule_timeslots WHERE eatingscheduleid IN (SELECT eatingscheduleid FROM eating_schedule WHERE animalid = @id)";
            string deleteScheduleQuery = "DELETE FROM eating_schedule WHERE animalid = @id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(deleteTimeSlotsQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();

                        using (MySqlCommand scheduleCmd = new MySqlCommand(deleteScheduleQuery, connection))
                        {
                            scheduleCmd.Parameters.AddWithValue("@id", id);
                            int rowsAffected = scheduleCmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                return $"Eating schedule for animal with ID {id} deleted successfully.";
                            }
                            else
                            {
                                return $"No eating schedule found for animal with ID {id}.";
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error deleting eating schedule: {ex.Message}");
                        return $"Error deleting eating schedule: {ex.Message}";
                    }
                }
            }
        }


        public List<AnimalEatingSchedule> GetAllEatingSchedules()
        {
            List<AnimalEatingSchedule> schedules = new List<AnimalEatingSchedule>();
            string query = "SELECT es.eatingscheduleid, es.animalid, es.nrtimesanimaleats, est.eatingtimeslot " +
                           "FROM eating_schedule es " +
                           "LEFT JOIN eating_schedule_timeslots est ON es.eatingscheduleid = est.eatingscheduleid";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            var scheduleDict = new Dictionary<int, AnimalEatingSchedule>();

                            while (reader.Read())
                            {
                                int scheduleId = reader.GetInt32("eatingscheduleid");
                                if (!scheduleDict.TryGetValue(scheduleId, out var schedule))
                                {
                                    schedule = new AnimalEatingSchedule
                                    {
                                        AnimalEatingScheduleID = scheduleId,
                                        Animal = new Animal { ID = reader.GetInt32("animalid") },
                                        NumberOfTimesADay = reader.GetInt32("nrtimesanimaleats"),
                                        TimeSlots = new List<TimeOnly>()
                                    };
                                    scheduleDict.Add(scheduleId, schedule);
                                    schedules.Add(schedule);
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("eatingtimeslot")))
                                {
                                    schedule.TimeSlots.Add(TimeOnly.Parse(reader.GetString("eatingtimeslot")));
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting all eating schedules: {ex.Message}");
                    }
                }
            }

            return schedules;
        }


        public AnimalEatingSchedule GetEatingScheduleByAnimal(int id)
        {
            AnimalEatingSchedule schedule = null;
            string query = "SELECT es.eatingscheduleid, es.nrtimesanimaleats, est.eatingtimeslot " +
                           "FROM eating_schedule es " +
                           "LEFT JOIN eating_schedule_timeslots est ON es.eatingscheduleid = est.eatingscheduleid " +
                           "WHERE es.animalid = @id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (var cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@id", id);

                    try
                    {
                        connection.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                if (schedule == null)
                                {
                                    schedule = new AnimalEatingSchedule
                                    {
                                        AnimalEatingScheduleID = reader.GetInt32("eatingscheduleid"),
                                        Animal = new Animal { ID = id },
                                        NumberOfTimesADay = reader.GetInt32("nrtimesanimaleats"),
                                        TimeSlots = new List<TimeOnly>()
                                    };
                                }

                                if (!reader.IsDBNull(reader.GetOrdinal("eatingtimeslot")))
                                {
                                    var dateTime = reader.GetDateTime(reader.GetOrdinal("eatingtimeslot"));
                                    var timeOnly = TimeOnly.FromDateTime(dateTime);
                                    schedule.TimeSlots.Add(timeOnly);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error getting eating schedule by animal ID: {ex.Message}");
                    }
                }
            }

            return schedule;
        }

        public string SaveEatingSchedule(AnimalEatingSchedule animalEatingSchedule)
        {
            string query = "INSERT INTO eating_schedule (animalid, nrtimesanimaleats) VALUES (@animalid, @nrtimesanimaleats); SELECT LAST_INSERT_ID();";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@animalid", animalEatingSchedule.Animal.ID);
                        cmd.Parameters.AddWithValue("@nrtimesanimaleats", animalEatingSchedule.NumberOfTimesADay);

                        int lastInsertedID = Convert.ToInt32(cmd.ExecuteScalar());
                        SaveTimeSlots(lastInsertedID, animalEatingSchedule.TimeSlots);

                        return $"Eating schedule for animal with ID {animalEatingSchedule.Animal.ID} saved successfully with ID {lastInsertedID}.";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving eating schedule: {ex.Message}");
                        return $"Error saving eating schedule: {ex.Message}";
                    }
                }
            }
        }

        private void SaveTimeSlots(int scheduleId, List<TimeOnly> timeSlots)
        {
            string query = "INSERT INTO eating_schedule_timeslots (eatingscheduleid, eatingtimeslot) VALUES (@eatingscheduleid, @eatingtimeslot);";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();
                        foreach (var timeSlot in timeSlots)
                        {
                            cmd.Parameters.Clear();

                            DateTime dateTime = DateTime.Today.Add(timeSlot.ToTimeSpan());
                            cmd.Parameters.AddWithValue("@eatingscheduleid", scheduleId);
                            cmd.Parameters.AddWithValue("@eatingtimeslot", dateTime);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error saving time slot: {ex.Message}");
                    }
                }
            }
        }

        public string UpdateEatingSchedule(AnimalEatingSchedule updatedEatingSchedule)
        {
            string updateScheduleQuery = "UPDATE eating_schedule SET nrtimesanimaleats = @nrtimesanimaleats WHERE animalid = @animalid";
            string deleteTimeSlotsQuery = "DELETE FROM eating_schedule_timeslots WHERE eatingscheduleid = @eatingscheduleid";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (var cmd = new MySqlCommand(updateScheduleQuery, connection))
                {
                    try
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@animalid", updatedEatingSchedule.Animal.ID);
                        cmd.Parameters.AddWithValue("@nrtimesanimaleats", updatedEatingSchedule.NumberOfTimesADay);
                        cmd.ExecuteNonQuery();

                        using (var deleteCmd = new MySqlCommand(deleteTimeSlotsQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@eatingscheduleid", updatedEatingSchedule.AnimalEatingScheduleID);
                            deleteCmd.ExecuteNonQuery();
                        }

                        SaveTimeSlots(updatedEatingSchedule.AnimalEatingScheduleID, updatedEatingSchedule.TimeSlots);

                        return $"Eating schedule for animal with ID {updatedEatingSchedule.Animal.ID} updated successfully.";
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error updating eating schedule: {ex.Message}");
                        return $"Error updating eating schedule: {ex.Message}";
                    }
                }
            }
        }
    }
}
