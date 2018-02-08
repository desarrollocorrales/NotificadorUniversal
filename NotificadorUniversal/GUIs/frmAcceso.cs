using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NotificadorUniversal.Utilerias;
using NotificadorUniversal.GUIs;

namespace firmas.GUIs
{
    public partial class frm_Acceso : Form
    {
        private frm_Configura frmLanzador;
        Efectos objEfectos = new Efectos();

        public frm_Acceso()
        {
            InitializeComponent();
        }

        public frm_Acceso(frm_Configura frmLanzador)
        {
            InitializeComponent();
            this.frmLanzador = frmLanzador;
        }

        private void frmAcceso_Load(object sender, EventArgs e)
        {
            this.Size = new Size(304, 193);

            this.ActiveControl = this.tbAccess;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = new Seguridad().Transform(this.tbAccess.Text);

                string acceso = NotificadorUniversal.Properties.Settings.Default.accesoConfig;

                if (new Seguridad().Transform(acceso).Equals(new Seguridad().Transform(claveAcceso)))
                {
                    frmLanzador.tmAccion.Stop();
                    frmLanzador.Show();
                    this.Close();
                }
                else
                {
                    this.ActiveControl = this.tbAccess;
                    this.tbAccess.SelectAll();
                    throw new Exception("Clave incorrecta");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void btnCambCve_Click(object sender, EventArgs e)
        {
            // mostrar el panel del cambio de clave
            this.Size = new Size(304, 542);

            // se habilita el panel
            this.panel1.Enabled = true;

            // se deshabilita el acceso
            this.label1.Enabled = false;
            this.tbAccess.Enabled = false;
            this.peAceptar.Enabled = false;
            this.peCancelar.Enabled = false;
            this.pePass.Enabled = false;
            this.tbAccess.Text = string.Empty;

            // habilita el panel
            this.tbPCveAnt.Text = string.Empty;
            this.tbPCveNueva.Text = string.Empty;
            this.tbPConfirmCve.Text = string.Empty;
            this.ActiveControl = this.tbPCveAnt;
        }

        private void btnPAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbPCveAnt.Text))
                    throw new Exception("Ingrese la clave anterior");

                if (string.IsNullOrEmpty(this.tbPCveNueva.Text))
                    throw new Exception("Ingrese la clave nueva");

                if (string.IsNullOrEmpty(this.tbPConfirmCve.Text))
                    throw new Exception("Ingrese la clave a confirmar");

                // valida si la clave anterior es correcta
                string claveAcceso = new Seguridad().Transform(this.tbPCveAnt.Text);

                string acceso = NotificadorUniversal.Properties.Settings.Default.accesoConfig;

                if (!new Seguridad().Transform(acceso).Equals(new Seguridad().Transform(claveAcceso)))
                {
                    this.ActiveControl = this.tbPCveAnt;
                    this.tbPCveAnt.SelectAll();
                    throw new Exception("Clave anterior incorrecta");
                }

                string claveNueva = this.tbPCveNueva.Text;
                string claveConfirm = this.tbPConfirmCve.Text;

                if (!claveNueva.Equals(claveConfirm))
                {
                    this.ActiveControl = this.tbPCveNueva;
                    this.tbPConfirmCve.Text = string.Empty;
                    this.tbPCveNueva.SelectAll();
                    throw new Exception("La claves no coinciden");
                }

                string cveNAcceso = new Seguridad().Transform(this.tbPCveNueva.Text);

                NotificadorUniversal.Properties.Settings.Default.accesoConfig = cveNAcceso;

                NotificadorUniversal.Properties.Settings.Default.Save();

                MessageBox.Show("Clave Modificada!!!", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnPCancelar_Click(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnPCancelar_Click(object sender, EventArgs e)
        {
            // regresa el tamaño del formulario
            this.Size = new Size(304, 193);

            // habilita el acces
            this.label1.Enabled = true;
            this.tbAccess.Enabled = true;
            this.btnAceptar.Enabled = true;
            this.btnCancelar.Enabled = true;
            this.btnCambCve.Enabled = true;

            // deshabilita el panel
            this.panel1.Enabled = false;

            this.ActiveControl = this.tbAccess;
        }

        private void tbAccess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                this.btnAceptar_Click(null, null);
            }
        }



