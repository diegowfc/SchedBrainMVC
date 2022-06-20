using SchedBrainMVC2.Data;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Controller
{
    internal class ContatoController
    {
        protected static DataContext Context = new DataContext();

        private static void ValidaContato(Contato contato)
        {
            if (contato.Nome.Trim() == "") throw new Exception("Nome vazio");

            if (contato.Sobrenome.Trim() == "") throw new Exception("Sobrenome vazio");

            if (contato.Apelido.Trim() == "") throw new Exception("Apelido vazio");

            if (contato.Telefone.Trim() == "") throw new Exception("Telefone Vazio");

            if (contato.Email.Trim() == "") throw new Exception("Email vazio");

            if (contato.Tipo.Trim() == "") throw new Exception("Tipo vazio");
        }

        internal static void InsereContato(Contato contato)
        {
            ValidaContato(contato);
            Context.Add(contato);
            Context.SaveChanges();
        }

        internal static List<Contato> ListaContatos()
        {
            return Context.Contatos.OrderBy(x => x.Nome).ThenBy(x => x.Sobrenome).ToList();
        }

        internal static void ExcluiContato(string apelido)
        {
            Contato contatoAlvo = Context.Contatos.FirstOrDefault(x => x.Apelido == apelido)!;
            Context.Contatos.Remove(contatoAlvo);

            if(TarefaController.retornaRelacionamentoContato(contatoAlvo.ID).Count > 0)
            {
                foreach (Tarefa t in TarefaController.retornaRelacionamentoContato(contatoAlvo.ID))
                {
                    t.ContatoId = null;
                    TarefaController.EditaTarefa(t);
                }
            }

            Context.SaveChanges();
        }

        internal static void EditaContato(Contato contato)
        {
            ValidaContato(contato);

            Context.Contatos.Update(contato).
            Context.SaveChanges();
        }

        internal static List<Contato> retornaFavoritos()
        {
            return Context.Contatos.Where(x => x.Favorito == true).ToList();
        }

        internal static Contato retornaContato(string apelido)
        {
            return Context.Contatos.Where(x => x.Apelido == apelido).FirstOrDefault();
        }

        internal static int retornaIDContato(string nome)
        {
            return Context.Contatos.Where(x => x.Nome == nome).FirstOrDefault().ID;
        }

        internal static string retornaApelidoContato(int? contatoId)
        {
            if(contatoId != null)
                return Context.Contatos.Where(x => x.ID == contatoId).FirstOrDefault().Apelido;

            return "";
        }
    }
}
