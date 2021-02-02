using CodeReuse.CustomerGenericExample;
using CodeReuse.UserAbstractionExample;
using System.Collections.Generic;

namespace MultipleUsagesOfCode
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Customer generic example
            Customer<string> simpleCustomer = new Customer<string> 
            {
                FirstName = "Ivan",
                LastName = "Ivanov",
                Address = "9th Kingdom, SillyWilly str, 13"
            };

            Customer<Address> customer = new Customer<Address>
            {
                FirstName = "Friedrich",
                LastName = "Nietzsche",
                Address = new Address 
                {
                    CityName = "Röcken",
                    StreetName = "Gostauer Weg",
                    HouseNumber = 2
                }
            };

            //Customer abstraction example
            //Например, если выбрана лиценция обычного пользователя открывается форма c полями для CommonUser
            CommonUser commonUser = new CommonUser
            {
                FirstName = "John",
                LastName = "Anderson",
                CreditCardNumber = "1234123412341234",
                ITN = 123526729406
            };

            //Если при регистрации выбрана опция премиум пользователя, открывается форма с полями для PermiumUser
            PremiumUser premiumUser = new PremiumUser
            {
                FirstName = "John",
                LastName = "Anderson",
                PremiumCarNumber = 1
            };

            List<IUser> users = new List<IUser>();
            users.Add(commonUser);
            users.Add(premiumUser);
        }
    }
}