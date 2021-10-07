using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace BookStorage
{
    class FileManager
    {
        public void WriteRecordInFile(IList<Book> books)
        {
            using (StreamWriter writer = new StreamWriter(DeffaultSettings.TXT_FILE))
            {
                var data = JsonConvert.SerializeObject(books);

                writer.WriteLine(data);
            }
        }

        public IEnumerable<Book> GetBooksFromFile()
        {
            return JsonConvert.DeserializeObject<List<Book>>(File.ReadAllText(DeffaultSettings.TXT_FILE));
        }
    }
}
