using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity.Concrete
{
   public class Customer:IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int FindexPuan { get; set; }
        public string CompanyName { get; set; }

        public Customer()
        {
            FindexPuan = 1001;
        }
    }
}
