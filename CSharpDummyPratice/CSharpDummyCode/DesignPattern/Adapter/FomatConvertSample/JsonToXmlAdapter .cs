using DesignPattern.Adapter.FomatConvertSample.FormatModel;

namespace DesignPattern.Adapter.FomatConvertSample
{
    public class JsonToXmlAdapter : IDataFormatAdapter
    {
        // 被轉接對象(Adaptee)
        private Json json;
        public JsonToXmlAdapter(Json json)
        {
            this.json = json;
        }

        public object Convert()
        {
            var xml = new Xml();
            //  Logic to convert Json to Xml -> json.jsonStr
            return xml;
        }
    }
}
