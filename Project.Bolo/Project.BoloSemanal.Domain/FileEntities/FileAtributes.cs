using System.Collections.Generic;
using System.IO;

namespace Project.BoloSemanal.Domain.FileEntities
{
    public abstract class FileAtributes
    {
        private StreamReader _fileNames = new StreamReader(@"Caminho da pasta a ler o arquivo");

        private List<string> _names = new List<string>();

        public StreamReader ReadFile { get { return _fileNames; } }

        public List<string> NamesList { get { return _names; } }
    }
}
