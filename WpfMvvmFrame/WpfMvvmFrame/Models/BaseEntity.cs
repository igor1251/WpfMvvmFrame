using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfMvvmFrame.Models
{
    public class BaseEntity
    {
        public int ID { get; set; } = 0;
        public string Name { get; set; } = string.Empty;
    }
}
