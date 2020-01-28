using System;
using ExpertPdf.HtmlToPdf;
using System.IO;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;

namespace HandyProsServiceReports.Helpers
{
    public class PDFActionResult : ViewResult
    {
        private object model_ = null;

        public PDFActionResult() : base() { }
        public PDFActionResult(string view)
        {
            base.ViewName = view;
        }
        public PDFActionResult(string view, object model)
        {
            base.ViewName = view;
            model_ = model;
        }
        public override void ExecuteResult(ControllerContext context)
        {
            IView view = FindView(context).View;

            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            ViewContext vc = new ViewContext(context, view, context.Controller.ViewData, context.Controller.TempData, sw);
            IViewDataContainer vdc = new PDFViewDataContainer() { ViewData = context.Controller.ViewData };
            HtmlHelper helper = new HtmlHelper(vc, vdc);

            helper.RenderAction(base.ViewName, model_);
            string html = sb.ToString();

            PdfConverter conv = CreatePdfConverter();
            byte[] htmlBytes = conv.GetPdfBytesFromHtmlString(html);

            HttpResponseBase response = context.HttpContext.Response;
            response.Clear();
            response.AddHeader("Content-Type", "binary/octet-stream");
            response.AddHeader("Content-Disposition",
                    string.Format("attachment; filename={0}; size={1}",
                        "pdfGenerated" + Guid.NewGuid() + ".PDF", htmlBytes.Length));
            response.BinaryWrite(htmlBytes);
            response.End();
        }

        private PdfConverter CreatePdfConverter()
        {
            var converter = new PdfConverter();
            //if (!string.IsNullOrEmpty(_licenseKey))
            //    converter.LicenseKey = _licenseKey;
#warning need license key to remove watermark from generated PDF

            converter.PdfDocumentInfo.AuthorName = "Handy Pros";

            PdfDocumentOptions docOptions = converter.PdfDocumentOptions;
            docOptions.EmbedFonts = true;

            docOptions.LeftMargin = 60;
            docOptions.TopMargin = 40;
            docOptions.RightMargin = 60;
            docOptions.BottomMargin = 60;

            return converter;
        }

        private class PDFViewDataContainer : IViewDataContainer
        {
            public ViewDataDictionary ViewData { get; set; }
        }
    }
}