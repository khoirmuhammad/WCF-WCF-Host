using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Data
{
    public class BaseMessage
    {
        public bool IsSucceed { get; set; }
        public string Message { get; set; }
    }
}