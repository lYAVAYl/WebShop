using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDAL.Models
{
    public class Product
    {
        public Guid ProductID { get; set; }         // Первичный ключ определяющий запись в таблице. Не пустое
        public string Code { get; set; }            // Код товара, формат «XX-XXXX-YYXX» где Х – число , Y- заглавная буква английского алфавита. Не пустое.
        public string ProductName { get; set; }     // Наименование товара
        public decimal Price { get; set; }          // Цена за единицу
        public string Category { get; set; }        // Категория товара

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
