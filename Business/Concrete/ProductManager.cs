﻿using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        } 
        
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
         InMemoryProductDal inMemoryProductDal = new InMemoryProductDal();
        }
    }
}
