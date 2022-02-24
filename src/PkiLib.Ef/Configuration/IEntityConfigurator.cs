using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Org.PkiLib.Ef.Configuration
{
    public interface IEntityConfigurator
    {
        EntityTypeBuilder<TEntity> Configure<TEntity>(EntityTypeBuilder<TEntity> entityTypeBuilder)
            where TEntity : class;
    }
}