using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace carsBackEnd.Models
{
    public class Engine
    {
        public Guid Id { get; set; }
        public string EngineName { get; set; }
        public string GasType { get; set; }
        public string CylinderType { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Created_At { get; set; }
        
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime Updated_At { get; set; }

        [ForeignKey("user")]
        public Guid UserId { get; set; }
        public User user { get; set; }

        [ForeignKey("Car")]
        public Guid CarId { get; set; }
        public Car car { get; set; }
    }
}