﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WowLauncher
{
    [Serializable]
    public class Server
    {
        public string ServerName { get; set; }
        public string FileContent { get; set; }
    }
}
