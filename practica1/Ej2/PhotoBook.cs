namespace practica1.Ej2;

public class PhotoBook
{
    public int Id { get; set; }
    protected int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int pages)
    {
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}