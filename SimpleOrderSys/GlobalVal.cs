using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleOrderSys
{
    internal class GlobalVal
    {
        public static int Cart = 0;
        public static List<ArrayList> OrderCart = new List<ArrayList>();
        public static string UserName = "";
        public static bool isTakeout = false;
        public static bool isBuyBag = false;
    }
}
