using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Customer
{
    public string Firstname {get; set;}
    public string Lastname { get; set; }
    public string Insertion { get; set; }
    public HomeAdress Adress { get; set; }

    // Customer

    public string PrintCustomer()
    {
        return $"Firstname: {Firstname}\n Lastname: {Lastname}\n Insertion: {Insertion}\n adres: {Adress.Address}\n stad: {Adress.City}\n Postcode: {Adress.Postalcode}";
    }
}
