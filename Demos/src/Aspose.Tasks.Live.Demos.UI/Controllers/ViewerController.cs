using Aspose.Tasks.Live.Demos.UI.Models.Common;
using Aspose.Tasks.Live.Demos.UI.Models;
using Aspose.Tasks.Live.Demos.UI.Services;
using System;
using System.Collections;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;

namespace Aspose.Tasks.Live.Demos.UI.Controllers
{
	public class ViewerController : BaseController
	{
		public override string Product => (string)RouteData.Values["product"];


		
		


			public ActionResult Viewer()
		{
			var model = new ViewModel(this, "Viewer")
			{				
				MaximumUploadFiles = 1,
				DropOrUploadFileLabel = Resources["DropOrUploadFile"],
				UploadAndRedirect = true
			};
			if (model.RedirectToMainApp)
				return Redirect("/tasks/" + model.AppName.ToLower());
			return View(model);		
			
		}	

	}
}
