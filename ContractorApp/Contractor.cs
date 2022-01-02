using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContractorApp
{
    internal class Contractor { 
        string name;
    string dateOfBirth;
    string email;
    int payment;

    public Contractor(string name, string dateOfBirth, string email, int payment)
    {
        this.Name = name;
        this.DateOfBirth = dateOfBirth;
        this.Email = email;
        this.Payment = payment;
    }

    public string Name { get => name; set => name = value; }
    public string DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }
    public string Email { get => email; set => email = value; }
    public int Payment { get => payment; set => payment = value; }
}
}
