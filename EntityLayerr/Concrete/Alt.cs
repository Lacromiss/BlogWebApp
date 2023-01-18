using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class Alt
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}
