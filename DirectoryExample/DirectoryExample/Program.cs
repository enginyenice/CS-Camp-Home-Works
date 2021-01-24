//Engin Yenice
namespace DirectoryExample
{
    class Program
    {
        static void Main(string[] args)
        {
            BookDirectory<int, string> bookDirectory = new DirectoryExample.BookDirectory<int, string>();
            bookDirectory.Add(765, "War and Peace");
            bookDirectory.Add(665, "Song of Solomon");
            bookDirectory.Add(565, "Ulysses");
            bookDirectory.Add(465, "The Shadow of the Wind");
            bookDirectory.Add(365, "Outbreak! Plagues That Changed History");
            bookDirectory.Add(265, "Lee Miller");
            bookDirectory.Add(165, "Merci Suárez Changes Gears");
            bookDirectory.Add(165, "Merci Suárez Changes Gears (Copy)");
            bookDirectory.Add(0, "");

            bookDirectory.GetAll();
        }
    }
}
