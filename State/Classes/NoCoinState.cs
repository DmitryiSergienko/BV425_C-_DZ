using BV425_C__DZ.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.State.Classes;

// Конкретное состояние: Без монеты
public class NoCoinState : IState
{
    private readonly VendingMachine _vendingMachine;

    public NoCoinState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("Монета вставлена.");
        _vendingMachine.SetState(_vendingMachine.HasCoinState);
    }

    public void EjectCoin()
    {
        Console.WriteLine("Монеты нет, нечего возвращать.");
    }

    public void SelectDrink()
    {
        Console.WriteLine("Сначала вставьте монету.");
    }

    public void Dispense()
    {
        Console.WriteLine("Сначала вставьте монету.");
    }
}