using System;
using System.Linq;
using System.Collections.Generic;


namespace AutoCollection
{
    class Auto
    {
        public string Mark
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }
        public int Year
        {
            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }
    }

    class Customer
    {
        public string Name
        {
            get;
            set;
        }

        public string Model
        {
            get;
            set;
        }

        public int Tel
        {
            get;
            set;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var instanceAuto = new List<Auto>
           {
               new Auto {Model = "Nissan" , Mark = "A145" , Year = 2000 , Color="red" },
               new Auto {Model = "Madza" , Mark = "A144" , Year = 2010 , Color="blue" },
               new Auto {Model = "Opel" , Mark = "A146" , Year = 2003 , Color="yellow" },
               new Auto {Model = "Peugeot" , Mark = "A148" , Year = 2011 , Color="black" },
            };

            var instanceCustomer = new List<Customer>
            {
                new Customer {Model = "Nissan" , Name= "Yunes" , Tel= 12349},
                new Customer {Model = "Madza" , Name= "Yurtik" , Tel= 12346},
                new Customer {Model = "Opel" , Name= "Nazar" ,   Tel= 12345},
                new Customer {Model = "Peugeot" , Name= "Yuri" , Tel= 12347},
            };

            var query = from x in instanceAuto
                        join y in instanceCustomer
                        on x.Model equals y.Model
                        orderby x.Model ascending
                        select new
                        {
                            model = x.Model,
                            mark = x.Mark,
                            year = x.Year,
                            color = x.Color,
                            name = y.Name,
                            tel = y.Tel,
                        };

            foreach (var item in query)
            {
                System.Console.WriteLine("name: {0} \nmodel: {1} \nmark: {2} \nyear: {3} \ncolor: {4} \ntel: {4} \n\n",
                item.name,
                item.model,
                item.mark,
                item.color,
                item.tel
                 );
            }
        }
    }
}
