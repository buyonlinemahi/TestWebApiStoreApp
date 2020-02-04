using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class SubCategory
    {
        [Key]
        public int SubCategoryID { get; set; }
        public string SubCategoryName { get; set; }
        [ForeignKey("CategoryID")]
        public int CategoryID { get; set; }
        public string Message { get; set; }
        public string CategoryName { get; set; }

    }
}
