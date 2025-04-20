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
        public void AddHumanInList<T>(T item)
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
        public void ShowList<T>(List<T> list)
        {
            if (list != null)
            {
                if (list is List<Trainer> trainers)
                {
                    foreach (var item in trainers)
                    {
                        item.DisplayInfo();
                    }
                }
                else if (list is List<Client> clients)
                {
                    foreach (var item in clients)
                    {
                        item.DisplayInfo();
                    }
                }
            }
        }
    }
}