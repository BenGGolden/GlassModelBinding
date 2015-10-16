using System.Web.Mvc;
using GlassModelBinding.Models;

namespace GlassModelBinding.Controllers
{
    public class ContentController : Controller
    {
        public ActionResult Content(SampleItem dataSourceModel, SampleRenderingParameters parametersModel)
        {
            var viewModel = new ContentViewModel
            {
                DataSource = dataSourceModel,
                Parameters = parametersModel
            };

            // Do more work

            return View(viewModel);
        }
    }
}