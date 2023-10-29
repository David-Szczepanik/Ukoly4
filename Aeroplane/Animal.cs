using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane {
    class Animal : IWeight {
        public enum Type {
            mammal,
            reptile,
            fish,
            bird,
            insect
        }
        private Type type;
        public Type AnimalType {
            get { return type; }
            set { type = value; }
        }
        public Animal(Type type) {
            this.type = type;
        }
        public override string ToString() {
            return $"{type}";
        }
        public double Weight() {
            double weight = 0;
            switch(type) {
                case Type.mammal:
                    weight = 50;
                    break;
                case Type.reptile:
                    weight = 10;
                    break;
                case Type.fish:
                    weight = 5;
                    break;
                case Type.bird:
                    weight = 3;
                    break;
                case Type.insect:
                    weight = 0.1;
                    break;
            }
            return weight;
        }
    }
}
