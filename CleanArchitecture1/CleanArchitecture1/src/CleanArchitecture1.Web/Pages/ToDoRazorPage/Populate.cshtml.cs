using CleanArchitecture1.Core;
using CleanArchitecture1.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CleanArchitecture1.Web.Pages.ToDoRazorPage
{
    public class PopulateModel : PageModel
    {
        private readonly IRepository _repository;

        public PopulateModel(IRepository repository)
        {
            _repository = repository;
        }

        public int RecordsAdded { get; set; }

        public void OnGet()
        {
            RecordsAdded = DatabasePopulator.PopulateDatabase(_repository);
        }
    }
}
