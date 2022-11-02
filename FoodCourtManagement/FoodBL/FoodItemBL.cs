using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using FoodCourtEntity;
using FoodDL;
using FoodDL.Migrations;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace FoodBL
{
    public class FoodItemBL
    {
        FoodDataL db = null;
        public string AddFood(FoodEntityEL food)
        {
            db = new FoodDataL();
            db.Fooditems2.Add(food);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateFood(FoodEntityEL food)
        {
            db = new FoodDataL();
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public List<FoodEntityEL> ShowAll()
        {
            db = new FoodDataL();
            List<FoodEntityEL> foodlist = db.Fooditems2.ToList();
            return foodlist;
        }
        public void serialise()
        {
            db = new FoodDataL();
            List<FoodEntityEL> foodList = db.Fooditems2.ToList();
            string json = JsonConvert.SerializeObject(foodList);
            File.WriteAllText("FoodItems.json", json);
        }
        public void ReportFoodItemsxml()
        {
            db = new FoodDataL();
            List<FoodEntityEL> foodList = db.Fooditems2.ToList();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FoodEntityEL>));
            FileStream fileStream = new FileStream("FoodItem.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, foodList);
        }
        public List<FoodEntityEL> ShowAllFoodDetails(string type)
        {
            db = new FoodDataL();
            List<FoodEntityEL> movielist = db.Fooditems2.ToList();
            //linq query -> select * from movie where movietype="type"
            var result = from movies in movielist
                         where movies.FoodName == type
                         orderby movies.FoodName ascending
                         select new FoodEntityEL { FoodName = movies.FoodName, FoodId = movies.FoodId ,price=movies.price };
            List<FoodEntityEL> movieresult = new List<FoodEntityEL>();
            foreach (var item in result) //linq query execution
            {
                movieresult.Add(item);
            }
            return movieresult;
        }
    }
}
