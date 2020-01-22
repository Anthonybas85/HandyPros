using Rotativa.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using DataModel.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using iTextSharp.tool.xml;

namespace HandyProsServiceReports.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult HandyProsIndex()
        {
            return View();
        }

    
        public ActionResult DownloadPDF()
        {
            try
            {
                //get the information to display in pdf from database
                //for the time
                //Hard coding values are here, these are the content to display in pdf 
                //Use ViewAsPdf Class to generate pdf using GeneratePDF.cshtml view

                //string html = RenderViewToString(ControllerContext, "~/Views/Home/HandyProsIndex.cshtml", null, false);
                ////will take ActionMethod and generate the pdf
                //var model = new GeneratePDFModel();
                //model.PDFContent = html;
                //// var fileName = "pdfGenerated" + DateTime.Now.ToLongTimeString() + ".pdf";
                  Session["fileName"] = "pdfGenerated" + Guid.NewGuid() + ".pdf";

                //return new Rotativa.ViewAsPdf("GeneratePDF", model)
                //{
                //    FileName = Session["fileName"].ToString(),
                //    PageSize = Size.A4,
                //    PageMargins = new Margins(30, 15, 20, 15)
                //};

                return new Rotativa.PartialViewAsPdf("_HandyProsPartial")
                {
                    FileName = Session["fileName"].ToString()
                };

                //using (MemoryStream stream = new System.IO.MemoryStream())
                //{
                //    StringReader sr = new StringReader(GridHtml);
                //    Document pdfDoc = new Document(PageSize.A4, 10f, 10f, 100f, 0f);
                //    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, stream);
                //    pdfDoc.Open();
                //    XMLWorkerHelper.GetInstance().ParseXHtml(writer, pdfDoc, sr);
                //    pdfDoc.Close();
                //    return File(stream.ToArray(), "application/pdf", Session["fileName"].ToString()+".pdf");
                //}
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public ActionResult SendEmail()
        {
            var fileName = Session["fileName"].ToString();
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("agbouabsy@gmail.com");
            mail.To.Add("agbouabsy@gmail.com");
            mail.Subject = "Test";
            mail.Attachments.Add(new Attachment("C:\\Users\\TOSHIBA\\Downloads\\" + fileName));
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("agbouabsy@gmail.com", "tdgu azzt msev aaul");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

            return RedirectToAction("HandyProsIndex", "Home");
        }

        static string RenderViewToString(ControllerContext context,
                                    string viewPath,
                                    object model = null,
                                    bool partial = false)
        {
            // first find the ViewEngine for this view
            ViewEngineResult viewEngineResult = null;
            if (partial)
                viewEngineResult = ViewEngines.Engines.FindPartialView(context, viewPath);
            else
                viewEngineResult = ViewEngines.Engines.FindView(context, viewPath, null);

            if (viewEngineResult == null)
                throw new FileNotFoundException("View cannot be found.");

            // get the view and attach the model to view data
            var view = viewEngineResult.View;
            context.Controller.ViewData.Model = model;

            string result = null;

            using (var sw = new StringWriter())
            {
                var ctx = new ViewContext(context, view,
                                            context.Controller.ViewData,
                                            context.Controller.TempData,
                                            sw);
                view.Render(ctx, sw);
                result = sw.ToString();
            }

            return result;
        }

        public static T CreateController<T>(RouteData routeData = null)
    where T : Controller, new()
        {
            // create a disconnected controller instance
            T controller = new T();

            // get context wrapper from HttpContext if available
            HttpContextBase wrapper;
            if (System.Web.HttpContext.Current != null)
                wrapper = new HttpContextWrapper(System.Web.HttpContext.Current);
            else
                throw new InvalidOperationException(
                    "Can't create Controller Context if no " +
                    "active HttpContext instance is available.");

            if (routeData == null)
                routeData = new RouteData();

            // add the controller routing if not existing
            if (!routeData.Values.ContainsKey("controller") &&
                !routeData.Values.ContainsKey("Controller"))
                routeData.Values.Add("controller",
                                     controller.GetType()
                                               .Name.ToLower().Replace("controller", ""));

            controller.ControllerContext = new ControllerContext(wrapper, routeData, controller);
            return controller;
        }
    }
}