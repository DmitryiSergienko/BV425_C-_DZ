using BV425_C__DZ.Classes;
using System.Collections.Generic;

int a = 3;
int b = 4;

Operation operationAdd;
Operation operationSubtract;
Operation operationMultiply;

operationAdd = Add;
Console.WriteLine($"Сумма:       {a} + {b} = " + operationAdd.Invoke(3, 4));
operationSubtract = Subtract;
Console.WriteLine($"Вычитание:   {a} - {b} = " + operationSubtract.Invoke(3, 4));
operationMultiply = Multiply;
Console.WriteLine($"Умножение:   {a} * {b} = " + operationMultiply.Invoke(3, 4));

int Add(int a, int b)
{
    return a + b;
}
int Subtract(int a, int b)
{
    return a - b;
}
int Multiply(int a, int b)
{
    return a * b;
}

/////////////////////////////////////////////////////////////////////////

var numbers = new List<int> { 1, 2, 3, 4, 5 };

// Лямбда-выражение: умножение каждого элемента на 2
List<int> doubledNumbers = numbers.ModifyList(x => x * 2);

// Вывод результата
Console.WriteLine("\nИсходный список:\t\t" + string.Join(", ", numbers));
Console.WriteLine("Модифицированный список:\t" + string.Join(", ", doubledNumbers));

delegate int Operation(int a, int b);