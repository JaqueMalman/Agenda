namespace Tarefas.Entidades
{
    public partial class Tarefa
    {
        public Tarefa(string descricao, TipoTarefa tipoTarefa)
        {
            ValidarDescricao(descricao);
            ValidarTipoTarefa(tipoTarefa);

            Descricao = descricao.Trim();
            TipoTarefa = tipoTarefa;
            //Feito = false;
        }

        public string Descricao { get; private set; }

        public TipoTarefa TipoTarefa { get; private set; }

        public bool Finalizada { get; private set; }
    }
}
