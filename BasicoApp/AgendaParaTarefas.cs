using System;
using System.Drawing;
using System.Windows.Forms;
using Tarefas.Entidades;

namespace BasicoApp
{
    public partial class AgendaParaTarefas : Form
    {
        private Agenda _agenda;
        public AgendaParaTarefas()
        {
            InitializeComponent();

            _agenda = new Agenda();
            rbNormal.Checked = true;
        }

        private void btnAdicionar_Click(object sender, System.EventArgs e)
        {
            try
            {
                var tipoTarefa = GetTipoTarefa();

                _agenda.AdicionarTarefa(TxtDescricao.Text, tipoTarefa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally 
            {
                TxtDescricao.Text = String.Empty;
            }
            ExibirTarefas();
            ExibirTarefasRichText();
        }

        private TipoTarefa GetTipoTarefa()
        {
            if (rbLembrete.Checked) return TipoTarefa.Lembrete;

            if (rbNormal.Checked) return TipoTarefa.Normal;

            return TipoTarefa.Urgente;
        }

        private void ExibirTarefas()
        {
            txtTarefasAgendadas.Text = String.Empty;

            foreach (var tarefa in _agenda.Tarefas)
            {
                var statusFinalizada = tarefa.Finalizada ? "Finalizada" : "Pendente";
                var tipoTarefa = tarefa.TipoTarefa.ToString();

                txtTarefasAgendadas.Text += String.Format(@"{0} - {1} - {2}" + Environment.NewLine,
                                                        statusFinalizada,
                                                        tipoTarefa,
                                                        tarefa.Descricao);
            }
        }

        private void ExibirTarefasRichText()
        {
            richTxtTarefas.Text = String.Empty;

            foreach (var tarefa in _agenda.Tarefas)
            {
                var statusFinalizada = tarefa.Finalizada ? "Finalizada" : "Pendente";
                var tipoTarefa = tarefa.TipoTarefa.ToString();

                var descricaoTarefa = String.Format(@"{0} - {1} - {2}" + Environment.NewLine,
                                                        statusFinalizada,
                                                        tipoTarefa,
                                                        tarefa.Descricao);

                richTxtTarefas.SelectionStart = richTxtTarefas.TextLength;
                richTxtTarefas.SelectionLength = 0;

                switch (tarefa.TipoTarefa)
                {
                    case TipoTarefa.Urgente:
                        richTxtTarefas.SelectionColor = Color.Red;
                        break;

                    case TipoTarefa.Lembrete:
                        richTxtTarefas.SelectionColor = Color.BlueViolet;
                        break;

                    default:
                        richTxtTarefas.SelectionColor = Color.Black;
                        break;
                }
                        
                richTxtTarefas.AppendText(descricaoTarefa);
                richTxtTarefas.SelectionColor = richTxtTarefas.ForeColor;
            }
        }
    }
}