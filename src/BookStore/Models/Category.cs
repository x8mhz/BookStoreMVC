namespace BookStore.Models
{
    public class Category
    {
        public Category(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public int Id { get; private set; }
        public string Title { get; private set; }

    }
}