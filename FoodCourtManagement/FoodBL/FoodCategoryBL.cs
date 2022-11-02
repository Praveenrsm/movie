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
    public class FoodCategoryBL
    {
        FoodDataL db = null;
        public string AddFood(FoodCategoryEL food1)
        {
            db = new FoodDataL();
            db.foodcategory.Add(food1);
            db.SaveChanges();
            return "saved";
        }
        public string UpdateFood(FoodCategoryEL food)
        {
            db = new FoodDataL();
            db.Entry(food).State = EntityState.Modified;
            db.SaveChanges();
            return "updated";
        }
        public List<FoodCategoryEL> ShowAll()
        {
            db = new FoodDataL();
            List<FoodCategoryEL> foodlist = db.foodcategory.ToList();
            return foodlist;
        }
        
        public List<FoodCategoryEL> ShowAllFoodDetails(string type)
        {
            db = new FoodDataL();
            List<FoodCategoryEL> movielist = db.foodcategory.ToList();
            //linq query -> select * from movie where movietype="type"
            var result = from movies in movielist
                         where movies.FoodName == type
                         orderby movies.FoodName ascending
                         select new FoodCategoryEL { FoodName = movies.FoodName, FoodId = movies.FoodId, Type = movies.Type };
            List<FoodCategoryEL> movieresult = new List<FoodCategoryEL>();
            foreach (var item in result) //linq query execution
            {
                movieresult.Add(item);
            }
            return movieresult;
        }
        public void reportcategory()
        {
            db = new FoodDataL();
            List<FoodCategoryEL> foodList = db.foodcategory.ToList();
            string json = JsonConvert.SerializeObject(foodList);
            File.WriteAllText("Foodcategory.json", json);
        }
        public void ReportFoodcategoryxml()
        {
            db = new FoodDataL();
            List<FoodCategoryEL> foodList = db.foodcategory.ToList();
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<FoodCategoryEL>));
            FileStream fileStream = new FileStream("Foodcategory1.xml", FileMode.Create);
            xmlSerializer.Serialize(fileStream, foodList);
        }
    }
}
