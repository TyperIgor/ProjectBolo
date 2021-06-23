using Project.BoloSemanal.Domain.FileEntities;
using System.Collections.Generic;

namespace Project.BoloSemanal.Core.Processors.FileRead
{
    public class ExtractFileContent : FileAtributes
    {
        public List<string> ReadFileContent()
        {
            while (!ReadFile.EndOfStream)
            {
                string readNames;

                readNames = ReadFile.ReadLine();

                NamesList.Add(readNames);
            }

            return NamesList;
        }

    }
}
