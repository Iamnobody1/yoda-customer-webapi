namespace Yoda.Services.Customer.Entities
{
    public class CustomerEntity
    {
        public guid Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Avatar { get; set; }
    }
}
