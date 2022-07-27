using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPractice.MockData
{
    public class GenericDataProvider<T>
    {
        public static List<T> GetGenericData(string fileName)
        {
            var data = new List<T>();

            using (StreamReader reader = new StreamReader(fileName))
            {
                string jsonContent = reader.ReadToEnd();
                data = JsonConvert.DeserializeObject<List<T>>(jsonContent);
            }

            return data;
        }
    }
}
