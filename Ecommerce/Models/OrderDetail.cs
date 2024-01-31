﻿using System.ComponentModel.DataAnnotations;
namespace Ecommerce.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public double Price { get; set; }
        public Order Order { get; set; }
        public Product? Product { get; set; }
    }
}
