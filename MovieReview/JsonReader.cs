using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using ReadJson;

namespace MovieReview
{
    public class JsonReader
    {
        public IEnumerable<Review> LoadJson()
        {
            //Here we are getting the filepath to the json file that has to be in the folder in JsonReaderSpike/bin/debug 
            using (StreamReader r = new StreamReader("C:\\Users\\Yindo\\Desktop\\CSharp\\MovieReview\\ratings.json"))
            {
                //Here we are saying that we want to read to file to the end/last charter
                var json = r.ReadToEnd();
                //Here we are decomposing the json file and putting it into a IEnumerable 
                //The DeserializerObject is what transform the json into .NET language
                var reviews = JsonConvert.DeserializeObject<IEnumerable<Review>>(json);

                IEnumerable<Review> list = new List<Review>();

                List<Review> temp = new List<Review>();

                foreach (var review in reviews)
                {
                    temp.Add(review);
                }

                list = temp;
                return list;
            }
        }
    }
}