        private void pePass_Click(object sender, EventArgs e)
        {
            try
            {
                // mostrar el panel del cambio de clave
                this.Size = new Size(304, 542);

                // se habilita el panel
                this.panel1.Enabled = true;

                // se deshabilita el acceso
                this.label1.Enabled = false;
                this.tbAccess.Enabled = false;
                pnbotones.Enabled = false;
                this.tbAccess.Text = string.Empty;

                // habilita el panel
                this.tbPCveAnt.Text = string.Empty;
                this.tbPCveNueva.Text = string.Empty;
                this.tbPConfirmCve.Text = string.Empty;
                this.ActiveControl = this.tbPCveAnt;
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pePass_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(pePass, NotificadorUniversal.Properties.Resources.pass1);
                pePass.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void pePass_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(pePass, NotificadorUniversal.Properties.Resources.pass2);
                pePass.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbAccess.Text))
                    throw new Exception("Ingrese la clave de acceso");

                string claveAcceso = new Seguridad().Transform(this.tbAccess.Text);

                string acceso = NotificadorUniversal.Properties.Settings.Default.accesoConfig;

                if (new Seguridad().Transform(acceso).Equals(new Seguridad().Transform(claveAcceso)))
                {
                    frmLanzador.tmAccion.Stop();
                    frmLanzador.Show();
                    this.Close();
                }
                else
                {
                    this.ActiveControl = this.tbAccess;
                    this.tbAccess.SelectAll();
                    throw new Exception("Clave incorrecta");
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void peAceptar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peAceptar, NotificadorUniversal.Properties.Resources.next_1_12);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peAceptar_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peAceptar, NotificadorUniversal.Properties.Resources.next_1_1);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        private void peCancelar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peCancelar, NotificadorUniversal.Properties.Resources.cerrar1);
                peCancelar.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelar_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peCancelar, NotificadorUniversal.Properties.Resources.cerrar2);
                peCancelar.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peGCxn_Click(object sender, EventArgs e)
        {
            try
            {
                // validacion
                if (string.IsNullOrEmpty(this.tbPCveAnt.Text))
                    throw new Exception("Ingrese la clave anterior");

                if (string.IsNullOrEmpty(this.tbPCveNueva.Text))
                    throw new Exception("Ingrese la clave nueva");

                if (string.IsNullOrEmpty(this.tbPConfirmCve.Text))
                    throw new Exception("Ingrese la clave a confirmar");

                // valida si la clave anterior es correcta
                string claveAcceso = new Seguridad().Transform(this.tbPCveAnt.Text);

                string acceso = NotificadorUniversal.Properties.Settings.Default.accesoConfig;

                if (!new Seguridad().Transform(acceso).Equals(new Seguridad().Transform(claveAcceso)))
                {
                    this.ActiveControl = this.tbPCveAnt;
                    this.tbPCveAnt.SelectAll();
                    throw new Exception("Clave anterior incorrecta");
                }

                string claveNueva = this.tbPCveNueva.Text;
                string claveConfirm = this.tbPConfirmCve.Text;

                if (!claveNueva.Equals(claveConfirm))
                {
                    this.ActiveControl = this.tbPCveNueva;
                    this.tbPConfirmCve.Text = string.Empty;
                    this.tbPCveNueva.SelectAll();
                    throw new Exception("La claves no coinciden");
                }

                string cveNAcceso = new Seguridad().Transform(this.tbPCveNueva.Text);

                NotificadorUniversal.Properties.Settings.Default.accesoConfig = cveNAcceso;

                NotificadorUniversal.Properties.Settings.Default.Save();

                MessageBox.Show("Clave Modificada!!!", "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.btnPCancelar_Click(null, null);
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message, "Acceso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

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

        private void peCancelarC_Click(object sender, EventArgs e)
        {
            // regresa el tamaño del formulario
            this.Size = new Size(304, 193);

            // habilita el acces
            this.label1.Enabled = true;
            this.tbAccess.Enabled = true;
            pnbotones.Enabled = true;

            // deshabilita el panel
            this.panel1.Enabled = false;

            this.ActiveControl = this.tbAccess;
        }

        private void peCancelarC_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peCancelarC, NotificadorUniversal.Properties.Resources.cerrar1);
                peCancelar.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void peCancelarC_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                objEfectos.MouseLeaveEfecto1(peCancelarC, NotificadorUniversal.Properties.Resources.cerrar2);
                peCancelar.Properties.ZoomPercent = 9;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

    }
}
