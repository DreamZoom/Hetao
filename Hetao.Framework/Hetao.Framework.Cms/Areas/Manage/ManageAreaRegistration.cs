using System.Web.Mvc;

namespace Hetao.Framework.Cms.Areas.Manage
{
    public class ManageAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Manage";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {

            Hetao.Framework.Web.Auth.AuthorProvider.Admin = new Hetao.Framework.SamplePermission.SampleAuthor();
            context.MapRoute(
                "Manage_default",
                "Manage/{controller}/{action}/{id2}",
                new { action = "Center", controller = "Main", id2 = UrlParameter.Optional },
                new string[] { "Hetao.Framework.Web.Core", 
                    "Hetao.Framework.Cms.Areas.Manage.Controllers",
                    "Hetao.Framework.CmsService.Controllters"
                }
            );

           

        
        }
    }
}
