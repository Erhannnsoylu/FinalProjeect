using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager = new ProductManager(new InmemoryProductDal());
            
            foreach (var product in produtManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }
         
        
        }
    }
}
