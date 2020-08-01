using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class OrderProduct
    {
        [Key]
        public Guid RecordID { get; set; }          // Первичный ключ определяющий запись в таблице. Не пустое

        [Required]
        public Guid OrderID { get; set; }           // ИД заказа. Не пустое
        [Required]
        public Guid ProductID { get; set; }         // ИД товара. Не пустое
        [Required]
        public int OrderNumber { get; set; }        // Количество заказанного товара. Не пустое.
        [Required]
        public decimal ProductPrice { get; set; }   // Цена  за единицу. Не пустое.

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}