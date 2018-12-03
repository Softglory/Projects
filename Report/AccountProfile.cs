using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using Stimulsoft.Controls;
using Stimulsoft.Base.Drawing;
using Stimulsoft.Report;
using Stimulsoft.Report.Dialogs;
using Stimulsoft.Report.Components;

namespace Reports
{
    public class AccountProfileReport : Stimulsoft.Report.StiReport
    {
        public AccountProfileReport()
        {
            this.InitializeComponent();
        }

        #region StiReport Designer generated code - do not modify
        public string webURL;
        public Stimulsoft.Report.Components.StiPage Page1;
        public Stimulsoft.Report.Components.StiPanel Panel1;
        public Stimulsoft.Report.Components.StiText Text2;
        public Stimulsoft.Report.Components.StiText Text3;
        public Stimulsoft.Report.Components.StiText Text4;
        public Stimulsoft.Report.Components.StiText Text5;
        public Stimulsoft.Report.Components.StiText Text6;
        public Stimulsoft.Report.Components.StiText Text7;
        public Stimulsoft.Report.Components.StiText Text8;
        public Stimulsoft.Report.Components.StiText Text9;
        public Stimulsoft.Report.Components.StiText Text10;
        public Stimulsoft.Report.Components.StiText Text11;
        public Stimulsoft.Report.Components.StiText Text12;
        public Stimulsoft.Report.Components.StiText Text13;
        public Stimulsoft.Report.Components.StiPanel Panel2;
        public Stimulsoft.Report.Components.StiDataBand DataBand1;
        public Stimulsoft.Report.Components.StiText Text15;
        public Stimulsoft.Report.Components.StiText Text16;
        public Stimulsoft.Report.Components.StiText Text14;
        public Stimulsoft.Report.Components.StiText Text1;
        public Stimulsoft.Report.Components.StiWatermark Page1_Watermark;
        public Stimulsoft.Report.Print.StiPrinterSettings AccountProfileReport_PrinterSettings;
        public AccountProfileDataSource AccountProfile;
        
