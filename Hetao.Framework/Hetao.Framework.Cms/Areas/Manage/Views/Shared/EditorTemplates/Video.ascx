<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<object>" %>

<input id="<%:Html.ViewData.ModelMetadata.PropertyName %>" type="text" name="<%:Html.ViewData.ModelMetadata.PropertyName %>" value="<%:Model %>" >

<input type="button" id="<%:Html.ViewData.ModelMetadata.PropertyName %>_upload" />
<script type="text/javascript">
    $(function () {
        $("#<%:Html.ViewData.ModelMetadata.PropertyName %>_upload").uploadify({
            multi: false,
            buttonText:"选择视频",
            fileTypeDesc: '视频文件',
            fileTypeExts: '*.mp4;*.wmv; *.rmvb; *.avi',
            swf: '/Plus/uploadify/uploadify.swf',
            uploader: '/Plus/uploadify/ashx/upload_json.ashx?dir=video',
            onUploadSuccess: function (file, data, response) {
                console.log(file);
                console.log(data);
                console.log(response);
                data = JSON.parse(data);
                $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val(data.url);
               
            }
        });
    });

</script>
