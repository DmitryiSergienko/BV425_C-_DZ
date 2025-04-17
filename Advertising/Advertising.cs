using System.Collections.Generic;

namespace BV425_C__DZ.Advertising
{
    public class Advertising
    {
        private Dictionary<string, List<string>> keyValueAdvertising;
        public Advertising() 
        {
            keyValueAdvertising = new();
        }

        public void Update(string Location, List<string> Domen)
        {
            keyValueAdvertising.Add(Location, Domen);
        }
        public void Search(string Location)
        {
            var domen = keyValueAdvertising[Location];
            Console.WriteLine(string.Join(", ", domen));
        }
    }
}
