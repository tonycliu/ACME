using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Model
{
    public class City
    {
        private string name;
        private double latitude, longtitude;

        public City(string name, double latitude, double longtitude)
        {
            this.name = name;
            this.latitude = latitude;
            this.longtitude = longtitude;
        }

        public virtual string Name
        {
            get { return this.name; }
        }

        public virtual double Latitude
        {
            get { return this.latitude; }
        }

        public virtual double Longtitude
        {
            get { return this.longtitude; }
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
            {
                return true;
            }
            
            if (!(obj is City))
            {
                return false;
            }

            City otherCity = (City)obj;
            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
