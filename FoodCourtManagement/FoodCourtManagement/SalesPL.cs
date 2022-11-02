using FoodBL;
using FoodCourtEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace FoodCourtManagement
{
    public class SalesPL
    {
        public void AddFood()
        {
            SalesBL FoodOperations = new SalesBL();
            salesEL food = new salesEL();
            Console.WriteLine("Enter FoodName:");
            food.FoodName = Console.ReadLine();
            Console.WriteLine("Enter food Actual price:");
            food.ActualPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter food discount:");
            food.Discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter food total price:");
            food.TotalPrice = food.ActualPrice-food.Discount;
            string msg = FoodOperations.AddFood(food);
            Console.WriteLine(msg);
        }
        public void updateFoods()
        {
           SalesBL movieOperations = new SalesBL();
            salesEL a = new salesEL();
            Console.WriteLine("Enter foodid:");
            a.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter food name:");
            a.FoodName = Console.ReadLine();
            Console.WriteLine("enter Actual price:");
            a.ActualPrice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter Discount:");
            a.Discount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter total price:");
            a.TotalPrice = a.ActualPrice-a.Discount;
            string msg = movieOperations.UpdateFood(a);
            Console.WriteLine(msg);
        }
        public void ShowAllfood()
        {
            SalesBL movieOperations = new SalesBL();
            List<salesEL> movies = movieOperations.ShowAll();
            foreach (var item in movies)
            {
                Console.WriteLine("Id: " + item.Id);
                Console.WriteLine("food Name:" + item.FoodName);
                Console.WriteLine("actual price:" + item.ActualPrice);
                Console.WriteLine("discount:" + item.Discount);
                Console.WriteLine("total price" + item.TotalPrice);
            }
            //List<Movie> movies = movieOperations.ShowMovieById();
        }
        public void showfoodbyname()
        {
            SalesBL movieOperations = new SalesBL();
            Console.WriteLine("enter food name:");
            string a = Console.ReadLine();
            List<salesEL> movies = movieOperations.ShowAllFoodDetails(a);
            foreach (var ab in movies)
            {
                Console.WriteLine(" id:" + ab.Id);
                Console.WriteLine("food Actual price:" + ab.ActualPrice);
                Console.WriteLine("food dsicount:" + ab.Discount);
                Console.WriteLine("food total price:" + ab.TotalPrice);
            }
        }
    }
}
