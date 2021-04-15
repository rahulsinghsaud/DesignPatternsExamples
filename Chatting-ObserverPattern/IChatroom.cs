using System;
namespace HeadFirstDesignPattern.ObserverPattern.Chatting
{
    public interface IChatroom
    {
        void addPerson(IPersons players);
        void removePerson(IPersons players);
        void notify();

    }
}
