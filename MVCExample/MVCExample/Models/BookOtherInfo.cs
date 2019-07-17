using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCExample.Models
{
    public class BookOtherInfo
    {
        public int Id { get; set; }
        public string Price { get; set; }

        public DateTime DateOfWrite { get; set; }

        public string Description { get; set; }
    }
}