using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories
{
    public interface IVendorRepository
    {
        Vendor GetAll(int id);
        Vendor GetById(int id);
        int Insert(Vendor vendor);
        int Update(Vendor vendor);
        int VendorPatchUpdate(Vendor vendor);
        int Delete(Vendor vendor);
        int DeleteById(int id);
        int Patch(int id);
    }
}
