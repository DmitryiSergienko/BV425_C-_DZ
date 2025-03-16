using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BV425_C__DZ.Classes
{
    public class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private DatabaseConnection() { Console.WriteLine("Экземпляр создан."); }
        public static DatabaseConnection Instance
        {
            get
            {
                if (instance == null) { instance = new DatabaseConnection(); }
                return instance;
            }
        }

        public void Connect()
        {
            Console.WriteLine("Соединение настроено!");
        }
    }
}
