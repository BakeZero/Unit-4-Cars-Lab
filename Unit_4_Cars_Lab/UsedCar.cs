using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_4_Cars_Lab
{
    internal class UsedCar : Car
    {
        double Mileage;
        public UsedCar(string Make, string Model, int Year, decimal Price, double Mileage) : base(Make, Model, Year, Price)
        {
            this.Mileage = Mileage;
        }

        public override string ToString()
        {
            string str = base.ToString();
            str += string.Format($"\t(Used) {Mileage:n} miles");
            return str;
        }
    }
}
