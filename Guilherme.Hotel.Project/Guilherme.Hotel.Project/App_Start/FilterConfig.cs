using System.Web;
using System.Web.Mvc;

namespace Guilherme.Hotel.Project {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
