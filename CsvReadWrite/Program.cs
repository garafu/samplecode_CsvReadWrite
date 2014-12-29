namespace CsvReadWrite
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    class Program
    {
        static void Main(string[] args)
        {
            List<string> row = null;

            using (var csv = new CsvReader(@"TestData.csv"))
            {
                while ((row = csv.ReadRow()) != null)
                {
                    Console.WriteLine(row[0].ToString());
                }
            }

            var data = new List<List<int>>()
            {
                new List<int>(){1,2,3,4,5},
                new List<int>(){1,1,1,1,1}
            };

            using (var writer = new CsvWriter(@"hoge.csv"))
            {
                writer.Write(data);
            }
        }

        static async void Func()
        {
            List<List<string>> data = null;

            using (var csv = new CsvReader(@"TestData.csv"))
            {
                data = await csv.ReadToEndAsync();
            }
        }

        static void Backup()
        {
            var file = new StreamReader(@"TestData.csv", Encoding.Default);
            var line = string.Empty;
            var data = new List<List<string>>();
            var record = new List<string>();
            var field = new StringBuilder();
            var isQuotedField = false;

            while ((line = file.ReadLine()) != null)
            {
                for (var i = 0; i < line.Length; i++)
                {
                    var item = line[i];

                    if (item == ',' && !isQuotedField)
                    {
                        record.Add(field.ToString());
                        field.Clear();
                    }
                    else if (item == '"')
                    {
                        if ((i + 1 >= line.Length) ||
                            (field.Length == 0 && !isQuotedField))
                        {
                            isQuotedField = true;
                            continue;
                        }

                        var peek = line[i + 1];

                        if (peek == '"')
                        {
                            field.Append('"');
                            i += 1;
                        }
                        else if (peek == ',' && isQuotedField)
                        {
                            isQuotedField = false;
                            i += 1;
                            record.Add(field.ToString());
                            field.Clear();
                        }
                    }
                    else
                    {
                        field.Append(item);
                    }
                }

                if (isQuotedField)
                {
                    field.Append(Environment.NewLine);
                }
                else
                {
                    record.Add(field.ToString());

                    data.Add(record);

                    record = new List<string>();
                }

                Console.WriteLine(line);
            }
        }
    }
}
