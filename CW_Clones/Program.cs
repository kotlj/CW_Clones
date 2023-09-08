using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CW_Clones
{

    interface ICloneable
    {
        object Clone();
    }
    class Document : ICloneable, IComparable
    {
        private string name;
        private double volume;

        public Document(string _name, double _volume)
        {
            name = _name;
            volume = _volume;
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }
        public object Clone()
        {
            return new Document(name, volume);
        }
        public int CompareTo(object obj)
        {
            Document doc = obj as Document;
            return Volume.CompareTo(doc.Volume);
        }
    }
    internal class Program
    {

        
        static void Main(string[] args)
        {
            Document doc1 = new Document("first", 1.0);
            Document doc2 = new Document("Second", 2.0);
            Document doc3 = new Document("third", 3.0);
            Document doc4 = (Document)doc1.Clone();
            Document[] arr = {doc1, doc3, doc2, doc4};
            Array.Sort(arr);
            foreach (var n in arr)
            {
                Console.WriteLine(n.Name + "\n" + n.Volume);
            }
        }
    }
}
