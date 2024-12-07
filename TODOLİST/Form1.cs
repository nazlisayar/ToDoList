using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TODOLİST
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gorev=txtgorev.Text;
            if (!string.IsNullOrEmpty(gorev))
            {
                ckdlstgorev.Items.Add(gorev);
                txtgorev.Clear();
            }
            else
            {
                MessageBox.Show("lütfen bir görev girin","uyarı",MessageBoxButtons.OK,MessageBoxIcon.Warning);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ckdlstgorev.SelectedItem != null)
            {
                ckdlstgorev.Items.Remove(ckdlstgorev.SelectedItem);
            }
            else
            {
                MessageBox.Show("lütfen silmek istediğiniz öğeyi seçiniz", "uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }
    }
}
