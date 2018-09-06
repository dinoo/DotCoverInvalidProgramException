using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace TestLibrary
{
    public class FooRepository : IFooRepository
    {
        private IEnumerable<SelectListItem> _timeUnits;

        public FooRepository()
        {
            _timeUnits = new List<SelectListItem>
            {
                new SelectListItem { Value = "30", Text = "30 minutes" },
                new SelectListItem { Value = "60", Text = "60 minutes" }
            };
        }

        public IReadOnlyList<SelectListItem> GetTimeUnits()
        {
            return _timeUnits.ToList().AsReadOnly();
        }
    }
}
