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

        string val;

  

        public void Read()
        {

            XmlReader reader = XmlReader.Create("C:\\users\\" + Environment.UserName + "\\appdata\\roaming\\Blob-IDE\\Data\\lang\\language.xml");



            while(reader.Read())
            {

                if((reader.NodeType == XmlNodeType.Element) && (reader.Name == "lang"))
                {

                    if(reader.HasAttributes)
                    {

                        val = reader.GetAttribute("value");
                        
                    }

                }

            }

        }

        public string get_Val()
        {

            return val;

        }

    }


}
