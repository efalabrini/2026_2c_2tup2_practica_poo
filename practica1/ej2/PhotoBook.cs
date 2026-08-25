namespace practica1.Controllers.Ej2
{
    public class PhotoBook
    {
        public int Id { get; set; }

        protected int numPages;

        public PhotoBook()
        {
            numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
}