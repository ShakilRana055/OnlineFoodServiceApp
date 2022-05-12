using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceEntity
{
    public class OnlineFoodServiceContext: DbContext
    {
        public OnlineFoodServiceContext(DbContextOptions<OnlineFoodServiceContext> options):base(options)
        {

        }
    }
}
