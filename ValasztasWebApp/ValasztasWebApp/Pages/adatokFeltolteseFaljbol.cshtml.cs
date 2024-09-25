using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ValasztasWebApp.Models;

namespace ValasztasWebApp.Pages
{
    public class adatokFeltolteseFaljbolModel : PageModel
    {
        private readonly IWebHostEnvironment _env;
        private readonly ValasztasDbContext _context;

        public adatokFeltolteseFaljbolModel(IWebHostEnvironment env, ValasztasDbContext context)
        {
            _context = context;
            _env = env;
        }

        [BindProperty]
        public IFormFile UploadFile { get;set;}

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var UploadFilePath = Path.Combine(_env.ContentRootPath, "uploads",UploadFile.FileName);
            using (var stream = new FileStream(UploadFilePath, FileMode.Create))
            {
                await UploadFile.CopyToAsync(stream);
            }
            //töltögetés

            StreamReader sr = new StreamReader(UploadFilePath);

            sr.Close();

                return Page();
        }
    }
}
