using dsd601Images2020.Model;

namespace dsd601Images2020.Operations
{
    public static class StaticPersonDetails
    {
        public static List<PersonDetails> StaticAllStaff = new List<PersonDetails>
                        {
           new PersonDetails {Id=1, Name ="John Window", Age= 28, Occupation="Builder", ImagePath = "photo1.jpg" },
           new PersonDetails {Id=2, Name = "Kelvin Wallbanger", Age = 32,  Occupation="Baker",ImagePath = "photo2.jpg" },
           new PersonDetails {Id=3, Name = "Jessie Fenster", Age = 12,  Occupation="Student",ImagePath = "photo3.jpg" },
           new PersonDetails {Id=4, Name = "Nancy Chao", Age = 11,  Occupation="Student",ImagePath = "photo4.jpg" },
           new PersonDetails {Id=5, Name = "Michael Kartoffel", Age = 52, Occupation="Stuntman", ImagePath = "photo5.jpg" },
           new PersonDetails {Id=6, Name = "David Spiegel", Age = 61, Occupation="Accountant", ImagePath = "photo6.jpg" }
                              };
    }
}
