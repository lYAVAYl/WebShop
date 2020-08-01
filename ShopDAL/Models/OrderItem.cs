using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Models
{
    public class OrderItem
    {
        public Guid RecordID { get; set; }      // Первичный ключ определяющий запись в таблице. Не пустое
        public Guid OrderID { get; set; }       // ИД заказа. Не пустое
        public Guid ItemID { get; set; }        // ИД товара. Не пустое
        public int OrderNumber { get; set; }    // Количество заказанного товара. Не пустое.
        public decimal ItemPrice { get; set; }  // Цена  за единицу. Не пустое.

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
