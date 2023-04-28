using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money Money = new Money(20, 30);
            Console.WriteLine(Money);
            Product Product = new Product();
            Console.WriteLine(Product);
            Product.LowPrice();
            Console.WriteLine(Product);
        }

        class Money
        {
            private int Usd_;
            private int Cents_;

            public int Usd { get => Usd_; set => Usd_ = value; }
            public int Cents { get => Cents_; set => Cents_ = value; }
            public Money()
            {
                Usd_ = 0;
                Cents_ = 0;
            }
            public Money(int USD, int Cents)
            {
                this.Usd_ = USD;
                this.Cents_ = Cents;
            }

            public override string ToString()
            {
                return string.Format
                    (
                    $"{Usd_}.{Cents_}"
                    );
            }

            public void Input()
            {
                Console.WriteLine("Enter the Whole Part: ");
                Usd_ = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Cents Part: ");
                Cents_ = Convert.ToInt32(Console.ReadLine());
            }
        }
        class Product : Money
        {
            private string Name;
            private Money Price;
            public Product(string Name, Money Price)
            {
                this.Name = Name;
                this.Price = Price;
            }

            public Product() : base(0, 0)
            {
                Input();
                InputName();
            }
            public string ShowName
            {
                get { return Name; }
                set { Name = value; }
            }
            public Money ShowPrice
            {
                get { return Price; }
                set { Price = value; }
            }
            public void LowPrice()
            {

                Console.WriteLine($"Low price for {Name} ");

                Console.WriteLine("Enter Reduce Whole Part: ");
                Usd -= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter Reduce Cents Part: ");
                Cents -= Convert.ToInt32(Console.ReadLine());
            }

            public void InputName()
            {
                Console.WriteLine("Enter the Name: ");
                Name = Console.ReadLine();
            }
            public override string ToString() => "Product: " + Name + "\n" + base.ToString();
        }

    }
}
