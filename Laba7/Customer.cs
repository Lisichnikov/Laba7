using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Xml.Linq;

namespace Variant16
{
    public class Customer
    {
        public string familyname;
        public string name;
        public string surname;
        public string address;
        public long phonenumber;
        public long cardnumber;
        public int bankaccountnumber { get; set; }

        public string GetName
        {
            get
            {
                return name;
            }
        }

        public string GetSurname
        {
            get
            {
                return surname;
            }
        }

        public Customer(int i)
        {
            familyname = "unknown";
            name = "unknown";
            surname = "unknown";
            address = "unknown";
            phonenumber = 0;
            cardnumber = 0;
            bankaccountnumber = 0;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public Customer(string familyname, string name, string surname, string address, long phonenumber, long cardnumber, int bankaccountnumber)
        {
            this.familyname = familyname;
            this.name = name;
            this.surname = surname;
            this.address = address;
            this.phonenumber = phonenumber;
            this.cardnumber = cardnumber;
            this.bankaccountnumber = bankaccountnumber;
        }

        public override string ToString()
        {
            return familyname + ", " + name + ", " + surname + ", " + address + ", " + phonenumber + ", " + cardnumber + ", " + bankaccountnumber;
        }
    }
}