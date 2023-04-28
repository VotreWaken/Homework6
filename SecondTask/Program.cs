using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] device =
            {
                new Microwave("Microwawe"),
                new Car      ("Car"),
                new Ship     ("Ship"),
                new Teapot   ("Teapot")
           };
            foreach (var item in device)
            {
                item.Show();
                item.Sound();
                item.Description();
                Console.WriteLine();
            }
        }
    }

        abstract class Device
        {
            private string _name;

            public string Name { get => _name; set => _name = value; }

            public Device()
            {

            }
            public Device(string name)
            {
                _name = name;
            }

            public virtual void Sound()
            {
                Console.WriteLine("Device Sound");
            }

            public virtual void Show()
            {
                Console.WriteLine("Device:" + Name);
            }

            public virtual void Description()
            {
                Console.WriteLine("Undefined Device");
            }
        }

        class Microwave : Device
        {
            public Microwave(string name) : base(name) { }

            public override void Sound()
            {
                Console.WriteLine("Microwave Sound");
            }

            public override void Show()
            {
                Console.WriteLine("Device:" + Name);
            }

            public override void Description()
            {
                Console.WriteLine("Microwave");
            }
        }

        class Car : Device
        {
            public Car(string name) : base(name) { }

            public override void Sound()
            {
                Console.WriteLine("Car Sound");
            }

            public override void Show()
            {
                Console.WriteLine("Device:" + Name);
            }

            public override void Description()
            {
                Console.WriteLine("Car");
            }
        }

        class Ship : Device
        {
            public Ship(string name) : base(name) { }

            public override void Sound()
            {
                Console.WriteLine("Ship Sound");
            }

            public override void Show()
            {
                Console.WriteLine("Device:" + Name);
            }

            public override void Description()
            {
                Console.WriteLine("Ship");
            }
        }

        class Teapot : Device
        {
            public Teapot(string name) : base(name) { }

            public override void Sound()
            {
                Console.WriteLine("Teapot Sound");
            }

            public override void Show()
            {
                Console.WriteLine("Device: " + Name);
            }

            public override void Description()
            {
                Console.WriteLine("Teapot");
            }
        }
    }

