namespace BasicoApp
{
    partial class AgendaParaTarefas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtDescricao = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUrgente = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbLembrete = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTarefasAgendadas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTxtTarefas = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtDescricao
            // 
            this.TxtDescricao.Location = new System.Drawing.Point(6, 42);
            this.TxtDescricao.Name = "TxtDescricao";
            this.TxtDescricao.Size = new System.Drawing.Size(287, 20);
            this.TxtDescricao.TabIndex = 0;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(607, 39);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 1;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tarefa";
            // 
            // rbUrgente
            // 
            this.rbUrgente.AutoSize = true;
            this.rbUrgente.Location = new System.Drawing.Point(92, 16);
            this.rbUrgente.Name = "rbUrgente";
            this.rbUrgente.Size = new System.Drawing.Size(63, 17);
            this.rbUrgente.TabIndex = 3;
            this.rbUrgente.TabStop = true;
            this.rbUrgente.Text = "Urgente";
            this.rbUrgente.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(19, 16);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 17);
            this.rbNormal.TabIndex = 4;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            this.rbNormal.UseWaitCursor = true;
            // 
            // rbLembrete
            // 
            this.rbLembrete.AutoSize = true;
            this.rbLembrete.Location = new System.Drawing.Point(176, 16);
            this.rbLembrete.Name = "rbLembrete";
            this.rbLembrete.Size = new System.Drawing.Size(69, 17);
            this.rbLembrete.TabIndex = 5;
            this.rbLembrete.TabStop = true;
            this.rbLembrete.Text = "Lembrete";
            this.rbLembrete.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbUrgente);
            this.groupBox1.Controls.Add(this.rbLembrete);
            this.groupBox1.Controls.Add(this.rbNormal);
            this.groupBox1.Location = new System.Drawing.Point(316, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 36);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Tarefa";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TxtDescricao);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.btnAdicionar);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(22, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(691, 84);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nova Tarefa";
            // 
            // txtTarefasAgendadas
            // 
            this.txtTarefasAgendadas.Location = new System.Drawing.Point(28, 148);
            this.txtTarefasAgendadas.Multiline = true;
            this.txtTarefasAgendadas.Name = "txtTarefasAgendadas";
            this.txtTarefasAgendadas.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTarefasAgendadas.Size = new System.Drawing.Size(305, 237);
            this.txtTarefasAgendadas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Tarefas agendadas";
            // 
            // richTxtTarefas
            // 
            this.richTxtTarefas.Location = new System.Drawing.Point(357, 148);
            this.richTxtTarefas.Name = "richTxtTarefas";
            this.richTxtTarefas.Size = new System.Drawing.Size(329, 248);
            this.richTxtTarefas.TabIndex = 10;
            this.richTxtTarefas.Text = "";
            // 
            // AgendaParaTarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 450);
            this.Controls.Add(this.richTxtTarefas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTarefasAgendadas);
            this.Controls.Add(this.groupBox2);
            this.Name = "AgendaParaTarefas";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtDescricao;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbUrgente;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbLembrete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTarefasAgendadas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTxtTarefas;
    }
}

