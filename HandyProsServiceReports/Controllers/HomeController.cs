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
using HandyProsServiceReports.Helpers;
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

        [HttpPost]
        public PartialViewResult SaveForm([Microsoft.AspNetCore.Mvc.FromBody] HandyProsFormModel handyProsFormModel)
        {
            return PartialView("_HandyProsPartial", handyProsFormModel);
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
               // var model = new GeneratePDFModel();
              //  model.PDFContent = html;
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
                    FileName = Session["fileName"].ToString(),ContentDisposition = ContentDisposition.Inline
                };

                // return this.PDF("_HandyProsPartial");

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

        [ChildActionOnly]
        public ActionResult _HandyProsPartial(HandyProsFormModel handyProsFormModel)
        {
            return PartialView("_HandyProsPartial",handyProsFormModel);
        }
    }

    public static class ControllerExtension
    {
        public static PDFActionResult PDF(this Controller controller, string viewName)
        {
            return new PDFActionResult(viewName);
        }
    }
}