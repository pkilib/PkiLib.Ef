using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Org.PkiLib.Ef.Configuration;

namespace Org.PkiLib.Ef.PostgreSql.Configuration
{
    public class DbTimestampWithTimeZonePropertyConfigurator : IDbTimestampWithTimeZonePropertyConfigurator
    {
        public PropertyBuilder<TProperty> Configure<TEntity, TProperty>(EntityTypeBuilder<TEntity> entityTypeBuilder, Expression<Func<TEntity, TProperty>> propertyExpression) where TEntity : class
        {
            return entityTypeBuilder
                .Property(propertyExpression)
                .HasColumnType(PostgreSql.ColumnTypes.TimestampWithTimeZone);
        }
    }
}