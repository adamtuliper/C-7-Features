using System;

namespace isCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var dog = new Dog();
            var cat = new Cat();
            IAnimal animal;

            animal = dog;
            if (animal is Dog myDog)
            {

            }

            if (animal is Dog)
            {
                var yaThatsADog = (Dog)animal;
            }

        }
    }


    class Dog : IAnimal
    {
        public void MakeSound() => throw null;

    }
    class Cat : IAnimal
    {
        public void MakeSound() => throw null;
    }
    interface IAnimal
    {
        void MakeSound();
    }
}
