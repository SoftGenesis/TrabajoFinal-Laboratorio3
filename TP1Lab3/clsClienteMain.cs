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


namespace TP1Lab3
{
    internal class clsClienteMain
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDMecanico.mdb";
        private String Tabla = "Cliente";

        Image img;

        private String name;
        private String mail;
        private String address;
        private Int32 phone;
        private DateTime date;
        private Decimal deuda;
        private Int32 cantidad;
        

        public String Nombre 
        {
            get { return name; }
            set { name = value; }
        }

        public String Mail 
        {
            get { return mail; }
            set { mail = value; }
        }

        public String Direccion 
        {
            get { return address; }
            set { address = value; }
        }

        public Int32 Telefono 
        {
            get { return phone; }
            set { phone = value; }
        }

        public DateTime Fecha 
        {
            get { return date; }
            set { date = value; }
        }
        public Int32 Cantidad 
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public Decimal Deuda
        {
            get { return deuda; }
            set { deuda = value; }
        }

        public AutoCompleteStringCollection CargarDatosTxt()
        {
            AutoCompleteStringCollection datos = new AutoCompleteStringCollection();

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
                    datos.Add(Convert.ToString(fila["Propietario"]));
                }
            }
            conexion.Close();
            return datos;
        }

        public void Agregar() /////////////////////////////////////////
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
                adaptador.Fill(DS,Tabla);
                DataTable tabla = DS.Tables[Tabla];
                DataRow fila = tabla.NewRow();
                fila["Propietario"] = name;
                fila["Telefono"] = phone;
                fila["Direccion"] = address;
                fila["Mail"] = mail;
                fila["Fecha"] = date;
                fila["Deuda"] = deuda;
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

        public void Exportar(String NomRep) 
        {
            try
            {
                cantidad = 0;
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
                    AD.WriteLine("Listado de Clientes\n");
                    AD.WriteLine("IdCliente, Propietario, Telefono, Direccion, Mail, Fecha\n");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila in DS.Tables[Tabla].Rows)
                        {
                            AD.Write(Convert.ToInt32(fila["IdCliente"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Propietario"]));
                            AD.Write(',');
                            AD.Write(Convert.ToInt32(fila["Telefono"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Direccion"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Mail"]));
                            AD.Write(',');
                            AD.WriteLine(Convert.ToDateTime(fila["Fecha"]));
                            cantidad++;
                        }
                        AD.Write("Cantidad de Clientes:,,");
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
            catch(Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarCombo(ComboBox cmb)///////////
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
                cmb.DisplayMember = "Propietario";
                cmb.ValueMember = "IdCliente";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Listar(DataGridView dgv, Label lblC, Label lblD)/////////////////////////////////////////////// 
        {
            try
            {
                cantidad = 0;
                deuda = 0;

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
                        dgv.Rows.Add(fila["Propietario"], Convert.ToInt32(fila["Telefono"]), fila["Direccion"], fila["Mail"],
                            Convert.ToDateTime(fila["Fecha"]), Convert.ToDecimal(fila["Deuda"]));
                        cantidad++;
                        deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                    }
                }
                lblC.Text = cantidad.ToString();
                lblD.Text = deuda.ToString("0.00");
                conexion.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarDeu(DataGridView dgv, Label lblC, Label lblD)////////////////////////////////////////////////
        {
            try
            {
                cantidad = 0;
                deuda = 0;
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
                        if (Convert.ToDecimal(fila["Deuda"]) > 0) 
                        {
                            dgv.Rows.Add(fila["Propietario"], Convert.ToInt32(fila["Telefono"]), fila["Direccion"], fila["Mail"],
                                Convert.ToDateTime(fila["Fecha"]), Convert.ToDecimal(fila["Deuda"]));
                            cantidad++;
                            deuda = deuda + Convert.ToDecimal(fila["Deuda"]);
                        }
                    }
                }
                lblC.Text = cantidad.ToString();
                lblD.Text = deuda.ToString("0.00");
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public String GetCliente(Int32 IdCliente)//////////////////////////////
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
                        if (Convert.ToInt32(fila["IdCliente"]) == IdCliente)
                        {
                            Result = Convert.ToString(fila["Propietario"]);
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

        public String GetClienteD(Int32 IdCliente)//////////////////////////////
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
                        if (Convert.ToInt32(fila["IdCliente"]) == IdCliente)
                        {
                            if (Convert.ToDecimal(fila["Deuda"]) > 0)
                            {
                                Result = Convert.ToString(fila["Deuda"]);
                            }
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

        public String GetIdCliente(String Cliente) ///////////////////////////
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
                        if (Convert.ToString(fila["Propietario"]) == Cliente)
                        {
                            Result = Convert.ToString(fila["IdCliente"]);
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

        public void ImprimirClientes(PrintPageEventArgs rep)//////////////////////////////////
        {
            try
            {
                cantidad = 0;
                Decimal TotDeu = 0;
                Decimal PromedioDeuda = 0;
                img = Image.FromFile(@"C:\Users\54228\Documents\Analista en Sistemas\Práctica Profesionalizante 1 de Informática - Laboratorio 3 (A)\Ejercicios Lab 3\TP1Lab3 - Copy - Trabajo Parcial\TP1Lab3\bin\Debug\Fondo nebulosa claro.jpg");
                int f = 122;


                Font TypeLetterT = new Font("Calibri", 20);
                Font TypeLetterH = new Font("Calibri", 16);
                Font TypeLetter = new Font("Calibri", 12);
                rep.Graphics.DrawString("Listado de Clientes", TypeLetterT, Brushes.Black, 300, 70);
                rep.Graphics.DrawString("Id", TypeLetterH, Brushes.MidnightBlue, 20, 100);
                rep.Graphics.DrawString("Nombre", TypeLetterH, Brushes.MidnightBlue, 50, 100);
                rep.Graphics.DrawString("Telefono", TypeLetterH, Brushes.MidnightBlue, 160, 100);
                rep.Graphics.DrawString("Direccion", TypeLetterH, Brushes.MidnightBlue, 260, 100);
                rep.Graphics.DrawString("Mail", TypeLetterH, Brushes.MidnightBlue, 426, 100);
                rep.Graphics.DrawString("Fecha", TypeLetterH, Brushes.MidnightBlue, 594, 100);
                rep.Graphics.DrawString("Deuda", TypeLetterH, Brushes.MidnightBlue, 744, 100);

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
                        rep.Graphics.DrawString(fila["IdCliente"].ToString(), TypeLetter, Brushes.Black, 20, f);
                        rep.Graphics.DrawString(fila["Propietario"].ToString(), TypeLetter, Brushes.Black, 50, f);
                        rep.Graphics.DrawString(fila["Telefono"].ToString(), TypeLetter, Brushes.Black, 160, f);
                        rep.Graphics.DrawString(fila["Direccion"].ToString(), TypeLetter, Brushes.Black, 260, f);
                        rep.Graphics.DrawString(fila["Mail"].ToString(), TypeLetter, Brushes.Black, 426, f);
                        rep.Graphics.DrawString(Convert.ToString(fila["Fecha"]), TypeLetter, Brushes.Black, 594, f);
                        rep.Graphics.DrawString(Convert.ToString(fila["Deuda"]), TypeLetter, Brushes.Black, 744, f);
                        f = f + 18;
                        cantidad++;
                        TotDeu = TotDeu + Convert.ToDecimal(fila["Deuda"]);
                    }
                }
                PromedioDeuda = TotDeu / cantidad;
                rep.Graphics.DrawString("Cantidad de Clientes: " + cantidad.ToString(), TypeLetter, Brushes.MidnightBlue, 70, f + 36);
                rep.Graphics.DrawString("Total de Deuda: " + TotDeu.ToString(), TypeLetter, Brushes.Maroon, 70, f + 54);
                rep.Graphics.DrawString("Promedio de Deuda: " + PromedioDeuda.ToString(), TypeLetter, Brushes.MidnightBlue, 70, f + 72);

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
