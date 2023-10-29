using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tax {
    internal class TestTax {
        static void Main(string[] args) {

            House h1 = new House();
            Flat f1 = new Flat();

            Car c1 = new Car();
            Motorcycle m1 = new Motorcycle();
            Trolleybus t1 = new Trolleybus();

            List<object> list = new List<object>();

            list.Add(h1);
            list.Add(f1);

            list.Add(c1);
            list.Add(m1);
            list.Add(t1);

            double celkovaDan = 0;

            foreach(var item in list) {
                double sazbaDane = 0;
                double hodnotaDane = 0;
                string nazevTridy = item.GetType().Name;

                if(item is RealEstate realEstate) {
                    if(realEstate is House house) {
                        sazbaDane = house.sazba;
                        hodnotaDane = house.tax();
                    } else if(realEstate is Flat flat) {
                        sazbaDane = flat.sazba;
                        hodnotaDane = flat.tax();
                    }
                } else if(item is Vehicle) {
                    sazbaDane = ((Vehicle)item).tax();
                    hodnotaDane = sazbaDane;
                }
                celkovaDan += hodnotaDane;
                Console.WriteLine($"{nazevTridy} - {sazbaDane} {Math.Round(hodnotaDane, 2)}");
            }
            Console.WriteLine($"Celková daň: {celkovaDan}");
        }
    }
}
