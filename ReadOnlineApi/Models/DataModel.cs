using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ReadOnlineApi.Models
{
    public class DataModel
    {
        public int page { get; set; }
        public int per_page { get; set; }
        public List<data> data { get; set; }
    }

    public class data
    {
        public int id;
        public string email;
    }
}