<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<object>" %>

<input id="<%:Html.ViewData.ModelMetadata.PropertyName %>" name="<%:Html.ViewData.ModelMetadata.PropertyName %>" value="<%:Model %>" >

<script type="text/javascript">
    $(function () {
        $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").uploadify({
            multi: false,
            buttonText:"选择视频",
            fileTypeDesc: '视频文件',
            fileTypeExts: '*.mp4; *.rmvb; *.avi',
            swf: '/Plus/uploadify/uploadify.swf',
            uploader: '/Plus/uploadify/ashx/upload_json.ashx?dir=video'
        });
    });

</script>
