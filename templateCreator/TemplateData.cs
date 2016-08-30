using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace TemplateCreator
{
    [XmlRoot("templateData")]
    class TemplateData
    {
        public XmlCDataSection templateHTML = new XmlDocument().CreateCDataSection("");
        public List<Dictionary<string, string>> data = new List<Dictionary<string, string>>();

        public TemplateData()
        {

        }
    }
}
