using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execepcion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {


           /* try
            {
                int telefono = Convert.ToInt32(txtTelefono.Text);
                int Matricula = Convert.ToInt32(txtMatricula.Text);
                int Semestre = Convert.ToInt32(txtSemestre.Text);
                

                MessageBox.Show("Hello");
            }
            catch (Exception eX)
            {   //El primero es un mensaje para el usuario
                MessageBox.Show("Valor incorrecto, Ingrese un nuevi valor");
                //El segundo es un mensaje pero para el desarollador
                MessageBox.Show(eX.ToString());
            }
            finally { txtTelefono.Focus(); };
            */

            //estos procesos ven si la condicion se cumple para hacer lo que esta alli senalado
            if (txtMatricula.Text == "")
            
                Ep.SetError(txtMatricula, "No ha ingresado matricula");


            if (txtNombre.Text == "")

                Ep.SetError(txtNombre, "No ha ingresado Nombre");
            
            if (txtSemestre.Text == "")

                Ep.SetError(txtSemestre, "No ha ingresado semestre");
           
            if (txtSemestre.Text == "")

                Ep.SetError(txtCarrera, "No ha ingresado Carrera");
            
            if (txtTelefono.Text == "")
                Ep.SetError(txtTelefono, "No ha ingresado telefono");

            //este proceso del try hace lo que esta dentro de los corchetes para atrapar errores con el catch y se regrese al error que senalo
            try
            {
                Alumno Al = new Alumno();
                Al.Matricula = txtMatricula.Text;
                Al.Nombre = txtNombre.Text;
                Al.Semestre = Convert.ToInt32(txtSemestre.Text);
                Al.carrera = txtCarrera.Text;
                Al.Telefono = Convert.ToInt32(txtTelefono.Text);
                throw new ExepcionEspecial("alumno no se creo exitosamente");
            }
            //atrapala excepcion del evento ex y la muestra al usuario con un mbox
            catch (FormatException ex)
            {
                MessageBox.Show("Error al registrar alumno"+ex.Message);

            }
            catch(ExepcionEspecial esp)
            {
                MessageBox.Show(Convert.ToString(esp));
            }
            finally
            {
                Ep.Clear();
            }    
            






        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void TxtCali_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                int cal = Convert.ToInt32(TxtCali.Text);
                if(cal < 1 || cal > 10)
                {
                    MessageBox.Show("Ingrese las calificaciones del 1 al 10"+e);
                }
            }
            catch
            {
                MessageBox.Show("introduzca los numeros correctos","Error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                

            }
            finally
            {

            }
        }
    }
}
