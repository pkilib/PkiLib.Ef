using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Org.PkiLib.Ef.Configuration
{
    public static class EntityTypeBuilderExtensions
    {
        public static PropertyBuilder<TProperty> Configure<TEntity, TProperty>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            IPropertyConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder, propertyExpression);
        }

        public static EntityTypeBuilder<TEntity> Configure<TEntity>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            IEntityConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder);
        }

        public static PropertyBuilder<TProperty> ConfigureDbConcurrencyToken<TEntity, TProperty>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            IDbConcurrencyTokenPropertyConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder, propertyExpression);
        }

        public static PropertyBuilder<TProperty> ConfigureDbCreated<TEntity, TProperty>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            IDbCreatedPropertyConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder, propertyExpression);
        }

        public static PropertyBuilder<TProperty> ConfigureDbGlobalId<TEntity, TProperty>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            IDbGlobalIdPropertyConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder, propertyExpression);
        }

        public static PropertyBuilder<TProperty> ConfigureDbTimestampWithTimeZone<TEntity, TProperty>(
            this EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression,
            IDbTimestampWithTimeZonePropertyConfigurator configurator)
            where TEntity : class
        {
            return configurator.Configure(entityTypeBuilder, propertyExpression);
        }
    }
}
