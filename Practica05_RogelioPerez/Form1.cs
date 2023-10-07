using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica05_RogelioPerez
{
    public partial class Form1 : Form
    {
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

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            //Obtener los datos en los TexBox 
            string nombres = txt_Nombre.Text;
            string apellidos = txt_Apellidos.Text;
            string edades = txt_Edad.Text;
            string estaturas = txt_Estatura.Text;
            string telefonos = txt_Telefono.Text;

           //Obtener el genero seleccionado
            string genero = "";
            if (rbtn_hombre.Checked)
            {
                genero = "Hombre";
            }

            else if (rbtn_Mujer.Checked)
            {
                genero = "Mujer";
            }

            if (EsEnteroValido(edades)&&EsDecimalValido(estaturas)&& EsEnteroValidos10Digitos(telefonos)&&
                EsTextoValido(nombres)&&EsTextoValido(apellidos))
            {

            }
            
            //crear una cadena con los datos 
            string datos = $"Nombres: {nombres}\r\nApellidos:{apellidos}\r\nTelefonos:{telefonos}\r\nEdades:{edades} años\r\nEstaturas:{estaturas}cm\r\nGenero:{genero}\r\n";

            //Guardar los datos en un archivo de texto
            string RutaArchivo = "c:/Users/Rogers/Documents/datos.text";            
            //File.WriteAllText(RutaArchivo, datos)
            //Verificar si el archivo ya existe 
            bool ArchivoExiste = File.Exists(RutaArchivo);

            if(ArchivoExiste == false)
            {
                File.WriteAllText(RutaArchivo,datos);
            }

            else
            {
                using (StreamWriter writer = new StreamWriter(RutaArchivo, true))
                {
                    if (ArchivoExiste)
                    {
                        //Si el archivo existe, añadir un separado antes del archivo 
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);

                }

            }
            //Mostrar un mensaje con los datos capturados 
            MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

            private bool EsEnteroValidos10Digitos(string valor)
            {
                long resultado;
                return long.TryParse(valor, out resultado) && valor.Length == 10;
            }

            private bool EsTextoValido(string valor)
            {
                return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");//Solo letras y espacios 
            }

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
                
                if(input.Length > 0)
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

            private void ValidarApellido(object sender, EventArgs e)
            {
                TextBox textBox = (TextBox)sender;
                if (!EsTextoValido(textBox.Text))
                {
                    MessageBox.Show("Por favor, ingrese una apellidos válida (Solo letras y espacios)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox.Clear();
                }
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
            MessageBox.Show("Seguro que quieres cancelar los datos?:\n\n" , "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            txt_Telefono.Clear();
            MessageBox.Show("¡¡Se eliminaron los datos exitosamente!!");

        }
    }
}
