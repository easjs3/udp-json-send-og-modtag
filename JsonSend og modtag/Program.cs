﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSend_og_modtag
{
    class Program
    {
        static void Main(string[] args)
        {
            JsonSender jsonSender = new JsonSender(888);
            jsonSender.start();
            Console.ReadLine();

        }
    }
}
