using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    class RealCustomer: Customer//Miras Inheritance RealCustomer bir Customer dır demektir.Asıl olayı ortakları miras olarak atar
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TcNo { get; set; }

    }
}
