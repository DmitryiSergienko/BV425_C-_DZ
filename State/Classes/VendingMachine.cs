using BV425_C__DZ.State.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.State.Classes;

// Класс контекста (автомат)
public class VendingMachine
{
    public IState NoCoinState { get; private set; }
    public IState HasCoinState { get; private set; }
    public IState DispenseState { get; private set; }

    private IState _currentState;

    public VendingMachine()
    {
        NoCoinState = new NoCoinState(this);
        HasCoinState = new HasCoinState(this);
        DispenseState = new DispenseState(this);

        // Начальное состояние
        _currentState = NoCoinState;
    }

    public void SetState(IState state)
    {
        _currentState = state;
    }

    public void InsertCoin()
    {
        _currentState.InsertCoin();
    }

    public void EjectCoin()
    {
        _currentState.EjectCoin();
    }

    public void SelectDrink()
    {
        _currentState.SelectDrink();
    }

    public void Dispense()
    {
        _currentState.Dispense();
    }
}