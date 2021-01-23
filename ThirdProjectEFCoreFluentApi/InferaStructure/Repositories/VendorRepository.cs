using Microsoft.EntityFrameworkCore;
using System.Linq;
using ThirdProjectEFCoreFluentApi.Contexts;
using ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories;
using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.InferaStructure.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly ProjectContext _db;

        public VendorRepository(ProjectContext db)
        {
            _db = db;
        }
        public Vendor GetAll(int id)
        {
            return _db.Vendor.Where(x => x.Id == id).Include(x => x.Tags).FirstOrDefault();
        }
        public Vendor GetById(int id)
        {
            return _db.Vendor.Find(id);
        }
        public int Insert(Vendor vendor)
        {
            _db.Vendor.Add(vendor);
            return _db.SaveChanges();
        }
        public int Update(Vendor vendor)
        {
            _db.Vendor.Update(vendor);
            return _db.SaveChanges();
        }
        public int Delete(Vendor vendor)
        {
            _db.Vendor.Remove(vendor);
            return _db.SaveChanges();
        }

        public int DeleteById(int id)
        {
            var result = _db.Vendor.Where(x => x.Id == id).FirstOrDefault();
            _db.Vendor.Remove(result);
            return _db.SaveChanges();
        }
        public int Patch(int id)
        {
            var result = _db.Vendor.Where(x => x.Id == id).FirstOrDefault();
            _db.Vendor.Update(result);
            return _db.SaveChanges();
        }

        public int VendorPatchUpdate(Vendor vendor)
        {
            _db.Vendor.AsNoTrackingWithIdentityResolution().FirstOrDefault(r => r.Id == vendor.Id);
            return _db.SaveChanges();
        }
    }
}
