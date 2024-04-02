using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DataAccessLayer
{
    public class BreedDAL : IBreedDAL
    {

        public List<Breed> GetBreadsByRegion(string region)
        {
            List<Breed> breeds = new List<Breed>();

            string query = "SELECT ID, Name, Region, RegionID FROM breeds WHERE Region = @Region";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@Region", region);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Breed breed = new Breed
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    Region = reader["Region"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"])
                                };

                                breeds.Add(breed);
                            }
                        }

                        return breeds;
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error reading breads: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public string SaveBreed(Breed breed)
        {
            string query = "INSERT INTO breeds (Name, Region, RegionID) " +
                           "VALUES (@Name, @Region, @RegionID)";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@Name", breed.Name);
                        cmd.Parameters.AddWithValue("@Region", breed.Region);
                        cmd.Parameters.AddWithValue("@RegionID", breed.RegionID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return $"Breed '{breed.Name}' saved successfully.";
                    }
                    catch (Exception ex)
                    {
                        return $"Error saving breed: {ex.Message}";
                    }
                }
            }
        }



        public List<Breed> GetAllBreeds()
        {
            List<Breed> breeds = new List<Breed>();

            string query = "SELECT * FROM breeds";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Breed breed = new Breed
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    Region = reader["Region"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"])
                                };

                                breeds.Add(breed);
                            }
                        }

                        return breeds;
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error reading breeds: {ex.Message}");
                        return breeds;
                    }
                }
            }
        }


    }
}
