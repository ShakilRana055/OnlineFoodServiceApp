using OnlineFoodServiceEntity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceBLL.IBLLRepository
{
    public interface IBLLCategoryRepository
    {
        public List<Category> GetAll();
    }
}
