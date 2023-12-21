using System;
using Bulky.DataAccess.Data;
using Bulky.DataAccess.Repository.IRepository;

namespace Bulky.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
	{

        private ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }

        public UnitOfWork(ApplicationDbContext db, IProductRepository pr, ICategoryRepository cr)
        {
            _db = db;
            Category = cr;
            Product = pr;
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}

