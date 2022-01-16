using System.Collections.Generic;

namespace Tarefas.Entidades
{
    public partial class Agenda
    {
        public Agenda()
        {
            Tarefas = new List<Tarefa>();
        }

        public List<Tarefa> Tarefas { get; private set; }
    }
}
