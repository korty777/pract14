using System;
using System.Runtime.Remoting.Messaging;

namespace ConsoleApp8
{

    // Задание 1

    class Instrument
    {
        public virtual void Play()
        {
            Console.WriteLine("Играет музыка...");
        }
    }
    class Guitar : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Брень-Брень!");
        }
    }
    class Drum : Instrument
    {
        public override void Play()
        {
            Console.WriteLine("Бум-Бум!");
        }
    }

    // Задание 2

    class Message
    {
        public virtual void Send()
        {
            Console.WriteLine("Сообщение отправлено...");
        }
    }
    class Email : Message
    {
        public override void Send()
        {
            Console.WriteLine("Email Отправлен!");
        }
    }
    class SMS : Message
    {
        public override void Send()
        {
            Console.WriteLine("SMS отправлено!");
        }
    }

    // Задание 3

    class Food
    {
        public virtual void Eat()
        {
            Console.WriteLine("Едим...");
        }
    }
    class Pizza : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим пиццу!");
        }
    }
    class Burger : Food
    {
        public override void Eat()
        {
            Console.WriteLine("Едим бургер!");
        }
    }

    // Задание 4

    abstract class Shape
    {
        public abstract string Draw();
    }
    class Circle : Shape
    {
        public override string Draw()
        {
        return "Рисую круг";
        }
    }
    class Triangle : Shape
    {
        public override string Draw()
        {
        return "Рисую треугольник";
        }
    }

    // Задание 5

    class Player
    {
        public virtual void Attack()
        {
            Console.WriteLine("Атакую!");
        }
    }
    class Warrior : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Рублю мечом!");
        }
    }
    class Archer : Player
    {
        public override void Attack()
        {
            Console.WriteLine("Стреляю из лука!");
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            // Вызов задания 1
            Console.WriteLine("Задание 1:");
            Instrument[] band = { new Guitar(), new Drum(), new Instrument() };
            foreach (var i in band) i.Play();

            Console.WriteLine();

            // Вызов задания 2
            Console.WriteLine("Задание 2:");
            Message[] messages = { new Email(), new SMS(), new Message() };
            foreach (var m in messages) m.Send();

            Console.WriteLine();

            // Вызов задания 3
            Console.WriteLine("Задание 3:");
            Food[] lunch = { new Pizza(), new Burger(), new Food() };
            foreach (var f in lunch) f.Eat();

            Console.WriteLine();

            // Вызов задания 4
            Console.WriteLine("Задание 4:");
            Shape[] shapes = { new Circle(), new Triangle() };
            foreach (var s in shapes) Console.WriteLine(s.Draw());

            Console.WriteLine();

            // Вызов задания 5
            Console.WriteLine("Задание 5:");
            Player[] team = { new Warrior(), new Archer(), new Player() };
            foreach (var p in team) p.Attack();
        }
    }
}