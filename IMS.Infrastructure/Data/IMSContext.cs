using System.Data.Entity;

namespace IMS.Infrastructure.Data
{
    public class IMSContext : DbContext
    {

        public IMSContext() : base("IMSContext")
        {
        }
        public new IDbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            return base.Set<TEntity>();
        }
    }
}
