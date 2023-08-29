using ls_poo_features.DBContext.Commands.Abstraction;
using ls_poo_features.Entity;

namespace ls_poo_features.DBContext.Commands.Implementation
{
    public partial class MySQLCommands : ISQLCommands
    {
        public string InsertBook(Book book)
        {
            return $@"INSERT INTO central_db.books
                    (
                        title,
                        isbn_code,
                        editor_name
                    ) 
                    VALUES
                    (
                        {book.Title},
                        {book.ISBNCode},
                        {book.Editor?.SocialName}
                    )
            ";
        }

        public string UpdateBook(Book book)
        {
            return $@"UPDATE central_db.books 
                    SET title = {book.Title},
                    isbn_code = {book.ISBNCode},
                    editor_name = {book.Editor?.SocialName}
                    WHERE id = {book.Id}
            ";
        }

        public string DeleteBook(Book book)
        {
            return $@"DELETE FROM central_db.books WHERE id = {book.Id}";
        }
    }
}
