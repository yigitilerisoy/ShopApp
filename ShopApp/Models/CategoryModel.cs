using ShopApp.Entity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace ShopApp.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }

        [Display(Name = "Name", Prompt = "Enter product name")]
        [Required(ErrorMessage = "Kategori adı zorunlu bir alan.")]
        [StringLength(60, MinimumLength = 5, ErrorMessage = "Kategori ismi 5-60 karakter aralığında olmalıdır!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Url zorunlu bir alan.")]

        public string Url { get; set; }

        public List<Product> Products { get; set; }
    }
}
