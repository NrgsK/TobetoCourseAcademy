using Business.Abstracts;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult(Messages.ProductAded);
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.ProductDeleted);
        }

        public IDataResult<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.ProductUpdated);
        }
    }
}
