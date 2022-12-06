using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HomeAdress
{
    public string Address { get; set; }
    public string City { get; set; }
    public string Postalcode { get; set; }

    // Address

    public string PrintCustomer()
    {
        return $"Address: {Address}\n City: {City}\n Postalcode: {Postalcode}";
    }
}

