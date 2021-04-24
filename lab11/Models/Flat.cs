using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab11.Models
{
    public class Flat
    {
        public int Id { get; set; }
        public int Footage { get; set; }
        public int Amount_of_rooms { get; set; }
        public string Material { get; set; }
        public string Address { get; set; }
    }
}
