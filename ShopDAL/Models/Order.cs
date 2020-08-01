using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Models
{
    public class Order
    {
        public Guid OrderID { get; set; }           // Первичный ключ определяющий запись в таблице. Не пустое
        public Guid CustomerID { get; set; }        // ИД заказчика. Не пустое
        public DateTime OrderDate { get; set; }     // Дата когда сделан заказ. Не пустое
        public DateTime ShipmentDate { get; set; }  // Дата доставки
        public decimal OrderNumber { get; set; }    // Номер заказа
        public string Status { get; set; }          // Состояние заказа

        public virtual Customer Customer { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
