using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrainSoup
{
    public class MRJson
    {
        public  string imgLoc { get; set; }
        public  string tumorLoc { get; set; }
        public  string result { get; set; }
    }
    public static class MRInformation
    {
        public static string date { get; set; }
        public static string imgLoc { get; set; }
        public static string tumorLoc { get; set; }
        public static string result { get; set; }
    }
}
