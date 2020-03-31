using MVCTrial.Helper;

namespace MVCTrial.Models
{
    public class ClientModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Contact Contact { get; set; }
        public int MyProperty { get; set; }
    }
}