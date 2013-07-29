using DesignPattern.Model;
using DesignPattern.Pattern.Iterator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class IteratorDriver
    {
        public static void Run()
        {
            CarRange carRange = new CarRange();

            //foreach (IVehicle v in carRange.Ranges)
            //{
            //    Console.Write(v);
            //}
            var iter = carRange.GetEnumerator();

            while (iter.MoveNext())
            {
                Console.Write(iter.Current);
            }

            VanRange vanRange = new VanRange();

            //foreach (IVehicle v in vanRange.Ranges)
            //{
            //    Console.Write(v);
            //}

            iter = vanRange.GetEnumerator();

            while (iter.MoveNext())
            {
                Console.Write(iter.Current);
            }
        }
    }
}
