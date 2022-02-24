using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.PkiLib.Common;
using Org.PkiLib.Ef.Configuration;

namespace Org.PkiLib.Ef.PostgreSql.Configuration
{
    public class DbGlobalIdPropertyConfigurator : IDbGlobalIdPropertyConfigurator
    {
        public PropertyBuilder<TProperty> Configure<TEntity, TProperty>(EntityTypeBuilder<TEntity> entityTypeBuilder, Expression<Func<TEntity, TProperty>> propertyExpression) where TEntity : class
        {
            Expression<Func<TEntity, object>> alternateKeyExpression = ExpressionHelper.ConvertResult<TEntity, TProperty, object>(propertyExpression);
            entityTypeBuilder.HasAlternateKey(alternateKeyExpression);
            return entityTypeBuilder
                .Property(propertyExpression)
                .HasColumnType(PostgreSql.ColumnTypes.Uuid);
        }
    }
}