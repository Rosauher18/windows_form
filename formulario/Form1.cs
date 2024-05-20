using formulario.Dato;
using formulario.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;  //Una tabla de datos para almacenar la informacion
        Usuario dato = new Usuario(); //Un objeto para manejar usuarios
        public Form1()
        {
            InitializeComponent(); //inicializa los componentes del formulario
            Iniciar(); //configura la tabla de datos al inicio
        }


       
      private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)  //Evento que se ejecuta cuando se hace clic en el boton guardar
        {
            Guardar(); //guarda los datos ingresados
            Iniciar(); //Reinicia la tabla de datos
            Limpiar();
            Consultar(); //Consulta y muestra los datos guardados
        }

        private void btnlimpiar_Click(object sender, EventArgs e)  //Evento que se ejecuta cuando se hace clic en el boton limpiar
        {
            Limpiar(); //Limpia los datos de los campos de texto
        }
        private void Iniciar() //Configura la tabla de datos al inicio
        {
            tabla = new DataTable(); //Crea una nueva tabla de datos 
            tabla.Columns.Add("Nombre"); //Añade un columna para el nombre
            tabla.Columns.Add("Edad");//Añade una columna para la edad 
            grilla.DataSource = tabla; //Asocia la tabla a una grilla (tabla visual)

        }
        private void Guardar() //Guarda los datos ingresados por el usuario 
        {
            UsuarioModelo modelo = new UsuarioModelo()
            {
                Nombre = txtnombre.Text, //obtiene el nombre del campo del texto
                Edad = int.Parse(txtedad.Text) //Convierte la edad del campo de texto
            };
            dato.Guardar(modelo); //guarda el modelo de usuario
        }
        private void Consultar() //Consulta y muestra los datos guardados en la tabla
        {
            foreach (var item in dato.Consultart()) 
            {
                DataRow fila = tabla.NewRow(); //Crea una  nueva fila en la tabla 
                fila["Nombre"] = item.Nombre;//Añade el nombre del usuario en la fila 
                fila["Edad"]=item.Edad; //Añade la edad del usuario en la fila 
                tabla.Rows.Add(fila); //Añade la fila a la tabla 
            }
        }
        private void Limpiar() //Limpia los campos de texto en el formulario 
        {
            txtnombre.Text = ""; //Limpia el campo de texto del nombre 
            txtedad.Text = ""; //Limpia el campo de texto de la edad 
        }
    }
}
