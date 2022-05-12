using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceEntity.Entity
{
    public class Category: BaseClass
    {
        public Category()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Category>Categories { get; set; }
    }
}
