using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient; //Referencia para trabajar en lOCALHOST en Xamp

namespace Practica05_RogelioPerez
{
    public partial class Form1 : Form
    {
        //Datos de conexion a MySql (Xamp)
        string conexionSql = "Server=localhost;Port=3306;Database=programacion_avanzada;Uid=root:Pwd=;";
        public Form1()
        {
            //agregar controladores de eventos TexChanged a los campos
            InitializeComponent();
            txt_Edad.TextChanged += ValidarEdad;
            txt_Estatura.TextChanged += ValidarEstatura;
            txt_Telefono.TextChanged += ValidarTelefono;
            txt_Nombre.TextChanged += ValidarNombre;
            txt_Apellidos.TextChanged += ValidarApellidos;

        }
        private void InsertarRegistro(string nombre, string apellidos, int edad, decimal estatura, string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSql))
            {
                conection.Open();

                string insertQuery = "INSERT INTO registros (Nombre, Apellidos, Edad, Estatura, Telefono, Genero)" + "VALUES (@Nombre, @Apellidos, @Edad, @Estatura, @Telefono, @Genero)";

                using (MySqlCommand command = new MySqlCommand(insertQuery, conection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellidos", apellidos);
                    command.Parameters.AddWithValue("@Edad", edad);
                    command.Parameters.AddWithValue("@Estatura", estatura);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Genero", genero);
                }

                conection.Close();
            }
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Obtener los datos en los TexBox 
            string nombres = txt_Nombre.Text;
            string apellidos = txt_Apellidos.Text;
            string edades = txt_Edad.Text;
            string estaturas = txt_Estatura.Text;
            string telefonos = txt_Telefono.Text;

            //Obtener el genero seleccionado//
            string genero = "";
            if (rbtn_hombre.Checked)
            {
                genero = "Hombre";
            }

            else if (rbtn_Mujer.Checked)
            {
                genero = "Mujer";
            }

            if (EsEnteroValido(edades) && EsDecimalValido(estaturas) && EsEnteroValidos10Digitos(telefonos) &&
                    EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                //crear una cadena con los datos 
                string datos = $"Nombres: {nombres}\r\nApellidos:{apellidos}\r\nTelefonos:{telefonos}\r\nEdades:{edades} años\r\nEstaturas:{estaturas}cm\r\nGenero:{genero}\r\n";

                //Guardar los datos en un archivo de texto
                string RutaArchivo = "c:/Users/Rogers/Documents/datos.text";
                //File.WriteAllText(RutaArchivo, datos)
                //Verificar si el archivo ya existe 
                bool ArchivoExiste = File.Exists(RutaArchivo);
                
                if (ArchivoExiste == false)
                {
                    File.WriteAllText(RutaArchivo, datos);
                }

                else
                {
                    //Verificar si el archivo existe
                    using (StreamWriter writer = new StreamWriter(RutaArchivo, true))
                    {

                        if (ArchivoExiste)
                        {
                            //Si el archivo existe, añadir un separado antes del archivo 
                            writer.WriteLine();
                            //Programar la funcionalidad de insertar Sql
                            InsertarRegistro(nombres, apellidos, int.Parse(edades), decimal.Parse(estaturas), telefonos, genero);
                            MessageBox.Show("Datos ingresados Correctamente");
                        }

                        else
                        {
                            writer.WriteLine(datos);
                            //Programar la funcionalidad de insertar Sql
                            InsertarRegistro(nombres, apellidos, int.Parse(edades), decimal.Parse(estaturas), telefonos, genero);
                            MessageBox.Show("Datos ingresados Correctamente");
                        }
                    }
                }
                //Mostrar un mensaje con los datos capturados 
                MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            }
            else
            {
                MessageBox.Show("Por favor, inbrese datos validos en los campo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        
        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");//Solo letras y espacios 
        }

        private bool EsEnteroValidos10Digitos(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }
            if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;
        }

        //validar el archivo existente
        //using (StreamWriter writer = new StreamWriter(rutaArchivo, true)) 

        private void ValidarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una estatura válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            //Eliminar espacios en blanco y guiones si es necesario 

            if (input.Length > 0)
            {
                if (!EsEnteroValidos10Digitos(input))
                {
                    MessageBox.Show("Por favor, ingrese una teléfono válida de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
            }
            else if (!EsEnteroValidos10Digitos(input))
            {
                MessageBox.Show("Por favor, ingrese una teléfono válida de 10 digitos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ValidarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una nombre válida (Solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void ValidarApellidos(object sender, EventArgs e)
        {

            TextBox textBox = (TextBox)sender;
            if (!EsTextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese una apellidos válida (Solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            txt_Telefono.Clear();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Seguro que quieres cancelar los datos?:\n\n", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            txt_Telefono.Clear();
            MessageBox.Show("¡¡Se eliminaron los datos exitosamente!!");

        }    
        
    } 
}
