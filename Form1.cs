using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;

namespace laboratorio6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Clientes> clientess = new List<Clientes>();
        List<Vehiculos> vehiculoss = new List<Vehiculos>();
        List<Alquiler> alquilers = new List<Alquiler>();
        List<Reporte> reportes = new List<Reporte>();

        public void cargarClientes()
        {
            String fileName = "Clientes.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Clientes clientes = new Clientes();
                clientes.Nit = reader.ReadLine();
                clientes.Nombre = reader.ReadLine();
                clientes.Direccion = reader.ReadLine();
            
                clientess.Add(clientes);

            }
            reader.Close();

            
        }

        public void cargarAlquileres()
        {
            String fileName = "Alquileres.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Alquiler alquileres = new Alquiler();
                alquileres.Nit = reader.ReadLine();
                alquileres.Placa = reader.ReadLine();
                alquileres.FechaAlq = Convert.ToDateTime(reader.ReadLine());
                alquileres.FechaDev = Convert.ToDateTime(reader.ReadLine());
                alquileres.Kilometros = Convert.ToInt32(reader.ReadLine());

                alquilers.Add(alquileres);

            }
            reader.Close();

         
        }
        public void rep() 
        {
            reportes.Clear();
            foreach(var alquiler in alquilers)
            {
                Clientes clientes = clientess.Find(c => c.Nit == alquiler.Nit);
                Vehiculos vehiculos = vehiculoss.Find(v => v.Placa == alquiler.Placa);

                Reporte reporte = new Reporte();
                reporte.Nombre1 = clientes.Nombre;
                reporte.Marca1 = vehiculos.Marca;
                reporte.Modelo1 = vehiculos.Modelo;
                reporte.FechaDevuelto1 = alquiler.FechaDev;
                reporte.TotalPagar1 = vehiculos.PrecioPerkm * alquiler.Kilometros;

                reportes.Add(reporte);
            }

        }
        public void CargarVehiculos()
        {
            StreamWriter vehiculosa = new StreamWriter(@"C:\Users\brayan11\Downloads\laboratorio6-master\bin\Debug\Vehiculos.txt", true);
            try
            {
                vehiculosa.WriteLine(textBox1.Text);
                vehiculosa.WriteLine(textBox2.Text);
                vehiculosa.WriteLine(textBox3.Text);
                vehiculosa.WriteLine(textBox4.Text);
                vehiculosa.WriteLine(textBox5.Text);
            }
            catch
            {
                MessageBox.Show("Error");
            }
            vehiculosa.Close();
        }
        public void MostrarVehiculos()
        {
            String fileName = "Vehiculos.txt";


            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            while (reader.Peek() > -1)
            {
                Vehiculos vehiculos = new Vehiculos();
                vehiculos.Placa = reader.ReadLine();
                vehiculos.Marca = reader.ReadLine();
                vehiculos.Modelo = Convert.ToInt32(reader.ReadLine());
                vehiculos.Color = reader.ReadLine();
                vehiculos.PrecioPerkm = Convert.ToInt32(reader.ReadLine());

                vehiculoss.Add(vehiculos);

            }
            reader.Close();
        }
        public void MostrarClientes()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewClientes.DataSource = null;
            dataGridViewClientes.DataSource = clientess;
            dataGridViewClientes.Refresh();
        }
        public void Mostrarvehiculos()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewVehiculos.DataSource = null;
            dataGridViewVehiculos.DataSource = vehiculoss;
            dataGridViewVehiculos.Refresh();
        }
        public void MostrarAlquiler()
        {

            //mostrar la lista de empleados en el gridview 
            dataGridViewAlquiler.DataSource = null;
            dataGridViewAlquiler.DataSource = alquilers;
            dataGridViewAlquiler.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            cargarClientes();
            MostrarClientes();
            cargarAlquileres();
            MostrarAlquiler();
            Mostrarvehiculos();
            MostrarVehiculos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CargarVehiculos();
        }
    }
}
