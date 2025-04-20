namespace BV425_C__DZ.Fitness.Structs
{
    public struct ContactInfo
    {
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public ContactInfo(string email, string phoneNumber)
        {
            Email = email;
            PhoneNumber = phoneNumber;
        }
        public readonly override string ToString()
        {
            return
                $"Почта:            {Email}\n" +
                $"Телефон:          {PhoneNumber}";
        }
    }
}