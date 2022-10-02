using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;// Add this component to Foreign key 


namespace car_rentals_project.Models
{
    public class Order
    {
        public Order() => CriadoEm = DateTime.Now;
        public int OrderId { get; set; }

        public int number { get; set; }

        public int ClientId { get; set; } 
        [ForeignKey("ClientId")]      // Foreign key 
        public Client Client { get; set; } 
        
        public int AutomobileId { get; set; } 
        [ForeignKey("AutomobileId")]    // Foreign key   
        public Automobile Automobile { get; set; }    
      
        [Required(ErrorMessage = "O campo preço é obrigatório!")]
        public float Total_Price { get; set; }

     
        public string Total_Days { get; set; }

        public string End_Date { get; set; }

        public DateTime CriadoEm { get; set; }
    }
}