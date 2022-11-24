using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace N3ApiClient.Tools
{
    public class XmlHelper
    {
        /// <summary>
        /// Serialize Object to Xml
        /// </summary>
        /// <param name="obj">Input object</param>
        /// <returns>Xml document</returns>
        public XmlDocument SerializeObject(object obj)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType());
            MemoryStream memStream = new MemoryStream();
            serializer.Serialize(memStream, obj);
            XmlDocument xml = new XmlDocument();
            memStream.Position = 0;
            xml.Load(memStream);
            memStream.Close();
            return xml;
        }
    }
}
