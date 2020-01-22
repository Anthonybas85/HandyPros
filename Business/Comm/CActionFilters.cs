using System.IO;
using System.Text;
using System.Web.Mvc;

namespace Business.Comm {
  

  public class RequireSSLAttribute : RequireHttpsAttribute {
    public bool RequireSecure = true;
    public override void OnAuthorization(AuthorizationContext filterContext) {
      if (filterContext.RequestContext.HttpContext.Request.IsLocal
        || System.Configuration.ConfigurationManager.AppSettings["EnableSSL"] == "false") {
        if (filterContext.HttpContext.Request.IsSecureConnection) {
          HandleNonHttpRequest(filterContext);
        }
      }
      else {

        if (RequireSecure) {
          // default RequireHttps functionality
          base.OnAuthorization(filterContext);
        }
        else {
          // non secure requested
          if (filterContext.HttpContext.Request.IsSecureConnection) {
            HandleNonHttpRequest(filterContext);
          }
        }
      }
    }

    protected virtual void HandleNonHttpRequest(AuthorizationContext filterContext) {
        if (!string.Equals(filterContext.HttpContext.Request.HttpMethod, "GET",
            System.StringComparison.OrdinalIgnoreCase)) return;
        // redirect to HTTP version of page
      string url = "http://" + filterContext.HttpContext.Request.Url.Host + filterContext.HttpContext.Request.RawUrl;
      filterContext.Result = new RedirectResult(url);
    }
  }

  public class CleanHTML : ActionFilterAttribute {
    public CleanHTML() { }


    private Stream _originalOutputStream;

    public override void OnActionExecuting(ActionExecutingContext filterContext) {
      _originalOutputStream = filterContext.HttpContext.Response.Filter;
      //filterContext.HttpContext.Response.Flush();
      filterContext.HttpContext.Response.Filter = new CapturingResponseFilter(filterContext.HttpContext.Response.Filter);
    }

    public override void OnResultExecuted(ResultExecutedContext filterContext) {
      filterContext.HttpContext.Response.Flush();
      CapturingResponseFilter capturingResponseFilter = (CapturingResponseFilter)filterContext.HttpContext.Response.Filter;
      filterContext.HttpContext.Response.Filter = _originalOutputStream;
      string textWritten = capturingResponseFilter.GetContents(filterContext.HttpContext.Response.ContentEncoding);
      textWritten = cleanHtml(textWritten);
      filterContext.HttpContext.Response.Write(textWritten);
    }

    private string cleanHtml(string html) {
      System.Text.RegularExpressions.Regex r = new System.Text.RegularExpressions.Regex(@"\s+");
      return r.Replace(html, " ");
    }

    private class CapturingResponseFilter : Stream {
      private Stream _sink;
      private MemoryStream mem;

      public CapturingResponseFilter(Stream sink) {
        _sink = sink;
        mem = new MemoryStream();
      }

      // The following members of Stream must be overriden.
      public override bool CanRead {
        get { return true; }
      }

      public override bool CanSeek {
        get { return false; }
      }

      public override bool CanWrite {
        get { return false; }
      }

      public override long Length {
        get { return 0; }
      }

      public override long Position { get; set; }

      public override long Seek(long offset, SeekOrigin direction) {
        return 0;
      }

      public override void SetLength(long length) {
        _sink.SetLength(length);
      }

      public override void Close() {
        _sink.Close();
        mem.Close();
      }

      public override void Flush() {
        _sink.Flush();
      }

      public override int Read(byte[] buffer, int offset, int count) {
        return _sink.Read(buffer, offset, count);
      }

      // Override the Write method to filter Response to a file. 
      public override void Write(byte[] buffer, int offset, int count) {
        //Here we will not write to the sink b/c we want to capture

        //Write out the response to the file.
        mem.Write(buffer, 0, count);
      }

      public string GetContents(Encoding enc) {
        var buffer = new byte[mem.Length];
        mem.Position = 0;
        mem.Read(buffer, 0, buffer.Length);
        return enc.GetString(buffer, 0, buffer.Length);
      }
    }
  }
}