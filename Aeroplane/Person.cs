using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane {
    class Person : IWeight {
        private string gender;
        private double height;
        private int age;

        public string Gender {
            get { return gender; }
            set { gender = value; }
        }
        public double Height {
            get { return height; }
            set { height = value; }
        }
        public int Age {
            get { return age; }
            set { age = value; }
        }
        public double Weight() { return height - 100; }
        public override string ToString() {
            return $"{gender} {height} {age}";
        }
        public Person(string gender, double height, int age) {
            Gender = gender;
            Height = height;
            Age = age;
        }
    }
}
