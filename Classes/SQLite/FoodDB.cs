using Microsoft.Data.Sqlite;
using System;
using System.Configuration;
using System.Windows.Forms;

namespace TestSeyed.Classes.SQLite
{
    static class FoodDB
    {
        //------------INPUTS-EDIT-REMOVE-------------------
        public static int AddIngredient(string Name,string Scale,double Quantity,DateTime ExpireDate)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    INSERT INTO Ingredients (Name,Scale,Quantity,ExpireDate) 
                    VALUES ($Name,$Scale,$Quantity,$ExpireDate)
                ", conn);
                command.Parameters.AddWithValue("$Name", Name);
                command.Parameters.AddWithValue("$Scale", Scale);
                command.Parameters.AddWithValue("$Quantity", Quantity);
                command.Parameters.AddWithValue("$ExpireDate", ExpireDate.ToString("MM/dd/yyyy"));
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        public static int EditIngredient(long id,string Name, string Scale, double Quantity, DateTime ExpireDate)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    UPDATE Ingredients
                    SET 
                        Name = $Name,
                        Scale = $Scale,
                        Quantity = $Quantity,
                        ExpireDate = $ExpireDate
                    WHERE id = $id;
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                command.Parameters.AddWithValue("$Name", Name);
                command.Parameters.AddWithValue("$Scale", Scale);
                command.Parameters.AddWithValue("$Quantity", Quantity);
                command.Parameters.AddWithValue("$ExpireDate", ExpireDate.ToString("MM/dd/yyyy"));
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        public static int DeleteIngredient(long id)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@" 
                    DELETE FROM Ingredients
                    WHERE id = $id;
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        public static int AddFood(string Name,string Ingredients,bool SelfService,string Category,string Details)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    INSERT INTO Foods (Name,Ingredients,SelfService,Category,Details) 
                    VALUES ($Name,$Ingredients,$SelfService,$Category,$Details) 
                ", conn);
                command.Parameters.AddWithValue("$Name", Name);
                command.Parameters.AddWithValue("$Ingredients", Ingredients);
                command.Parameters.AddWithValue("$SelfService", SelfService);
                command.Parameters.AddWithValue("$Category", Category);
                command.Parameters.AddWithValue("$Details", Details);
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        public static int EditFood(long id,string Name, string Ingredients, bool SelfService, string Category, string Details)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    UPDATE Foods
                    SET
                        Name = $Name,
                        Ingredients = $Ingredients,
                        SelfService = $SelfService,
                        Category = $Category,
                        Details = $Details
                    WHERE id = $id;
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                command.Parameters.AddWithValue("$Name", Name);
                command.Parameters.AddWithValue("$Ingredients", Ingredients);
                command.Parameters.AddWithValue("$SelfService", SelfService?1:0);
                command.Parameters.AddWithValue("$Category", Category);
                command.Parameters.AddWithValue("$Details", Details);
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        public static int DeleteFood(long id)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    DELETE FROM Foods
                    WHERE id = $id;
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return ex.ErrorCode;
                }
            }
        }
        //------------RETRIVE-INFO-FROM-DB-----------------

    }
}
