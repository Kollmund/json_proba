using Newtonsoft.Json;
using System;
using System.IO;
using System.Threading.Tasks;

namespace json_pro
{

    class Price
    {
        public double sum;
        public string simbol;
    }
    
    struct Product
    {
        public int type;
        public string name;
        public Price price;
    }

    class Program
    {
        static void Main(string[] args)
        {
        var json = System.IO.File.ReadAllText(@"test.json");
        var objects = JsonConvert.DeserializeObject<Price>(json);
        Console.WriteLine(objects.sum);


        Price sot = new Price();
        sot.sum = 100.0;
        sot.simbol = "p.";

            Product foo = new Product();
            foo.type = 0;
            foo.name = "Air2";
            foo.price = sot;

        using (StreamWriter file = File.CreateText("price.json"))
            {
            JsonSerializer serializer = new JsonSerializer();
            serializer.Serialize(file, foo);
            Console.WriteLine("Data has been saved to file");
            }

        }
    }
}
