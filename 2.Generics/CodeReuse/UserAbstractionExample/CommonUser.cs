namespace CodeReuse.UserAbstractionExample
{
    public class CommonUser : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public string CreditCardNumber { get; set ; }
        public long ITN { get; set ; }
    }
}