using System;
using System.Collections.Generic;
using System.Linq;

namespace MVP.Model
{
    /// <summary>
    /// 仿DataBase資料庫
    /// </summary>
    public class PackageDocRepository : IPackageDocRepository
    {
        // 方便Demo用-建立假資料庫資料變數
        public List<PackageDoc> PackageDocs { get; set; }

        private List<PackageDoc> GeneratorSeedData()
        {
            var seedDatas = new List<PackageDoc>();

            var seedData = new PackageDoc()
            {
                ProductName = "ProductA",
                DocNo = "A001",
                Yield = 10,
                NGYield = 0,
            };

            var seedData2 = new PackageDoc()
            {
                ProductName = "ProductB",
                DocNo = "A002",
                Yield = 11,
                NGYield = 0,
            };

            seedDatas.Add(seedData);
            seedDatas.Add(seedData2);

            return seedDatas;
        }

        public PackageDocRepository()
        {
            PackageDocs = GeneratorSeedData();
        }

        public PackageDocRepository(List<PackageDoc> datas)
        {
            PackageDocs = datas;
        }

        public void CreatePackageDoc(PackageDoc doc)
        {
            var packageDoc = PackageDocs.Where(x => x.DocNo.Equals(doc.DocNo));

            if (packageDoc.Count() > 0)
                throw new Exception("已有此單據資料，不可新增");

            PackageDocs.Add(doc);
        }

        public void UpdatePackageDoc(PackageDoc doc)
        {
            var orinigialPack = GetPackageDoc(doc.DocNo);
            PackageDocs.Remove(orinigialPack);
            PackageDocs.Add(doc);
        }

        public List<PackageDoc> QueryAllPackageDocs()
        {
            return PackageDocs;
        }

        public PackageDoc GetPackageDoc(string docNo)
        {
            var packageDocs = PackageDocs.Where(x => x.DocNo.Equals(docNo));

            if (packageDocs.Count() == 0)
                throw new Exception("無此資料");

            return packageDocs.FirstOrDefault();
        }

        public void DeletePackageDoc(string docNo)
        {
            var orinigialPack = GetPackageDoc(docNo);
            PackageDocs.Remove(orinigialPack);
        }


    }
}
