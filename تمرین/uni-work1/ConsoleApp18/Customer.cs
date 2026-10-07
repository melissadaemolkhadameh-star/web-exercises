namespace Customers
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string EmailAddress { get; set; }
        public string NationalID { get; set; }
        public string PhoneNumber { get; set; }

        public void PlaceOrder()
        {
            System.Console.WriteLine($"{CustomerID} has placed an order.");
        }

        public void CancelOrder()
        {
            System.Console.WriteLine($"{CustomerID} has cancelled an order.");
        }
    }
}
