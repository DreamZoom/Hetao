<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<object>" %>

<input id="<%:Html.ViewData.ModelMetadata.PropertyName %>" type="hidden" name="<%:Html.ViewData.ModelMetadata.PropertyName %>" value="<%:Model %>">
<input type="button" id="<%:Html.ViewData.ModelMetadata.PropertyName %>_upload" />
<style>
    #imageList img {
        width: 100%;
    }

    #imageList span3 {
        margin: 0px !important;
        padding: 4px;
    }
</style>
<div class="row" id="imageList" style="margin-left: 0px;">
</div>

<script type="text/javascript">
    $(function () {

        var images = $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val();
        var imageList = images.split(',');
        for (var i = 0; i < imageList.length; i++) {
            $("#imageList").append('<div class="span3"><img src="' + imageList[i] + '" alt="' + imageList[i] + '" /></div>');
        }


        $("#<%:Html.ViewData.ModelMetadata.PropertyName %>_upload").uploadify({
            multi: true,
            buttonText: "选择图片",
            fileTypeDesc: '图片文件',
            fileTypeExts: '*.jpg; *.png; *.bmp',
            swf: '/Plus/uploadify/uploadify.swf',
            uploader: '/Plus/uploadify/ashx/upload_json.ashx?dir=image',
            onSelect: function () {
                $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val("");
                $("#imageList div").remove();
            },
            onUploadSuccess: function (file, data, response) {
                console.log(file);
                console.log(data);
                console.log(response);
                data = JSON.parse(data);
                var imgs = $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val();
                if (imgs) {
                    $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val(imgs + "," + data.url);
                }
                else {
                    $("#<%:Html.ViewData.ModelMetadata.PropertyName %>").val(data.url);
                }
                $("#imageList").append('<div class="span3"><img src="' + data.url + '" alt="' + file.name + '" /></div>');
            }
        });
    });

</script>
