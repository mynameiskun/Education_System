function fileChange(base) {
    $("#fileTypeError").html('');
    var fileName = $('#file_upload').val();　　　　　　　　　　　　　　　　　　//获得文件名称
    var fileType = fileName.substr(fileName.length - 4, fileName.length);　　//截取文件类型,如(.xls)
    if (fileType == '.xls' || fileType == '.doc' || fileType == '.pdf') {　　　　　//验证文件类型,此处验证也可使用正则
        $.ajax({
            url: base + '/actionsupport/upload/uploadFile',　　　　　　　　　　//上传地址
            type: 'POST',
            cache: false,
            data: new FormData($('#uploadForm')[0]),　　　　　　　　　　　　　//表单数据
            processData: false,
            contentType: false,
            success: function (data) {
                if (data == 'fileTypeError') {
                    $("#fileTypeError").html('*上传文件类型错误,支持类型: .xsl .doc .pdf');　　//根据后端返回值,回显错误信息
                }
                $("input[name='enclosureCode']").attr('value', data);
            }
        });
    } else {
        $("#fileTypeError").html('*上传文件类型错误,支持类型: .xls .doc .pdf');
    }
}