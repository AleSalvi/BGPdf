using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.CompilerServices.RuntimeHelpers;

namespace WindowsFormsApp1
{
    internal class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string TaxCode { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public void SetUser(string name, string surname, string taxCode, string email, string phone, string address)
        {
            this.Name = name;
            this.Surname = surname;
            this.TaxCode = taxCode;
            this.Email = email;
            this.Phone = phone;
            this.Address = address;
        }
    }
}
