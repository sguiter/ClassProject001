using System.Reflection;

namespace ClassProject001;

public class CustomerAppointment
{
    public Customer c {get;set;}
    public Appointment a {get; set;}

    public CustomerAppointment(Customer c,Appointment a) //combination of 2 becomes a primary key 
    {
        this.c = c;
        this.a = a;
    }

}
