using System.Collections.Generic;
using System.Web.Mvc;

namespace TestLibrary
{
    public interface IFooRepository
    {
        IReadOnlyList<SelectListItem> GetTimeUnits();
    }
}