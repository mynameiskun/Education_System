<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <script src="uploader/zui.uploader.min.js"></script>
    <link href="uploader/zui.uploader.min.css" rel="stylesheet" />
   
    <script src="Jquery/jquery-3.3.1.min.js"></script>
    <title></title>
    <script type="text/javascript">
    var formData = new FormData(this);
    var file = $(that)[0].files[0];
    formData.append("file",file); //传给后台的file的key值是可以自己定义的
    formData.append("params",JSON.stringify(typeData))
    $.ajax({
        url: baseUrl + 'Myapp', 
        type:'POST',
        cache: false, 
        processData: false,
        contentType: false,
        data: formData,
        success: function(data){
 
        },
        error: function(err) {
 
        }
    })

    </script>
</head>
<body>
   <%-- 
   <form id="form1" name="form1">
	<input type="file" id="file" name="fileupload" class="inputfile poa" accept="application/vnd.openxmlformats-officedocument.spreadsheetml.sheet, application/vnd.ms-excel" onchange="upload(this)"></input>	<Button class="btn btn-primary mr10 btn-sm pointer" onclick="uploadSure()">上传</Button>
</form>--%>
   
    <form action="UploadFile.ashx" method="post" enctype="multipart/form-data">
    <input type="file" name="fileUpload" />
    <input type="submit" value="上传文件" />
    </form>
</body>

</html>
