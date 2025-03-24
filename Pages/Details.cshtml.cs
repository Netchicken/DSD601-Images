using dsd601Images2020.Model;
using dsd601Images2020.Operations;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dsd601Images2020.Pages
{
    //https://www.learnrazorpages.com/razor-pages/forms/select-lists
    public class DetailsModel : PageModel
    {
        public SelectList Staff { get; set; }
        //the selected image
        [BindProperty]
        public PersonDetails? SelectedStaff { get; set; }
        //a list of images
        [BindProperty]
        public int SelectedStaffId { get; set; }


        public void OnGet()
        {
            LoadImages();
            SelectedStaff = new PersonDetails();
        }

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                foreach (var item in StaticPersonDetails.StaticAllStaff)
                {
                    if (SelectedStaffId == item.Id)
                    {
                        SelectedStaff.Id = item.Id;
                        SelectedStaff.Name = item.Name;
                        SelectedStaff.Age = item.Age;
                        SelectedStaff.ImagePath = item.ImagePath;
                        SelectedStaff.Occupation = item.Occupation;
                    }
                }
            }
            LoadImages();
        }
        private void LoadImages()
        {
            Staff = new SelectList(StaticPersonDetails.StaticAllStaff, nameof(PersonDetails.Id), nameof(PersonDetails.Name), null);
        }
    }
}
