using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoData1
{
    public partial class FrmMain : Form
    {
        Tarea ta = new Tarea();
        List<Tarea> lista = new List<Tarea>();
        FrmData tarea = new FrmData();
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TxtMenu.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //hacemos el switch para la opcion del menu

            switch (Convert.ToInt32(textBox11.Text))
            {

                case 1:
                    //instanciamos la forma para llamarla 
                    FrmData captura = new FrmData();
                    
                    for (int r = 0; r < 5; r++)

                    {
                        //hacemos que el btn result al presioif (fmat.ShowDialog() == DialogResult.OK)narlo se haga un dialog Ok y metemos el accept btn como  el btn para que la forma tome el resultado
                        if (tarea.ShowDialog() == DialogResult.OK)
                        {
                            Tarea t = new Tarea();
                            captura.Focus();
                            
                            //que se agregue en dgvmaterias una nueva fila cada vez que se inicie el for hasta tener 3 casillas para usar
                            DgvData.Rows.Add();
                            DgvData.Rows[r].Cells[0].Value = tarea.TxtUser.Text;
                            t.User = tarea.TxtUser.Text;
                            DgvData.Rows[r].Cells[1].Value = tarea.TxtDate.Text;
                            t.Date = tarea.TxtDate.Text;
                            DgvData.Rows[r].Cells[2].Value = tarea.TxtName.Text;
                            t.Name = tarea.TxtName.Text;
                            DgvData.Rows[r].Cells[3].Value = tarea.TxtDesc.Text;
                            t.Description = tarea.TxtDesc.Text;
                            DgvData.Rows[r].Cells[4].Value = tarea.TxtHour.Text;
                            t.Hour = tarea.TxtHour.Text;
                            DgvData.Rows[r].Cells[5].Value = tarea.TxtStatus.Text;
                            t.Status = tarea.TxtStatus.Text;
                            lista.Add(t);

                            //que se borre los datos que se metieron para que no se tengan que borrar
                            tarea.TxtUser.Text = "";
                            tarea.TxtDate.Text = "";
                            tarea.TxtName.Text = "";
                            tarea.TxtDesc.Text = "";
                            tarea.TxtHour.Text = "";
                            tarea.TxtStatus.Text = "";
                        }
                    }
                    break;
                case 2:
                    //instanciamps la forma captura
                    FrmDataPrint data = new FrmDataPrint();
                    data.Focus();
                    data.Show(this);
                    //por cada elemento guardado en la lista hacemos que se imprima en el txtbox que tenemos en esa forma, el eviromen,newline es para que genere otra linea
                    foreach (Tarea d in lista)
                    {
                        data.TxtDataprint1.Text += d.User +" " + Environment.NewLine
                           + d.Name + " " + Environment.NewLine
                           +d.Date + " "+ Environment.NewLine
                           + d.Hour + " " + Environment.NewLine
                            + d.Description + " " + Environment.NewLine
                           + d.Status + " " + Environment.NewLine
                           + "===========================================================================" + Environment.NewLine;

                    }
                    break;
                default:
                    MessageBox.Show("Seleccione una opcion valida");
                    break;

            }
        }

       

        private void BtnMenu_Click(object sender, EventArgs e)
        {
            //escondemos el menu para cuando el usuario le pique al Btnmenu salga con sus contenidos
            TxtMenu.Text = "1. Crear tarea\r\n2. Detalles de tareas";
            TxtMenu.Show();
        }

        private void BtnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void DgvData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void DgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //aqui tenemos el evento cuando alguien seleccione una celda cualquiera
            //lo guardamos en la variable index
            // y hacemos que el value se imprima en el txtbox
            ta.IndexRow = e.RowIndex;
            DataGridViewRow row = DgvData.Rows[ta.IndexRow];
            txtStatusUpdate.Text = row.Cells[5].Value.ToString();
        }

        private void BrnUpdate_Click(object sender, EventArgs e)
        {
            //aqui hacemos que el usuario pueda cambiar el contenido del estatus de la cell que seleccione
            DataGridViewRow datarow = DgvData.Rows[ta.IndexRow];
            datarow.Cells[5].Value = txtStatusUpdate.Text;
        }
    }
}
