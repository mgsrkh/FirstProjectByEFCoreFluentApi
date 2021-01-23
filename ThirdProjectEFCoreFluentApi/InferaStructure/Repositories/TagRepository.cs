using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ThirdProjectEFCoreFluentApi.Contexts;
using ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories;
using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.InferaStructure.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ProjectContext _db;

        public TagRepository(ProjectContext db)
        {
            _db = db;
        }

        public List<Tag> GetAll()
        {
            return _db.Tag.Include(x=>x.Vendor).ToList();
        }
        public Tag GetById(int id)
        {
            return _db.Tag.Find(id);
        }
        public int Insert(Tag tag)
        {
            _db.Tag.Add(tag);
            return _db.SaveChanges();
        }
        public int Update(Tag tag)
        {
            _db.Tag.Update(tag);
            return _db.SaveChanges();
        }
        public int Delete(Tag tag)
        {
            _db.Tag.Remove(tag);
            return _db.SaveChanges();
        }
        public int DeleteById(int id)
        {
            var result = _db.Tag.Where(x => x.VendorId == id).FirstOrDefault();
            _db.Tag.Remove(result);
            return _db.SaveChanges();
        }
    }
}
