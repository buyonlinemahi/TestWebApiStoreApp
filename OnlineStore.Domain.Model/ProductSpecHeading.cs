using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class ProductSpecHeading
    {
        [Key]
        public int SpecHeadingID { get; set; }
        public string SpecHeadingTitle { get; set; }
        public int ProductID { get; set; }
        public string Message { get; set; }
    }
}
