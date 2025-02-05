namespace Datas
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxInicial = new System.Windows.Forms.TextBox();
            this.textBoxFinal = new System.Windows.Forms.TextBox();
            this.textBoxAtual = new System.Windows.Forms.TextBox();
            this.btnData = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxInicial2 = new System.Windows.Forms.TextBox();
            this.textBoxFinal2 = new System.Windows.Forms.TextBox();
            this.textBoxAtual2 = new System.Windows.Forms.TextBox();
            this.calendarioIcone = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuNotificacao = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Restaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.Mensagem = new System.Windows.Forms.ToolStripMenuItem();
            this.Fechar = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNotificacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(63, 40);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.monthCalendar1.MaxSelectionCount = 30;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(312, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Inicial :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(312, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Final :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(312, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Data Atual :";
            // 
            // textBoxInicial
            // 
            this.textBoxInicial.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxInicial.Location = new System.Drawing.Point(395, 58);
            this.textBoxInicial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxInicial.Name = "textBoxInicial";
            this.textBoxInicial.Size = new System.Drawing.Size(116, 20);
            this.textBoxInicial.TabIndex = 4;
            // 
            // textBoxFinal
            // 
            this.textBoxFinal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxFinal.Location = new System.Drawing.Point(395, 91);
            this.textBoxFinal.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFinal.Name = "textBoxFinal";
            this.textBoxFinal.Size = new System.Drawing.Size(116, 20);
            this.textBoxFinal.TabIndex = 5;
            // 
            // textBoxAtual
            // 
            this.textBoxAtual.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxAtual.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAtual.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBoxAtual.Location = new System.Drawing.Point(395, 124);
            this.textBoxAtual.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxAtual.Name = "textBoxAtual";
            this.textBoxAtual.Size = new System.Drawing.Size(116, 20);
            this.textBoxAtual.TabIndex = 6;
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnData.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnData.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnData.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnData.Location = new System.Drawing.Point(348, 168);
            this.btnData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(142, 23);
            this.btnData.TabIndex = 7;
            this.btnData.Text = "Selecionar Data";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 319);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Data Atual :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(69, 286);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Data Final :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 253);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Data Inicial :";
            // 
            // textBoxInicial2
            // 
            this.textBoxInicial2.Location = new System.Drawing.Point(156, 250);
            this.textBoxInicial2.Name = "textBoxInicial2";
            this.textBoxInicial2.Size = new System.Drawing.Size(100, 20);
            this.textBoxInicial2.TabIndex = 11;
            // 
            // textBoxFinal2
            // 
            this.textBoxFinal2.Location = new System.Drawing.Point(156, 286);
            this.textBoxFinal2.Name = "textBoxFinal2";
            this.textBoxFinal2.Size = new System.Drawing.Size(100, 20);
            this.textBoxFinal2.TabIndex = 12;
            // 
            // textBoxAtual2
            // 
            this.textBoxAtual2.Location = new System.Drawing.Point(156, 319);
            this.textBoxAtual2.Name = "textBoxAtual2";
            this.textBoxAtual2.Size = new System.Drawing.Size(100, 20);
            this.textBoxAtual2.TabIndex = 13;
            // 
            // calendarioIcone
            // 
            this.calendarioIcone.ContextMenuStrip = this.MenuNotificacao;
            this.calendarioIcone.Icon = ((System.Drawing.Icon)(resources.GetObject("calendarioIcone.Icon")));
            this.calendarioIcone.Text = "CalendarioIcone";
            this.calendarioIcone.Visible = true;
            // 
            // MenuNotificacao
            // 
            this.MenuNotificacao.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Restaurar,
            this.Mensagem,
            this.Fechar});
            this.MenuNotificacao.Name = "MenuNotificacao";
            this.MenuNotificacao.Size = new System.Drawing.Size(181, 92);
            this.MenuNotificacao.Opening += new System.ComponentModel.CancelEventHandler(this.MenuNotificacao_Opening);
            this.MenuNotificacao.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.MenuNotificacao_ItemClicked);
            
            // 
            // Restaurar
            // 
            this.Restaurar.Name = "Restaurar";
            this.Restaurar.Size = new System.Drawing.Size(180, 22);
            this.Restaurar.Text = "Restaurar";
            // 
            // Mensagem
            // 
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(180, 22);
            this.Mensagem.Text = "Mensagem";
            // 
            // Fechar
            // 
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(180, 22);
            this.Fechar.Text = "Fechar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 456);
            this.Controls.Add(this.textBoxAtual2);
            this.Controls.Add(this.textBoxFinal2);
            this.Controls.Add(this.textBoxInicial2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.textBoxAtual);
            this.Controls.Add(this.textBoxFinal);
            this.Controls.Add(this.textBoxInicial);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MenuNotificacao.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxInicial;
        private System.Windows.Forms.TextBox textBoxFinal;
        private System.Windows.Forms.TextBox textBoxAtual;
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxInicial2;
        private System.Windows.Forms.TextBox textBoxFinal2;
        private System.Windows.Forms.TextBox textBoxAtual2;
        private System.Windows.Forms.NotifyIcon calendarioIcone;
        private System.Windows.Forms.ContextMenuStrip MenuNotificacao;
        private System.Windows.Forms.ToolStripMenuItem Restaurar;
        private System.Windows.Forms.ToolStripMenuItem Mensagem;
        private System.Windows.Forms.ToolStripMenuItem Fechar;
    }
}

