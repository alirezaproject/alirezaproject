namespace DataLayer.Entities.ContactAgg
{

    public class ContactUs
    {
        public long ContactUsId { get; private set; }
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Message { get; private set; }

        public ContactUs(string name, string email, string message)
        {
            Name = name;
            Email = email;  
            Message = message;
        }
    }
}