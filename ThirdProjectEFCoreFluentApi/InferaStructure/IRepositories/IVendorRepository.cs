using ThirdProjectEFCoreFluentApi.Models;

namespace ThirdProjectEFCoreFluentApi.InferaStructure.IRepositories
{
    public interface IVendorRepository
    {
        Vendor GetVendorById(int id);
        Vendor GetById(int id);
        Vendor Insert(Vendor vendor);
        int Update(Vendor vendor);
        int Delete(Vendor vendor);
        int DeleteById(int id);
        Vendor GetByIdForPatch(int id);
        Vendor Patch(Vendor vendor);
        int SavePatchChanges(Vendor vendor);

    }
}