        public void Text2__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.Location, true);
        }
        
        public void Text3__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "العنوان";
        }
        
        public void Text4__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.Phone, true);
        }
        
        public void Text5__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "رقم الهاتف";
        }
        
        public void Text6__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.ProfessionTitle, true);
        }
        
        public void Text7__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "المهنه";
        }
        
        public void Text8__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.FacebookUrl, true);
        }
        
        public void Text9__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "فيس بوك";
        }
        
        public void Text10__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.TwitterUrl, true);
        }
        
        public void Text11__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "تويتر";
        }
        
        public void Text12__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.Website, true);
        }
        
        public void Text13__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "الموقع الكتروني";
        }
        
        public void Text15__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.ServiceName, true);
        }
        
        public void Text16__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, Line, true);
        }
        
        public void Text14__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = "خدمات مقدمه";
        }
        
        public void Text1__GetValue(object sender, Stimulsoft.Report.Events.StiGetValueEventArgs e)
        {
            e.Value = ToString(sender, AccountProfile.FirstName, true) + " " + ToString(sender, AccountProfile.LastName, true);
        }
        
        private void InitializeComponent()
        {
            this.AccountProfile = new AccountProfileDataSource();
            this.Dictionary.Variables.Add(new Stimulsoft.Report.Dictionary.StiVariable("", "webURL", "webURL", "", typeof(string), "", false, false, false));
            this.NeedsCompiling = false;
            // Variables init
            // Variables init
            this.webURL = "";
            this.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.ReferencedAssemblies = new System.String[] {
                    "System.Dll",
                    "System.Drawing.Dll",
                    "System.Windows.Forms.Dll",
                    "System.Data.Dll",
                    "System.Xml.Dll",
                    "Stimulsoft.Controls.Dll",
                    "Stimulsoft.Base.Dll",
                    "Stimulsoft.Report.Dll"};
            this.ReportAlias = "AccountProfileReport";
            // 
            // ReportChanged
            // 
            this.ReportChanged = new DateTime(2018, 12, 3, 15, 27, 57, 194);
            // 
            // ReportCreated
            // 
            this.ReportCreated = new DateTime(2018, 12, 2, 19, 31, 53, 0);
            this.ReportFile = "F:\\githubGlory\\Report\\AccountProfile.mrt";
            this.ReportGuid = "40b9a2bc37c24d36be30789267301571";
            this.ReportName = "AccountProfileReport";
            this.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.ReportVersion = "2010.3.900";
            this.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            // 
            // Page1
            // 
            this.Page1 = new Stimulsoft.Report.Components.StiPage();
            this.Page1.Guid = "62acae31db2e40d28be63d9213604d41";
            this.Page1.Name = "Page1";
            this.Page1.PageHeight = 11;
            this.Page1.PageWidth = 8.5;
            this.Page1.PaperSize = System.Drawing.Printing.PaperKind.Letter;
            this.Page1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 2, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Page1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Panel1
            // 
            this.Panel1 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 0.9, 7.5, 2.5);
            this.Panel1.Name = "Panel1";
            this.Panel1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // Text2
            // 
            this.Text2 = new Stimulsoft.Report.Components.StiText();
            this.Text2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 0, 1.9, 0.4);
            this.Text2.Guid = "404737d75ae94b2fb61e1f97c55f8180";
            this.Text2.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text2.Name = "Text2";
            this.Text2.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text2__GetValue);
            this.Text2.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text2.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text2.Font = new System.Drawing.Font("Arial", 10F);
            this.Text2.Interaction = null;
            this.Text2.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text2.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text2.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text3
            // 
            this.Text3 = new Stimulsoft.Report.Components.StiText();
            this.Text3.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 0, 1.9, 0.4);
            this.Text3.Guid = "557c4283faad4e5a9a41d3bb94fee071";
            this.Text3.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text3.Name = "Text3";
            this.Text3.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text3__GetValue);
            this.Text3.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text3.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text3.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text3.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text3.Interaction = null;
            this.Text3.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text3.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text3.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text4
            // 
            this.Text4 = new Stimulsoft.Report.Components.StiText();
            this.Text4.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 0.4, 1.9, 0.4);
            this.Text4.Guid = "70de91c3c23a4d438581f533c3dea095";
            this.Text4.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text4.Name = "Text4";
            this.Text4.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text4__GetValue);
            this.Text4.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text4.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text4.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text4.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text4.Font = new System.Drawing.Font("Arial", 10F);
            this.Text4.Interaction = null;
            this.Text4.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text4.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text4.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text5
            // 
            this.Text5 = new Stimulsoft.Report.Components.StiText();
            this.Text5.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 0.4, 1.9, 0.4);
            this.Text5.Guid = "38e864990d134aaa88fcf7c05f67e14b";
            this.Text5.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text5.Name = "Text5";
            this.Text5.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text5__GetValue);
            this.Text5.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text5.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text5.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text5.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text5.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text5.Interaction = null;
            this.Text5.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text5.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text5.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text6
            // 
            this.Text6 = new Stimulsoft.Report.Components.StiText();
            this.Text6.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 0.8, 1.9, 0.4);
            this.Text6.Guid = "b249490ed1534f2e8f29616714ea119a";
            this.Text6.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text6.Name = "Text6";
            this.Text6.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text6__GetValue);
            this.Text6.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text6.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text6.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text6.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text6.Font = new System.Drawing.Font("Arial", 10F);
            this.Text6.Interaction = null;
            this.Text6.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text6.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text6.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text7
            // 
            this.Text7 = new Stimulsoft.Report.Components.StiText();
            this.Text7.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 0.8, 1.9, 0.4);
            this.Text7.Guid = "bf354256fdee461a8c3f843be14e7525";
            this.Text7.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text7.Name = "Text7";
            this.Text7.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text7__GetValue);
            this.Text7.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text7.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text7.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text7.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text7.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text7.Interaction = null;
            this.Text7.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text7.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text7.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text8
            // 
            this.Text8 = new Stimulsoft.Report.Components.StiText();
            this.Text8.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 1.2, 1.9, 0.4);
            this.Text8.Guid = "1400d2c4427143f2ac6011da9d6773e5";
            this.Text8.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text8.Name = "Text8";
            this.Text8.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text8__GetValue);
            this.Text8.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text8.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text8.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text8.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text8.Font = new System.Drawing.Font("Arial", 10F);
            this.Text8.Interaction = null;
            this.Text8.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text8.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text8.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text9
            // 
            this.Text9 = new Stimulsoft.Report.Components.StiText();
            this.Text9.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 1.2, 1.9, 0.4);
            this.Text9.Guid = "2ecfc4c3a46c4e5f9ad69fbdd896dbc2";
            this.Text9.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text9.Name = "Text9";
            this.Text9.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text9__GetValue);
            this.Text9.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text9.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text9.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text9.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text9.Interaction = null;
            this.Text9.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text9.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text9.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text10
            // 
            this.Text10 = new Stimulsoft.Report.Components.StiText();
            this.Text10.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 1.6, 1.9, 0.4);
            this.Text10.Guid = "1de3e2b50e3347e0b5defc84857162b1";
            this.Text10.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text10.Name = "Text10";
            this.Text10.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text10__GetValue);
            this.Text10.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text10.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text10.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text10.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text10.Font = new System.Drawing.Font("Arial", 10F);
            this.Text10.Interaction = null;
            this.Text10.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text10.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text10.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text11
            // 
            this.Text11 = new Stimulsoft.Report.Components.StiText();
            this.Text11.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 1.6, 1.9, 0.4);
            this.Text11.Guid = "0047da83929b4247985db1d380066fce";
            this.Text11.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text11.Name = "Text11";
            this.Text11.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text11__GetValue);
            this.Text11.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text11.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text11.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text11.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text11.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text11.Interaction = null;
            this.Text11.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text11.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text11.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text12
            // 
            this.Text12 = new Stimulsoft.Report.Components.StiText();
            this.Text12.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(3.7, 2, 1.9, 0.4);
            this.Text12.Guid = "ebd439a615fe4215b9d2b5bb80b7ba96";
            this.Text12.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text12.Name = "Text12";
            this.Text12.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text12__GetValue);
            this.Text12.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text12.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text12.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text12.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text12.Font = new System.Drawing.Font("Arial", 10F);
            this.Text12.Interaction = null;
            this.Text12.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text12.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text12.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text13
            // 
            this.Text13 = new Stimulsoft.Report.Components.StiText();
            this.Text13.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.6, 2, 1.9, 0.4);
            this.Text13.Guid = "62b9fbb8c4514b2188bce23eff83e249";
            this.Text13.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text13.Name = "Text13";
            this.Text13.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text13__GetValue);
            this.Text13.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text13.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text13.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text13.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text13.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.Text13.Interaction = null;
            this.Text13.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text13.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text13.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Panel1.Guid = null;
            this.Panel1.Interaction = null;
            // 
            // Panel2
            // 
            this.Panel2 = new Stimulsoft.Report.Components.StiPanel();
            this.Panel2.CanGrow = true;
            this.Panel2.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0.2, 4, 7.5, 6.1);
            this.Panel2.Name = "Panel2";
            this.Panel2.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Panel2.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            // 
            // DataBand1
            // 
            this.DataBand1 = new Stimulsoft.Report.Components.StiDataBand();
            this.DataBand1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0.2, 7.5, 0.4);
            this.DataBand1.DataSourceName = "AccountProfile";
            this.DataBand1.Name = "DataBand1";
            this.DataBand1.Sort = new System.String[0];
            this.DataBand1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.DataBand1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.DataBand1.BusinessObjectGuid = null;
            // 
            // Text15
            // 
            this.Text15 = new Stimulsoft.Report.Components.StiText();
            this.Text15.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(5.1, 0, 1.9, 0.4);
            this.Text15.Guid = "33479fe6af024b569a56e72c08ff3f89";
            this.Text15.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text15.Name = "Text15";
            this.Text15.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text15__GetValue);
            this.Text15.Type = Stimulsoft.Report.Components.StiSystemTextType.DataColumn;
            this.Text15.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text15.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text15.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text15.Font = new System.Drawing.Font("Arial", 10F);
            this.Text15.Interaction = null;
            this.Text15.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text15.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text15.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text16
            // 
            this.Text16 = new Stimulsoft.Report.Components.StiText();
            this.Text16.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(7, 0, 0.5, 0.4);
            this.Text16.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text16.Name = "Text16";
            this.Text16.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text16__GetValue);
            this.Text16.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text16.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text16.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.All, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text16.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text16.Font = new System.Drawing.Font("Arial", 10F);
            this.Text16.Guid = null;
            this.Text16.Interaction = null;
            this.Text16.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text16.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text16.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.DataBand1.DataRelationName = null;
            this.DataBand1.Guid = null;
            this.DataBand1.Interaction = null;
            this.DataBand1.MasterComponent = null;
            this.Panel2.Guid = null;
            this.Panel2.Interaction = null;
            // 
            // Text14
            // 
            this.Text14 = new Stimulsoft.Report.Components.StiText();
            this.Text14.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(4.9, 3.6, 2.8, 0.3);
            this.Text14.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Right;
            this.Text14.Name = "Text14";
            this.Text14.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text14__GetValue);
            this.Text14.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text14.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text14.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text14.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text14.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.Text14.Guid = null;
            this.Text14.Interaction = null;
            this.Text14.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text14.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text14.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            // 
            // Text1
            // 
            this.Text1 = new Stimulsoft.Report.Components.StiText();
            this.Text1.ClientRectangle = new Stimulsoft.Base.Drawing.RectangleD(0, 0, 7.7, 0.6);
            this.Text1.HorAlignment = Stimulsoft.Base.Drawing.StiTextHorAlignment.Center;
            this.Text1.Name = "Text1";
            this.Text1.GetValue += new Stimulsoft.Report.Events.StiGetValueEventHandler(this.Text1__GetValue);
            this.Text1.Type = Stimulsoft.Report.Components.StiSystemTextType.Expression;
            this.Text1.VertAlignment = Stimulsoft.Base.Drawing.StiVertAlignment.Center;
            this.Text1.Border = new Stimulsoft.Base.Drawing.StiBorder(Stimulsoft.Base.Drawing.StiBorderSides.None, System.Drawing.Color.Black, 1, Stimulsoft.Base.Drawing.StiPenStyle.Solid, false, 4, new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black));
            this.Text1.Brush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Transparent);
            this.Text1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.Text1.Guid = null;
            this.Text1.Interaction = null;
            this.Text1.Margins = new Stimulsoft.Report.Components.StiMargins(0, 0, 0, 0);
            this.Text1.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.Black);
            this.Text1.TextOptions = new Stimulsoft.Base.Drawing.StiTextOptions(false, false, false, 0F, System.Drawing.Text.HotkeyPrefix.None, System.Drawing.StringTrimming.None);
            this.Page1.ExcelSheetValue = null;
            this.Page1.Interaction = null;
            this.Page1.Margins = new Stimulsoft.Report.Components.StiMargins(0.39, 0.39, 0.39, 0.39);
            this.Page1_Watermark = new Stimulsoft.Report.Components.StiWatermark();
            this.Page1_Watermark.Font = new System.Drawing.Font("Arial", 100F);
            this.Page1_Watermark.Image = null;
            this.Page1_Watermark.TextBrush = new Stimulsoft.Base.Drawing.StiSolidBrush(System.Drawing.Color.FromArgb(50, 0, 0, 0));
            this.AccountProfileReport_PrinterSettings = new Stimulsoft.Report.Print.StiPrinterSettings();
            this.PrinterSettings = this.AccountProfileReport_PrinterSettings;
            this.Page1.Report = this;
            this.Page1.Watermark = this.Page1_Watermark;
            this.Panel1.Page = this.Page1;
            this.Panel1.Parent = this.Page1;
            this.Text2.Page = this.Page1;
            this.Text2.Parent = this.Panel1;
            this.Text3.Page = this.Page1;
            this.Text3.Parent = this.Panel1;
            this.Text4.Page = this.Page1;
            this.Text4.Parent = this.Panel1;
            this.Text5.Page = this.Page1;
            this.Text5.Parent = this.Panel1;
            this.Text6.Page = this.Page1;
            this.Text6.Parent = this.Panel1;
            this.Text7.Page = this.Page1;
            this.Text7.Parent = this.Panel1;
            this.Text8.Page = this.Page1;
            this.Text8.Parent = this.Panel1;
            this.Text9.Page = this.Page1;
            this.Text9.Parent = this.Panel1;
            this.Text10.Page = this.Page1;
            this.Text10.Parent = this.Panel1;
            this.Text11.Page = this.Page1;
            this.Text11.Parent = this.Panel1;
            this.Text12.Page = this.Page1;
            this.Text12.Parent = this.Panel1;
            this.Text13.Page = this.Page1;
            this.Text13.Parent = this.Panel1;
            this.Panel2.Page = this.Page1;
            this.Panel2.Parent = this.Page1;
            this.DataBand1.Page = this.Page1;
            this.DataBand1.Parent = this.Panel2;
            this.Text15.Page = this.Page1;
            this.Text15.Parent = this.DataBand1;
            this.Text16.Page = this.Page1;
            this.Text16.Parent = this.DataBand1;
            this.Text14.Page = this.Page1;
            this.Text14.Parent = this.Page1;
            this.Text1.Page = this.Page1;
            this.Text1.Parent = this.Page1;
            // 
            // Add to Panel1.Components
            // 
            this.Panel1.Components.Clear();
            this.Panel1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text2,
                        this.Text3,
                        this.Text4,
                        this.Text5,
                        this.Text6,
                        this.Text7,
                        this.Text8,
                        this.Text9,
                        this.Text10,
                        this.Text11,
                        this.Text12,
                        this.Text13});
            // 
            // Add to DataBand1.Components
            // 
            this.DataBand1.Components.Clear();
            this.DataBand1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Text15,
                        this.Text16});
            // 
            // Add to Panel2.Components
            // 
            this.Panel2.Components.Clear();
            this.Panel2.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.DataBand1});
            // 
            // Add to Page1.Components
            // 
            this.Page1.Components.Clear();
            this.Page1.Components.AddRange(new Stimulsoft.Report.Components.StiComponent[] {
                        this.Panel1,
                        this.Panel2,
                        this.Text14,
                        this.Text1});
            // 
            // Add to Pages
            // 
            this.Pages.Clear();
            this.Pages.AddRange(new Stimulsoft.Report.Components.StiPage[] {
                        this.Page1});
            this.AccountProfile.Columns.AddRange(new Stimulsoft.Report.Dictionary.StiDataColumn[] {
                        new Stimulsoft.Report.Dictionary.StiDataColumn("AccountId", "AccountId", "AccountId", typeof(int)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FirstName", "FirstName", "FirstName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("LastName", "LastName", "LastName", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("CardImage", "CardImage", "CardImage", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Location", "Location", "Location", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Phone", "Phone", "Phone", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ProfessionTitle", "ProfessionTitle", "ProfessionTitle", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("FacebookUrl", "FacebookUrl", "FacebookUrl", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("TwitterUrl", "TwitterUrl", "TwitterUrl", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("Website", "Website", "Website", typeof(string)),
                        new Stimulsoft.Report.Dictionary.StiDataColumn("ServiceName", "ServiceName", "ServiceName", typeof(string))});
            this.AccountProfile.Parameters.AddRange(new Stimulsoft.Report.Dictionary.StiDataParameter[] {
                        new Stimulsoft.Report.Dictionary.StiDataParameter("@AccountId", 8, 0)});
            this.DataSources.Add(this.AccountProfile);
            this.Dictionary.Databases.Add(new Stimulsoft.Report.Dictionary.StiSqlDatabase("Connection", "Connection", "User ID=.;Initial Catalog=arabMontrealDb;Password=;Integrated Security=True;Data " +
"Source=.", false));
            this.AccountProfile.Connecting += new System.EventHandler(this.GetAccountProfile_SqlCommand);
        }
        
        public void GetAccountProfile_SqlCommand(object sender, System.EventArgs e)
        {
            this.AccountProfile.SqlCommand = "execute AccountProfile @AccountId";
        }
        
        #region DataSource AccountProfile
        public class AccountProfileDataSource : Stimulsoft.Report.Dictionary.StiSqlSource
        {
            
            public AccountProfileDataSource() : 
                    base("Connection", "AccountProfile", "AccountProfile", "", true, false, 30)
            {
            }
            
            public virtual int AccountId
            {
                get
                {
                    return ((int)(StiReport.ChangeType(this["AccountId"], typeof(int), true)));
                }
            }
            
            public virtual string FirstName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FirstName"], typeof(string), true)));
                }
            }
            
            public virtual string LastName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["LastName"], typeof(string), true)));
                }
            }
            
            public virtual string CardImage
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["CardImage"], typeof(string), true)));
                }
            }
            
            public virtual string Location
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Location"], typeof(string), true)));
                }
            }
            
            public virtual string Phone
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Phone"], typeof(string), true)));
                }
            }
            
            public virtual string ProfessionTitle
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ProfessionTitle"], typeof(string), true)));
                }
            }
            
            public virtual string FacebookUrl
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["FacebookUrl"], typeof(string), true)));
                }
            }
            
            public virtual string TwitterUrl
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["TwitterUrl"], typeof(string), true)));
                }
            }
            
            public virtual string Website
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["Website"], typeof(string), true)));
                }
            }
            
            public virtual string ServiceName
            {
                get
                {
                    return ((string)(StiReport.ChangeType(this["ServiceName"], typeof(string), true)));
                }
            }
        }
        #endregion DataSource AccountProfile
        #endregion StiReport Designer generated code - do not modify
    }
}
