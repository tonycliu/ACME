using DesignPattern.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Client
{
    public class CompositionDriver
    {
        public static void Run()
        {
            Item nut = new Part("Nut", 5);
            Item bolt = new Part("Bolt", 10);
            Item belt = new Part("Belt", 100);

            Item box = new Assembly("Box");
            box.AddItem(nut);
            box.AddItem(bolt);
            box.AddItem(belt);

            Item boxBig = new Assembly("Box Big");
            Item wire = new Part("Wire", 8);
            boxBig.AddItem(box);
            boxBig.AddItem(wire);
            boxBig.AddItem(wire);

            Console.WriteLine(box);
            Console.WriteLine(boxBig);
        }
    }
}
