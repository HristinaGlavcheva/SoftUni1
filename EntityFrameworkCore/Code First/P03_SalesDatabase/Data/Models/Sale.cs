﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P03_SalesDatabase.Data.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required, ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

        [Required, ForeignKey(nameof(Customer))]
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }

        [Required, ForeignKey(nameof(Store))]
        public int StoreId { get; set; }
        public virtual Store Store { get; set; }
    }
}
