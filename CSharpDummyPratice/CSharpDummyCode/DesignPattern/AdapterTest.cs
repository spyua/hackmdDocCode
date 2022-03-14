using DesignPattern.Adapter.FomatConvertSample;
using DesignPattern.Adapter.FomatConvertSample.FormatModel;
using NUnit.Framework;
using System.Data;

namespace DesignPattern
{
    public class AdapterTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void JustXmlDemo()
        {
            var json = new Json("some json data");
            IDataFormatAdapter adapter = new JsonToXmlAdapter(json);
            Xml xml = adapter.Convert() as Xml;
        }

        [Test]
        public void JustCSVDemo()
        {
            var json = new Json("some json data");
            IDataFormatAdapter adapter = new JsonToCSVAdapter(json);
            CSV csv = adapter.Convert() as CSV;
        }

    }
}