using System;
namespace HeadFirstDesignPattern.ObserverPattern.Chatting
{
    public class Chatting
    {
        public static void Main()
        {
            Chatroom chatroom = new Chatroom();
            Console.WriteLine("Welcome to the chatroom. Enter your name please");

            IPersons persons = new Person(Console.ReadLine(), chatroom);
            Console.WriteLine("Enter your name please");
            IPersons person1 = new Person(Console.ReadLine(), chatroom);
            Console.WriteLine("Enter your name please");
            IPersons person2 = new Person(Console.ReadLine(), chatroom);
            Console.WriteLine("Enter your name please");
            IPersons person3 = new Person(Console.ReadLine(), chatroom);

            //If need to remove person
            //chatroom.removePlayer(person3);
            //
            chatroom.notify();
            Console.WriteLine("Enter your name please");
            IPersons person4 = new Person(Console.ReadLine(), chatroom);
            chatroom.notify();


        }
    }
}
