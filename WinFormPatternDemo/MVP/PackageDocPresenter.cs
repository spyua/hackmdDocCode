using MVP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MVP
{
    public class PackageDocPresenter : IPresenter
    {
        private readonly IView _view;
        private IPackageDocRepository _docRepo;
        
        public PackageDocPresenter(IView view)
        {
            _docRepo = new PackageDocRepository();
            _view = view;
            _view.Presenter = this;
            RefreshPackageDocListView();
        }

        public PackageDocPresenter(IView view, IPackageDocRepository docRepo)
        {
            _docRepo = docRepo;

            _view = view;
            _view.Presenter = this;
            RefreshPackageDocListView();
        }


        public void RefreshPackageDocListView()
        {
            if (_docRepo.QueryAllPackageDocs().Count() == 0)
            {
                _view.Product = string.Empty;
                _view.DocNo = string.Empty;
                _view.Yield = 0;
                _view.NGYield = 0;
                _view.PackageDocList = new List<string>();
                return;
            }
                
            var packageDocs = from doc in _docRepo.QueryAllPackageDocs() select doc.DocNo;
            int selectedPackageDoc = _view.SelectedPackageDoc >= 0 ? _view.SelectedPackageDoc : 0;
            _view.PackageDocList = packageDocs.ToList();
            _view.SelectedPackageDoc = selectedPackageDoc;
        }

        // 待完成
        public void UpdatePackageDocView(string docNo)
        {
            var packageDoc = _docRepo.GetPackageDoc(docNo);
            _view.Product = packageDoc.ProductName;
            _view.DocNo = packageDoc.DocNo;
            _view.Yield = packageDoc.Yield;
            _view.NGYield = packageDoc.NGYield;
        }

        public void SavePackageDoc()
        {
            if (!InvalidDocPara())
                return;

            var packDoc = new PackageDoc()
            {
                ProductName = _view.Product,
                DocNo = _view.DocNo,
                Yield = _view.Yield,
                NGYield = _view.NGYield
            };

            _docRepo.CreatePackageDoc(packDoc);
            RefreshPackageDocListView();
        }

        public void DeletePackageDoc()
        {
            if (!InvalidDocPara())
                return;

            _docRepo.DeletePackageDoc(_view.DocNo);
            RefreshPackageDocListView();
        }

        private bool InvalidDocPara()
        {
            try
            {
                ValidtionText();
                return true;
            }
            catch (ArgumentNullException e)
            {
                throw new Exception(e.ToString());
            }
        }

        // Invaild 
        private void ValidtionText()
        {
            AssertText(_view.Product, "請填寫產品名稱");
            AssertText(_view.DocNo, "請填寫單號");
        }

        private void AssertText(string text, string errorMessage)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new ArgumentNullException(errorMessage);
            }
        }


    }
}
