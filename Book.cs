namespace mis221_rakern_composition_lab
{
    public class Book
    {
        private string isbn;
        private string title;
        private Author author;


        public Book(string tempIsbn, string tempTitle, Author tempAuthor) {
            isbn = tempIsbn;
            title = tempTitle;
            author = tempAuthor;
        }

        public string GetIsbn() {
            return isbn;
        }

        public string GetTitle() {
            return title;
        }

        public Author GetAuthor() {
            return author;
        }

        public void SetIsbn(string tempIsbn) {
            isbn = tempIsbn;
        }

        public void SetTitle(string tempTitle) {
            title = tempTitle;
        }

        public void SetAuthor(Author tempAuthor) {
            author = tempAuthor;
        }

        public override string ToString() {
            return "isbn = " + isbn + ", title = " + title + ", author: " + author.ToString();
        }
    }
}