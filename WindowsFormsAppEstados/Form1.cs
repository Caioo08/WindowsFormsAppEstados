using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppEstados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string est = cboEstado.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                cboSudeste.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
            }
            else if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboNorte.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
            }
            else if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PN" | est == "PI" | est == "RN" | est == "SE")
            {
                cboNordeste.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());  
            }else if (est == "SC" | est == "RS" | est == "PR")
            {
                cboSul.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
            }else if(est == "GO" | est == "MT" | est == "MS")
            {
                cboCentroOeste.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
            }


            lblTd.Text = cboEstado.Items.Count.ToString();
            lblCo.Text = cboCentroOeste.Items.Count.ToString();
            lblNd.Text = cboNordeste.Items.Count.ToString();
            lblNt.Text = cboNorte.Items.Count.ToString();
            lblSd.Text = cboSudeste.Items.Count.ToString();
            lblSl.Text = cboSul.Items.Count.ToString();

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboEstado.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
            }
        }
    }
}
