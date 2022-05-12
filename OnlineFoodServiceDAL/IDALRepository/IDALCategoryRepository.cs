using OnlineFoodServiceEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceDAL.IDALRepository
{
    public interface IDALCategoryRepository
    {
        public List<Category> GetAll();
    }
}
