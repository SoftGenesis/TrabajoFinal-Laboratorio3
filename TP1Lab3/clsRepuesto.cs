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
    internal class clsRepuesto
    {
        private OleDbConnection conexion = new OleDbConnection();
        private OleDbCommand comando = new OleDbCommand();
        private OleDbDataAdapter adaptador = new OleDbDataAdapter();

        private String CadenaConexion = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDMecanico.mdb";
        private String Tabla = "TRepuesto";
        Image img;
        private String nombrer;
        private String marca;
        private String codigor;
        private Decimal valorfinaltotal;
        private Int32 cantidad;
        
        private Decimal porunidad;

        public String NombreR
        {
            get { return nombrer; }
            set { nombrer = value; }
        }

        public String Marca 
        {
            get { return marca; }
            set { marca = value; }
        }

        public String CodigoR
        {
            get { return codigor; }
            set { codigor = value; }
        }

        public Decimal ValorFinalTotal
        {
            get { return valorfinaltotal; }
            set { valorfinaltotal = value; }
        }

        public Int32 Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        public Decimal PoruUnidad
        {
            get { return porunidad; }
            set { porunidad = value; }
        }

        public void Agregar()////////////////////////////////////////////////
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
                fila["NombreR"] = nombrer;
                fila["Marca"] = marca;
                fila["CodigoR"] = codigor;
                fila["Cantidad"] = cantidad;
                fila["ValorFinalTotal"] = valorfinaltotal;
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

        public void ListarCombo(ComboBox cmb)///////////////////////////////////////
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
                cmb.DisplayMember = "NombreR";
                cmb.ValueMember = "IdRepuesto";

                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void Listar(DataGridView dgv)
        {
            try
            {
                porunidad = 0;
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
                        porunidad = Convert.ToDecimal(fila["ValorFinalTotal"]) / Convert.ToInt32(fila["Cantidad"]);
                        dgv.Rows.Add(fila["NombreR"], fila["Marca"], fila["CodigoR"], Convert.ToInt32(fila["Cantidad"]), 
                            Convert.ToDecimal(fila["ValorFinalTotal"]), porunidad);
                       
                    }
                }
                conexion.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public void ListarMa(DataGridView dgv, ComboBox cmb)
        {
            try
            {
                porunidad = 0;
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
                        if (Convert.ToString(fila["Marca"]) == cmb.Text)
                        {
                            porunidad = Convert.ToDecimal(fila["ValorFinalTotal"]) / Convert.ToInt32(fila["Cantidad"]);
                            dgv.Rows.Add(fila["NombreR"], null, fila["CodigoR"], Convert.ToInt32(fila["Cantidad"]),
                                Convert.ToDecimal(fila["ValorFinalTotal"]), porunidad);
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

        public String GetRepuesto (Int32 IdRepuesto)////////////////////////////////////////////////
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
                if(DS.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow fila in DS.Tables[Tabla].Rows)
                    {
                        if (Convert.ToInt32(fila["IdRepuesto"]) == IdRepuesto) 
                        {
                            Result = Convert.ToString(fila["NombreR"]);
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

        public void ListarComboMa(ComboBox cmb)/////////////////////////////////////////////////////////
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
                cmb.ValueMember = "IdRepuesto";

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
                Decimal ValorXUnidad;
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
                    AD.WriteLine("Listado de Repuestos");
                    AD.WriteLine("IdRepuesto, Nombre del Repuesto, Marca, Codigo del Repuesto, Cantidad, Valor por Unidad, Valor Total del Repuesto\n");
                    if (DS.Tables[0].Rows.Count > 0)
                    {
                        foreach (DataRow fila in DS.Tables[Tabla].Rows)
                        {
                            Int32 Cantidad = Convert.ToInt32(fila["Cantidad"]);
                            Decimal ValorTotalXRepuesto = Convert.ToDecimal(fila["ValorFinalTotal"]);
                            ValorXUnidad = ValorTotalXRepuesto / Cantidad;

                            AD.Write(Convert.ToInt32(fila["IdRepuesto"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["NombreR"]));
                            AD.Write(',');
                            AD.Write(Convert.ToString(fila["Marca"]));
                            AD.Write(',');
                            AD.Write(Convert.ToInt32(fila["CodigoR"]));
                            AD.Write(',');
                            AD.Write(Cantidad);
                            AD.Write(',');
                            AD.Write(ValorXUnidad);
                            AD.Write(',');
                            AD.WriteLine(ValorTotalXRepuesto);
                            cantidad++;
                        }
                        AD.Write("Cantidad Total de Repuestos:,,");
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

        public void ImprimirRepuestos(PrintPageEventArgs rep)//////////////////////////////////
        {
            try
            {
                Decimal ValorUnidad = 0;
                Cantidad = 0;
                img = Image.FromFile(@"C:\Users\54228\Documents\Analista en Sistemas\Práctica Profesionalizante 1 de Informática - Laboratorio 3 (A)\Ejercicios Lab 3\TP1Lab3 - Copy - Trabajo Parcial\TP1Lab3\bin\Debug\Fondo nebulosa claro.jpg");
                int f = 122;


                Font TypeLetterT = new Font("Calibri", 20);
                Font TypeLetterH = new Font("Calibri", 16);
                Font TypeLetter = new Font("Calibri", 12);
                rep.Graphics.DrawString("Listado de Repuestos", TypeLetterT, Brushes.Black, 300, 70);
                rep.Graphics.DrawString("Id", TypeLetterH, Brushes.MidnightBlue, 20, 100);
                rep.Graphics.DrawString("Nombre", TypeLetterH, Brushes.MidnightBlue, 60, 100);
                rep.Graphics.DrawString("Marca", TypeLetterH, Brushes.MidnightBlue, 200, 100);
                rep.Graphics.DrawString("Codigo", TypeLetterH, Brushes.MidnightBlue, 300, 100);
                rep.Graphics.DrawString("Cantidad", TypeLetterH, Brushes.MidnightBlue, 426, 100);
                rep.Graphics.DrawString("Valor por Unidad", TypeLetterH, Brushes.MidnightBlue, 544, 100);
                rep.Graphics.DrawString("Valor Total", TypeLetterH, Brushes.MidnightBlue, 744, 100);

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
                        ValorUnidad = Convert.ToDecimal(fila["ValorFinalTotal"]) / Convert.ToInt32(fila["Cantidad"]);
                        rep.Graphics.DrawString(fila["IdRepuesto"].ToString(), TypeLetter, Brushes.Black, 20, f);
                        rep.Graphics.DrawString(fila["NombreR"].ToString(), TypeLetter, Brushes.Black, 60, f);
                        rep.Graphics.DrawString(fila["Marca"].ToString(), TypeLetter, Brushes.Black, 200, f);
                        rep.Graphics.DrawString(fila["CodigoR"].ToString(), TypeLetter, Brushes.Black, 300, f);
                        rep.Graphics.DrawString(fila["Cantidad"].ToString(), TypeLetter, Brushes.Black, 426, f);
                        rep.Graphics.DrawString(Convert.ToString(ValorUnidad), TypeLetter, Brushes.Black, 544, f);
                        rep.Graphics.DrawString(Convert.ToString(fila["ValorFinalTotal"]), TypeLetter, Brushes.Black, 744, f);
                        f = f + 18;
                        Cantidad++;
                    }
                }
                rep.Graphics.DrawString("Cantidad de Repuestos: " + Cantidad.ToString(), TypeLetter, Brushes.MidnightBlue, 70, f + 36);

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
