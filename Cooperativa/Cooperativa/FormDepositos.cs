using BL.Cooperativa;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cooperativa
{
    public partial class FormDepositos : Form
    {
        DepositosBL _depositos;

        public FormDepositos()
        {
            InitializeComponent();

            _depositos = new DepositosBL();
            listaDepositosBindingSource.DataSource = _depositos.ObtenerDepositos();
        }

        private void FormDepositos_Load(object sender, EventArgs e)
        {

        }

        private void listaDepositosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaDepositosBindingSource.EndEdit();
            var Deposito = (Deposito)listaDepositosBindingSource.Current;

            var resultado = _depositos.GuardarDeposito(Deposito);

            if (resultado.Existoso == true)
            {
                listaDepositosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Deposito guardado");  
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _depositos.AgregarDeposito();
            listaDepositosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }  
            }
        }

        private void Eliminar(int id)
        {
            
            var resultado = _depositos.EliminarDeposito(id);

            if (resultado == true)
            {
                listaDepositosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el producto!");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
