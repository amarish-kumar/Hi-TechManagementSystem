using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary_Disconnected_Mode.BLL
{
    public class Client
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public int StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Province { get; set; }
        public string Phone { get; set; }
        public float CreditLimit { get; set; }
    }
}
