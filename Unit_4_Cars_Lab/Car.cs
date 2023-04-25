using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Cars_Lab
{
    internal class Car
    {
        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }
        protected decimal Price { get; set; }
        public static List<Car> carsList = new List<Car>();
        public Car()
        {
            Make = string.Empty;
            Model = string.Empty;
            Year = 0; 
            Price = 0m;
        }
        public Car(string Make, string Model, int Year, decimal Price)
        {
            this.Make = Make;
            this.Model = Model;
            this.Year = Year;
            this.Price = Price;
        }

        public virtual string ToString()
        {
            string str = Make.PadRight(8) + "\t" + Model.PadRight(8) + "\t" + Year.ToString().PadRight(8) + string.Format($" {Price:c}").PadRight(5);
            return str;
        }

        public static void AddCar( Car car )
        {
            carsList.Add( car );
        }

        public static void RemoveCar( int index )
        {
            carsList.RemoveAt( index );
        }

        public static void ListCars()
        {
            for (int i=0 ; i<carsList.Count; i++)
            {
                Console.WriteLine($"{i+1}. {carsList[i].ToString()}");
            }
        }

        public static void ListCar(int i)
        {
            Console.WriteLine($"{carsList[i].ToString()}");
            RemoveCar(i);
        }

        public static int GetSize()
        {
            return carsList.Count;
        }
    }
}
