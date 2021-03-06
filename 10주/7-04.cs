using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first
{
    class Program
    {
        class Animal
        {
            public int Age
            {
                get;
                set;
            }
            public Animal()
            {
                this.Age = 0;
            }
            public void Eat()
            {
                Console.WriteLine("냠냠 먹습니다.");
            }
            public void Sleep()
            {
                Console.WriteLine("쿨쿨 잠을 잡니다.");
            }
        }
        class Dog : Animal
        {
            public string Color
            {
                get;
                set;
            }
            public void Bark()
            {
                Console.WriteLine("왈왈 짓습니다.");
            }
        }
        class Cat : Animal
        {
            public string Color
            {
                get;
                set;
            }
            public void Meow()
            {
                Console.WriteLine("냥냥 웁니다.");
            }
        }
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>()
            {
                new Dog(), new Cat(), new Cat(), new Dog(),
                new Dog(), new Cat(), new Dog(), new Dog()
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();
                /*
                if (item is Dog)
                {
                    ((Dog)item).Bark();
                    (item as Dog).Bark();
                }
                if (item is Cat)
                {
                    ((Cat)item).Meow();
                    (item as Cat).Meow();
                }
                */
                var dog = item as Dog;
                var cat = item as Cat;
                if (dog != null)
                {
                    dog.Bark();
                }
                if (cat != null)
                {
                    cat.Meow();
                }
            }
        }
    }
}
