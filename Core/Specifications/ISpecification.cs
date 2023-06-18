using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace Core.Specifications
{
    public interface ISpecification<TEntity>
    {
        Expression<Func<TEntity,bool>> Critiria {get;}
        List<Expression<Func<TEntity,object>>> Includes {get;}
    }
}