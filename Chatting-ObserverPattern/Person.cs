using System;
namespace HeadFirstDesignPattern.ObserverPattern.Chatting
{
    public class Person:IPersons
    {
        public string name;
        public bool freshentry;
        public Person(string name, IChatroom chatroom)
        {
            this.name = name;
            this.freshentry = true;
            chatroom.addPerson(this);
        }

        public void notification()
        {
            if (freshentry)
            {
                Console.WriteLine($"New person {name} has joined chatroom");
            }
            this.freshentry = false;
        }

        public void register()
        {
            throw new NotImplementedException();
        }
    }
}
