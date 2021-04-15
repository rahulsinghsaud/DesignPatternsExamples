using System;
using System.Collections;
using System.Collections.Generic;

namespace HeadFirstDesignPattern.ObserverPattern.Chatting
{
    public class Chatroom:IChatroom
    {
        ArrayList persons;
        public Chatroom()
        {
            this.persons = new ArrayList();
        }

        public void addPerson(IPersons person)
        {
            this.persons.Add(person);
        }

        public void notify()
        {
            foreach (var person in persons)
            {
                IPersons persons = (IPersons)person;
                persons.notification();
                
            }
        }

        public void removePerson(IPersons person)
        {
            this.persons.Remove(person);
        }
    }
}
