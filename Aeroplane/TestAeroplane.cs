using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aeroplane {
    internal class TestAeroplane {
        static void Main() {
            Person p1 = new Person("man", 180, 20); 
            Person p2 = new Person("woman", 170, 20); 

            Animal cat = new Animal(Animal.Type.mammal);
            //Animal tortoise= new Animal(Animal.Type.reptile);

            Thing t1 = new Thing(10, 15, 15);
            //p1.Height = 150;
            //cat.AnimalType= Animal.Type.reptile;
            //t1.Length = 100;

            List<IWeight> list = new List<IWeight>();
            list.Add(p1); list.Add(p2);
            list.Add(cat); //list.Add(tortoise);
            list.Add(t1);

            Console.WriteLine(p1.ToString());
            Console.WriteLine(cat.ToString());
            Console.WriteLine(t1.ToString());

            double celkovaVaha = 0;

            foreach(IWeight item in list) {
                celkovaVaha += item.Weight();
            }
            Console.WriteLine($"Celková váha nákladu: {celkovaVaha} kg");
        }
    }
}
