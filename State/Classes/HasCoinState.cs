using BV425_C__DZ.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.State.Classes;

// Конкретное состояние: Монета вставлена
public class HasCoinState : IState
{
    private readonly VendingMachine _vendingMachine;

    public HasCoinState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("Монета уже вставлена.");
    }

    public void EjectCoin()
    {
        Console.WriteLine("Монета возвращена.");
        _vendingMachine.SetState(_vendingMachine.NoCoinState);
    }

    public void SelectDrink()
    {
        Console.WriteLine("Напиток выбран.");
        _vendingMachine.SetState(_vendingMachine.DispenseState);
    }

    public void Dispense()
    {
        Console.WriteLine("Сначала выберите напиток.");
    }
}