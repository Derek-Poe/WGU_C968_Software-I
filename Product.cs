using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_001340166
{
    public class Product
    {
        private BindingList<Part> associatedParts;
        private int productID;
        private string name;
        private int inStock;
        private decimal price;
        private int min;
        private int max;

        public int ProductID { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
        public BindingList<Part> AssociatedParts { get; set; }

        public Product(int productID, string name, int inStock, decimal price, int min, int max)
        {
            ProductID = productID;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            AssociatedParts = new BindingList<Part>();
        }

        public void addAssociatedPart(Part part)
        {
            this.AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int partID)
        {
            foreach (Part part in this.AssociatedParts)
            {
                if (part.PartID == partID)
                {
                    this.AssociatedParts.Remove(this.lookupAssociatedPart(partID));
                    return true;
                }
            }
            return false;
        }

        public Part lookupAssociatedPart(int partID) 
        {
            foreach(Part part in this.AssociatedParts)
            {
                if (part.PartID == partID) { 
                    return part; 
                }
            }
            return new Inhouse(-1,"",-1,-1,-1,-1,-1);
        }
    }
}
