using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.State.Interfaces;

// Интерфейс состояния
public interface IState
{
    void InsertCoin();
    void EjectCoin();
    void SelectDrink();
    void Dispense();
}