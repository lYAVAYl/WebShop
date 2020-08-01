using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Product
    {
        [Key]
        public Guid ProductID { get; set; }         // Первичный ключ определяющий запись в таблице. Не пустое
        
        [Required]
        public string Code { get; set; }            // Код товара, формат «XX-XXXX-YYXX» где Х – число , Y- заглавная буква английского алфавита. Не пустое.
        public string ProductName { get; set; }     // Наименование товара
        public decimal Price { get; set; }          // Цена за единицу
        [MaxLength(30)]
        public string Category { get; set; }        // Категория товара

        public virtual ICollection<OrderProduct> OrderItems { get; set; }
    }
}