using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace darkstar.core
{
    public interface IEFRepository<TEntity,TId>
    {
        void Add(TEntity p1);
        void Update(TEntity p1);
        void Delete(TId Id);
    }
}
