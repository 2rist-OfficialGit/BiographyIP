using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BiographyIP.Models
{
    public class ModelDataIP
    {
        public string ip { get; set; } = string.Empty;
        public string city { get; set; } = string.Empty;
        public string region { get; set; } = string.Empty;
        public string country { get; set; } = string.Empty;
        public string loc { get; set; } = string.Empty; 
        public string org { get; set; } = string.Empty;
        public string postal { get; set; } = string.Empty;
        public string timezone { get; set; } = string.Empty;
    }
}
