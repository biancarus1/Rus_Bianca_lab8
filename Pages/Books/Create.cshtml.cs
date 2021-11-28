using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Rus_Bianca_lab.Data;
using Rus_Bianca_lab.Models;

namespace Rus_Bianca_lab.Pages.Books
{
    public class CreateModel : PageModel
    {
        private readonly Rus_Bianca_lab.Data.Rus_Bianca_labContext _context;

        public CreateModel(Rus_Bianca_lab.Data.Rus_Bianca_labContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Book Book { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Book.Add(Book);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
