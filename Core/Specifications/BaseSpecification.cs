using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class BaseSpecification<TEntity> : ISpecification<TEntity>
    {
        public BaseSpecification()
        {
            
        }
        public BaseSpecification(Expression<Func<TEntity, bool>> critiria)
        {
            Critiria = critiria;
        }
        public Expression<Func<TEntity, bool>> Critiria {get;}

        public List<Expression<Func<TEntity, object>>> Includes {get;} = new List<Expression<Func<TEntity, object>>>();

        protected void AddInclude(Expression<Func<TEntity, object>> includeExpression) => Includes.Add(includeExpression);
    }
}