using RelatoriosReport.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RelatoriosReport.Controllers
{
    public class RelatorioController : Controller
    {
        private Contexto db = new Contexto();
        // GET: Relatorio
        public ActionResult Index()
        {
            var ds = RetornaClientes();
            DataTable dt = new DataTable();
            dt.Columns.Add("Nome", typeof(string));
            dt.Columns.Add("ClienteId", typeof(string));

            foreach (var item in ds)
            {
                DataRow row = dt.NewRow();
                row["ClienteId"] = item.ClienteId;
                row["Nome"] = item.Nome;
                dt.Rows.Add(row);
            }
            var viewer = new Microsoft.Reporting.WebForms.ReportViewer();
            viewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
            viewer.LocalReport.ReportPath = Request.MapPath(Request.ApplicationPath) + @"Report/Report1.rdlc";
            viewer.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSet1", (DataTable)dt));
            viewer.SizeToReportContent = true;
            viewer.Width = System.Web.UI.WebControls.Unit.Percentage(100);
            viewer.Height = System.Web.UI.WebControls.Unit.Percentage(100);
            ViewBag.ReportViewer = viewer;

            return View();
        }

        public List<Cliente> RetornaClientes()
        {
            var ltsCliente = db.Clientes.ToList();

            return ltsCliente;
        }
    }
}