using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane {
    internal class Thing : IWeight {
        private double height, length, width;

        public double Height {
            get { return height; }
            set { height = value; }
        }
        public double Length {
            get { return length; }
            set { length = value; }
        }
        public double Width {
            get { return width; }
            set { width = value; }
        }
        public Thing(double height, double length, double width) {
            this.height = height;
            this.length = length;
            this.width = width;
        }
        public override string ToString() {
            return $"{height} {length} {width}";
        }
        public double Weight() {
            return (height * length * width) * 2;
        }
    }
}
