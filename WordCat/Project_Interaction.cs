using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;

namespace WordCat
{
    class Project_Interaction
    {

        string name;
        string creator;
        string type;

        public void Get_Info(string location)
        {

            XmlReader reader = XmlReader.Create(location);



            while (reader.Read())
            {

                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "name"))
                {

                    if (reader.HasAttributes)
                    {

                        name = reader.GetAttribute("value");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "creator"))
                {

                    if (reader.HasAttributes)
                    {

                        creator = reader.GetAttribute("value");

                    }

                }
                if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "type"))
                {

                    if (reader.HasAttributes)
                    {

                        type = reader.GetAttribute("value");

                    }

                }


            }
            if ((name == null) || (creator == null) || (type == null))
            {
                MessageBox.Show("File is outdated or\nnot a \"Blob IDE-Project-XML-File\"!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Name : " + name + "\nCreator : " + creator + "\nType : " + type, "Project Information - " + name, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }


    }
}
