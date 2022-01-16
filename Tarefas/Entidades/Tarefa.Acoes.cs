using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefas.Entidades
{
    public partial class Tarefa
    {
        internal void FinalizarTarefa()
        {
            Finalizada = true;
        }

        internal void ReabrirTarefa()
        {
            Finalizada = false;
        }
    }
}
