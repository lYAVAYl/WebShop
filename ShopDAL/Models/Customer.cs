using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Models
{
    public class Customer
    {
        public Guid CustomerID { get; set; }        // Первичный ключ определяющий запись в таблице. Не пустое
        public string CustomerName { get; set; }    // Наименование заказчика. Не пустое.
        public string Code { get; set; }            // Код заказчика. Содержит данные формата «ХХХХ-ГГГГ» где Х – число, ГГГГ – год в котором зарегистрирован заказчик. Не пустое.
        public string Address { get; set; }         // Адрес заказчика
        public decimal Discount { get; set; }       // % скидки для заказчика. 0 или null – означает что скидка не распространяется.

        public virtual ICollection<Order> Orders { get; set; }

    }
}
