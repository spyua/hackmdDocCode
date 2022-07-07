using MVP.Model;
using NSubstitute;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MVP.UnitTest
{
    public class Tests
    {
        private  List<PackageDoc> packageDocs = new List<PackageDoc> {
                new PackageDoc {ProductName = "ProductA", DocNo = "A001", Yield = 1, NGYield = 2},
                new PackageDoc {ProductName = "ProductB", DocNo = "A002", Yield = 2, NGYield = 1},
                new PackageDoc {ProductName = "ProductC", DocNo = "A003", Yield = 3, NGYield = 0}
        };

        private IPackageDocRepository packageDocRepo;

        private IView packageDocView;
        private IPresenter packageDocPresenter;

        [SetUp]
        public void Setup()
        {
            packageDocRepo = Substitute.For<IPackageDocRepository>();
            packageDocRepo.QueryAllPackageDocs().Returns(packageDocs);
            packageDocRepo.PackageDocs = packageDocs;

            packageDocView = Substitute.For<IView>();
            packageDocView.PackageDocList = new List<string>();

            packageDocPresenter = new PackageDocPresenter(packageDocView, packageDocRepo);
        }

        [Test]
        public void Prenster建構子初始化時View中PackageDocList會同步更新資料()
        {
            var packageDocs = from packageDoc in this.packageDocs select packageDoc.DocNo;
            CollectionAssert.AreEqual(packageDocView.PackageDocList, packageDocs.ToList());
        }

        [Test]
        public void Prenster新增資料時Repo會執行CreatePackageDoc方法()
        {
            packageDocView.Product.Returns("NewProduct");
            packageDocView.DocNo.Returns("Test");
            packageDocView.Yield.Returns(0);
            packageDocView.NGYield.Returns(0);

            packageDocPresenter.SavePackageDoc();

            packageDocRepo.Received().CreatePackageDoc(Arg.Is<PackageDoc>(x=>
                x.ProductName.Equals("NewProduct")
                && x.DocNo.Equals("Test")
                && x.Yield ==0
                && x.NGYield == 0));
        }
    }
}