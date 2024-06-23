namespace PruebaBackend_GrupoMock_Gustavo_Romero.Models
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Author { get; set; }
        public required string Genre { get; set; }

        public DateTime PublishDate { get; set; }

    }
}
