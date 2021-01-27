using System;

namespace json_pro
{
    struct book
    {
        public string name;
        public string autor;
        public int year;

        //конструктор
        public book(string name, string autor, int year)
        {
            this.name = name;
            this.autor = autor;
            this.year = year;
        }
    }
    // я тупой, не могу добавить структуру в струткуруру

    //    class Price
    //{
    //    public double sum;
    //    public string simbol;

    //}

    //struct Product
    //{
    //    public int type;
    //    public string name;
    //    public Price;
    //}

    class Program
    {
        static void Main(string[] args)
        {
        
        }
    }
}
