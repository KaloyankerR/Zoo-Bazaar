using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace DataAccessLayer
{
    public class RegionDAL : IRegionDAL
    {


        public string CreateRegion(ZooRegion region)
        {
            
            string query = "INSERT INTO regions (Name, TypeOfAnimals, CagesCapacity, AnimalsCapacity, CagesAssigned, AnimalsAssigned) " +
                           "VALUES (@Name, @TypeOFAnimals, @CagesCapacity, @AnimalsCapacity, @CagesAssigned, @AnimalsAssigned)";

            using (MySqlConnection connection =  DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@Name", region.Name);
                        cmd.Parameters.AddWithValue("@TypeOFAnimals", region.TypeOfAnimals);
                        cmd.Parameters.AddWithValue("@CagesCapacity", region.CagesCapacity);
                        cmd.Parameters.AddWithValue("@AnimalsCapacity", region.AnimalsCapacity);
                        cmd.Parameters.AddWithValue("@CagesAssigned", region.CagesAssigned);
                        cmd.Parameters.AddWithValue("@AnimalsAssigned", region.AnimalsAssigned);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return $"Region '{region.Name}' saved successfully.";
                    }
                    catch (Exception ex)
                    {
                        return $"Error saving region: {ex.Message}";
                    }
                }
            }
        }

        public List<ZooRegion> ReadAllRegions()
        {
            List<ZooRegion> regions = new List<ZooRegion>();

            string query = "SELECT * FROM regions";

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
                                ZooRegion region = new ZooRegion
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    TypeOfAnimals = reader["TypeOfAnimals"].ToString(),
                                    CagesCapacity = Convert.ToInt32(reader["CagesCapacity"]),
                                    AnimalsCapacity = Convert.ToInt32(reader["AnimalsCapacity"]),
                                    CagesAssigned = Convert.ToInt32(reader["CagesAssigned"]),
                                    AnimalsAssigned = Convert.ToInt32(reader["AnimalsAssigned"])
                                };

                                regions.Add(region);
                            }
                        }

                        return regions;
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error reading regions: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public string DeleteRegionById(int regionId)
        {
            string query = "DELETE FROM regions WHERE ID = @RegionId";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@RegionId", regionId);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Region with ID {regionId} deleted successfully.";
                        }
                        else
                        {
                            return $"No region found with ID {regionId}.";
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        return $"Error deleting region: {ex.Message}";
                    }
                }
            }
        }


        public ZooRegion GetRegionByName(string regionName)
        {
            string query = "SELECT * FROM regions WHERE Name = @RegionName";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@RegionName", regionName);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ZooRegion existingRegion = new ZooRegion
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    TypeOfAnimals = reader["TypeOfAnimals"].ToString(),
                                    CagesCapacity = Convert.ToInt32(reader["CagesCapacity"]),
                                    AnimalsCapacity = Convert.ToInt32(reader["AnimalsCapacity"]),
                                    CagesAssigned = Convert.ToInt32(reader["CagesAssigned"]),
                                    AnimalsAssigned = Convert.ToInt32(reader["AnimalsAssigned"])
                                };

                                return existingRegion;
                            }
                            else
                            {
                                // No region found with the given name
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error retrieving region: {ex.Message}");
                        return null;
                    }
                }
            }
        }




        public ZooRegion GetRegionByID(int regionID)
        {
            string query = "SELECT * FROM regions WHERE ID = @RegionID";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@RegionID", regionID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                ZooRegion existingRegion = new ZooRegion
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    Name = reader["Name"].ToString(),
                                    TypeOfAnimals = reader["TypeOfAnimals"].ToString(),
                                    CagesCapacity = Convert.ToInt32(reader["CagesCapacity"]),
                                    AnimalsCapacity = Convert.ToInt32(reader["AnimalsCapacity"]),
                                    CagesAssigned = Convert.ToInt32(reader["CagesAssigned"]),
                                    AnimalsAssigned = Convert.ToInt32(reader["AnimalsAssigned"])
                                };

                                return existingRegion;
                            }
                            else
                            {
                                // No region found with the given name
                                return null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle exception
                        Console.WriteLine($"Error retrieving region: {ex.Message}");
                        return null;
                    }
                }
            }
        }


        public string UpdateRegion(int id, ZooRegion updatedRegion)
        {
            string query = "UPDATE regions SET Name = @Name, TypeOfAnimals = @TypeOFAnimals, " +
                           "CagesCapacity = @CagesCapacity, AnimalsCapacity = @AnimalsCapacity, " +
                           "CagesAssigned = @CagesAssigned, AnimalsAssigned = @AnimalsAssigned " +
                           "WHERE Id = @Id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@Id", id);
                        cmd.Parameters.AddWithValue("@Name", updatedRegion.Name);
                        cmd.Parameters.AddWithValue("@TypeOFAnimals", updatedRegion.TypeOfAnimals);
                        cmd.Parameters.AddWithValue("@CagesCapacity", updatedRegion.CagesCapacity);
                        cmd.Parameters.AddWithValue("@AnimalsCapacity", updatedRegion.AnimalsCapacity);
                        cmd.Parameters.AddWithValue("@CagesAssigned", updatedRegion.CagesAssigned);
                        cmd.Parameters.AddWithValue("@AnimalsAssigned", updatedRegion.AnimalsAssigned);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Region with ID {id} updated successfully.";
                        }
                        else
                        {
                            return $"No region found with ID {id}.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error updating region: {ex.Message}";
                    }
                }
            }
        }





    }
}
