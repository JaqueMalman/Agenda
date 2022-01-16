using System;

namespace Tarefas.Entidades
{
    public partial class Agenda
    {
        public void AdicionarTarefa(string descricao, TipoTarefa tipoTarefa)
        {
            ValidarTarefa(descricao);
            Tarefas.Add(new Tarefa(descricao, tipoTarefa));
        }

        public void FinalizarTarefa(string descricao)
        {
            var tarefa = BuscaTarefa(descricao);

            tarefa.FinalizarTarefa();
        }

        public void ReabrirTarefa(string descricao)
        {
            var tarefa = BuscaTarefa(descricao);

            tarefa.ReabrirTarefa();
        }

        private Tarefa BuscaTarefa(string descricao)
        {
            var tarefa = Tarefas.Find(t => t.Descricao == descricao);

            if (tarefa == null)
            {
                throw new Exception("Tarefa não encontrada.");
            }

            return tarefa;
        }
    }
}