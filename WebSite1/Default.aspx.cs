﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    public void ProcessRequest(HttpContext context)
    {
        context.Response.ContentType = "text/html";
        HttpServerUtility server = context.Server;
        HttpRequest request = context.Request;
        HttpResponse response = context.Response;

        HttpPostedFile file = context.Request.Files[0];
        if (file.ContentLength > 0)
        {
            string extName = Path.GetExtension(file.FileName);
            string fileName = Guid.NewGuid().ToString();
            string fullName = fileName + extName;

            string imageFilter = ".jpg|.png|.gif|.ico";// 随便模拟几个图片类型
            if (imageFilter.Contains(extName.ToLower()))
            {
                string phyFilePath = server.MapPath("~/Upload/Image/") + fullName;
                file.SaveAs(phyFilePath);
                response.Write("上传成功！文件名：" + fullName + "<br />");
                response.Write(string.Format("<img src='Upload/Image/{0}'/>", fullName));
            }
        }
    }
}