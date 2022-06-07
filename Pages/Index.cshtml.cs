using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601Images2020.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {

        public string? Imagepath { get; set; }
        public List<string>? ImagepathList;



        public IndexModel()
        {
            ImagepathList = new List<string>();

            ImagepathList.Add("photo1.jpg");
            ImagepathList.Add("photo2.jpg");
            ImagepathList.Add("photo3.jpg");
            ImagepathList.Add("photo4.jpg");
            ImagepathList.Add("photo5.jpg");
            ImagepathList.Add("photo6.jpg");
        }

        public void OnGet()
        {
        }


        public void OnPost()
        {
        }
    }
}