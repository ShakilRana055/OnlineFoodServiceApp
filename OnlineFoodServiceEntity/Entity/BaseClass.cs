using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceEntity.Entity
{
    public class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
