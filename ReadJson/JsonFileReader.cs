using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace ReadJson
{
    public class JsonFileReader
    {
        public IEnumerable<Item> LoadJson()
        {
            DateTime start = DateTime.Now;
            //Here we are getting the filepath to the json file that has to be in the folder in JsonReaderSpike/bin/debug 
            using (StreamReader r = new StreamReader("C:/Users/nicol/Documents/School/ratings.json"))
            {
                //Here we are saying that we want to read to file to the end/last charter
                var json = r.ReadToEnd();
                //Here we are decomposing the json file and putting it into a IEnumerable 
                //The DeserializerObject is what transform the json into .NET language
                var items = JsonConvert.DeserializeObject<IEnumerable<Item>>(json);
                
                IEnumerable<Item> list = new List<Item>();
                
                List<Item> temp = new List<Item>();
                
                foreach (var item in items)
                {
                    temp.Add(item);
                }

                list = temp;
                return list;
            }
            
            DateTime end = DateTime.Now;
            //this here is so that we can see how long it takes to read the file
            Console.WriteLine("Time "+ (end-start).TotalSeconds);
            
        }

        public class Item
        {
            public int Reviewer { get; set; }
            public float Movie{ get; set; }
            public int Grade{ get; set; }
            public string Date{ get; set; }
        }
    }
}