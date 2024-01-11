using Api.Data.Context;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Data.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {

        private readonly MyContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }


        public async Task<bool> DeleteAsync(Guid id)
        {
            try
            {
                var exist = await _dataSet.FirstOrDefaultAsync(x => x.Id == id);
                if (exist == null) return false;
                _dataSet.Remove(exist);
                await _context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> InsertAsync(T item)
        {
            try
            {
                if (item.Id == Guid.Empty)
                {
                    item.Id = Guid.NewGuid();
                }
                item.CreateAt = DateTime.UtcNow;

                _dataSet.Add(item);
                await _context.SaveChangesAsync();

            }
            catch (Exception)
            {
                throw;
            }
            return item;
        }

        public async Task<IEnumerable<T>> SelectAllAsync()
        {
            try
            {
                return await _dataSet.ToListAsync();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> SelectAsync(Guid id)
        {
            try
            {
                return await _dataSet.SingleOrDefaultAsync(i => i.Id == id);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public async Task<T> UpdateAsync(T item)
        {
            try
            {
                var itemDb = await _dataSet.FirstOrDefaultAsync(i => i.Id == item.Id);
                if (itemDb == null) return null;

                item.UpdateAt = DateTime.UtcNow;
                item.CreateAt = itemDb.CreateAt;

                _context.Entry(itemDb).CurrentValues.SetValues(item);


                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {

                throw;
            }
            return item;
        }
    }
}
