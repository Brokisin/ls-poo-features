using ls_poo_features.Entity;

namespace ls_poo_features.DBContext.Commands.Abstraction
{
    public partial interface ISQLCommands
    {
        public string InsertBook(Book book);
        public string UpdateBook(Book book);
        public string DeleteBook(Book book);
    }
}
