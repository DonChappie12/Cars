using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace carsBackEnd.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string StyleofCar { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public int MPG { get; set; }
        public string Warranty { get; set; }
        public string Drivetrain { get; set; }
        public string Description { get; set; }
        public string Wear { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_At { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_At { get; set; }

        /****
            This will connect to user id making it a one to many relationship 
            A user can create a new listing of a car
        ****/ 
        [ForeignKey("user")]
        public Guid UserId { get; set; }
        public User user { get; set; }
        public List<Engine> Engine { get; set; }
        public Car()
        {
            Engine = new List<Engine>();
        }

        // Todo: This is wear the engine class would be
        // public int MyProperty { get; set; }
    }
}