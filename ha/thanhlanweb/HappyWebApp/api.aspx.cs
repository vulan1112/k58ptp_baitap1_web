using System;
using System.Web;
using System.IO;
using MultiPurposeDLL;

public partial class api : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Nếu gọi bằng GET ?num=xxx
        if (Request.HttpMethod == "GET" && Request.QueryString["num"] != null)
        {
            int number = 0;
            int.TryParse(Request.QueryString["num"], out number);

            HappyNumberChecker checker = new HappyNumberChecker();
            checker.Number = number;
            string result = checker.Check();

            Response.ContentType = "application/json";
            Response.Write("{\"result\":\"" + result + "\"}");
            Response.End();
        }
        // Nếu gọi bằng POST (giữ nguyên cho trường hợp khác)
        else if (Request.HttpMethod == "POST")
        {
            string jsonString;
            using (StreamReader reader = new StreamReader(Request.InputStream))
            {
                jsonString = reader.ReadToEnd();
            }

            // Parse JSON thủ công vì .NET 2.0 không có Json.NET
            int number = 0;
            if (jsonString.Contains("\"num\":"))
            {
                string numStr = jsonString.Split(new string[] { "\"num\":" }, StringSplitOptions.None)[1].TrimEnd('}');
                int.TryParse(numStr, out number);
            }

            HappyNumberChecker checker = new HappyNumberChecker();
            checker.Number = number;
            string result = checker.Check();

            Response.ContentType = "application/json";
            Response.Write("{\"result\":\"" + result + "\"}");
            Response.End();
        }
        else
        {
            // Trả về mặc định nếu không có tham số
            Response.ContentType = "application/json";
            Response.Write("{\"result\":\"No number provided\"}");
            Response.End();
        }
    }
}
