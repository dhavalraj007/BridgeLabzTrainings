using CsvHelper;
using System.Globalization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace MyApp
{
    class FileOperations
    {
        public static void test()
        {
            /*FileExists("C:\\dev\\Training\\Day1\\MyApp\\TextFile1.txt");
            ReadText("C:\\dev\\Training\\Day1\\MyApp\\TextFile1.txt");
            WriteText("C:\\dev\\Training\\Day1\\MyApp\\TextFile1.txt");*/
            //WriteBinary("C:\\dev\\Training\\Day1\\MyApp\\TextFile1.txt");
            Person person = new Person(123, "jake", "Ny", 28);
            /*  SerializeObject(person,"C:\\dev\\Training\\Day1\\MyApp\\object.txt");
              Person p = (Person)DeserializeObject("C:\\dev\\Training\\Day1\\MyApp\\object.txt");
              Console.WriteLine(p.ToString());*/

            /*JSONSerializePerson(person, "C:\\dev\\Training\\Day1\\MyApp\\JSONobject.txt");
            Person p = JSONDeserializePerson("C:\\dev\\Training\\Day1\\MyApp\\JSONobject.txt");
            Console.WriteLine(p.ToString());*/

            CSVSerializePersons(new Person[] { person, person, person }, "C:\\dev\\Training\\Day1\\MyApp\\objects.csv");
            var deserializedPersons = CSVDeserializePersons("C:\\dev\\Training\\Day1\\MyApp\\objects.csv");
            foreach(Person p in deserializedPersons)
            {
                Console.WriteLine(p.ToString());  
            }
        }


        static void WriteText(string v)
        {
            File.WriteAllLines(v, new string[] { "First Line", "Second Line", "Third Line" });
        }

        static void ReadText(string v)
        {
            string[] lines = File.ReadAllLines(v);
            foreach (string line in lines) { Console.WriteLine(line); }
        }

        static void FileExists(string path)
        {
            Console.WriteLine(File.Exists(path) ? "Exists" : "Does not Exists");
        }

        static void WriteBinary(string path)
        {
            FileStream fs = File.OpenWrite(path);
            fs.Write(new byte[] { 0b00000001, 0b00000010, 0b00000011 });
            fs.Close();
        }

        static void SerializeObject(object p, string path)
        {
            FileStream fs = File.OpenWrite(path);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, p);
            fs.Close();
        }

        static object DeserializeObject(string path)
        {
            FileStream fs = File.OpenRead(path);
            BinaryFormatter bf = new BinaryFormatter();
            return bf.Deserialize(fs);
        }
        static void JSONSerializePerson(Person p, string path)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(p));
        }
        static Person JSONDeserializePerson(string path)
        {
            return JsonSerializer.Deserialize<Person>(File.ReadAllText(path));
        }

        static void CSVSerializePersons(Person[] persons, string path)
        {
            StreamWriter streamWriter = new StreamWriter(path);
            CsvWriter csvWriter = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
            csvWriter.WriteRecords(persons);
            csvWriter.Flush();
            streamWriter.Close();
        }
        static Person[] CSVDeserializePersons(string path)
        {
            StreamReader streamReader= new StreamReader(path);
            CsvReader csvReader = new CsvReader(streamReader,CultureInfo.InvariantCulture);
            return csvReader.GetRecords<Person>().ToArray<Person>();
        }
    }
}