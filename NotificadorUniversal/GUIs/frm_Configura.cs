using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NotificadorUniversal.Utilerias;
using firmas.GUIs;
using NotificadorUniversal.Modelos;
using DevExpress.XtraBars.Alerter;
using System.Diagnostics;
using ExpandCollapsePanelDemo.GUIs;

namespace NotificadorUniversal.GUIs
{
    public partial class frm_Configura : Form
    {
        #region Variables
        Consultas objConsultas = new Consultas(); Efectos objEfectos = new Efectos(); Sesion SesionActiva = new Sesion(); Seguridad objUtilerias = new Seguridad();
        private frm_Configura frmLanzador;
        List<notificaciones> lstNoti;
        #endregion

        #region Constructor

        public frm_Configura()
        {
            InitializeComponent();
        }

        public frm_Configura(frm_Configura frmLanzador)
        {
            InitializeComponent();
            this.frmLanzador = frmLanzador;
        }

        private void frm_Configura_Load(object sender, EventArgs e)
        {
            var Config = Properties.Settings.Default;

            System.Reflection.Assembly assembly = System.Reflection.Assembly.GetExecutingAssembly();
            FileVersionInfo fvi = FileVersionInfo.GetVersionInfo(assembly.Location);
            lblVersion1.Text = fvi.FileVersion; // +" Copyright ©  2018";

            txbSegundos.Text = Config.Segundos.ToString();

            txbServidor.Text = Config.Servidor;
            txbUsuario.Text = Config.Usuario;
            txbContraseña.Text = new Seguridad().Base64Decode(Config.Contrasenia); //Config.Contrasenia; //


            if (Config.BaseDeDatos != "base de datos")
            {
                CargarBasesDeDatos();
                cmbBasesDeDatos.SelectedItem = Config.BaseDeDatos;
                cmbBasesDeDatos_SelectionChangeCommitted(null, null);
            }

            if (Config.Servidor != "servidor")
            {
                tmAccion.Interval = Config.Segundos * 1000;
                tmAccion.Start();
            }

        }

        private void frm_Configura_Shown(object sender, EventArgs e)
        {
            this.Hide();
        }
        #endregion

        #region Eventos

