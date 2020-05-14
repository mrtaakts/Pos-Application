using System.ComponentModel.DataAnnotations;

namespace POS.Models {
    public class Product {
        [Key]
        public int ProductId{get; set;}

        [MinLength(2, ErrorMessage = "En az 2 harf içeren bir isim giriniz")]
        [Required (ErrorMessage = "Ürün ismi boş bırakılamaz")]
        public string Name { get; set; }

        
        public string Description { get; set; }

        [Range (0, 1000, ErrorMessage = "0-1000 aralığında bir sayı giriniz")]
        [Required (ErrorMessage = "Ürün fiyatı boş bırakılamaz")]
        public int? Price { get; set; }

        [Required (ErrorMessage = "Ürün kategorisi boş bırakılamaz")]
        public string Category { get; set; }


        public byte[] Image { get; set; }
        

    }
}