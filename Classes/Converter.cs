using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DastFood.Classes.Types;

namespace DastFood.Classes
{
    static class Converter
    {
        /// <summary>
        /// Converts Shamsi Date to Miladi
        /// </summary>
        /// <param name="shamsiDate">Shamsi Date in YYYY/MM/DD format</param>
        /// <returns>DateTime containing the converted date</returns>
        public static DateTime ToMiladi(string shamsiDate)
        {
            string[] dateEntities = shamsiDate.Split('/');
            
            if (dateEntities == null
                || dateEntities.Length != 3
                || dateEntities[0].Length != 4
                || dateEntities[1].Length != 2
                || dateEntities[2].Length != 2
                ) throw new ArgumentException();

            PersianCalendar Shamsi = new PersianCalendar();
            DateTime date = new DateTime(
                (int.Parse(dateEntities[0])), // Year
                (int.Parse(dateEntities[1])), // Month
                (int.Parse(dateEntities[2])), // Day
                Shamsi);
            return date;
        }
        /// <summary>
        /// Converts Miladi DateTime object to Shamsi string (YYYY/MM/DD)
        /// </summary>
        /// <param name="miladiDate">A DateTime representing the miladi date</param>
        /// <returns>string with YYYY/MM/DD format</returns>
        public static string ToShamsi(DateTime miladiDate)
        {
            PersianCalendar Shamsi = new PersianCalendar();
            return Shamsi.GetYear(miladiDate).ToString() 
                + "/" + Shamsi.GetMonth(miladiDate).ToString().PadLeft(2,'0') 
                + "/" + Shamsi.GetDayOfMonth(miladiDate).ToString().PadLeft(2, '0');
        }

        /// <summary>
        /// Subtracts one amount from another with different scales (firstAmount - secondAmount)
        /// </summary>
        /// <param name="firstAmount">First amount as a float - Should be of Scale [firstScale]</param>
        /// <param name="secondAmount">Second amount as a float - Should be of Scale [SecondScale]</param>
        /// <param name="firstScale">First amount scale [دانه،کیلوگرم،گرم،لیتر،میلی لیتر،بسته 5 تایی ، بسته]</param>
        /// <param name="secondScale">Second amount scale [دانه،کیلوگرم،گرم،لیتر،میلی لیتر،بسته 5 تایی ، بسته]</param>
        /// <returns>Subtracted Amount</returns>
        public static float Subtract(float firstAmount,float secondAmount,string firstScale,string secondScale)
        {
            switch (firstScale) {
                case "دانه":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else throw new ArgumentException();
                case "کیلوگرم":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "گرم") return firstAmount - (secondAmount / 1000);
                    else throw new ArgumentException();
                case "گرم":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "کیلوگرم") return firstAmount - (secondAmount * 1000);
                    else throw new ArgumentException();
                case "لیتر":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "میلی لیتر") return firstAmount - (secondAmount / 1000);
                    else throw new ArgumentException();
                case "میلی لیتر":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "لیتر") return firstAmount - (secondAmount * 1000);
                    else throw new ArgumentException();
                case "بسته 5 تایی":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "بسته") return firstAmount - (secondAmount / 5);
                    else throw new ArgumentException();
                case "بسته":
                    if (secondScale == firstScale) return firstAmount - secondAmount;
                    else if (secondScale == "بسته 5 تایی") return firstAmount - (secondAmount * 5);
                    else throw new ArgumentException();

                default: throw new ArgumentException();
            }
        }

        /// <summary>
        /// Adds one amount to other with different scales (firstAmount + secondAmount)
        /// </summary>
        /// <param name="firstAmount">First amount as a float - Should be of Scale [firstScale]</param>
        /// <param name="secondAmount">Second amount as a float - Should be of Scale [SecondScale]</param>
        /// <param name="firstScale">First amount scale [دانه،کیلوگرم،گرم،لیتر،میلی لیتر،بسته 5 تایی ، بسته]</param>
        /// <param name="secondScale">Second amount scale [دانه،کیلوگرم،گرم،لیتر،میلی لیتر،بسته 5 تایی ، بسته]</param>
        /// <returns>Added Amount Result</returns>
        public static float Add(float firstAmount, float secondAmount, string firstScale, string secondScale)
        {
            switch (firstScale)
            {
                case "دانه":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else throw new ArgumentException();
                case "کیلوگرم":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "گرم") return firstAmount + (secondAmount / 1000);
                    else throw new ArgumentException();
                case "گرم":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "کیلوگرم") return firstAmount + (secondAmount * 1000);
                    else throw new ArgumentException();
                case "لیتر":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "میلی لیتر") return firstAmount + (secondAmount / 1000);
                    else throw new ArgumentException();
                case "میلی لیتر":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "لیتر") return firstAmount + (secondAmount * 1000);
                    else throw new ArgumentException();
                case "بسته 5 تایی":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "بسته") return firstAmount + (secondAmount / 5);
                    else throw new ArgumentException();
                case "بسته":
                    if (secondScale == firstScale) return firstAmount + secondAmount;
                    else if (secondScale == "بسته 5 تایی") return firstAmount + (secondAmount * 5);
                    else throw new ArgumentException();

                default: throw new ArgumentException();
            }
        }
        
        private const string fieldDelimiter = "„";
        private const string ingredientDelimiter = "ƒ";
        /// <summary>
        /// Converts a DataGridView table to a recipe string [id„amount„scale ƒ]
        /// </summary>
        /// <param name="basketRows"> Rows Collection of the table with IngID=0 , IngAmount=2 , IngScale=3 as row indexes </param>
        /// <returns>recipe string</returns>
        public static string ToRecipeString(DataGridViewRowCollection basketRows)
        {
            string recipe = "";
            foreach (DataGridViewRow row in basketRows)
            {
                recipe += row.Cells[0/*IngId*/].Value.ToString() + fieldDelimiter
                        + row.Cells[2/*IngAmount*/].Value.ToString() + fieldDelimiter
                        + row.Cells[3/*IngScale*/].Value.ToString() + ingredientDelimiter;
            }
            return recipe;
        }
        /// <summary>
        /// Converts recipe string to a list of RecipeIngredients
        /// </summary>
        /// <param name="recipeString">recipe string [id„amount„scale ƒ]</param>
        /// <returns>List of RecipeIngredient </returns>
        public static List<RecipeIngredient> ToRecipeList(string recipeString)
        {
            List<RecipeIngredient> Recipe = new List<RecipeIngredient>();

            string[] ingredients = recipeString.Split(char.Parse(ingredientDelimiter));
            foreach (string Ing in ingredients)
            {
                
                string[] fields = Ing.Split(char.Parse(fieldDelimiter));
                if (fields[0] == "") continue;

                Recipe.Add(new RecipeIngredient { 
                    IngId = long.Parse(fields[0].Trim()),
                    IngAmount = double.Parse(fields[1].Trim()),
                    IngScale = fields[2].Trim()
                });
            }

            return Recipe.Count == 0 ? null : Recipe;
        }
    }
}
