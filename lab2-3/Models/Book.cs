using System.ComponentModel.DataAnnotations;

namespace lab2_3.Controllers
{
    public class Book
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Nhap Title")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Nhap Author")]
        [StringLength(50, ErrorMessage = "Author k qua 250 chu")]
        public string Author { get; set; }
        public string Image { get; set; }
    }
}