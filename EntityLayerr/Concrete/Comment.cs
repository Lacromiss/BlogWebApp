using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class Comment
    {
        public int Id { get; set; }
        public string Kontent { get; set; }
        public DateTime SendTime { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
