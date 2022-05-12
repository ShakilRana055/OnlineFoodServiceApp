using OnlineFoodServiceDAL.IDALRepository;
using OnlineFoodServiceEntity.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineFoodServiceDAL.DALRepository
{
    public class DALCategoryRepository: IDALCategoryRepository
    {
        private readonly ISQLServerConfiguration sql;

        public DALCategoryRepository(ISQLServerConfiguration sql)
        {
            this.sql = sql;
        }

        public List<Category> GetAll()
        {
            var categories = new List<Category>
            {
                new Category()
                {
                    Id = 1,
                    Name = "Category 1"
                },
                new Category()
                {
                    Id = 2,
                    Name = "Category 2"
                },
                new Category()
                {
                    Id = 3,
                    Name = "Category 3"
                },
            };
            Get();
            return categories;
        }
        public void Get()
        {
            var list = new List<Test>();
            DataTable dt = sql.ExecuteProcedure("SelectAllTest");
            foreach (DataRow dr in dt.Rows)
            {
                list.Add(new Test(dr));
            }
        }
        public class Test
        {
            public int Id { get; set; }
            public int Number { get; set; }
            public Test(DataRow dr)
            {
                Id = Convert.ToInt32(dr["Id"]);
                Number = Convert.ToInt32(dr["Id"]);
            }
        }
    }
}
