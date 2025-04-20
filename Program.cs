using BV425_C__DZ.Fitness.Classes;
using BV425_C__DZ.Fitness.Enums;

var fitness = new FitnessCenter();
fitness.AddHumanInList(new Trainer("1", new List<string> {
    $"{TrainerType.CardioTraining}", $"{TrainerType.Yoga}", $"{TrainerType.FunctionalTraining}"
}, "Чак", "Норрис", "chack@mail.ru", "+791221332324"));
fitness.AddHumanInList(new Trainer("2", new List<string> {
    $"{TrainerType.Stretching}", $"{TrainerType.DanceFitness}", $"{TrainerType.Bodybuilding}"
}, "Майкл", "Джордан", "jordan@mail.ru", "+79231232144"));
fitness.AddHumanInList(new Trainer("3", new List<string> {
    $"{TrainerType.CrossFit}", $"{TrainerType.FunctionalTraining}", $"{TrainerType.MartialArts}"
}, "Джеки", "Чан", "chan@mail.ru", "+79215215244"));
fitness.AddHumanInList(new Trainer("4", new List<string> {
    $"{TrainerType.WeightLifting}", $"{TrainerType.Pilates}", $"{TrainerType.Stretching}"
}, "Сильвестр", "Столовой", "stolovoi@mail.ru", "+79346462326"));
fitness.AddHumanInList(new Trainer("5", new List<string> {
    $"{TrainerType.CardioTraining}", $"{TrainerType.Yoga}", $"{TrainerType.Bodybuilding}"
}, "Шварц", "Терминатов", "terminate@mail.ru", "+79125353464"));

fitness.AddHumanInList(new Client("6", MembershipType.Yearly, "Челик", "Бибов", "chelik@mail.ru", "+79528821212"));
fitness.AddHumanInList(new Client("7", MembershipType.Monthly, "Биба", "Бобович", "biba@mail.ru", "+79123456436"));
fitness.AddHumanInList(new Client("8", MembershipType.DropIn, "Боба", "Бибович", "boba@mail.ru", "+79346344366"));
fitness.AddHumanInList(new Client("9", MembershipType.Monthly, "Карл", "Маркс", "karl@mail.ru", "+79658997656"));
fitness.AddHumanInList(new Client("10", MembershipType.Yearly, "Миклуха", "Маклай", "mikle@mail.ru", "+79021401042"));

fitness.ShowList(fitness.Trainers);
fitness.ShowList(fitness.Clients);