using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MusicalInstruments[] musicalInstruments =
            {
                new Violin  ("Violin", "Egor",
                             "1213"),

                new Trombone("Trombone","Sima",
                             "1367"),

                new Ukulele ("Ukulele","Descr",
                             "1331"),

                new Cello   ("Cello","Hello World",
                             "1574")
            };

            foreach (var item in musicalInstruments)
            {
                item.Show();
                item.Desc();
                item.Sound();
                item.History();
                Console.WriteLine();
                Console.WriteLine();
            }
        }

        abstract class MusicalInstruments
        {
            protected string name_;
            protected string description_;
            protected string history_;

            public MusicalInstruments(string Name, string Description, string History)
            {
                description_ = Description;
                history_ = History;
                name_ = Name;
            }
            public abstract void Sound();
            public abstract void Show();
            public abstract void Desc();
            public abstract void History();

        }
        class Violin : MusicalInstruments
        {
            public Violin(string Name, string Description, string History) :
                          base(Name, Description, History)
            { }

            public override void Sound() => Console.WriteLine("Violin Sound");

            public override void Show() => Console.WriteLine($"Instrument:{name_}");

            public override void Desc() => Console.WriteLine($"Description:{description_}");

            public override void History() => Console.WriteLine($"History:{history_}");

        }

        class Trombone : MusicalInstruments
        {
            public Trombone(string Name, string Description, string History) :
                          base(Name, Description, History)
            { }

            public override void Sound() => Console.WriteLine("Trombone Sound");

            public override void Show() => Console.WriteLine($"Instrument:{name_}");

            public override void Desc() => Console.WriteLine($"Description:{description_}");

            public override void History() => Console.WriteLine($"History:{history_}");
        }

        class Ukulele : MusicalInstruments
        {
            public Ukulele(string Name, string Description, string History) :
                          base(Name, Description, History)
            { }

            public override void Sound() => Console.WriteLine("Ukulele Sound");

            public override void Show() => Console.WriteLine($"Instrument:{name_}");

            public override void Desc() => Console.WriteLine($"Description:{description_}");

            public override void History() => Console.WriteLine($"History:{history_}");
        }

        class Cello : MusicalInstruments
        {
            public Cello(string Name, string Description, string History) :
                          base(Name, Description, History)
            { }

            public override void Sound() => Console.WriteLine("Cello Sound");

            public override void Show() => Console.WriteLine($"Instrument:{name_}");

            public override void Desc() => Console.WriteLine($"Description:{description_}");

            public override void History() => Console.WriteLine($"History:{history_}");
        }
    }
}
