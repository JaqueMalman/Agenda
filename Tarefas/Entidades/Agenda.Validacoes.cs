using System;

namespace Tarefas.Entidades
{
    public partial class Agenda
    {
        private void ValidarTarefa(string descricao)
        {
            if (Tarefas.Exists(t => t.Descricao == descricao))
            {
                throw new Exception("Já existe uma tarefa com a mesma descrição.");
            }
        }
    }
}
