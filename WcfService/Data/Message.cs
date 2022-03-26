using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcfService.Data
{
    public class Message<T> : BaseMessage
    {
        public T Data { get; set; }
    }
}