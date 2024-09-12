using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Evaluacion.models;

namespace Evaluacion
{
    public partial class form1 : Form
    {
        // Escribe un programa que almacene los nombres de 25 estudiantes en un arreglo e imprima los nombres de los estudiantes cuyos nombre completo tenga mas de 25 caracteres
        GeneralNames names = new GeneralNames();
        int index = 0;
        public form1()
        {
            InitializeComponent();
        }

        private void cmbNames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            AddNames();
        }

        public void AddNames()
        {
            try {
            String name = tbNames.Text;
            names.AddNames(name, index);
            index++;
            ShowNames();
            tbNames.Clear();
            tbNames.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowNames()
        {
            try
            {
                cmbNames.Items.Clear();
                for (int i = 0; i < index; i++)
                {
                    cmbNames.Items.Add(names.GetNames()[i]);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tbNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                AddNames();
            }
        }
    }
}
