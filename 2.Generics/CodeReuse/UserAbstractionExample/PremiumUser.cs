namespace CodeReuse.UserAbstractionExample
{
    public class PremiumUser : IUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PremiumCarNumber { get; set; }
    }
}