using DesignPattern.Adapter.FomatConvertSample.FormatModel;

namespace DesignPattern.Adapter.FomatConvertSample
{
    // 被轉接對象(Adaptee)
    public class Json
    {
        public string jsonStr;

        public Json(string str)
        {
            str = jsonStr;
        }

    }
}
