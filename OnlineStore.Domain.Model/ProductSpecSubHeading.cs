using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineStore.Domain.Model
{
    public class ProductSpecSubHeading
    {
        public int ProductSpecSubHeadingID { get; set; }
        public string SubHeading { get; set; }
        public string SubHeadingDescritption { get; set; }
        public int SpecHeadingID { get; set; }
        public string Message { get; set; }
        public string ProductSpecHeadingTitle { get; set; }
    }
}
