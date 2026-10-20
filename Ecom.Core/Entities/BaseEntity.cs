using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecom.Core.Entities
{
    public class BaseEntity<T>
    {
        //t respresent any type instead of int , int is faster in search because it is index , T means I can know the id before saving in db
        public T Id { get; set; }
    }
}
