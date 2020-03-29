using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_Practico_2
{
    public partial class frm_desafio : Form
    {
        Queue<ClaseLetras1> CL1 = new Queue<ClaseLetras1>();

        public frm_desafio()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; MessageBox.Show("Solo se admiten letras", "Validación de texto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }
        private bool Validaciones()
        {
            bool validado = true;
            if (txt_dato.Text == "")
            {
                validado = false;
                EPvalidaciones.SetError(txt_dato, "Ingrese una letra");
            }
          
            return validado;
        }

        private void BorarSMS()
        {
         
            EPvalidaciones.SetError(txt_dato, "");
        }
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            BorarSMS();
            if(Validaciones())
            {
                ClaseLetras1 cl1 = new ClaseLetras1();

                cl1.dletra = txt_dato.Text.ToLower();
                CL1.Enqueue(cl1);
                dgv_cola1.DataSource = null;
                dgv_cola1.DataSource = CL1.ToArray();
                txt_dato.Clear();
            }
          
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if(CL1.Count !=0)
            {
                ClaseLetras1 cl1 = new ClaseLetras1();
                cl1 = CL1.Dequeue();

                txt_dato.Text = cl1.dletra;
                dgv_cola1.DataSource = CL1.ToList();
                MessageBox.Show("El registro ha sido elimnado exitosamente de la cola","AVISO");
                //Aqui debes tomar el dato para el AVL, antes de borrar el dato del textbox
                MessageBox.Show("El registro elimando esta siendo trasladado a un AVL", "ATENCIÓN");
            }
        }
    }
}
