using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsToDoList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                listTodo.Items.Add(txtTarefa.Text);
                txtTarefa.Clear();
            }
            else
            {
                MessageBox.Show("Porfavor digite algo valido");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (listTodo.SelectedItem != null)
            {
                txtTarefa.Focus();
                btnSave.Visible = true;
                btnAdd.Visible = false;
                btnCancelar.Visible = true;
                btnEditar.Visible = false;
            }
            else
            {
                MessageBox.Show("por favor selecione uma tarefa para editar");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrWhiteSpace(txtTarefa.Text))
            {
                int selectedItem = listTodo.SelectedIndex;
                listTodo.Items[selectedItem] = txtTarefa.Text;

                txtTarefa.Clear();
                txtTarefa.Focus();

                btnSave.Visible = false;
                btnAdd.Visible = true;
                btnCancelar.Visible = false;
                btnEditar.Visible = true;
            }
            else
            {
                MessageBox.Show("Por favor digite algo valido para salvar");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (listTodo.SelectedItem != null)
            {
                listTodo.Items.Remove(listTodo.SelectedItem);
                txtTarefa.Focus();
            }
            else
            {
                MessageBox.Show("Por favor selecione uma tarefa para excluir");
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtTarefa.Focus();
            txtTarefa.Clear();
            btnSave.Visible = false;
            btnAdd.Visible = true;
            btnCancelar.Visible = false;
            btnEditar.Visible = true;
        }
    }
}
