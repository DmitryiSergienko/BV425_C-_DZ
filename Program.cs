using BV425_C__DZ.Classes;
using BV425_C__DZ.Interfaces;

// Singleton
var single1 = DatabaseConnection.Instance;
single1.Connect();
var single2 = DatabaseConnection.Instance;
single2.Connect();

// Проверка, что оба объекта являются одним и тем же экземпляром
Console.WriteLine($"singleton1 == singleton2: {ReferenceEquals(single1, single2)}\n");

///////////////////////////////////////////////////////////////////////////////////////////////////////
// Factory Method
var factoryDocx = new FactoryDocx();
Document docx1 = factoryDocx.createDocument();
docx1.printDocument();

var factoryXlsx = new FactoryXlsx();
Document xlsx1 = factoryXlsx.createDocument();
xlsx1.printDocument();

var factoryPptx = new FactoryPptx();
Document pptx1 = factoryPptx.createDocument();
pptx1.printDocument();

///////////////////////////////////////////////////////////////////////////////////////////////////////
// Abstract Factory
IAirplaneFactory boing = new BoiengFactory();
Transport transport1 = boing.CreateAirplane();
transport1.printLabel().printParameters();

IAutoFactory supra = new ToyotaFactory();
Transport transport2 = supra.CreateAuto();
transport2.printLabel().printParameters();

///////////////////////////////////////////////////////////////////////////////////////////////////////
// Builder
// Использование строителя напрямую
var builder = new ComputerBuilder();
var customComputer = builder
    .SetProcessor("AMD Ryzen 7")
    .SetRAM(64)
    .SetStorage(2048)
    .SetGPU("NVIDIA RTX 4090")
    .SetMotherboard("ASRock X570")
    .Build();

customComputer.ShowInfo();
Console.WriteLine();

// Использование директора
var director = new ComputerDirector(new ComputerBuilder());
var gamingComputer = director.BuildGamingComputer();
gamingComputer.ShowInfo();
Console.WriteLine();

var officeComputer = director.BuildOfficeComputer();
officeComputer.ShowInfo();

///////////////////////////////////////////////////////////////////////////////////////////////////////
// Prototype
// Создаем базовый объект автомобиля
Car originalCar = new Car("Toyota Camry", "Red");
originalCar.ShowInfo();

// Клонируем объект
Car clonedCar = originalCar.Clone();
clonedCar.Color = "Blue"; // Изменяем цвет у клонированного объекта

Console.WriteLine("\nКлонированный автомобиль:");
clonedCar.ShowInfo();

// Проверяем, что оригинальный объект не изменился
Console.WriteLine("\nОригинальный автомобиль:");
originalCar.ShowInfo();