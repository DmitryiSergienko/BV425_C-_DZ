using BV425_C__DZ.Fitness.Structs;
namespace BV425_C__DZ.Fitness.Classes
{
    public class Trainer : Person
    {
        public string TrainerID { get; set; }
        public List<string> Specializations { get; set; }
        public Trainer(string trainerID, List<string> specializations,
            string firstName, string lastName, string email, string phoneNumber) :
            base(firstName, lastName, email, phoneNumber)
        {
            TrainerID = trainerID;
            Specializations = specializations;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine(
                $"Id тренера:       {TrainerID}\n" +
                $"Имя:              {FirstName}\n" +
                $"Фамилия:          {LastName}"
            );
            Console.Write($"Специализация:    ");
            foreach (var item in Specializations)
            {
                Console.Write($"{item}");
                if (item != Specializations.Last())
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine($"\n{Contact}\n");
        }
        public override string GetRole()
        {
            return "Тренер";
        }
    }
}