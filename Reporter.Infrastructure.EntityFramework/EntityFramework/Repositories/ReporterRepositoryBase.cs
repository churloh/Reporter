using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Repositories.EntityFramework;

namespace Reporter.EntityFramework.Repositories
{
    public abstract class ReporterRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ReporterDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }

    public abstract class ReporterRepositoryBase<TEntity> : ReporterRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }
}
