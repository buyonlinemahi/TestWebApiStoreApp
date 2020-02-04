using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace OnlineStore.Domain.Model
{
    public class ProductImage
    {
        [Key]
        public int ProductImageID { get; set; }
        public string ProductPhoto { get; set; }
        [ForeignKey("ProductID")]
        public int ProductID { get; set; }
        public IFormFile Photo { get; set; }
    }
}
