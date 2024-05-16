using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models{

    public class Product{

        [Display(Name = "Urun Id")]
        public int ProductId { get; set; }

        [Required]
        [Display(Name = "Urun Adı")]
        public string? Name { get; set;} 
        
          [Required]
        [Display(Name = "Fiyat")]
        public decimal Price { get; set; }
         
    
         [Display(Name = "Foto")]
        public string ?  Image { get; set; } 
      
        [Display(Name = "Active")]
        public bool IsActive { get; set; }


         [Required]
         [Display(Name = "Category")]


        public int ?  CategoryId { get; set; }

        // public IFormFile  ImageFile{ get; set; }
    }

}