using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace didongexpress
{
    public static class ExtensionMethod
    {
        public static string Prefix(this string original, string prefix)
        {
            // check null or empty, etc...

            return "[" + prefix + "] " + original;
        }
    }
}