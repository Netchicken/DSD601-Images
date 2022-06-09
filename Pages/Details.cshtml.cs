using dsd601Images2020.Model;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace dsd601Images2020.Pages
{
    [BindProperties]
    public class DetailsModel : PageModel
    {
        public SelectList Staff { get; set; }
        //the selected image
        public PersonDetails? SelectedStaff { get; set; }
        //a list of images
        public int SelectedStaffId { get; set; }

        List<PersonDetails> AllStaff { get; set; }

        //create the constructor by typing ctor
        public DetailsModel()
        {
            SelectedStaff = new PersonDetails();

            AllStaff = new List<PersonDetails>
            {
           new PersonDetails {Id=1, Name ="John Window", Age= 28, Occupation="Builder", ImagePath = "photo1.jpg" },
           new PersonDetails {Id=2, Name = "Kelvin Wallbanger", Age = 32,  Occupation="Baker",ImagePath = "photo2.jpg" },
           new PersonDetails {Id=3, Name = "Jessie Fenster", Age = 12,  Occupation="Student",ImagePath = "photo3.jpg" },
           new PersonDetails {Id=4, Name = "Nancy Chao", Age = 11,  Occupation="Student",ImagePath = "photo4.jpg" },
           new PersonDetails {Id=5, Name = "Michael Kartoffel", Age = 52, Occupation="Stuntman", ImagePath = "photo5.jpg" },
           new PersonDetails {Id=6, Name = "David Spiegel", Age = 61, Occupation="Accountant", ImagePath = "photo6.jpg" }
};
            //Create a selectlist for the dropdown
            Staff = new SelectList(AllStaff, nameof(PersonDetails.Id), nameof(PersonDetails.Name), null);


        }
        public void OnGet()
        {

        }


        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                foreach (var item in AllStaff)
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

        }
    }
}
