﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatWS.Models.WS
{
    public class Reply
    {
        public string message { get; set; }
        public int result { get; set; }
        public object data { set; get; }


    }
}