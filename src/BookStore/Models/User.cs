using System;
using System.Collections.Generic;

namespace BookStore.Models
{
    public class User
    {
        public User(int id, string email, string password)
        {
            Id = id;
            Email = email;
            Password = password;
            Active = false;
            Code = Guid.NewGuid();
        }

        public int Id { get; private set; }
        public string Email { get; private set; }
        public string Password { get; private set; }       
        public DateTime RegisterDate { get; private set; }
        public bool Active { get; private set; }
        public Guid Code { get; private set; }

        public string ConfirmPassword { get; private set; }

        public virtual ICollection<Order> Orders { get; set; }
    }
}