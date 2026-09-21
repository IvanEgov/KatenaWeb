using Katena.Domain;
using Katena.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Katena.Components.ResultComponents
{
	public class ResultViewComponent : ViewComponent
	{
		private readonly DataManager _dataManager;

		public ResultViewComponent(DataManager dataManager)
		{
			this._dataManager = dataManager;
		}
		public IViewComponentResult Invoke(string gender)
		{
			if(gender == "male")
			{
				return View("Male");
			}
			return View("Female");
		}
	}
}
