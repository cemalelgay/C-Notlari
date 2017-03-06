using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC_CRUD.Models
{
    public class Car
    {
        public int ID { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public byte Age { get; set; }
    }
}