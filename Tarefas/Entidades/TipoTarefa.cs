namespace Tarefas.Entidades
{
    /// <summary>
    /// Identifica o tipo de tarefa em uma agenda
    /// </summary>
    public enum TipoTarefa
    {        
        /// <summary>
        /// Tarefa que se não for resolvida o mais rápido possível pode causar problemas.
        /// </summary>
        Urgente,

        /// <summary>
        /// Pode ser realizada após as tarefas de urgência
        /// </summary>
        Normal,

        /// <summary>
        /// Tratra-se de um lembrete
        /// </summary>
        Lembrete
    }
}
