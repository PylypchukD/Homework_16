using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_02
{
    internal class House
    {
        private string address;
        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }

        public House(string address, City city)
        {
            this.address = address;
            this.city = city;
        }
        public House Clone()
        {
            return this;
        } 
        public House DeepClone()
        {
            return new House(this.Address, this.city.Clone() as City);
        }

    }

    internal class City : ICloneable
    {
        private string name;
        public City(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public object Clone()
        {
            return new City(this.name);
        }
    }
}
