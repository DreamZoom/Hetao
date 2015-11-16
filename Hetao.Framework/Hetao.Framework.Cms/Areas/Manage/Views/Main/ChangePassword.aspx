<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>
<!--[if IE 8]> <html lang="en" class="ie8"> <![endif]-->
<!--[if IE 9]> <html lang="en" class="ie9"> <![endif]-->
<!--[if !IE]><!-->
<html lang="en">
<!--<![endif]-->
<!-- BEGIN HEAD -->
<head>
    <meta charset="utf-8" />
    <title>修改密码</title>
    <meta content="width=device-width, initial-scale=1.0" name="viewport" />
    <meta content="" name="description" />
    <meta content="" name="author" />
    <%: Styles.Render("~/theme/metronic") %>
    <%: Scripts.Render("~/bundles/modernizr") %>
    <link rel="shortcut icon" href="favicon.ico" />
</head>
<!-- END HEAD -->
<!-- BEGIN BODY -->
<body class="login">
    <!-- BEGIN LOGO -->
    <div class="logo">
        <img src="/assets/img/logo-big.png" alt="" />
    </div>
    <!-- END LOGO -->
    <!-- BEGIN LOGIN -->
    <div class="content">
        <!-- BEGIN LOGIN FORM -->

        <%using (Html.BeginForm(null, null, FormMethod.Post, new { @class = "form-vertical login-form" }))
          { %>
        <h3 class="form-title">修改密码</h3>
        <%if (!Html.ViewData.ModelState.IsValid)
          {%>
        <div class="alert alert-error">
            <button class="close" data-dismiss="alert"></button>
            <span><%:Html.ValidationSummary()%></span>
        </div>
        <%} %>
        
        
        <div class="control-group">
            <label class="control-label visible-ie8 visible-ie9">原密码</label>
            <div class="controls">
                <div class="input-icon left">
                    <i class="icon-lock"></i>
                    <input class="m-wrap placeholder-no-fix" type="password" placeholder="原密码" name="password" />
                </div>
            </div>
        </div>

        <div class="control-group">
            <label class="control-label visible-ie8 visible-ie9">新密码</label>
            <div class="controls">
                <div class="input-icon left">
                    <i class="icon-lock"></i>
                    <input class="m-wrap placeholder-no-fix" type="password" placeholder="新密码" name="newpassword" />
                </div>
            </div>
        </div>
        <div class="form-actions">
           
            <button type="submit" class="btn green ">
                应用修改 <i class="m-icon-swapright m-icon-white"></i>
            </button>
        </div>
       
        <%} %>


       
       
    </div>
    <!-- END LOGIN -->
    <!-- BEGIN COPYRIGHT -->
    <div class="copyright">
        2015 &copy; wxllzf
    </div>
    <!-- END COPYRIGHT -->
    <!-- BEGIN JAVASCRIPTS -->
    <%: Scripts.Render("~/js/metronic") %>
    <script>
        jQuery(document).ready(function () {
            App.initLogin();
        });
    </script>
    <!-- END JAVASCRIPTS -->
</body>
<!-- END BODY -->
</html>
