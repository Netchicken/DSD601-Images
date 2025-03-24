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
            ImagepathList = new List<string>();
            //{
            //    //image names added to the list
            //    "photo1.jpg",
            //    "photo2.jpg",
            //    "photo3.jpg",
            //    "photo4.jpg",
            //    "photo5.jpg",
            //    "photo6.jpg"
            //};

            LoadImage();
        }


        private void LoadImage()
        {
            // Get the path to the wwwroot folder
            string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");

            // Get all files in the wwwroot folder
            string[] allFiles = Directory.GetFiles(wwwrootPath, "*.*", SearchOption.AllDirectories);

            // Print the names of the files
            foreach (string file in allFiles)
            {
                //remove the path to the image leaving only the name
                string fileName = Path.GetFileName(file);
                ImagepathList.Add(fileName);
            }
        }



        public void OnGet()
        {
        }


        public void OnPost()
        {
        }
    }
}