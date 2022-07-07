using MVP.Model;
using System.Collections.Generic;

namespace MVP
{
    public interface IPresenter
    {
        void UpdatePackageDocView(string docNo);
        void SavePackageDoc();
        void DeletePackageDoc();
    }
}
