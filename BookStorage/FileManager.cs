using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace BookStorage
{
    class FileManager
    {
        private readonly JsonSerializer _serializer = new JsonSerializer();

        public void WriteRecordInFile(Book book)
        {
            using (StreamWriter writer = new StreamWriter(DeffaultSettings.TXT_FILE, true))
            {
                var data = JsonConvert.SerializeObject(book, Formatting.Indented);

                writer.WriteLine(data);
            }
        }

        public IEnumerable<Book> GetBooksFromFile()
        {
            IList<Book> lists = new List<Book>();

            using (var reader = new StreamReader(DeffaultSettings.TXT_FILE))
            {
                using (var json = new JsonTextReader(reader))
                {
                    if (json == null)
                    {
                        throw new NullReferenceException();
                    }

                    yield return _serializer.Deserialize<Book>(json);
                }
            }
        }
    }
}
