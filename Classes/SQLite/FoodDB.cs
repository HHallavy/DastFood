using DastFood.Classes.Types;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DastFood.Classes.SQLite
{
    static class FoodDB
    {
        private const string sqliteDateFormat = "yyyy-MM-dd";

        //------------INPUTS-EDIT-REMOVE-------------------
        public static int AddIngredient(string Name, string Scale, double Quantity, DateTime ExpireDate)
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
                command.Parameters.AddWithValue("$ExpireDate", ExpireDate.ToString(sqliteDateFormat));
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    if (ex.SqliteErrorCode == 19)
                    {
                        MessageBox.Show(
                            "این ماده اولیه قبلاً اضافه شده",
                            "ورودی تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        return ex.ErrorCode;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return ex.ErrorCode;
                    }

                }
            }
        }
        public static int AddIngredientChangeRecord(long id, double changeAmount, DateTime date)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    
                    UPDATE Ingredients
                    SET Quantity = Quantity + $Change
                    WHERE id = $IngredientID;
                    
                    INSERT INTO IngredientsReports (IngredientID,Change,Date) 
                    VALUES ($IngredientID,$Change,$Date); 

                ", conn);
                command.Parameters.AddWithValue("$IngredientID", id);
                command.Parameters.AddWithValue("$Change", changeAmount);
                command.Parameters.AddWithValue("$Date", date.ToString(sqliteDateFormat));
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    if (ex.SqliteErrorCode == 19)
                    {
                        MessageBox.Show(
                            "این گزارش قبلاً اضافه شده",
                            "ورودی تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        return ex.ErrorCode;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return ex.ErrorCode;
                    }

                }
            }
        }
        public static int EditIngredient(long id, string Name, string Scale, double Quantity, DateTime ExpireDate)
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
                command.Parameters.AddWithValue("$ExpireDate", ExpireDate.ToString(sqliteDateFormat));
                try
                {
                    command.ExecuteNonQuery();
                    conn.Close();
                    return 0;
                }
                catch (SqliteException ex)
                {
                    // Unique Constraint Failed
                    if (ex.SqliteErrorCode == 19)
                    {
                        MessageBox.Show(
                            "این ماده اولیه قبلاً اضافه شده",
                            "ورودی تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        return ex.ErrorCode;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return ex.ErrorCode;
                    }
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
        public static int AddFood(string Name, string Ingredients, bool SelfService, string Category, string Details)
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
                    if (ex.SqliteErrorCode == 19)
                    {
                        MessageBox.Show(
                            "این غذا قبلاً اضافه شده",
                            "ورودی تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        return ex.ErrorCode;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return ex.ErrorCode;
                    }
                }
            }
        }
        public static int EditFood(long id, string Name, string Ingredients, bool SelfService, string Category, string Details)
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
                command.Parameters.AddWithValue("$SelfService", SelfService ? 1 : 0);
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
                    if (ex.SqliteErrorCode == 19)
                    {
                        MessageBox.Show(
                            "این غذا قبلاً اضافه شده",
                            "ورودی تکراری",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                        return ex.ErrorCode;
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        return ex.ErrorCode;
                    }
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
        public static Ingredient GetIngredient(long id)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    SELECT *
                    FROM Ingredients
                    WHERE id = $id
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                try
                {
                    SqliteDataReader Ingredients = command.ExecuteReader();
                    if (Ingredients.Read())
                    {
                        return new Ingredient
                        {
                            id = Ingredients.GetInt32(0 /*Id*/),
                            name = Ingredients.GetString(1 /*name*/),
                            scale = Ingredients.GetString(2/*scale*/),
                            quantity = Ingredients.GetDouble(3/*quantity*/),
                            expireDate = DateTime.Parse(Ingredients.GetString(4/*expireDate*/))
                        };
                    }
                    else
                        return null;

                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static Series GetIngredientReportChartAtMonth(long id, DateTime date)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand("Select(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month')And IngredientId=$IngredientId)) AS Day1,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 1 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+1 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day2,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 2 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+2 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day3,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 3 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+3 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day4,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 4 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+4 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day5,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 5 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+5 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day6,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 6 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+6 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day7,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 7 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+7 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day8,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 8 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+8 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day9,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 9 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+9 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day10,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 10 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+10 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day11,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 11 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+11 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day12,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 12 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+12 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day13,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 13 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+13 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day14,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 14 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+14 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day15,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 15 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+15 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day16,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 16 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+16 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day17,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 17 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+17 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day18,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 18 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+18 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day19,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 19 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+19 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day20,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 20 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+20 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day21,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 21 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+21 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day22,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 22 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+22 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day23,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 23 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+23 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day24,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 24 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+24 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day25,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 25 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+25 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day26,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 26 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+26 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day27,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 27 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+27 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day28,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 28 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+28 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day29,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 29 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+29 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day30,CASE WHEN CAST(strftime('%d',$ReportDate) as INTEGER) > 30 THEN(Select SUM(Change) FROM(SELECT Change from IngredientsReports WHERE Date(IngredientsReports.Date) <= Date($ReportDate,'start of month','+30 day')And IngredientId=$IngredientId)) ELSE NULL END AS Day31"
                    , conn);
                command.Parameters.AddWithValue("$IngredientId", id);
                command.Parameters.AddWithValue("$ReportDate", date.ToString(sqliteDateFormat));
                try
                {
                    SqliteDataReader Report = command.ExecuteReader();
                    if (Report.Read())
                    {
                        Series ReportSeries = new Series(GetIngredient(id).name);
                        for (int i = 0; i < 31; i++)
                        {
                            if (Report.IsDBNull(i))
                                ReportSeries.Points.AddXY(i + 1, 0.0d);
                            else
                                ReportSeries.Points.AddXY(i + 1, Report.GetDouble(i));
                        }
                        return ReportSeries;
                    }
                    else
                        return null;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static Series GetIngredientReportChartA_B(long id, DateTime dateA, DateTime dateB)
        {
            if(dateA == dateB)
            {
                MessageBox.Show(
                            "تاریخ شروع و پایان یکسان هستند.",
                            "بازه تاریخ نامعتبر است",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation,
                            MessageBoxDefaultButton.Button1,
                            MessageBoxOptions.RtlReading
                            );
                return null;
            }
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(DateA_B_SQLcommand(dateA, dateB)
                , conn);
                command.Parameters.AddWithValue("$IngredientId", id);
                if (dateB > dateA)
                    command.Parameters.AddWithValue("$ReportDateA", dateA.ToString(sqliteDateFormat));
                else
                    command.Parameters.AddWithValue("$ReportDateA", dateB.ToString(sqliteDateFormat));
                try
                {
                    SqliteDataReader Report = command.ExecuteReader();
                    Series ReportSeries = new Series(GetIngredient(id).name);

                    if (Report.Read())
                    {
                        int daysBetween = dateB.Subtract(dateA).Days;
                        for (int i = 0; i < daysBetween; i++)
                        {
                            if (Report.IsDBNull(i))
                            {
                                ReportSeries.Points.AddXY(i + 1, 0.0d);
                                ReportSeries.Points[i].AxisLabel = Converter.ShamsiDay(dateA.AddDays(i));
                            }
                            else
                            {
                                ReportSeries.Points.AddXY(i + 1, Report.GetDouble(i));
                                ReportSeries.Points[i].AxisLabel = Converter.ShamsiDay(dateA.AddDays(i));
                            }
                        }
                        return ReportSeries;
                    }
                    else
                        return null;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }

        private static string DateA_B_SQLcommand(DateTime dateA, DateTime dateB)
        {
            int daysBetween = dateB.Subtract(dateA).Days;
            string command = "SELECT ";
            for (int i = 0; i < daysBetween; i++)
            {
                command += $@"(SELECT SUM(Change)
                               FROM(
                                   SELECT Change from IngredientsReports
                                   WHERE
                                       Date(IngredientsReports.Date) <= Date($ReportDateA, '+{i} day')
                                       And IngredientId =$IngredientId
                                   )),";
            }
            if (command.EndsWith(",")) command = command.Substring(0, command.Length - 1);
            Clipboard.SetText(command);
            return command == "SELECT " ? null : command;
        }

        public static Series GetFoodReportChart(long id, DateTime date)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand("SELECT ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month') ) ) AS Day1, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+1 day') ) ) AS Day2, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+2 day') ) ) AS Day3, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+3 day') ) ) AS Day4, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+4 day') ) ) AS Day5, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+5 day') ) ) AS Day6, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+6 day') ) ) AS Day7, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+7 day') ) ) AS Day8, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+8 day') ) ) AS Day9, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+9 day') ) ) AS Day10, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+10 day') ) ) AS Day11, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+11 day') ) ) AS Day12, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+12 day') ) ) AS Day13, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+13 day') ) ) AS Day14, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+14 day') ) ) AS Day15, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+15 day') ) ) AS Day16, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+16 day') ) ) AS Day17, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+17 day') ) ) AS Day18, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+18 day') ) ) AS Day19, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+19 day') ) ) AS Day20, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+20 day') ) ) AS Day21, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+21 day') ) ) AS Day22, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+22 day') ) ) AS Day23, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+23 day') ) ) AS Day24, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+24 day') ) ) AS Day25, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+25 day') ) ) AS Day26, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+26 day') ) ) AS Day27, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+27 day') ) ) AS Day28, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+28 day') ) ) AS Day29, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+29 day') ) ) AS Day30, ( SELECT SUM(Amount) FROM FoodReports WHERE ( FoodId = $FoodId AND Date(FoodReports.Date) = Date($ReportDate,'start of month','+30 day') ) ) AS Day31"
                    , conn);
                command.Parameters.AddWithValue("$FoodId", id);
                command.Parameters.AddWithValue("$ReportDate", date.ToString(sqliteDateFormat));
                try
                {
                    SqliteDataReader Report = command.ExecuteReader();
                    if (Report.Read())
                    {
                        Series ReportSeries = new Series("گزارش غذا");
                        for (int i = 0; i < 31; i++)
                        {
                            if (Report.IsDBNull(i))
                                ReportSeries.Points.AddXY(i + 1, 0.0d);
                            else
                                ReportSeries.Points.AddXY(i + 1, Report.GetDouble(i));
                        }
                        return ReportSeries;
                    }
                    else
                        return null;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static Food GetFood(long id)
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    SELECT *
                    FROM Foods
                    WHERE id = $id
                ", conn);
                command.Parameters.AddWithValue("$id", id);
                try
                {
                    SqliteDataReader Foods = command.ExecuteReader();
                    if (Foods.Read())
                    {
                        return new Food
                        {
                            Id = Foods.GetInt64(0 /*Id*/),
                            Name = Foods.GetString(1 /*Name*/),
                            RecipeString = Foods.GetString(2 /*Ingredients*/),
                            isSelfService = Foods.GetInt32(3/*SelfService*/) == 1,
                            Category = Foods.GetString(4 /*Category*/),
                            Details = Foods.IsDBNull(5/*Details*/) ? "" : Foods.GetString(5/*Details*/)
                        };
                    }
                    else
                        return null;

                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static List<object[]> GetIngredientList()
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    SELECT Id,Name,Scale,Quantity
                    FROM Ingredients
                    ORDER BY Name ASC
                ", conn);
                try
                {
                    SqliteDataReader Ingredients = command.ExecuteReader();
                    List<object[]> IngList = new List<object[]>();
                    while (Ingredients.Read())
                    {
                        IngList.Add(new object[] {
                            Ingredients["Id"],
                            Ingredients["Name"],
                            Ingredients["Quantity"].ToString() + " " + Ingredients["Scale"].ToString()
                        });
                    }
                    conn.Close();
                    return IngList;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static List<object[]> GetFoodList()
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    SELECT Id,Name,Category,SelfService,Details,Ingredients
                    FROM Foods
                    ORDER BY Name ASC
                ", conn);
                try
                {
                    SqliteDataReader Foods = command.ExecuteReader();
                    List<object[]> FoodList = new List<object[]>();
                    while (Foods.Read())
                    {
                        FoodList.Add(new object[] {
                            Foods["Id"],
                            Foods["Name"],
                            Foods["Category"],
                            Foods.GetInt32(Foods.GetOrdinal("SelfService")) == 1,
                            Foods["Details"],
                            Foods["Ingredients"].ToString()
                        });
                    }
                    conn.Close();
                    return FoodList;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
        public static object[] GetFoodCategories()
        {
            using (SqliteConnection conn = new SqliteConnection(
                ConfigurationManager.ConnectionStrings["FoodDB"].ConnectionString
                ))
            {
                conn.Open();
                SqliteCommand command = new SqliteCommand(@"
                    SELECT DISTINCT Name
                    FROM Categories
                ", conn);
                try
                {
                    SqliteDataReader Categories = command.ExecuteReader();
                    List<object> categories = new List<object>();
                    while (Categories.Read())
                    {
                        categories.Add(Categories[0]);
                    }
                    return categories.Count != 0 ? categories.ToArray() : null;
                }
                catch (SqliteException ex)
                {
                    MessageBox.Show(ex.Message);
                    return null;
                }
            }
        }
    }
}
