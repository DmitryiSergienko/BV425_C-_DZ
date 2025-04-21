using System.Collections.Generic;

namespace BV425_C__DZ.Fitness.Classes
{
    class FitnessCenter
    {
        public List<Client> Clients;
        public List<Trainer> Trainers;
        public FitnessCenter()
        {
            Clients = [];
            Trainers = [];
        }
        public void AddHumanInList(Person item)
        {
            if (item != null)
            {
                if (item is Client client)
                {
                    Clients.Add(client);
                }
                else if (item is Trainer trainer)
                {
                    Trainers.Add(trainer);
                }
            }
        }
        public void ShowList<T>(List<T> persons) where T : Person
        {
            if (persons != null)
            {
                foreach (var person in persons)
                {
                    person.DisplayInfo();
                }
            }
        }
    }
}