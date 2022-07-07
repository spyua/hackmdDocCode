using System.Collections.Generic;

namespace MVP
{
    public interface IView
    {
        string Product { get; set; }
        string DocNo { get; set; }
        int Yield { get; set; }
        int NGYield { get; set; }
        IList<string> PackageDocList { get; set; }
        int SelectedPackageDoc { get; set; }
        IPresenter Presenter { set; }
    }
}
