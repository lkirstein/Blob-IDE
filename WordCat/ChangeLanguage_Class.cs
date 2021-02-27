using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Xml;

namespace WordCat
{
    class ChangeLanguage_Class
    {

        public void UpdateConfig(string key, string value)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);

            foreach(XmlElement xmlElement in xmlDoc.DocumentElement)
            {

                if(xmlElement.Name.Equals("appSettings"))
                {

                    foreach(XmlNode xNode in xmlElement.ChildNodes)
                    {

                        xNode.Attributes[1].Value = value;

                    }

                }

            }


            ConfigurationManager.RefreshSection("appSettings");

            xmlDoc.Save(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);


        }


    }
}
