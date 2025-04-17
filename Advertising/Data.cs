namespace BV425_C__DZ.Advertising
{
    public enum Location
    {
        Яндекс_Директ,
        Ревдинский_рабочий,
        Газета_уральских_москвичей,
        Крутая_реклама
    }
    public enum Domen
    {
        ru,
        ru_svrd_revda,
        ru_svrd_pervik,
        ru_msk,
        ru_permobl,
        ru_chelobl,
        ru_svrd
    }
    public class Data
    {
        public static string[] _location = { 
            "Яндекс.Директ", "Ревдинский рабочий", "Газета уральских москвичей", "Крутая реклама" 
        };
        public static string[] _arrayDomen = { 
            "/ru", "/ru/svrd/revda", "/ru/svrd/pervik", "/ru/msk", "/ru/permobl", "/ru/chelobl", "/ru/svrd" 
        };

        public string this[Location location]
        {
            get 
            {
                return _location[(int)location];
            }
        }
        public string this[Domen arrayDomen]
        {
            get
            {
                return _arrayDomen[(int)arrayDomen];
            }
        }
    }
}
