using System.Collections.Generic;
using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories
{
    public interface ITagRepository
    {
        List<Tag> GetAll();
        Tag GetById(int id);
        int Insert(Tag tag);
        int Update(Tag tag);
        int Delete(Tag tag);
        int DeleteById(int id);
    }
}
