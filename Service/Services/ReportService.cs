using Reports;
using Stimulsoft.Report;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Service
{
   public class ReportService : IReportService
    {
        private string ConnectionString;
        public ReportService()
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["DBEntities"].ConnectionString;
        }
        public byte[] DownloadAccountProfile(int AccountId)
        {
            AccountProfileReport Report = new AccountProfileReport();
            Report.AccountProfile.Parameters["@AccountId"].ParameterValue = AccountId;
            //<!-- URL -->< add key = "WebURL" value = "http://localhost/Arab_Monteral/" />
          //  var url = HttpContent.Current.Request.Url.Authority;

            Report.Dictionary.Databases.Clear();
            Report.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", "Connection", ConnectionString, false));
            Report.Render(false);

            System.IO.MemoryStream memoryStream = new System.IO.MemoryStream();

            Report.ExportDocument(Stimulsoft.Report.StiExportFormat.Pdf, memoryStream);

            byte[] fileBytes = memoryStream.ToArray();
            memoryStream.Flush();
            memoryStream.Close();
            return fileBytes;

        }
    }
}
