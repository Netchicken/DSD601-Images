﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dsd601Images2020.Pages
{
    [BindProperties]
    public class IndexModel : PageModel
    {
        //the selected image
        public string? Imagepath { get; set; }
        //a list of images
        public List<string>? ImagepathList = new List<string>();


        public void OnGet()
        {
            ImagepathList = LoadImagePure();
        }


        public void OnPost()
        {
            ImagepathList = LoadImagePure();
        }

        private void LoadImage()
        {
            //manually add files to the list
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



            // Get the path to the wwwroot folder
            string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");

            // Get all files in the wwwroot folder
            string[] allFiles = Directory.GetFiles(wwwrootPath, "*.*", SearchOption.AllDirectories);

            // Print the names of the files
            foreach (string file in allFiles)
            {
                //remove the path to the image leaving only the name
                // string fileName = Path.GetFileName(file); //get the file name only

                //get the relative path to the image
                string fileName = Path.GetRelativePath("wwwroot\\images", file); //this works as well.
                ImagepathList.Add(fileName);
            }


        }



        private List<string> LoadImagePure()
        {
            //manually add files to the list
            List<string>? imagepathList = new List<string>();


            // Get the path to the wwwroot folder
            string wwwrootPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images");

            // Get all files in the wwwroot folder
            string[] allFiles = Directory.GetFiles(wwwrootPath, "*.*", SearchOption.AllDirectories);

            // Print the names of the files
            foreach (string file in allFiles)
            {
                //remove the path to the image leaving only the name
                // string fileName = Path.GetFileName(file); //get the file name only

                //get the relative path to the image
                string fileName = Path.GetRelativePath("wwwroot\\images", file); //this works as well.
                imagepathList.Add(fileName);
            }

            return imagepathList;
        }


    }
}