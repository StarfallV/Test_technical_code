using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_technical_code.Models
{
    public class Response
    {
        public bool Success { get; set; }
        public List<string> Data { get; set; }
    }
}