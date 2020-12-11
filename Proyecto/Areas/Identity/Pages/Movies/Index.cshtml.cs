using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proyecto.Data;
using Proyecto.Models;

namespace Proyecto.Areas.Identity.Pages.Movies
{
    [Authorize] //It is added so that no redirections are made without the user being logged in.
    public class IndexModel : PageModel
    {
        private readonly Proyecto.Data.ProyectCrudContext _context;

        public IndexModel(Proyecto.Data.ProyectCrudContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();

        }
    }
}
