using ChoETL;
using System.Collections.Generic;
using System.Linq;
using static TemperatureModels.ClientExport;
using static TemperatureModels.ClientList;

namespace TemperatureManagement.Utilities
{
    public class ExportUtils
    {
        public static void ToCSV(ClientExportResponse clientExport, IList<string> headerList, string filePath)
        {
            if (clientExport == null) return;

            using (var w = new ChoCSVWriter<Client>(filePath).WithFirstLineHeader())
            {
                w.WriteHeader(headerList.ToArray());
                w.Write(clientExport.Clients);
            }
        }
    }
}
