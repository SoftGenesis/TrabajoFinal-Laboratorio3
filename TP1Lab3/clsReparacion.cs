using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.IO;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms.DataVisualization.Charting;

namespace TP1Lab3
{
    internal class clsReparacion
    {
        clsClienteMain c = new clsClienteMain();
        clsAuto a = new clsAuto();
        clsRepuesto ru = new clsRepuesto();

        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();
        Image img;
        private String CadenaConexion = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = BDMecanico.mdb";
        private String Tabla = "TReparacion";

        private String reparacion;
        private DateTime fecha;
        private String falla;
        private Int32 idrepuesto;
        private Int32 idpatente;
        private Int32 idcliente;
        private Int32 cantidad;

        public String Reparacion
        {
            get { return reparacion; }
            set { reparacion = value; }
        }

        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        public String Falla
        {
            get { return falla; }
            set { falla = value; }
        }

        public Int32 Idrepuesto
        {
            get { return idrepuesto; }
            set { idrepuesto = value; }
        }

        public Int32 Idpatente
        {
            get { return idpatente; }
            set { idpatente = value; }
        }

        public Int32 Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }

        public Int32 Cantidad
        {
            get => cantidad;
            set => cantidad = value;
        }

        public void Agregar()/////////////////////////////////////////////////
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
                fila["Reparacion"] = reparacion;
                fila["Fecha"] = fecha;
                fila["Falla"] = falla;
                fila["IdRepuesto"] = idrepuesto;
                fila["IdPatente"] = idpatente;
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



        public void ListarCombo(ComboBox cmb)//////////////////////////////
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
                cmb.DisplayMember = "Reparacion";
                cmb.ValueMember = "IdReparacion";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Listar(DataGridView dgv)///////////////////////////////////////////////////////
        {
            try
            {
                String MaMo = "";
                String Repuesto = "";
                String Cliente = "";

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
                        MaMo = a.GetMarca(Convert.ToInt32(fila["IdPatente"]));
                        Repuesto = ru.GetRepuesto(Convert.ToInt32(fila["IdRepuesto"]));
                        Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));

