using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;


namespace Core.Specifications
{
    public interface ISpecification<T>
    {
        Expression<Func<T,bool>> Critiria {get;}
        List<Expression<Func<T,object>>> Includes {get;}

        Expression<Func<T,object>> OrderBy{get;}
        Expression<Func<T,object>> OrderByDescending{get;}

        public int Take { get;}
        public int Skip { get;}
        public bool IsPagingEnabled { get;}
    }
}