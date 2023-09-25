using ls_poo_features.Entity;

namespace ls_poo_features.Repositories
{
    public class EditorRepository
    {
        Editor editor = new Editor();
        List<Editor> listaEditora = new List<Editor>();

        public void CadastrarEditora()
        {
            Console.WriteLine("\nInsira os atributos da editora: ");
            Console.WriteLine("Nome de contato: ");
            editor.ContactName = Console.ReadLine();
            Console.WriteLine("Nome social: ");
            editor.SocialName = Console.ReadLine();
            Console.WriteLine("Telefone para contato: ");
            editor.Cellphone = Console.ReadLine();
            listaEditora.Add(editor);
        }

        public void RetornaEditora(string nomeEditora)
        {
            foreach (var editor in listaEditora)
            {
                if (nomeEditora == editor.ContactName)
                {
                    Console.WriteLine("\nEditora buscada:");
                    Console.WriteLine($"{editor.SocialName}\n{editor.ContactName}\n{editor.Cellphone}\n");
                }
                else
                {
                    Console.WriteLine("\nNão foi encontrado editora com esse nome\n");
                }
            }
        }
    }
}
