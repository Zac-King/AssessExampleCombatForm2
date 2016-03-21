using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;
using System.IO;

namespace Combat.Utilities
{
    // Requires reference to System.Runtime.Serialization.Formatters.Soap;
    class Serializer
    {
        public static void SerilizeBinary<T>(string saveFolder, string fileName, T t) 
        {
            using (FileStream fs = File.Create(@"..\..\" + saveFolder + @"\" + fileName + ".bin"))
            {
                BinaryFormatter serializer = new BinaryFormatter(); // Create a Binary Serializer

                serializer.Serialize(fs, t);    // Serialize our desired object, t, at our desired Location, fs. 
                fs.Close();                     // Be sure to close the file after we are done
            }
        }

        public static T DeserializeBinary<T>(string saveFolder, string fileName)
        {
            T t;    // Our Temp container for 
            using (FileStream fs = File.OpenRead(@"..\..\" + saveFolder + @"\" + fileName + ".bin")) 
            {
                BinaryFormatter deserializer = new BinaryFormatter();

                t = (T)deserializer.Deserialize(fs); // 
                fs.Close();     // Be sure to close the file after we are done
            }

            return t;
        }


        public static void SerializeXML<T>(string saveFolder, string fileName, T t)
        {
            using (FileStream fs = File.Create(@"..\..\" + saveFolder + @"\" + fileName + ".bin"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                serializer.Serialize(fs, t);
                fs.Close();
            }
        }

        public static T DeserializeXML<T>(string saveFolder, string fileName)
        {
            T t;
            using (FileStream fs = File.OpenRead(@"..\..\" + saveFolder + @"\" + fileName + ".bin"))
            {
                XmlSerializer deserializer = new XmlSerializer(typeof(T));
                t = (T)deserializer.Deserialize(fs);
            }

            return t;
        }
    }
}
