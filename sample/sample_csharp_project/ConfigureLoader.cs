using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml;

namespace sampleUI
{
    class ConfigureLoader
    {
        private static ConfigureLoader Instance;

        FileInfo m_confFile;
        XmlDocument m_xDoc;

        public static ConfigureLoader This()
        {
            if (Instance == null)
            {
                Instance = new ConfigureLoader();
                Instance.initialize();
            }
            return
                Instance;
        }

        public void initialize()
        {
            if (!File.Exists("config.xml"))
            {
                StreamWriter sw = (StreamWriter)File.CreateText("config.xml");
                sw.Write("<?xml version=\"1.0\" encoding=\"utf-8\" ?> \n\t<configuration>\n\n\t</configuration>");
                sw.Close();
            }
            m_xDoc = new XmlDocument();
            m_xDoc.Load("config.xml");
               
            
        }

        public void SetItems(string Key, string Value)
        {
            XmlNode node = m_xDoc.SelectSingleNode("//" + Key);
            if(node != null)
                node.InnerText = Value;
            else
            {
                node = m_xDoc.CreateNode(XmlNodeType.Element, Key, "");
                node.InnerText = Value;
                m_xDoc.DocumentElement.AppendChild(node);
            }
            return;
        }

        public string GetItems(string Key)
        {
            XmlNode node = m_xDoc.SelectSingleNode("//" + Key);
            if (node != null)
                return node.InnerText;
            else
                return "";
        }

        public void Terminate()
        {
            m_xDoc.Save("config.xml");
        }
    }
}
