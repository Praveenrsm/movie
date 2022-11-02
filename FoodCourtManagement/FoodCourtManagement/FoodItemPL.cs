using System;
using System.Collections.Generic;
using System.Text;
using FoodBL;
using FoodCourtEntity;
namespace FoodCourtManagement
{
    public class FoodItemPL
    {
        public void AddFood()
        {
            FoodItemBL FoodOperations = new FoodItemBL();
            FoodEntityEL food = new FoodEntityEL();
            Console.WriteLine("Enter FoodName:");
            food.FoodName = Console.ReadLine();
            Console.WriteLine("Enter foodprice:");
            food.price = Convert.ToInt32(Console.ReadLine());
            string msg = FoodOperations.AddFood(food);
            Console.WriteLine(msg);
        }
        public void updateFoods()
        {
            FoodItemBL movieOperations = new FoodItemBL();
            FoodEntityEL a = new FoodEntityEL();
            Console.WriteLine("Enter foodid:");
            a.FoodId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter food name:");
            a.FoodName = Console.ReadLine();
            Console.WriteLine("enter price:");
            a.price=Convert.ToInt32(Console.ReadLine());
            string msg = movieOperations.UpdateFood(a);
            Console.WriteLine(msg);
        }
        public void ShowAllfood()
        {
            FoodItemBL movieOperations = new FoodItemBL();
            List<FoodEntityEL> movies = movieOperations.ShowAll();
            foreach (var item in movies)
            {
                Console.WriteLine("Id: " + item.FoodId);
                Console.WriteLine("food Name:" + item.FoodName);
                Console.WriteLine("price:" + item.price);
            }
            //List<Movie> movies = movieOperations.ShowMovieById();
        }
        public void showfoodbyname()
        {
            FoodItemBL movieOperations = new FoodItemBL();
            Console.WriteLine("enter food name:");
            string a = Console.ReadLine();
            List<FoodEntityEL> movies = movieOperations.ShowAllFoodDetails(a);
            foreach (var ab in movies)
            {
                Console.WriteLine(" id:" + ab.FoodId);
                Console.WriteLine("food price:" + ab.price);
            }
        }
        public void ser()
        {
            FoodItemBL ab = new FoodItemBL();
            ab.serialise();
            Console.WriteLine("json file added");
        }
        public void xml()
        {
            FoodItemBL ab = new FoodItemBL();
            ab.ReportFoodItemsxml();
            Console.WriteLine("xml file added");
        }
    }
}
