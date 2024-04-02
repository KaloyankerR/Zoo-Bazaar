using BusinessLogicObjectLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using BusinessLogicLayer;

namespace DataAccessLayer
{
    public class AnimalDAL : IAnimalDAL
    {

        public string SaveAnimal(Animal animal)
        {
            string query = "INSERT INTO animals_table (ID, CageID, CageName, RegionID, RegionName, Name, DateOfBirth, Age, Gender, AnimalType, TypeOfFood, AdopterName, Description, Picture) " +
                           "VALUES (@ID, @CageID, @CageName, @RegionID, @RegionName, @Name, @DateOfBirth, @Age, @Gender, @AnimalType, @TypeOfFood, @AdopterName, @Description,  @Picture)";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@ID", animal.ID);
                        cmd.Parameters.AddWithValue("@CageID", animal.CageID);
                        cmd.Parameters.AddWithValue("@CageName", animal.CageName);
                        cmd.Parameters.AddWithValue("@RegionID", animal.RegionID);
                        cmd.Parameters.AddWithValue("@RegionName", animal.RegionName);
                        cmd.Parameters.AddWithValue("@Name", animal.Name);
                        cmd.Parameters.AddWithValue("@DateOfBirth", animal.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", animal.Age);
                        cmd.Parameters.AddWithValue("@Gender", animal.Gender);
                        cmd.Parameters.AddWithValue("@AnimalType", animal.AnimalType);
                        cmd.Parameters.AddWithValue("@TypeOfFood", animal.TypeOfFood.ToString());
                        cmd.Parameters.AddWithValue("@AdopterName", animal.AdopterName);
                        cmd.Parameters.AddWithValue("@Description", animal.Description);
                        cmd.Parameters.AddWithValue("@Picture", animal.Picture);


                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        return $"Animal '{animal.Name}' saved successfully.";
                    }
                    catch (Exception ex)
                    {
                        return $"Error saving animal: {ex.Message}";
                    }
                }
            }
        }

        public List<Animal> GetAllAnimals()
        {
            List<Animal> animals = new List<Animal>();

            string query = "SELECT * FROM animals_table";

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
                                Animal animal = new Animal
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CageID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Gender = reader["Gender"].ToString(),
                                    AnimalType = reader["AnimalType"].ToString(),
                                    TypeOfFood = Enum.Parse<TypeOfFood>(reader["TypeOfFood"].ToString()),
                                    AdopterName = reader["AdopterName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Picture = reader["Picture"] as byte[]

                                };

                                animals.Add(animal);
                            }
                        }

                        return animals;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals: {ex.Message}");
                        return null;
                    }
                }
            }
        }


        public List<Animal> GetAnimalsByRegionName(string regionName)
        {
            List<Animal> animals = new List<Animal>();

            string query = "SELECT * FROM animals_table WHERE RegionName = @RegionName";

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
                            while (reader.Read())
                            {
                                Animal animal = new Animal
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CageID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Gender = reader["Gender"].ToString(),
                                    AnimalType = reader["AnimalType"].ToString(),
                                    TypeOfFood = Enum.Parse<TypeOfFood>(reader["TypeOfFood"].ToString()),
                                    AdopterName = reader["AdopterName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Picture = reader["Picture"] as byte[]

                                };

                                animals.Add(animal);
                            }
                        }

                        return animals;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals by RegionName: {ex.Message}");
                        return null;
                    }
                }
            }
        }




        public List<Animal> GetAllAnimalsByBreed(string breed)
        {
            List<Animal> animals = new List<Animal>();

            string query = "SELECT * FROM animals_table WHERE CONCAT(AnimalType) LIKE @breed";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@breed", $"%{breed}%");

                        Console.WriteLine($"Executing query: {cmd.CommandText}");

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Animal animal = new Animal
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CageID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Gender = reader["Gender"].ToString(),
                                    AnimalType = reader["AnimalType"].ToString(),
                                    TypeOfFood = Enum.Parse<TypeOfFood>(reader["TypeOfFood"].ToString()),
                                    AdopterName = reader["AdopterName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Picture = reader["Picture"] as byte[]

                                };

                                animals.Add(animal);
                            }
                        }

                        return animals;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals by breed: {ex.Message}");
                        return null;
                    }
                }
            }
        }

        public Animal GetAnimalById(int id)
        {
            string query = "SELECT * FROM animals_table WHERE ID = @id";
            Animal animal = null;

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@id", id);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                animal = new Animal
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CageID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Gender = reader["Gender"].ToString(),
                                    AnimalType = reader["AnimalType"].ToString(),
                                    TypeOfFood = Enum.Parse<TypeOfFood>(reader["TypeOfFood"].ToString()),
                                    AdopterName = reader["AdopterName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Picture = reader["Picture"] as byte[]

                                };
                            }
                        }

                        return animal;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animal by ID: {ex.Message}");
                        return null;
                    }
                }
            }
        }


        public string DeleteAnimalById(int id)
        {
            string query = "DELETE FROM animals_table WHERE ID = @id";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameter
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Animal with ID {id} deleted successfully.";
                        }
                        else
                        {
                            return $"No animal found with ID {id}.";
                        }
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error deleting animal by ID: {ex.Message}");
                        return $"Error deleting animal by ID: {ex.Message}";
                    }
                }
            }
        }



        public string UpdateAnimal(Animal updatedAnimal)
        {
            string query = "UPDATE animals_table SET CageID = @CageID, CageName = @CageName, RegionID = @RegionID, RegionName = @RegionName, " +
                           "Name = @Name, DateOfBirth = @DateOfBirth, Age = @Age, Gender = @Gender, AnimalType = @AnimalType, " +
                           "TypeOfFood = @TypeOfFood, AdopterName = @AdopterName, Description = @Description, Picture = @Picture " +
                           "WHERE ID = @ID";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Set parameters
                        cmd.Parameters.AddWithValue("@CageID", updatedAnimal.CageID);
                        cmd.Parameters.AddWithValue("@CageName", updatedAnimal.CageName);
                        cmd.Parameters.AddWithValue("@RegionID", updatedAnimal.RegionID);
                        cmd.Parameters.AddWithValue("@RegionName", updatedAnimal.RegionName);
                        cmd.Parameters.AddWithValue("@Name", updatedAnimal.Name);
                        cmd.Parameters.AddWithValue("@DateOfBirth", updatedAnimal.DateOfBirth);
                        cmd.Parameters.AddWithValue("@Age", updatedAnimal.Age);
                        cmd.Parameters.AddWithValue("@Gender", updatedAnimal.Gender);
                        cmd.Parameters.AddWithValue("@AnimalType", updatedAnimal.AnimalType);
                        cmd.Parameters.AddWithValue("@TypeOfFood", updatedAnimal.TypeOfFood.ToString());
                        cmd.Parameters.AddWithValue("@AdopterName", updatedAnimal.AdopterName);
                        cmd.Parameters.AddWithValue("@Description", updatedAnimal.Description);
                        cmd.Parameters.AddWithValue("@Picture", updatedAnimal.Picture);
                        cmd.Parameters.AddWithValue("@ID", updatedAnimal.ID);

                        // Execute the query
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            return $"Animal with ID '{updatedAnimal.ID}' updated successfully.";
                        }
                        else
                        {
                            return $"Animal with ID '{updatedAnimal.ID}' not found.";
                        }
                    }
                    catch (Exception ex)
                    {
                        return $"Error updating animal: {ex.Message}";
                    }
                }
            }
        }


        public List<Animal> GetAnimalsByCageID(int cageID)
        {
            List<Animal> animals = new List<Animal>();

            string query = "SELECT * FROM animals_table WHERE CageID = @CageID";

            using (MySqlConnection connection = DatabaseLink.CreateConnection())
            {
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    try
                    {
                        connection.Open();

                        // Add parameter to the query to filter by CageID
                        cmd.Parameters.AddWithValue("@CageID", cageID);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Animal animal = new Animal
                                {
                                    ID = Convert.ToInt32(reader["ID"]),
                                    CageID = Convert.ToInt32(reader["CageID"]),
                                    CageName = reader["CageName"].ToString(),
                                    RegionID = Convert.ToInt32(reader["RegionID"]),
                                    RegionName = reader["RegionName"].ToString(),
                                    Name = reader["Name"].ToString(),
                                    DateOfBirth = DateOnly.FromDateTime(reader.GetDateTime("DateOfBirth")),
                                    Age = Convert.ToInt32(reader["Age"]),
                                    Gender = reader["Gender"].ToString(),
                                    AnimalType = reader["AnimalType"].ToString(),
                                    TypeOfFood = Enum.Parse<TypeOfFood>(reader["TypeOfFood"].ToString()),
                                    AdopterName = reader["AdopterName"].ToString(),
                                    Description = reader["Description"].ToString(),
                                    Picture = reader["Picture"] as byte[]
                                };

                                animals.Add(animal);
                            }
                        }

                        return animals;
                    }
                    catch (Exception ex)
                    {
                        // Handle the exception as needed
                        Console.WriteLine($"Error getting animals by CageID: {ex.Message}");
                        return null;
                    }
                }
            }
        }



    }
}
