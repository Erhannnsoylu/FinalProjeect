﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal: IProductdal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            
            _produtcs = new List<Product>
            {
                new Product{ProductId=1,CategoryId=1,ProductName="Bardak",UnitPrice=15, UnitInStock=15 }
                new Product{ProductId=2,CategoryId=2,ProductName="Kamere",UnitPrice=500, UnitInStock=3 }
                new Product{ProductId=3,CategoryId=2,ProductName="Telefon",UnitPrice=1500,UnitInStock=2 }
                new Product{ProductId=4,CategoryId=2,ProductName="Klavye",UnitPrice=150,UnitInStock=65 }
                new Product{ProductId=5,CategoryId=2,ProductName="Fare",UnitPrice=85,UnitInStock=1 }
            };    
        }
        public void Add(Product product)
        {
            _produtcs.Add(product);
        }

        public void Delete(Product product)
        {
            Product productToDelete=null;
            foreach (var p in _products)
            {
                if (product.ProductId == p.ProductId)
                {
                    productToDelete = p;
                }
            }
            productToDelete = _produtcs.SingleOrDefault(p=>p.ProductId==product.ProductId);
            _produtcs.Remove(productToDelete);
        }

        public List<Product> GetAll()
        {
            return _products;

        }

        public void Update(Product product)
        {
         Product productToUpdate = _produtcs.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitInStock = product.UnitInStock;
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }



    }

   
}
