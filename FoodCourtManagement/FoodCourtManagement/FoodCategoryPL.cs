using FoodBL;
using FoodCourtEntity;
using FoodDL;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace FoodCourtManagement
{
    public class FoodCategoryPL
    {
        public void AddFood()
        {
            FoodCategoryBL FoodOperations = new FoodCategoryBL();
            FoodCategoryEL food = new FoodCategoryEL();
            Console.WriteLine("Enter FoodName:");
            food.FoodName = Console.ReadLine();
            Console.WriteLine("Enter food type:");
            food.Type = Console.ReadLine();
            string msg = FoodOperations.AddFood(food);
            Console.WriteLine(msg);
        }
        public void updateFoods()
        {
            FoodCategoryBL movieOperations = new FoodCategoryBL();
            FoodCategoryEL a = new FoodCategoryEL();
            Console.WriteLine("Enter foodid:");
            a.FoodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter food name:");
            a.FoodName = Console.ReadLine();
            Console.WriteLine("enter type:");
            a.Type =Console.ReadLine();
            string msg = movieOperations.UpdateFood(a);
            Console.WriteLine(msg);
        }
        public void ShowAllfood()
        {
            FoodCategoryBL movieOperations = new FoodCategoryBL();
            List<FoodCategoryEL> movies = movieOperations.ShowAll();
            foreach (var item in movies)
            {
                Console.WriteLine("Id: " + item.FoodId);
                Console.WriteLine("food Name:" + item.FoodName);
                Console.WriteLine("price:" + item.Type);
            }
            //List<Movie> movies = movieOperations.ShowMovieById();
        }
        public void showfoodbyname()
        {
            FoodCategoryBL movieOperations = new FoodCategoryBL();
            Console.WriteLine("enter food name:");
            string a = Console.ReadLine();
            List<FoodCategoryEL> movies = movieOperations.ShowAllFoodDetails(a);
            foreach (var ab in movies)
            {
                Console.WriteLine(" id:" + ab.FoodId);
                Console.WriteLine("food type:" + ab.Type);
            }
        }
        public void reportcategory()
        {
            FoodCategoryBL movieOperations = new FoodCategoryBL();
            movieOperations.reportcategory();
            movieOperations.ReportFoodcategoryxml();
        }
        //public void reportcategory1()
        //{
        //    FoodCategoryBL movieOperations = new FoodCategoryBL();
        //    movieOperations.ReportFoodcategoryxml();
        //}
    }
}
