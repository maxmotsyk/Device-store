using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp8
{
    public class Sings
    {
        public string  Name { get; set; }
        public int ID { get; set; }
        public double Price { get; set; }

        public Sings(string name, int id, double price) => (Name, ID, Price) = (name, id, price);
    }
}
