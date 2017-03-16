using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Blog_MVS.Web.Models.ViewModels
{
    public class VMPost
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Category { get; set; }
        public string Tags { get; set; }
        public string Writer { get; set; }
    }
}