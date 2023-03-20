using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManger : IProductService
    {
        private IProductDal _productDal;
        private object productId;

        public ProductManger(IProductDal productDal)
        {
            _productDal = productDal;
        }
       

        public Product GetById(int prouductId)
        {
            return _productDal.Get(filter:p => p.ProuductId == productId);
        }

        public List<Product> GetList()
        {
           return _productDal.GetList().ToList();  
        }

        public List<Product> GetListByCategory(int categoryId)
        {
            return _productDal.GetList(filter: p => p.ProuductId == productId).ToList();
        }

       
        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }
        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
