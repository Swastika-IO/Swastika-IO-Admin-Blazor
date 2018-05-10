using System;
using System.Collections.Generic;
using System.Text;

namespace Swastika.Admin.Blazor.Shared
{
    public class Product
    {
        public int id { get; set; }
        public int priority { get; set; }
        public int code { get; set; }
        public string title { get; set; }
        public string image { get; set; }
        public string imageUrl { get; set; }
        public DateTime createdDateTime { get; set; }
        public string createdBy { get; set; }
        public string detailsUrl { get; set; }
    }
}
