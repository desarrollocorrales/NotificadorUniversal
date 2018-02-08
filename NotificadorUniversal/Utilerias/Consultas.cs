using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using NotificadorUniversal.Modelos;
using System.Data.EntityClient;

namespace NotificadorUniversal.Utilerias
{
    public class Consultas
    {
        public usuarios InicarSesion(string user, string pass)
        {
            try
            {
                Seguridad objSeguridad = new Seguridad();
                string contrasenia = pass; // objSeguridad.Encriptar(pass);
                using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                {
                    usuarios login = Ctx.usuarios.FirstOrDefault(o => o.usuario == user && o.clave == contrasenia && o.status == 2);
                    if (login == null)
                        return login;
                    else{
                        return login;
                    }
                }                
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<notificaciones> BuscarNotificaciones(int idSucursal, int idUsuario)
        {
            try{
                List<notificaciones> LstResultado = new List<notificaciones>();
                List<notificaciones> LstResultadoidUsuario = new List<notificaciones>();
                using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                {
                    LstResultado = (from n in Ctx.notificaciones where n.idsucursal == idSucursal && n.estatus == 1 select n).ToList(); //&& n.idusuario == idUsuario

                    //if (LstResultado.Count > 0)
                    //{
                    //    LstResultadoidUsuario = (from lru in LstResultado where lru.idusuario == idUsuario select lru).ToList();
                    //}

                }
                return LstResultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void ObtenerSucursales(ComboBox cmb, int idEmpresa = 0)
        {
            try{
                using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                {
                    List<ordenes_empresas> lst_empresas = (from ta in Ctx.ordenes_empresas orderby ta.nombreempresa select ta).ToList();
                    cmb.ValueMember = "idempresa";
                    cmb.DisplayMember = "nombrecorto";
                    cmb.DataSource = lst_empresas;
                    cmb.SelectedIndex = -1;

                    if (idEmpresa > 0)
                    {
                        int x = 0;
                        foreach (ordenes_empresas elemento in ((List<ordenes_empresas>)cmb.DataSource))
                        {
                            if (elemento.idempresa == idEmpresa)
                            {
                                cmb.SelectedIndex = x;
                                break;
                            }
                            x++;
                        }
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        public void ObtenerUsuarios(ComboBox cmb, int idEmpresa, int idUsuario = 0)
        {
            try
            {
                using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                {
                    List<usuarios> lst_usuarios = (from u in Ctx.usuarios where u.idempresa == idEmpresa orderby u.usuario select u).ToList();
                    cmb.ValueMember = "idusuario";
                    cmb.DisplayMember = "usuario";
                    cmb.DataSource = lst_usuarios;
                    cmb.SelectedIndex = -1;

                    if (idUsuario > 0)
                    {
                        int x = 0;
                        foreach (usuarios elemento in ((List<usuarios>)cmb.DataSource))
                        {
                            if (elemento.idusuario == idUsuario)
                            {
                                cmb.SelectedIndex = x;
                                break;
                            }
                            x++;
                        }
                    }
                }
            }
            catch (Exception ex)
            { throw ex; }
        }

        //MySQL
        private static MySqlConnection myConn = new MySqlConnection();
        private static MySqlCommand myComm = new MySqlCommand();
        private static MySqlDataAdapter myAdapter = new MySqlDataAdapter();

        private static string obtenerStringDeConexion()
        {
            var Config = Properties.Settings.Default;

            MySqlConnectionStringBuilder cs = new MySqlConnectionStringBuilder();
            cs.Server = Config.Servidor;
            cs.UserID = Config.Usuario;
            cs.Password = new Seguridad().Base64Decode(Config.Contrasenia); //Config.Contrasenia; //
            cs.Port = Convert.ToUInt32("3306");
            cs.Database = Config.BaseDeDatos == "base de datos" ? "corrales_sistema" : Config.BaseDeDatos;
            cs.PersistSecurityInfo = false;

            return cs.ToString();
        }

        public List<string> ObtenerBasesDeDatos()
        {
            List<string> lstBasesDeDatos = new List<string>();

            try
            {
                myConn.ConnectionString = obtenerStringDeConexion();
                myConn.Open();

                myComm.Connection = myConn;
                myComm.CommandText = "Show Databases";

                DataTable dt = new DataTable();
                myAdapter.SelectCommand = myComm;
                myAdapter.Fill(dt);

                foreach (DataRow fila in dt.Rows)
                {
                    lstBasesDeDatos.Add(Convert.ToString(fila[0]));
                }

                myConn.Close();
            }
            catch (Exception ex)
            {
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
                throw ex;
            }

            return lstBasesDeDatos;
        }

        public bool ProbarConexion(string server, string usuario, string pass)
        {
            try{
                var Config = Properties.Settings.Default;

                MySqlConnectionStringBuilder cs = new MySqlConnectionStringBuilder();
                cs.Server = server;
                cs.UserID = usuario;
                cs.Password = pass; // new Seguridad().Base64Decode(pass);
                cs.Port = Convert.ToUInt32("3306");
                cs.Database = Config.BaseDeDatos == "base de datos" ? "corrales_sistema" : Config.BaseDeDatos;

                myConn.Open();
                return true;

            }
            catch (Exception ex)
            {
                if (myConn.State != ConnectionState.Closed)
                    myConn.Close();
                throw ex;
            }
        }

        public void ConexionModelo(string server, string user, string pass, string database)
        {
            try
            {
                // Initialize the EntityConnectionStringBuilder.
                EntityConnectionStringBuilder entityBuilder =
                    new EntityConnectionStringBuilder();

                //
                //entityBuilder.Name = "corrales_sistemaEntities";
                //Set the provider name.
                entityBuilder.Provider = "MySql.Data.MySqlClient";

                // Set the provider-specific connection string.
                string BD = string.Empty;
                if (database == "base de datos") { BD = "corrales_sistema"; }
                entityBuilder.ProviderConnectionString = "server=" + server + ";user id=" + user + ";password=" + pass + ";persistsecurityinfo=True;database="+BD;

                             // Set the Metadata location.
                             entityBuilder.Metadata = "res://*/Modelos.sistemasCorrales.csdl|res://*/Modelos.sistemasCorrales.ssdl|res://*/Modelos.sistemasCorrales.msl";
                Console.WriteLine(entityBuilder.ToString());

                using (EntityConnection conn =
                    new EntityConnection(entityBuilder.ToString()))
                {
                    conn.Open();
                    //Console.WriteLine("Just testing the connection.");
                    conn.Close();
                }
            }
            catch (Exception ex)
            { throw ex; }
        }
    }
}
