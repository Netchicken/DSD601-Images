using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601Images2020.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //the selected image
        public string? Imagepath { get; set; }
        //a list of images
        public List<string>? ImagepathList;


        //create the constructor by typing ctor
        public IndexModel()
        {
            ImagepathList = new List<string>
            {
                //image names added to the list
                "photo1.jpg",
                "photo2.jpg",
                "photo3.jpg",
                "photo4.jpg",
                "photo5.jpg",
                "photo6.jpg"
            };
        }

        public void OnGet()
        {
        }


        public void OnPost()
        {
        }
    }
}