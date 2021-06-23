using Project.BoloSemanal.Core.Ordenation;
using Project.BoloSemanal.Core.Processors.FileRead;
using Project.BoloSemanal.Core.Processors.FileWrite;

namespace Project.BoloSemanal.Initializer
{
    public class ExecuteApplication
    {
        private readonly ExtractFileContent _extractFileContent;
        private readonly ExcelFileProcessor _excelFileProcessor;

        public ExecuteApplication()
        {
            _extractFileContent = new ExtractFileContent();
            _excelFileProcessor = new ExcelFileProcessor();
        }


        public void Start()
        {
            var fileContent = _extractFileContent.ReadFileContent();

            BubbleOrder.BubbleSort(fileContent);

            _excelFileProcessor.GenerateLocalXlsxFile(fileContent);
        }
    }
}
