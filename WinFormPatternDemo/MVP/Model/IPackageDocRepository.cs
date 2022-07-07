using System.Collections.Generic;

namespace MVP.Model
{
    public interface IPackageDocRepository
    {      
        List<PackageDoc> PackageDocs { get; set; }

        void CreatePackageDoc(PackageDoc doc);

        void UpdatePackageDoc(PackageDoc doc);

        List<PackageDoc> QueryAllPackageDocs();

        PackageDoc GetPackageDoc(string docNo);

        void DeletePackageDoc(string docNo);
    }
}
