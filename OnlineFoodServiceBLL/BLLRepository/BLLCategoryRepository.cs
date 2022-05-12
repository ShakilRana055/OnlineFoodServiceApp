using OnlineFoodServiceBLL.IBLLRepository;
using OnlineFoodServiceDAL.IDALRepository;
using OnlineFoodServiceEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceBLL.BLLRepository
{
    public class BLLCategoryRepository: IBLLCategoryRepository
    {
        private readonly IDALCategoryRepository context;

        public BLLCategoryRepository(IDALCategoryRepository context)
        {
            this.context = context;
        }

        public List<Category> GetAll()
        {
            return context.GetAll();
        }
    }
}
