using System;

namespace Tarefas.Entidades
{
    public partial class Tarefa
    {
        private static void ValidarDescricao(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
            {
                throw new Exception("O campo descrição deve ser preenchido.");
            }
        }

        private static void ValidarTipoTarefa(TipoTarefa tipoTarefa)
        {
            if (!Enum.IsDefined(typeof(TipoTarefa), tipoTarefa))
            {
                throw new Exception("Tipo de tarefa inválido.");
            }
        }
    }
}
