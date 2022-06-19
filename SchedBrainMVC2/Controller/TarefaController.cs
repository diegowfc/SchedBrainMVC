using SchedBrainMVC2.Data;
using SchedBrainMVC2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedBrainMVC2.Controller
{
    internal class TarefaController
    {
        protected static DataContext Context = new DataContext();

        internal static void Validacao(Tarefa tarefa)
        {
            if (tarefa.Titulo.Trim() == "") throw new Exception("Nome Vazio");
            if (tarefa.Anexos == null) throw new Exception("É necessário uma imagem!");
        }
        internal static void InsereTarefa(Tarefa tarefa)
        {
            Context.Add(tarefa);
            Context.SaveChanges();
        }

        internal static void ExcluiTarefa(string nome)
        {
            Tarefa tarefaAlvo = Context.Tarefas.FirstOrDefault(x => x.Titulo == nome)!;
            Context.Tarefas.Remove(tarefaAlvo);
            tarefaAlvo.Lembrete = false;
            Context.SaveChanges();
        }

        internal static void ConcluiTarefa(string nome)
        {
            Tarefa tarefaAlvo = Context.Tarefas.FirstOrDefault(x => x.Titulo == nome)!;
            tarefaAlvo.Situacao = "Concluído";
            Context.Update(tarefaAlvo);
            Context.SaveChanges();
        }

        internal static List<Tarefa> retornaTarefaPrioritaria()
        {
            return Context.Tarefas.Where(x => x.Prioridade == "Alta" && x.Situacao == "Pendente").ToList();
        }

        internal static List<Tarefa> ListaTarefa()
        {
            return Context.Tarefas.OrderBy(x => x.DataMaximaConclusao).ToList();
        }
    }
}
