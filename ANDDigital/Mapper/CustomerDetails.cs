namespace ANDDigital.Mapper
{    
    using System.Collections.Generic;
    using System.Linq;
    using Model;

    public class CustomerDetails
    {
        private static List<Customer> phoneNumbers = new List<Customer>()
        {
            new Customer { CustomerId = 1, CustomerPhoneNumber = "1234351435", Active = false},
            new Customer { CustomerId = 2, CustomerPhoneNumber = "34523462462", Active = false},
            new Customer { CustomerId = 3, CustomerPhoneNumber = "345346456356" , Active = false}
        };

        public static List<string> GetAllPhoneNumbers()
        {
            return phoneNumbers.Select(x => x.CustomerPhoneNumber).ToList();
        }

        public static string GetPhoneNumbersByCustomerId(int customerId)
        {    
            return phoneNumbers.Where(x => x.CustomerId == customerId).FirstOrDefault().CustomerPhoneNumber;
        }

        public static bool ActivatePhoneNumber(int customerId)
        {
            var pNumber = phoneNumbers.Where(x => x.CustomerId == customerId);
            if (pNumber == null)
            {
                return false;
            }
            pNumber.FirstOrDefault(x => x.Active = true);
            return pNumber.Where(x => x.CustomerId == customerId).FirstOrDefault().Active;
        }


    }
}
