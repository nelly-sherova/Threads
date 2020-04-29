using System;
using System.Collections.Generic;
using System.Threading;

namespace Threads
{
    class Client
    {
        public int Id {get; set;}
        public decimal Balance {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string MiddleName {get; set;}
        public Client(){}
        public Client(int id, decimal Balance, string FirstName, string LastName, string MiddleName)
        {
            this.Id = id;
            this.Balance = Balance;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.MiddleName = MiddleName;
        }

        
    }
}
