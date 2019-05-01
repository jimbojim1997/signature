using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace TemplateCreator
{
    class Template
    {
        private TemplateData templateData = new TemplateData();
        
        public Template()
        {

        }

        /// <summary>
        /// Loads the template HTML from a plain text file.
        /// </summary>
        /// <param name="fileName">The file path to load the HTML from.</param>
        public void TemplateFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Open))
                using (StreamReader sr = new StreamReader(fs))
                {
                    templateData.templateHTML.Value = sr.ReadToEnd();
                }
            }
            else
            {
                throw new FileNotFoundException();
            }
        }

        /// <summary>
        /// Loads the template HTML from a String.
        /// </summary>
        /// <param name="text"></param>
        public void TemplateFromText(string text)
        {
            templateData.templateHTML.Value = text;
        }

        /// <summary>
        /// Gets the HTML template string.
        /// </summary>
        /// <returns></returns>
        public string GetTemplateHTML()
        {
            return templateData.templateHTML.Value;
        }

        /// <summary>
        /// Creates the templates from <c>data</c> list then saves them into the <c>outputDirectory</c> using the <c>outputName</c> naming convention.
        /// </summary>
        /// <param name="outputDirectory">The directory to save the templates to.</param>
        /// <param name="outputName">The naming convention to use for the saved files. e.g.<example>[Forename] [Surname].</example></param>
        /// <param name="outputExtension">The file extension for the resulting files.</param>
        public void CreateTemplates(string outputDirectory, string outputName, string outputExtension)
        {
            
        }

        /// <summary>
        /// Save the template data to an XML file.
        /// </summary>
        /// <param name="saveLocation">The file path to save the data to.</param>
        public void SaveTemplateData(string saveLocation)
        {
            XmlSerializer xs = new XmlSerializer(typeof(TemplateData));
            using (FileStream fs = new FileStream(saveLocation, FileMode.Create))
            {
                xs.Serialize(fs, templateData);
            }
        }

        /// <summary>
        /// Load the template data from an XML file.
        /// </summary>
        /// <param name="loadLocation">The file path to load the data from.</param>
        public void LoadTemplateData(string loadLocation)
        {
            XmlSerializer xs = new XmlSerializer(typeof(TemplateData));
            using (FileStream fs = new FileStream(loadLocation, FileMode.Open))
            {
                templateData = (TemplateData)xs.Deserialize(fs);
            }
        }
    }
}
