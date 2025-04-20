using BV425_C__DZ.Fitness.Enums;
using BV425_C__DZ.Fitness.Structs;

namespace BV425_C__DZ.Fitness.Classes
{
    class Client : Person
    {
        public string ClientID { get; set; }
        public MembershipType Membership { get; set; }
        public Client(string clientID, MembershipType membership,
            string firstName, string lastName, string email, string phoneNumber) :
            base(firstName, lastName, email, phoneNumber)
        {
            ClientID = clientID;
            Membership = membership;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Id клиента:       {ClientID}\n" +
                $"Имя:              {FirstName}\n" +
                $"Фамилия:          {LastName}\n" +         
                $"Членство:         {Membership}\n" +
                $"{Contact}\n"
            );
        }
        public override string GetRole()
        {
            return "Клиент";
        }
    }
}