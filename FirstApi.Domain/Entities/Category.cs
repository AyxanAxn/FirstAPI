using FirstApi.Domain.Commons.EntityBase;
using FirstApi.Domain.Entities.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApi.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<CategoryProduct> categoryProducts { get; set; }
    }
}
