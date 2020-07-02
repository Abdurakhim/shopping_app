using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shopping_app.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Models.Category> AllCategories { get; }
    }
}
