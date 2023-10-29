using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax {
    abstract class RealEstate {
        public abstract double tax();
    }
    class House : RealEstate {
        public double sazba = 1.27;
        public override double tax() {
            return sazba * DateTime.Now.Day;
        }
    }
    class Flat : RealEstate {
        public double sazba = 1.15;

        public override double tax() {
            return sazba * DateTime.Now.DayOfYear;
        }
    }
    abstract class Vehicle {
        public virtual double tax() {
            return 1500;
        }
    }
    class Car : Vehicle { }
    class Motorcycle : Vehicle { }
    class Trolleybus : Vehicle {
        private double sazba = 0.9;
        public override double tax() {
            return sazba * base.tax();
        }
    }
}
