using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebShop.Models
{
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }        // Первичный ключ определяющий запись в таблице. Не пустое
        
        [Required]
        public string CustomerName { get; set; }    // Наименование заказчика. Не пустое.
        public string Code { get; set; }            // Код заказчика. Содержит данные формата «ХХХХ-ГГГГ» где Х – число, ГГГГ – год в котором зарегистрирован заказчик. Не пустое.
        [Required]
        public string Address { get; set; }         // Адрес заказчика
        public decimal Discount { get; set; }       // % скидки для заказчика. 0 или null – означает что скидка не распространяется.

        public virtual ICollection<Order> Orders { get; set; }

    }
}