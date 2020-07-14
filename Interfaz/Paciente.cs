using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DentalCare_System.DB;
using MySql.Data.MySqlClient;

namespace DentalCare_System.Interfaz
{
    public partial class Paciente : Form

    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void Editar_Click(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Close();

        }
      
        //Boton de Guardar 
        private void Guardar_Click(object sender, EventArgs e)
        {
           
          
            try
            {
               //Se Declaran las Varaiables 
                String Nombre = TxtNombre.Text;
                String Apellido = TxtApellido.Text;
                String Telefono = TxtTelefono.Text;
                String Celular = TxtCelular.Text;
                String Ocupacion = TxtOcupacion.Text;
                String Direccion = TxtDireccion.Text;
                String Sexo =TxtSexo.Text;
                String EstadoCivil = TxtEstadoCivil.Text;
                String FechaNacimiento = Convert.ToDateTime(TxtFechaNacimiento.Text).ToString("yyyy-MM-dd");
                


                if ( Nombre!="" 
                    && Apellido!=""
                    && Sexo!="" && FechaNacimiento !="" && EstadoCivil !="" && Celular !="" && Telefono !="")
                {
                    
                    string sql = "INSERT INTO paciente ( nombre, apellido, Fecha_Nacimiento, sexo , estado_civil , celular, telefono, ocupacion, direccion)" +
                        " VALUES ( '" + Nombre + "','" + Apellido +"','" + FechaNacimiento + "','"+ Sexo +"','"+ EstadoCivil + "','" + Celular  + "','" + Telefono + "','" + Ocupacion + "','" + Direccion + "' )";
                    
                    MySqlConnection conexionBD = DbConnection.ObtenerConeccion();

                    conexionBD.Open();
                        
                    try
                    {
                        MySqlCommand comando = new MySqlCommand(sql,conexionBD);
                        

                        comando.ExecuteNonQuery();
                        


                        MessageBox.Show("Registro guardado");
                        
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("Error al guardar: " + ex.Message);
                    }
                    finally
                    {
                        conexionBD.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Debe completar todos los campos");
                }
            }
            catch (FormatException fex)
            {
                MessageBox.Show("Datos incorrectos: " + fex.Message);
            }

        }

        private void Paciente_Load(object sender, EventArgs e)
        {

           /* try
            {
                DataSet ds = ;
                dt = ds.Tables[0];
                ListaPacientes.DataSource = dt;
              

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);

            }*/
        }
    }
}
