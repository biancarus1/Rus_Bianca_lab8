using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Rus_Bianca_lab.Data;
using Rus_Bianca_lab.Models;

namespace Rus_Bianca_lab.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Rus_Bianca_lab.Data.Rus_Bianca_labContext _context;

        public IndexModel(Rus_Bianca_lab.Data.Rus_Bianca_labContext context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
