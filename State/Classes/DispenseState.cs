using BV425_C__DZ.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.State.Classes;

// Конкретное состояние: Выдача напитка
public class DispenseState : IState
{
    private readonly VendingMachine _vendingMachine;

    public DispenseState(VendingMachine vendingMachine)
    {
        _vendingMachine = vendingMachine;
    }

    public void InsertCoin()
    {
        Console.WriteLine("Подождите, выдача напитка...");
    }

    public void EjectCoin()
    {
        Console.WriteLine("Напиток уже выдаётся, монету вернуть нельзя.");
    }

    public void SelectDrink()
    {
        Console.WriteLine("Подождите, выдача напитка...");
    }

    public void Dispense()
    {
        Console.WriteLine("Напиток выдан.");
        _vendingMachine.SetState(_vendingMachine.NoCoinState);
    }
}