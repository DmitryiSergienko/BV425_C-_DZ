using BV425_C__DZ.Fitness.Interfaces;
using BV425_C__DZ.Fitness.Structs;

namespace BV425_C__DZ.Fitness.Classes
{
    public abstract class Person : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ContactInfo Contact {  get; set; }
        public Person(string firstName, string lastName, string email, string phoneNumber) 
        {
            FirstName = firstName;
            LastName = lastName;
            Contact = new(email, phoneNumber);
        }
        public virtual void DisplayInfo() 
        {
            Console.WriteLine(
                $"Имя:          {FirstName}\n" +
                $"Фамилия:      {LastName}\n" +
                $"Контакты:\n" +
                $"{Contact}\n"
            );
        }
        public virtual string GetRole()
        {
            return "Человек";
        }
    }
}