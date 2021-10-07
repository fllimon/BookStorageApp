using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;

namespace BookStorage
{
    class FileManager
    {
        public void WriteRecordInFile(Book book)
        {
            using (StreamWriter writer = new StreamWriter(DeffaultSettings.TXT_FILE, true))
            {
                var data = JsonConvert.SerializeObject(book, Formatting.Indented);

                writer.WriteLine(data);
            }
        }
    }
}
