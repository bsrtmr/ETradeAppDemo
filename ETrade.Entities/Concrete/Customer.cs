using ETrade.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ETrade.Entities.Concrete
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string UserName_ { get; set; }
        public string Password_ { get; set; }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public string TelNr1 { get; set; }
        public string TelNr2 { get; set; }
    }
}
