using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }           // Первичный ключ определяющий запись в таблице. Не пустое

        [Required]
        public Guid CustomerID { get; set; }        // ИД заказчика. Не пустое
        [Required]
        public DateTime OrderDate { get; set; }     // Дата когда сделан заказ. Не пустое
        public DateTime ShipmentDate { get; set; }  // Дата доставки
        public decimal OrderNumber { get; set; }    // Номер заказа
        public string Status { get; set; }          // Состояние заказа

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderProduct> OrderItems { get; set; }
    }
}