using FoodCourtEntity;
using FoodDL;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace FoodBL
{
    public class SalesBL
    {
        FoodDataL db = null;
        public string AddFood(salesEL food)
        {
            db = new FoodDataL();
            db.sales.Add(food);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateFood(salesEL food)
        {
            db = new FoodDataL();
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public List<salesEL> ShowAll()
        {
            db = new FoodDataL();
            List<salesEL> foodlist = db.sales.ToList();
            return foodlist;
        }
        public List<salesEL> ShowAllFoodDetails(string type)
        {
            db = new FoodDataL();
            List<salesEL> movielist = db.sales.ToList();
            //linq query -> select * from movie where movietype="type"
            var result = from movies in movielist
                         where movies.FoodName == type
                         orderby movies.FoodName ascending
                         select new salesEL { FoodName = movies.FoodName, Id= movies.Id, ActualPrice = movies.ActualPrice,Discount=movies.Discount,TotalPrice=movies.TotalPrice };
            List<salesEL> movieresult = new List<salesEL>();
            foreach (var item in result) //linq query execution
            {
                movieresult.Add(item);
            }
            return movieresult;
        }
        public void serialise()
        {
            db = new FoodDataL();
            List<salesEL> foodList = db.sales.ToList();
            string json = JsonConvert.SerializeObject(foodList);
            File.WriteAllText("sales.json", json);
        }
        public void ReportFoodItemsxml()
        {
            db = new FoodDataL();
            List<salesEL> foodList = db.sales.ToList();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FoodEntityEL>));
            FileStream fileStream = new FileStream("sales.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, foodList);
        }
    }
}
