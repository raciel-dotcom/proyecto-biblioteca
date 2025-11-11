namespace proyecto_biblioteca.DataBase.Modelos
{
    public class Book
    {
        public string Title { get; set; }
        public string Gender { get; set; }
        public string Author { get; set; }
        public string Editorial { get; set; }
        public DateTime PublicationDate { get; set; }
        public DateTime CreationDate { get; set; }
        public int Quantity  { get; set; }
        public int Id { get; set; }
    }
}
