using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;

namespace Salon.UTILS
{
    class GenericSerializator
    {
        public static void Serialize<T>(string fileName, List<T> listToSerialize) where T : class
        {
            try
            {
                var serializator = new XmlSerializer(typeof(List<T>));
                using (var sw = new StreamWriter($@"../../Data/{fileName}"))
                {
                    serializator.Serialize(sw, listToSerialize);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<T> Deserialize<T>(string fileName) where T : class
        {

            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var sr = new StreamReader($@"../../Data/{fileName}"))
                {
                    return (List<T>)serializer.Deserialize(sr);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
