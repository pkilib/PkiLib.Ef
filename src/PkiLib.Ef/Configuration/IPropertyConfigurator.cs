﻿using System;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Org.PkiLib.Ef.Configuration
{
    public interface IPropertyConfigurator
    {
        PropertyBuilder<TProperty> Configure<TEntity, TProperty>(
            EntityTypeBuilder<TEntity> entityTypeBuilder,
            Expression<Func<TEntity, TProperty>> propertyExpression)
            where TEntity : class;
    }
}