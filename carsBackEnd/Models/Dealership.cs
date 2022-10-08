using System;

namespace carsBackEnd.Models
{
    // ? This could be a many to many relationship with a dealershhip can have many cars and a car can be in many dealerships
    public class Dealership
    {
        public Guid MyProperty { get; set; }
        public string DelearshipName { get; set; }
        // ? Have a count method for the amount of new cars a dealership has
    }
}