﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using CTMLibrary.CtmMessages;

namespace CTMLibrary
{
   public static class Seralizer
    {
        public static T Deserialize<T>(string input)
        where T : class
        {
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(T));

            using (var sr = new StringReader(input))
                return (T)ser.Deserialize(sr);
        }
        public static string SerializeObject<T>(T toSerialize)
        {
            var xmlSerializer = new XmlSerializer(toSerialize.GetType());
            //Create our own namespaces for the output
            var ns = new XmlSerializerNamespaces();

            //Add an empty namespace and empty value
            ns.Add("", "");
            using (StringWriter textWriter = new StringWriterWithEncoding(Encoding.GetEncoding("ISO-8859-1")))
            {
                xmlSerializer?.Serialize(textWriter, toSerialize, ns);
                return textWriter?.ToString();
            }
        }

        public static CTM_Message ByteArrayToObject(byte[] arrBytes)
        {
            var memStream = new MemoryStream();
            var binForm = new BinaryFormatter();

            memStream?.Write(arrBytes, 0, arrBytes.Length);
            memStream?.Seek(0, SeekOrigin.Begin);

            var obj = (CTM_Message)binForm?.Deserialize(memStream);

            return obj;
        }

    }
    public class StringWriterWithEncoding : StringWriter
    {
        public StringWriterWithEncoding(Encoding encoding) : base()
        {
            Encoding = encoding;
        }
        public override Encoding Encoding { get; }
    }
}
