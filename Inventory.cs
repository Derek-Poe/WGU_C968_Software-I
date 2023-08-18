using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C968_001340166
{
    public class Inventory
    {
        public static BindingList<Product> Products = new BindingList<Product>();
        public static BindingList<Part> AllParts = new BindingList<Part>();
        public static void addProduct(Product product)
        {
            Products.Add(product);
        }
        public static bool removeProduct(int productID)
        {
            foreach(Product product in Products)
            {
                if(product.ProductID == productID)
                {
                    Products.Remove(product);
                    return true;
                }
            }
            return false;
        }
        public static Product lookupProduct(int productID) 
        {
            foreach (Product product in Products)
            {
                if(product.ProductID == productID)
                {
                    return product;
                }
            }
            return new Product(-1, "", -1, productID - 1, -1, -1);
        }
        public static void updateProduct(int productID, Product product) 
        {
            for (int i = 0; i < Inventory.Products.Count; i++)
            {
                if (Inventory.Products[i].ProductID == productID)
                {
                    Inventory.Products[i].Name = product.Name;
                    Inventory.Products[i].Price = product.Price;
                    Inventory.Products[i].Max = product.Max;
                    Inventory.Products[i].Min = product.Min;
                    Inventory.Products[i].InStock = product.InStock;
                    foreach(Part part in product.AssociatedParts.Except(Inventory.Products[i].AssociatedParts))
                    {
                        Inventory.Products[i].removeAssociatedPart(part.PartID);
                    }
                    MainScreen.updateGridViews();
                    return;
                }
            }
        }
        public static void addPart(Part part) 
        { 
            AllParts.Add(part);
        }
        public static bool deletePart(Part partDelete)
        {
            foreach(Part part in Inventory.AllParts)
            {
                if(part.PartID == partDelete.PartID)
                {
                    Inventory.AllParts.Remove(part);
                    MainScreen.updateGridViews();
                    return true;
                }
            }
            return false;
        }
        public static Part lookupPart(int partID)
        {
            foreach (Part part in Inventory.AllParts)
            {
                if(part.PartID == partID)
                {
                    return part;
                }
            }
            return new Inhouse(-1, "",-1, -1, -1, -1, -1);
        }
        public static void updatePart(int partID, Part part)
        {
            for(int i = 0; i < Inventory.AllParts.Count; i++)
            {
                if (Inventory.AllParts[i].PartID == partID)
                {
                    Inventory.AllParts[i] = part;
                    MainScreen.updateGridViews();
                    return;
                }
            }
        }
    }
}
