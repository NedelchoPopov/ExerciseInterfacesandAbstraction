﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Telephony
{
    public class SmartPhone : ICaller, IBrowser
    {
        public string Call(string phoneNumber) => $"Calling... {phoneNumber}";
        public string Browse(string website) => $"Browsing: {website}!";
    }
}