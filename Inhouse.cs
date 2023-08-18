using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace C968_001340166
{
    public class Inhouse : Part
    {
        public int MachineID { get; set; }
        public Inhouse(int partID, string name, decimal price, int inStock, int min, int max, int machine) 
        {
            PartID = partID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            MachineID = machine;
        }
    }
}