                        dgv.Rows.Add(fila["Reparacion"], fila["Fecha"], fila["Falla"], Repuesto, MaMo, Cliente);
                    }
                }

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarA(DataGridView dgv, ComboBox cmb)
        {
            try
            {
                String MaMo = "";
                String Repuesto = "";
                String Cliente = "";
                String Patente = "";

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
                        Patente = a.GetPatente(Convert.ToInt32(fila["IdPatente"]));
                        if (Convert.ToInt32(fila["IdPatente"]) == Convert.ToInt32(cmb.SelectedValue))
                        {
                            MaMo = a.GetMarca(Convert.ToInt32(fila["IdPatente"]));
                            Repuesto = ru.GetRepuesto(Convert.ToInt32(fila["IdRepuesto"]));
                            Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));

                            dgv.Rows.Add(fila["Reparacion"], fila["Fecha"], fila["Falla"], Repuesto, MaMo, Cliente);
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

        public void ListarC(DataGridView dgv, ComboBox cmb)
        {
            try
            {
                String MaMo = "";
                String Repuesto = "";
                String Cliente = "";

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
                            MaMo = a.GetMaMo(Convert.ToInt32(fila["IdPatente"]));
                            Repuesto = ru.GetRepuesto(Convert.ToInt32(fila["IdRepuesto"]));
                            dgv.Rows.Add(fila["Reparacion"], fila["Fecha"], fila["Falla"], Repuesto, MaMo, Cliente);
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

        public String GetRa(Int32 IdCli) //////////////////////////////////
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
                        if (Convert.ToInt32(fila["IdCliente"]) == IdCli)
                        {
                            Result = Convert.ToString(fila["Reparacion"]);
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

        public void Exportar(String NomRep)
        {
            try
            {
                Int32 cantidad = 0;
                String Repuesto;
                String Patente;
                String Cliente;
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
                    AD.WriteLine("Listado de Reparaciones\n");
                    AD.WriteLine("Reparacion, Fecha, Falla, Repuesto, Patente, Cliente\n");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila in DS.Tables[Tabla].Rows)
                        {
                            Repuesto = ru.GetRepuesto(Convert.ToInt32(fila["IdRepuesto"]));
                            Patente = a.GetPatente(Convert.ToInt32(fila["IdPatente"]));
                            Cliente = c.GetCliente(Convert.ToInt32(fila["IdCliente"]));

                            AD.Write(Convert.ToString(fila["Reparacion"]));
                            AD.Write(',');
                            AD.Write(Convert.ToDateTime(fila["Fecha"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Falla"]));
                            AD.Write(',');
                            AD.Write(Repuesto);
                            AD.Write(',');
                            AD.Write(Patente);
                            AD.Write(',');
                            AD.WriteLine(Cliente);
                            cantidad++;
                        }
                        AD.Write("Cantidad de Reparaciones:,,");
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

        public void ImprimirReparaciones(PrintPageEventArgs rep)//////////////////////////////////
        {
            try
            {
                String Cliente;
                String Repuesto;
                String Patente;
                String MaMo;
                Cantidad = 0;
                img = Image.FromFile(@"C:\Users\54228\Documents\Analista en Sistemas\Práctica Profesionalizante 1 de Informática - Laboratorio 3 (A)\Ejercicios Lab 3\TP1Lab3 - Copy - Trabajo Parcial\TP1Lab3\bin\Debug\Fondo nebulosa claro.jpg");
                int f = 122;


                Font TypeLetterT = new Font("Calibri", 20);
                Font TypeLetterH = new Font("Calibri", 15);
                Font TypeLetterMaMoPa = new Font("Calibri", 12);
                Font TypeLetter = new Font("Calibri", 10);
                rep.Graphics.DrawString("Listado de Reparaciones", TypeLetterT, Brushes.Black, 300, 70);
                rep.Graphics.DrawString("Id", TypeLetterH, Brushes.MidnightBlue, 10, 100);
                rep.Graphics.DrawString("Reparacion", TypeLetterH, Brushes.MidnightBlue, 30, 100);
                rep.Graphics.DrawString("Falla", TypeLetterH, Brushes.MidnightBlue, 210, 100);
                rep.Graphics.DrawString("Fecha", TypeLetterH, Brushes.MidnightBlue, 290, 100);
                rep.Graphics.DrawString("Repuesto", TypeLetterH, Brushes.MidnightBlue, 450, 100);
                rep.Graphics.DrawString("Marca/Modelo/Patente", TypeLetterMaMoPa, Brushes.MidnightBlue, 569, 100);
                rep.Graphics.DrawString("Cliente", TypeLetterH, Brushes.MidnightBlue, 740, 100);

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
                        Repuesto = ru.GetRepuesto(Convert.ToInt32(fila["IdRepuesto"]));
                        Patente = a.GetPatente(Convert.ToInt32(fila["IdPatente"]));
                        MaMo = a.GetMaMo(Convert.ToInt32(fila["IdPatente"]));
                        rep.Graphics.DrawString(fila["IdReparacion"].ToString(), TypeLetter, Brushes.Black, 10, f);
                        rep.Graphics.DrawString(fila["Reparacion"].ToString(), TypeLetter, Brushes.Black, 30, f);
                        rep.Graphics.DrawString(Convert.ToString(fila["Falla"]), TypeLetter, Brushes.Black, 210, f);
                        rep.Graphics.DrawString(Convert.ToString(fila["Fecha"]), TypeLetter, Brushes.Black, 290, f);
                        rep.Graphics.DrawString(Repuesto, TypeLetter, Brushes.Black, 450, f);
                        rep.Graphics.DrawString(MaMo, TypeLetter, Brushes.Black, 569, f);
                        rep.Graphics.DrawString(Patente, TypeLetter, Brushes.Black, 680, f);
                        rep.Graphics.DrawString(Cliente, TypeLetter, Brushes.Black, 740, f);
                        f = f + 18;
                        Cantidad++;
                    }
                }
                rep.Graphics.DrawString("Cantidad de Reparaciones: " + Cantidad.ToString(), TypeLetter, Brushes.MidnightBlue, 70, f + 36);

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
