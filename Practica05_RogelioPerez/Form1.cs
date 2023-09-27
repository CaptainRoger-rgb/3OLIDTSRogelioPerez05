using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica05_RogelioPerez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

            if (rbtn_Mujer.Checked)
            {
                genero = "Mujer";
            }

            //crear una cadena con los datos 
            string datos = $"Nombres: {nombres}\r\nApellidos:{apellidos}\r\nTelefonos:{telefonos}\r\nEdades:{edades} años\r\nEstaturas{estaturas}cm\r\nGenero:{genero}";

            //Guardar los datos en un archivo de texto
            string RutaArchivo = "c:/Users/Rogers/Documents/datos.text";            
            //File.WriteAllText(RutaArchivo, datos)
            //Verificar si el archivo ya existe 
            bool ArchivoExiste = File.Exists(RutaArchivo);

            using (StreamWriter writer = new StreamWriter(RutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    //Si el archivo existe, añadir un separado antes del archivo 
                    writer.WriteLine(datos);
                }
            }

            //Mostrar un mensaje con los datos capturados 
            MessageBox.Show("Datos guardados con éxito:\n\n" + datos, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellidos.Clear();
            txt_Edad.Clear();
            txt_Estatura.Clear();
            txt_Telefono.Clear();           
        }
    }
}
