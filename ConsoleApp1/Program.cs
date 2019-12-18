using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //var lista = new List<Ajuste>();
            //var ajuste1 = new Ajuste();
            //ajuste1.Name = "Texto";
            //ajuste1.Value = 15;
            //lista.Add(ajuste1);
            //Serialize(lista, "AjustesOrig.xml");

            var listaLectura = Deserialize("Ajustes.xml");

            foreach (var item in listaLectura)
            {
                //var nombre = item.Name;
                //var valor = item.Value;
                //Console.WriteLine(nombre+", "+valor);
                Console.WriteLine($"El nombre:{item.Name} vale= {item.Value}");

            }

            Console.WriteLine("Presione <Enter> para continuar");


            Console.ReadLine();


        }

        static void Serialize(object myObject, string fileName)
        {
            XmlSerializer xsSubmit = new XmlSerializer(myObject.GetType());
            var xml = "";

            using (var sww = new StringWriter() )
            {
                using (XmlWriter writer = XmlWriter.Create(sww, new XmlWriterSettings() { Indent = true, OmitXmlDeclaration=true }))
                {
                    xsSubmit.Serialize(writer, myObject );
                    xml = sww.ToString(); // Your XML
                }
            }
            System.IO.File.WriteAllText(fileName, xml);
        }

        static List<Ajuste> Deserialize(string fileName)
        {
            using (TextReader reader = new StreamReader(fileName))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Ajuste>));
                return (List<Ajuste>)serializer.Deserialize(reader);
            }
        }

    }
    public class Ajuste
    {
        public string Name { get; set; }
        public int Value { get; set; }

    }
}
