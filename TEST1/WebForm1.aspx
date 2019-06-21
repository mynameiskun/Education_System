<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="TEST1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="lib/uploader/zui.uploader.min.css" rel="stylesheet" />
    <script src="lib/uploader/zui.uploader.min.js"></script>
    <title></title>
    <script type="text/javascript">
       $('#uploaderExample').uploader({
    autoUpload: true,            // 当选择文件后立即自动进行上传操作
    url: 'your/file/upload/url'  // 文件上传提交地址
});
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div id="uploaderExample" class="uploader">
        <div class="file-list" data-drag-placeholder="请拖拽文件到此处"></div>
        <button type="button" class="btn btn-primary uploader-btn-browse"><i class="icon icon-cloud-upload"></i> 选择文件</button>
    </div>
    
    </form>
</body>
</html>
