namespace ClassProject001;

public class Customers
{
    public List<Customer> customerList {get; set;}

    public Customers()
    {
        customerList = new List<Customer>();
    }

    public Customer Authenticate(string username, string password)
    {
        var c = customerList.Where(o => (o.Username == username) && (object.Password == password) );

        if(c.Count() > 0)
        {
            return c.First();
        }
        else
        {
            return null; 
        }
    }

}
