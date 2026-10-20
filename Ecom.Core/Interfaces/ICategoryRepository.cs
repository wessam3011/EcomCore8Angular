using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ecom.Core.Entities.Product;

namespace Ecom.Core.Interfaces
{
    public interface ICategoryRepository: IGenericRepository<Category>
    {
        //this interface inhiert crud from igenericRepository but it may contain operations related to category only
        //for future method

    }
}
