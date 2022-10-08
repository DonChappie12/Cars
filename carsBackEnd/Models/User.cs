using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace carsBackEnd.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_At { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_At { get; set; }
        public List<Car> Cars { get; set; }
        public List<Engine> Engines { get; set; }
        // public List<Order> Orders { get; set; }
        public User()
        {
            Cars = new List<Car>();
            Engines = new List<Engine>();
            // Orders = new List<Order>();
        }
    }
}