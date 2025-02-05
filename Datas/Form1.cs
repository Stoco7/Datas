﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Datas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            textBoxInicial.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxFinal.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxAtual.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBoxInicial2.Text = monthCalendar1.SelectionStart.ToShortDateString();
            textBoxFinal2.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            textBoxAtual2.Text = monthCalendar1.TodayDate.ToShortDateString();
        }

        private void MenuNotificacao_Opening(object sender, CancelEventArgs e)
        {

        }

        private void MenuNotificacao_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name.ToString() == "Fechar")
            {
                this.Close();
            }
            else if (e.ClickedItem.Name.ToString() == "Restaurar")
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if (e.ClickedItem.Name.ToString() == "Mensagem")
            {
                MessageBox.Show("VOCE ESTA LENDO ESSA MENSAGEM!");
            }
        }
    }
}
