using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //snippet
    class Product
    {

        //CRUD operasyonları create update 
        //ana anahtar
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }

        //stok adedi
        public int UnitsInStock { get; set; }

    }
}
