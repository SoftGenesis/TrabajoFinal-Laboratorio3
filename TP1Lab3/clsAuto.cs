using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Drawing.Printing;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;


namespace TP1Lab3
{
    internal class clsAuto
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDMecanico.mdb";
        private String Tabla = "TAuto";
        Image img;        
        clsClienteMain c = new clsClienteMain();

        private String patente;
        private String marca;
        private String modelo;
        private Int32 año;
        private String sino;
        private Int32 idcliente;
        private Int32 cant;

        public String Patente
        {
            get { return patente; }
            set { patente = value; }
        }

        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }

        public String Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }

        public Int32 Año
        {
            get { return año; }
            set { año = value; }
        }

        public String Sino
        {
            get { return sino; }
            set { sino = value; }
        }

        public Int32 Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public Int32 Cantidad
        {
            get { return cant; }
            set { cant = value; }
        }

        public class Car
        {
            public string Name { get; set; }
        }

        HttpRequestMessage request = new HttpRequestMessage
        {
            Method = HttpMethod.Get,
            RequestUri = new Uri("https://car-data.p.rapidapi.com/cars/makes"),
            Headers =
            {
                    { "X-RapidAPI-Key", "6778b57df7mshcec08746408344ap1612a5jsnba1e1be8ba68" },
                    { "X-RapidAPI-Host", "car-data.p.rapidapi.com" },
            },
        };

        public async void CargarCmbFrm(ComboBox comboBoxCountries)
        {
            // ...

            try
            {
                using (HttpClient httpClient = new HttpClient())
                {
                    // Realiza la solicitud GET a la API y obtiene la respuesta
                    HttpResponseMessage response = await httpClient.SendAsync(request);

                    if (response.IsSuccessStatusCode)
                    {
                        // Lee el contenido JSON de la respuesta y deserializa en una lista de objetos CarMake
                        string jsonResponse = await response.Content.ReadAsStringAsync();
                        string[] carMakes = JsonConvert.DeserializeObject<string[]>(jsonResponse);

                        // Agrega los nombres de las marcas al ComboBox
                        foreach (string carMake in carMakes)
                        {
                            comboBoxCountries.Items.Add(carMake);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Error al obtener la lista de Marcas. Código de estado: " + response.StatusCode);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar la lista de Marcas: " + ex.Message);
            }
        }

        public void Agregar()///////////////////////////////////////////////////
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["Patente"] = patente;
                fila["Marca"] = marca;
                fila["Modelo"] = modelo;
                fila["AñoLanzamiento"] = año;
                fila["RepuestosVigentes"] = sino;
                fila["IdCliente"] = idcliente;
                tabla.Rows.Add(fila);
                OleDbCommandBuilder conciliacambios = new OleDbCommandBuilder(adaptador);
                adaptador.Update(DS, Tabla);

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarComboMarca(ComboBox cmb) ///////////////////////////
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                cmb.DataSource = DS.Tables[Tabla];
                cmb.DisplayMember = "Marca";
                cmb.ValueMember = "IdPatente";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarComboModelo(ComboBox cmb) ///////////////////////////
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                cmb.DataSource = DS.Tables[Tabla];
                cmb.DisplayMember = "Modelo";
                cmb.ValueMember = "IdPatente";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarComboPatente(ComboBox cmb) ///////////////////////////
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                cmb.DataSource = DS.Tables[Tabla];
                cmb.DisplayMember = "Patente";
                cmb.ValueMember = "IdPatente";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarComboMarcaModelo(ComboBox cmb)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                cmb.Items.Clear();

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        cmb.Items.Add(Convert.ToString(fila["Marca"] + ", " + fila["Modelo"]));
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarComboPatenteCondicionado(ComboBox cmb1, TextBox txt) ///////////////////////////
        {
            try
            {
                String Cliente;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                cmb1.Items.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                   
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));//////////// REVISARRR!!!!!!!!!!!!
                        if (txt.Text == Cliente)
                        {
                            cmb1.Items.Add(fila["Patente"]);
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public String GetMaMo(Int32 IdAuto) ///////////////////////////
        {
            try
            {
                String Result = "";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdPatente"]) == IdAuto)
                        {
                            Result = Convert.ToString(fila["Marca"] + ", " + fila["Modelo"]);
                        }
                    }
                }

                conexion.Close();
                return Result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public String CantidadPorMarca(String Marca) ///////////////////////////
        {
            try
            {
                String Result = "";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToString(fila["Marca"]) == Marca)
                        {
                            Cantidad++;
                        }
                    }
                }
                Result = Cantidad.ToString();
                conexion.Close();
                return Result;
                
            }
            catch (Exception e) 
            {
                return e.ToString() ;
            }
        }

        public String GetMarca(Int32 idPatente) ///////////////////////////
        {
            try
            {
                String Result = "";
                Cantidad = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdPatente"]) == idPatente)
                        {
                            Result = Convert.ToString(fila["Marca"]);
                            Cantidad++;
                        }
                    }
                }

                conexion.Close();
                return Result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public String GetPatente(Int32 IdAuto) ///////////////////////////
        {
            try
            {
                String Result = "";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdPatente"]) == IdAuto)
                        {
                            Result = Convert.ToString(fila["Patente"]);
                        }
                    }
                }

                conexion.Close();
                return Result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public String GetIdPatente(String Patente) ///////////////////////////
        {
            try
            {
                String Result = "";
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToString(fila["Patente"]) == Patente)
                        {
                            Result = Convert.ToString(fila["IdPatente"]);
                        }
                    }
                }

                conexion.Close();
                return Result;
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        public void Listar(DataGridView dgv)///////////////////////////////////////
        {
            try
            {
                String Cliente;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                dgv.Rows.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));
                        dgv.Rows.Add(fila["Patente"], fila["Marca"], fila["Modelo"], Convert.ToInt32(fila["AñoLanzamiento"]),
                            fila["RepuestosVigentes"], Cliente);
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarCliente(DataGridView dgv, ComboBox cmb)//////////////////////////////////
        {
            try
            {
                String Cliente;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                dgv.Rows.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));
                        if (Cliente == cmb.Text) 
                        {
                            dgv.Rows.Add(fila["Patente"], fila["Marca"], fila["Modelo"], Convert.ToInt32(fila["AñoLanzamiento"]),
                            fila["RepuestosVigentes"], Cliente);
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void ListarMarca(DataGridView dgv, ComboBox cmb)//////////////////////////////////
        {
            try
            {
                String Cliente;
                String Marca;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                dgv.Rows.Clear();
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Marca = Convert.ToString(fila["Marca"]);
                        
                        if (Marca == cmb.Text)
                        {
                            Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));
                            dgv.Rows.Add(fila["Patente"], fila["Marca"], fila["Modelo"], Convert.ToInt32(fila["AñoLanzamiento"]),
                            fila["RepuestosVigentes"], Cliente);
                        }
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }
        }

        public void Exportar(String NomRep)
        {
            try
            {
                String Cliente;
                Int32 cantidad = 0;
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                if (NomRep != "")
                {
                    StreamWriter AD = new StreamWriter(NomRep, false, Encoding.UTF8);
                    AD.WriteLine("Listado de Autos\n");
                    AD.WriteLine("Patente, Marca, Modelo, AñoLanzamiento, RepuestosVigentes, Propietario\n");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila in DS.Tables[Tabla].Rows)
                        {
                            Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));

                            AD.Write(Convert.ToInt32(fila["IdPatente"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Patente"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Marca"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Modelo"]));
                            AD.Write(',');
                            AD.Write(Convert.ToInt32(fila["AñoLanzamiento"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["RepuestosVigentes"]));
                            AD.Write(',');
                            AD.WriteLine(Cliente);
                            cantidad++;
                        }
                        AD.Write("Cantidad de Autos:,,");
                        AD.WriteLine(cantidad);
                    }
                    MessageBox.Show("Archivo Generado con Exito!\n" + NomRep);
                    AD.Close();
                }
                else 
                {
                    MessageBox.Show("Ingrese Nombre Porfavor!");
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Estadistica(Chart chart, Int32 AñoMenor, Int32 AñoMayor)
        {
            try
            {
                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);
                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["AñoLanzamiento"]) >= AñoMenor &&
                            Convert.ToInt32(fila["AñoLanzamiento"]) <= AñoMayor)
                        {
                            Series serie = chart.Series.Add(fila["Marca"].ToString());


                            serie.Label = Cantidad.ToString();
                            //String x = Convert.ToString(fila["Marca"]);/////////////Corregir
                            //CantidadXMarca = CantidadPorMarca(x);/////////////Corregir

                            serie.Points.Add(Cantidad);
                        }

                    }
                }
                conexion.Close();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void ImprimirGrafico(Chart chartVentas, TextBox Inicio, TextBox Fin)
        {
            PrintDocument documento = new PrintDocument();

            documento.PrintPage += (s, ev) =>
            {

                ChartArea chartArea = chartVentas.ChartAreas[0];
                Bitmap bitmap = new Bitmap(chartVentas.Width, chartVentas.Height);
                chartVentas.DrawToBitmap(bitmap, chartVentas.ClientRectangle);


                ev.Graphics.DrawImage(bitmap, ev.MarginBounds.Left, ev.MarginBounds.Top);


                string titulo = "Grafica de Autos";
                Font fuenteTitulo = new Font("Arial", 12, FontStyle.Underline);
                float posicionTituloY = ev.MarginBounds.Top - 70;
                ev.Graphics.DrawString(titulo, fuenteTitulo, System.Drawing.Brushes.BlueViolet, ev.MarginBounds.Left, posicionTituloY);
            };

            using (PrintPreviewDialog dialogoPrevisualizacion = new PrintPreviewDialog())
            {
                dialogoPrevisualizacion.Document = documento;
                dialogoPrevisualizacion.ShowDialog();
            }

            if (MessageBox.Show("¿Desea imprimir el gráfico?", "Imprimir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (PrintDialog dialogoImpresion = new PrintDialog())
                {
                    dialogoImpresion.Document = documento;
                    if (dialogoImpresion.ShowDialog() == DialogResult.OK)
                    {
                        documento.Print();
                    }
                }
            }
        }

        public void ImprimirAutos(PrintPageEventArgs rep)//////////////////////////////////
        {
            try
            {
                String Cliente;
                Cantidad = 0;
                img = Image.FromFile(@"C:\Users\54228\Documents\Analista en Sistemas\Práctica Profesionalizante 1 de Informática - Laboratorio 3 (A)\Ejercicios Lab 3\TP1Lab3 - Copy - Trabajo Parcial\TP1Lab3\bin\Debug\Fondo nebulosa claro.jpg");
                int f = 122;


                Font TypeLetterT = new Font("Calibri", 20);
                Font TypeLetterH = new Font("Calibri", 16);
                Font TypeLetter = new Font("Calibri", 12);
                rep.Graphics.DrawString("Listado de Autos", TypeLetterT, Brushes.Black, 300, 70);
                rep.Graphics.DrawString("Patente", TypeLetterH, Brushes.MidnightBlue, 50, 100);
                rep.Graphics.DrawString("Marca", TypeLetterH, Brushes.MidnightBlue, 200, 100);
                rep.Graphics.DrawString("Modelo", TypeLetterH, Brushes.MidnightBlue, 300, 100);
                rep.Graphics.DrawString("Año", TypeLetterH, Brushes.MidnightBlue, 400, 100);
                rep.Graphics.DrawString("Repuestos Vigentes", TypeLetterH, Brushes.MidnightBlue, 506, 100);
                rep.Graphics.DrawString("Cliente", TypeLetterH, Brushes.MidnightBlue, 704, 100);
                //rep.Graphics.DrawString("Deuda", TypeLetterH, Brushes.MidnightBlue, 744, 100);

                conexion.ConnectionString = CadenaConexion;
                conexion.Open();

                comando.Connection = conexion;
                comando.CommandType = CommandType.TableDirect;
                comando.CommandText = Tabla;

                adaptador = new OleDbDataAdapter(comando);
                DataSet DS = new DataSet();
                adaptador.Fill(DS, Tabla);

                if (DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));
                        rep.Graphics.DrawString(fila["Patente"].ToString(), TypeLetter, Brushes.Black, 50, f);
                        rep.Graphics.DrawString(fila["Marca"].ToString(), TypeLetter, Brushes.Black, 200, f);
                        rep.Graphics.DrawString(fila["Modelo"].ToString(), TypeLetter, Brushes.Black, 300, f);
                        rep.Graphics.DrawString(fila["AñoLanzamiento"].ToString(), TypeLetter, Brushes.Black, 400, f);
                        rep.Graphics.DrawString(fila["RepuestosVigentes"].ToString(), TypeLetter, Brushes.Black, 506, f);
                        rep.Graphics.DrawString(Cliente, TypeLetter, Brushes.Black, 704, f);
                        //rep.Graphics.DrawString(Convert.ToString(fila["Deuda"]), TypeLetter, Brushes.Black, 744, f);
                        f = f + 18;
                        Cantidad++;
                    }
                }
                rep.Graphics.DrawString("Cantidad de Autos: " + Cantidad.ToString(), TypeLetter, Brushes.MidnightBlue, 70, f + 36);

                rep.Graphics.DrawImage(img, 70, f + 90, 700, 300);
                rep.Graphics.Dispose();
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }

}
