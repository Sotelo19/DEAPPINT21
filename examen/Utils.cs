using System;
using System.IO;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace p17_repasopoo
{
    public static class Utils {
        public static void GrabarXml(string arch, Red red) {
            FileStream f = File.Open(arch, FileMode.Create);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            xml.Serialize(f,red);
        }
        public static void LeerXml(string arch, ref Red red) {
            FileStream f = File.Open(arch, FileMode.Open);
            XmlSerializer xml = new XmlSerializer(typeof(Red));
            red = (Red) xml.Deserialize(f);
        }
        public static void GrabarJson(string arch, Red red) {
             StreamWriter f = File.CreateText(arch);
             JsonSerializer json = new JsonSerializer();
             json.Serialize(f, red);
             f.Close();
        }
        public static void LeerJson(string arch, ref Red red) {
           StreamReader f = File.OpenText(arch);
           string txt = f.ReadToEnd();
           red = JsonConvert.DeserializeObject<Red>(txt);
        }
    }
}