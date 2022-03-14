using DesignPattern.Adapter.FomatConvertSample.FormatModel;

namespace DesignPattern.Adapter.FomatConvertSample
{
    public class JsonToCSVAdapter : IDataFormatAdapter
    {
        // 被轉接對象(Adaptee)
        private Json json;
        public JsonToCSVAdapter(Json json)
        {
            this.json = json;
        }

        public object Convert()
        {
            var csv = new CSV();
            //  Logic to convert Json to CSV -> json.jsonStr
            return csv;
        }
    }
}
