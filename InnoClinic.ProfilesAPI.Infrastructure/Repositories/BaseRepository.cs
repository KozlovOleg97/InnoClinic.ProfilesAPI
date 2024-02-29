using InnoClinic.ProfilesAPI.Infrastructure.DataAccess;
using InnoClinic.ProfilesAPI.Infrastructure.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace InnoClinic.ProfilesAPI.Infrastructure.Repositories
{
    public class BaseRepository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly ProfileDbContext _profileDbContext;
        private readonly DbSet<TEntity> _dbSet;

        public BaseRepository(ProfileDbContext profileDbContext)
        {
            _profileDbContext = profileDbContext;
            _dbSet = _profileDbContext.Set<TEntity>();
        }

        public async Task AddAsync(TEntity entity) => await _dbSet.AddAsync(entity);
        public async Task<IEnumerable<TEntity>> GetAllAsync() => await _dbSet.ToListAsync();

        public async Task<TEntity?> GetAsync(Guid? id) => await _dbSet.FindAsync(id);

        public async Task DeleteAsync(Guid id)
        {
            var dataToDelete = await _dbSet.FindAsync(id);
            if (dataToDelete != null)
                _dbSet.Remove(dataToDelete);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await Task.Run(() => _dbSet.Attach(entity));
            _profileDbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task SaveAsync()
        {
            await _profileDbContext.SaveChangesAsync();
        }
    }
}
