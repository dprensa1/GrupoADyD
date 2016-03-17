﻿using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GrupoADyD.Models
{
    public class DetailedSale
    {
        [DisplayName("Id")]
        public int DetailedSaleId { get; set; }

        [DisplayName("Descuento")]
        public decimal Discount { get; set; }

        [DisplayName("Costo")]
        public decimal Cost { get; set; }

        [DisplayName("Precio")]
        public decimal Price { get; set; }

        [ForeignKey("Product")]
        public int ProductId { get; set; }

        public virtual Sale Sale { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual Client Client { get; set; }
    }
}