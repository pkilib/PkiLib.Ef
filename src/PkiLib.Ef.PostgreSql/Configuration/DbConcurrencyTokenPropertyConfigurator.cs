using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.PkiLib.Ef.Configuration;

namespace Org.PkiLib.Ef.PostgreSql.Configuration
{
    public class DbConcurrencyTokenPropertyConfigurator : IDbConcurrencyTokenPropertyConfigurator
    {
        public PropertyBuilder<TProperty> Configure<TEntity, TProperty>(EntityTypeBuilder<TEntity> entityTypeBuilder, Expression<Func<TEntity, TProperty>> propertyExpression) where TEntity : class
        {
            return entityTypeBuilder
                .Property(propertyExpression)
                .HasColumnName(PostgreSql.ColumnNames.Xmin)
                .HasColumnType(PostgreSql.ColumnTypes.Xid)
                .ValueGeneratedOnAddOrUpdate()
                .IsConcurrencyToken();
        }
    }
}