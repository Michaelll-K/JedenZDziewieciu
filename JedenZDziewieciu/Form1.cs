using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JedenZDziewieciu.Tools;

namespace JedenZDziewieciu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblKategorioa.Text = "";
            lblNumer.Text = "";
        }

        private void btnLos_Click(object sender, EventArgs e)
        {
            QuestionManager qm = new QuestionManager();
            string[] result = qm.GetQuestions();

            lblKategorioa.Text = result[0];
            lblNumer.Text = result[1];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            QuestionManager qm = new QuestionManager();
            qm.ClearQuestions();
        }
    }
}
