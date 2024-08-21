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
                cboSudeste.Focus();
            }
            else if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboNorte.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
                cboNorte.Focus();
            }
            else if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                cboNordeste.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
                cboNordeste.Focus();
            }
            else if (est == "SC" | est == "RS" | est == "PR")
            {
                cboSul.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
                cboSul.Focus();
            }
            else if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                cboCentroOeste.Items.Add(cboEstado.SelectedItem.ToString());
                cboEstado.Items.Remove(cboEstado.SelectedItem.ToString());
                cboCentroOeste.Focus();
            }            

            lblTd.Text = cboEstado.Items.Count.ToString();
            lblCo.Text = cboCentroOeste.Items.Count.ToString();
            lblNd.Text = cboNordeste.Items.Count.ToString();
            lblNt.Text = cboNorte.Items.Count.ToString();
            lblSd.Text = cboSudeste.Items.Count.ToString();
            lblSl.Text = cboSul.Items.Count.ToString();
            cboCentroOeste.Sorted = true;
            cboEstado.Sorted = true;
            cboNordeste.Sorted = true;
            cboNorte.Sorted = true;
            cboSudeste.Sorted = true;
            cboSul.Sorted = true;
            cboEstado.ResetText();
            btn1.Visible= false;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            if (est == "AM" | est == "PA" | est == "AC" | est == "RR" | est == "RO" | est == "AP" | est == "TO")
            {
                cboEstado.Items.Add(cboNorte.SelectedItem.ToString());
                cboNorte.Items.Remove(cboNorte.SelectedItem.ToString());
                cboNorte.ResetText();
                lblNt.Text = cboNorte.Items.Count.ToString();
                lblTd.Text = cboEstado.Items.Count.ToString();
                cboEstado.Sorted = true;
                btn2.Visible = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            if (est == "AL" | est == "BA" | est == "CE" | est == "MA" | est == "PB" | est == "PE" | est == "PI" | est == "RN" | est == "SE")
            {
                cboEstado.Items.Add(cboNordeste.SelectedItem.ToString());
                cboNordeste.Items.Remove(cboNordeste.SelectedItem.ToString());
                cboNordeste.ResetText();
                lblNd.Text = cboNordeste.Items.Count.ToString();
                lblTd.Text = cboEstado.Items.Count.ToString();
                cboEstado.Sorted = true;
                btn3.Visible = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string est = cboCentroOeste.SelectedItem.ToString();
            if (est == "GO" | est == "MT" | est == "MS" | est == "DF")
            {
                cboEstado.Items.Add(cboCentroOeste.SelectedItem.ToString());
                cboCentroOeste.Items.Remove(cboCentroOeste.SelectedItem.ToString());
                cboCentroOeste.ResetText();
                lblCo.Text = cboCentroOeste.Items.Count.ToString();
                lblTd.Text = cboEstado.Items.Count.ToString();
                cboEstado.Sorted = true;
                btn4.Visible = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string est = cboSudeste.SelectedItem.ToString();
            if (est == "SP" | est == "RJ" | est == "MG" | est == "ES")
            {
                cboEstado.Items.Add(cboSudeste.SelectedItem.ToString());
                cboSudeste.Items.Remove(cboSudeste.SelectedItem.ToString());
                cboSudeste.ResetText();
                lblSd.Text = cboSudeste.Items.Count.ToString();
                lblTd.Text = cboEstado.Items.Count.ToString();
                cboEstado.Sorted = true;
                btn5.Visible = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            if (est == "SC" | est == "RS" | est == "PR")
            {
                cboSudeste.Items.Add(cboSul.SelectedItem.ToString());
                cboSul.Items.Remove(cboSul.SelectedItem.ToString());
                cboSul.ResetText();
                lblSl.Text = cboSul.Items.Count.ToString();
                lblTd.Text = cboEstado.Items.Count.ToString();
                cboEstado.Sorted = true;
                btn6.Visible = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn1.Visible = false;
            btn2.Visible = false;
            btn3.Visible = false;
            btn4.Visible = false;
            btn5.Visible = false;
            btn6.Visible = false;
        }

        private void cboEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboEstado.SelectedItem.ToString();
            btn1.Visible = false;
            if (est != "")
            {
                btn1.Visible = true;
            }
        }

        private void cboNorte_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNorte.SelectedItem.ToString();
            btn2.Visible = false;
            if (est != "")
            {
                btn2.Visible = true;
            }
        }

        private void cboNordeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboNordeste.SelectedItem.ToString();
            btn3.Visible = false;
            if (est != "")
            {
                btn3.Visible = true;
            }
        }

        private void cboCentroOeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboCentroOeste.SelectedItem.ToString();
            btn4.Visible = false;
            if (est != "")
            {
                btn4.Visible = true;
            }
        }

        private void cboSudeste_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSudeste.SelectedItem.ToString();
            btn5.Visible = false;
            if (est != "")
            {
                btn5.Visible = true;
            }
        }

        private void cboSul_SelectedIndexChanged(object sender, EventArgs e)
        {
            string est = cboSul.SelectedItem.ToString();
            btn6.Visible = false;
            if (est != "")
            {
                btn6.Visible = true;
            }
        }
    }
}
