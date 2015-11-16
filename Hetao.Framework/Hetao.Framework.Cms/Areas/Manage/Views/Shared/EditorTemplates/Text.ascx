<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<object>" %>


<textarea id="<%:Html.ViewData.ModelMetadata.PropertyName %>" name="<%:Html.ViewData.ModelMetadata.PropertyName %>" ><%:Model %></textarea>

<script type="text/javascript">

    var editor;
    KindEditor.ready(function (K) {
        editor = K.create('textarea[name="<%:Html.ViewData.ModelMetadata.PropertyName %>"]', {
            allowFileManager: false,
            width: "80%",
            minHeight:200,
            resizeType:1
        });
       
    });
</script>