        #region Efectos
        private void peGCxn_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peGCxn, NotificadorUniversal.Properties.Resources.right_arrow_1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void peGCxn_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peGCxn, NotificadorUniversal.Properties.Resources.right_arrow_0);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void pePlay_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(pePlay, NotificadorUniversal.Properties.Resources.next_1_12);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void pePlay_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(pePlay, NotificadorUniversal.Properties.Resources.next_1_1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void peSalir_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peSalir, NotificadorUniversal.Properties.Resources.cerrar1);
                peSalir.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void peSalir_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peSalir, NotificadorUniversal.Properties.Resources.cerrar2);
                peSalir.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        #endregion

        private void peSalir_Click(object sender, EventArgs e)
        {
            try
            {
                tmAccion.Start();
                this.Hide();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peGCxn_Click(object sender, EventArgs e)
        {
            try
            {
                if (txbServidor.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre del Servidor."); }
                if (txbUsuario.Text.Trim() == "") { throw new Exception("No ha capturado el Nombre de Usuario de la conexión."); }
                if (txbContraseña.Text.Trim() == "") { throw new Exception("No ha capturado la contraseña de Usuario del Servidor"); }

                var Config = Properties.Settings.Default;

                Config.Servidor = txbServidor.Text.Trim();
                Config.Usuario = txbUsuario.Text.Trim();
                Config.Contrasenia = objUtilerias.Base64Encode(txbContraseña.Text.Trim());
                Config.Segundos = Int32.Parse(txbSegundos.Text.Trim());

                Config.Save();
                //objConsultas.ConexionModelo(Config.Servidor, Config.Usuario, new Seguridad().Base64Decode(Config.Contrasenia),Config.BaseDeDatos);
                CargarBasesDeDatos();
            }
            catch (Exception ex)
            {
                var Mensaje = ex.Message;
                var Tipo = ex.GetType().ToString();
                MessageBox.Show(Mensaje, Tipo, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbBasesDeDatos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbBasesDeDatos.SelectedIndex == -1) return;

                var Config = Properties.Settings.Default;
                objConsultas.ObtenerSucursales(cmbSucursales, Config.idsucursal);
                if (Config.idusuario != 0) cmbSucursales_SelectionChangeCommitted(null, null);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void niIcono_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                MostrarConfiguracion();
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void cmbSucursales_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSucursales.SelectedIndex == -1) return;

                var Config = Properties.Settings.Default;
                int IdEmpresa = ((List<ordenes_empresas>)cmbSucursales.DataSource)[cmbSucursales.SelectedIndex].idempresa;
                objConsultas.ObtenerUsuarios(cmbUsuarios, IdEmpresa, Config.idusuario);
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pePlay_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbBasesDeDatos.SelectedIndex == -1) { throw new Exception("No ha seleccionado una Base de Datos."); }
                if (cmbSucursales.SelectedIndex == -1) { throw new Exception("No ha seleccionado una Sucursal."); }
                if (cmbUsuarios.SelectedIndex == -1) { throw new Exception("No ha seleccionado un Usuario."); }
                if (txbSegundos.Text.Trim() == "") { throw new Exception("No ha introducido la fecuencia de Segundos de Notificación."); }

                var Config = Properties.Settings.Default;

                Config.BaseDeDatos = (string)cmbBasesDeDatos.SelectedItem;
                Config.idsucursal = ((List<ordenes_empresas>)cmbSucursales.DataSource)[cmbSucursales.SelectedIndex].idempresa;
                Config.idusuario = ((List<usuarios>)cmbUsuarios.DataSource)[cmbUsuarios.SelectedIndex].idusuario;
                Config.Segundos = int.Parse(txbSegundos.Text.Trim());

                Config.Save();

                SesionActiva.nombre = ((List<usuarios>)cmbUsuarios.DataSource)[cmbUsuarios.SelectedIndex].nombre;

                tmAccion.Interval = Config.Segundos * 1000;
                tmAccion.Start();
                this.Hide();

            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void tmAccion_Tick(object sender, EventArgs e)
        {
            try
            {
                if (bgwConsultar.IsBusy == false)
                {
                    bgwConsultar.RunWorkerAsync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bgwConsultar_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var Config = Properties.Settings.Default;
                var idSucursal = Config.idsucursal; var idusuario = Config.idusuario;
                lstNoti = new List<notificaciones>();
                lstNoti = objConsultas.BuscarNotificaciones(idSucursal, idusuario);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void bgwConsultar_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            try
            {
                if (lstNoti.Count >= 1)
                {
                    using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                    {
                         var config = Properties.Settings.Default;                      

                        
                        List<notificaciones> lstNotiSuc = lstNoti.Where(c => c.msjtodos == 1).ToList();
                        if (lstNotiSuc.Count > 0)
                        {
                            foreach (notificaciones NSuc in lstNotiSuc)
                            {
                                StringBuilder sb = new StringBuilder();
                                string pro = (from p in Ctx.programa where p.idprograma == NSuc.idprograma select p.nombre).FirstOrDefault();
                                ordenes_empresas suc = (from s in Ctx.ordenes_empresas where s.idempresa == config.idsucursal select s).FirstOrDefault();
                                //sb.AppendLine(string.Format("Existen {0} Notificaciones para la Sucursal {1} \n\t\t\t", lstNotiSuc.Count, suc.nombrecorto));
                                sb.AppendLine(string.Format("La Sucursal {0}, tienes una Notificación de {1} ",suc.nombrecorto, pro.ToUpper() + "\n\t"));
                                sb.AppendLine(string.Format(NSuc.notificacion));
                                sb.AppendLine("PRESIONA CLICK PARA REVISAR.");

                                AlertInfo info = new AlertInfo("Su Atención Porfavor", sb.ToString());
                                info.Tag = NSuc.idnotificacion.ToString();
                                alrtPedidos.Show(this, info); 
                            }
                        }

                        List<notificaciones> lstNotiUsu = lstNoti.Where(u => u.idusuario == config.idusuario && u.msjtodos == 0).ToList();
                        if (lstNotiUsu.Count > 0)
                        {
                            foreach (notificaciones NUsu in lstNotiUsu)
                            {
                                StringBuilder sb = new StringBuilder();
                                string pro = (from p in Ctx.programa where p.idprograma == NUsu.idprograma select p.nombre).FirstOrDefault();
                                //string usu = (from u in Ctx.usuarios where u.idusuario == config.idusuario select u.nombre).FirstOrDefault();
                                sb.AppendLine(string.Format("Tienes una Notificación de {0} ", pro.ToUpper() + "\n\t"));
                                sb.AppendLine(string.Format(NUsu.notificacion));
                                sb.AppendLine("PRESIONA CLICK PARA REVISAR.");

                                AlertInfo info = new AlertInfo("Su Atención Porfavor", sb.ToString());
                                info.Tag = NUsu.idnotificacion.ToString();
                                alrtPedidos.Show(this, info); 
                            }                           
                        }

                        //sb.AppendLine("Haga click aqui para verlos");
                        //frmSiNoDialog frm = new frmSiNoDialog("Importante", sb.ToString());                                          
                    }                  
                }
                else
                {
                    lstNoti = null;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void alrtPedidos_BeforeFormShow(object sender, AlertFormEventArgs e)
        {
            using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
            {
                int IdNotif = int.Parse(e.AlertForm.AlertInfo.Tag.ToString());
                notificaciones noti = new notificaciones();
                noti = (from n in lstNoti where n.idnotificacion == IdNotif select n).FirstOrDefault();

                //if (noti.msjtodos == 1)
                //{
                //    e.AlertForm.LookAndFeel.SkinMaskColor = Color.LightYellow;
                //    e.AlertForm.LookAndFeel.SkinMaskColor2 = Color.Yellow;
                //}
                //else
                //{
                //    e.AlertForm.LookAndFeel.SkinMaskColor = Color.LightGreen;
                //    e.AlertForm.LookAndFeel.SkinMaskColor2 = Color.Green;
                //}
            }
            e.AlertForm.LookAndFeel.SkinMaskColor = Color.Firebrick;
            e.AlertForm.LookAndFeel.SkinMaskColor2 = Color.LightYellow;
            e.AlertForm.Size = new Size(300, 150);
        }

        private void alrtPedidos_AlertClick(object sender, AlertClickEventArgs e)
        {
            try
            {
                using (corrales_sistemaEntities Ctx = new corrales_sistemaEntities())
                {
                    int IdNotif = int.Parse(e.Info.Tag.ToString());                    
                    notificaciones noti = (from n in lstNoti where n.idnotificacion == IdNotif select n).FirstOrDefault();
                    programa objPrograma = (from p in Ctx.programa where p.idprograma == noti.idprograma select p).FirstOrDefault();

                    if (objPrograma != null)
                    {
                        var Config = Properties.Settings.Default;
                        string liga = objPrograma.liganotificacion + "&suc=" + new Seguridad().Base64Encode(Config.idsucursal.ToString()) + "&usu=" + new Seguridad().Base64Encode(Config.idusuario.ToString());
                        Process.Start(liga);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        #endregion

        #region Metodos

        private void CargarBasesDeDatos()
        {
            try
            {
                cmbBasesDeDatos.DataSource = objConsultas.ObtenerBasesDeDatos();
            }
            catch (Exception x)
            { throw x; }
        }

        private void MostrarConfiguracion()
        {
            new frm_Acceso(this).Show();
        }

        #endregion

    }
}
