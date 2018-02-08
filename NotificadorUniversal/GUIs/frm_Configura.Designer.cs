namespace NotificadorUniversal.GUIs
{
    partial class frm_Configura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Configura));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbSegundos = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUsu = new System.Windows.Forms.GroupBox();
            this.pePlay = new DevExpress.XtraEditors.PictureEdit();
            this.cmbBasesDeDatos = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.cmbSucursales = new System.Windows.Forms.ComboBox();
            this.gbDB = new System.Windows.Forms.GroupBox();
            this.txbServidor = new System.Windows.Forms.TextBox();
            this.peGCxn = new DevExpress.XtraEditors.PictureEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txbUsuario = new System.Windows.Forms.TextBox();
            this.txbContraseña = new System.Windows.Forms.TextBox();
            this.alrtPedidos = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.tmAccion = new System.Windows.Forms.Timer(this.components);
            this.niIcono = new System.Windows.Forms.NotifyIcon(this.components);
            this.bgwConsultar = new System.ComponentModel.BackgroundWorker();
            this.peSalir = new DevExpress.XtraEditors.PictureEdit();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblVersion1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.gbUsu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePlay.Properties)).BeginInit();
            this.gbDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peGCxn.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(538, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "BIENVENIDO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mostrar ventanas cada:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(328, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 13;
            this.label1.Text = "segundos";
            // 
            // txbSegundos
            // 
            this.txbSegundos.Location = new System.Drawing.Point(247, 56);
            this.txbSegundos.Name = "txbSegundos";
            this.txbSegundos.Size = new System.Drawing.Size(75, 20);
            this.txbSegundos.TabIndex = 12;
            this.txbSegundos.Text = "120";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbUsu);
            this.groupBox1.Controls.Add(this.gbDB);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(16, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(522, 290);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conexión";
            // 
            // gbUsu
            // 
            this.gbUsu.Controls.Add(this.pePlay);
            this.gbUsu.Controls.Add(this.cmbBasesDeDatos);
            this.gbUsu.Controls.Add(this.label8);
            this.gbUsu.Controls.Add(this.label3);
            this.gbUsu.Controls.Add(this.label10);
            this.gbUsu.Controls.Add(this.cmbUsuarios);
            this.gbUsu.Controls.Add(this.cmbSucursales);
            this.gbUsu.Location = new System.Drawing.Point(15, 153);
            this.gbUsu.Name = "gbUsu";
            this.gbUsu.Size = new System.Drawing.Size(501, 130);
            this.gbUsu.TabIndex = 25;
            this.gbUsu.TabStop = false;
            this.gbUsu.Text = "Datos";
            // 
            // pePlay
            // 
            this.pePlay.EditValue = global::NotificadorUniversal.Properties.Resources.next_1_12;
            this.pePlay.Location = new System.Drawing.Point(427, 72);
            this.pePlay.Name = "pePlay";
            this.pePlay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePlay.Properties.ZoomPercent = 15;
            this.pePlay.Size = new System.Drawing.Size(68, 43);
            this.pePlay.TabIndex = 24;
            this.pePlay.ToolTip = "Iniciar";
            this.pePlay.Click += new System.EventHandler(this.pePlay_Click);
            this.pePlay.MouseLeave += new System.EventHandler(this.pePlay_MouseLeave);
            this.pePlay.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pePlay_MouseMove);
            // 
            // cmbBasesDeDatos
            // 
            this.cmbBasesDeDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBasesDeDatos.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBasesDeDatos.FormattingEnabled = true;
            this.cmbBasesDeDatos.Location = new System.Drawing.Point(104, 25);
            this.cmbBasesDeDatos.Name = "cmbBasesDeDatos";
            this.cmbBasesDeDatos.Size = new System.Drawing.Size(287, 26);
            this.cmbBasesDeDatos.TabIndex = 16;
            this.cmbBasesDeDatos.SelectionChangeCommitted += new System.EventHandler(this.cmbBasesDeDatos_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 18);
            this.label8.TabIndex = 9;
            this.label8.Text = "Base de datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 22;
            this.label3.Text = "Usuario:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 60);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "Sucursal:";
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsuarios.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(104, 89);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(287, 26);
            this.cmbUsuarios.TabIndex = 21;
            // 
            // cmbSucursales
            // 
            this.cmbSucursales.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSucursales.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSucursales.FormattingEnabled = true;
            this.cmbSucursales.Location = new System.Drawing.Point(104, 57);
            this.cmbSucursales.Name = "cmbSucursales";
            this.cmbSucursales.Size = new System.Drawing.Size(287, 26);
            this.cmbSucursales.TabIndex = 19;
            this.cmbSucursales.SelectionChangeCommitted += new System.EventHandler(this.cmbSucursales_SelectionChangeCommitted);
            // 
            // gbDB
            // 
            this.gbDB.Controls.Add(this.txbServidor);
            this.gbDB.Controls.Add(this.peGCxn);
            this.gbDB.Controls.Add(this.label5);
            this.gbDB.Controls.Add(this.label6);
            this.gbDB.Controls.Add(this.label7);
            this.gbDB.Controls.Add(this.txbUsuario);
            this.gbDB.Controls.Add(this.txbContraseña);
            this.gbDB.Location = new System.Drawing.Point(15, 16);
            this.gbDB.Name = "gbDB";
            this.gbDB.Size = new System.Drawing.Size(501, 131);
            this.gbDB.TabIndex = 24;
            this.gbDB.TabStop = false;
            // 
            // txbServidor
            // 
            this.txbServidor.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbServidor.Location = new System.Drawing.Point(108, 25);
            this.txbServidor.Name = "txbServidor";
            this.txbServidor.Size = new System.Drawing.Size(367, 26);
            this.txbServidor.TabIndex = 6;
            this.txbServidor.Text = "loscorrales.com.mx";
            // 
            // peGCxn
            // 
            this.peGCxn.EditValue = global::NotificadorUniversal.Properties.Resources.right_arrow_1;
            this.peGCxn.Location = new System.Drawing.Point(427, 72);
            this.peGCxn.Name = "peGCxn";
            this.peGCxn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peGCxn.Properties.ZoomPercent = 15;
            this.peGCxn.Size = new System.Drawing.Size(68, 43);
            this.peGCxn.TabIndex = 23;
            this.peGCxn.ToolTip = "Guardar";
            this.peGCxn.Click += new System.EventHandler(this.peGCxn_Click);
            this.peGCxn.MouseLeave += new System.EventHandler(this.peGCxn_MouseLeave);
            this.peGCxn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peGCxn_MouseMove);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 5;
            this.label5.Text = "Servidor:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(42, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "Contraseña:";
            // 
            // txbUsuario
            // 
            this.txbUsuario.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbUsuario.Location = new System.Drawing.Point(108, 57);
            this.txbUsuario.Name = "txbUsuario";
            this.txbUsuario.Size = new System.Drawing.Size(191, 26);
            this.txbUsuario.TabIndex = 10;
            this.txbUsuario.Text = "corrales_tablero";
            // 
            // txbContraseña
            // 
            this.txbContraseña.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbContraseña.Location = new System.Drawing.Point(108, 89);
            this.txbContraseña.Name = "txbContraseña";
            this.txbContraseña.PasswordChar = '*';
            this.txbContraseña.Size = new System.Drawing.Size(191, 26);
            this.txbContraseña.TabIndex = 11;
            this.txbContraseña.Text = "acceso.2016";
            // 
            // alrtPedidos
            // 
            this.alrtPedidos.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceCaption.ForeColor = System.Drawing.Color.Black;
            this.alrtPedidos.AppearanceCaption.Options.UseFont = true;
            this.alrtPedidos.AppearanceCaption.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceCaption.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.AppearanceHotTrackedText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceHotTrackedText.ForeColor = System.Drawing.Color.RoyalBlue;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseFont = true;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceHotTrackedText.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceHotTrackedText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.AppearanceText.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alrtPedidos.AppearanceText.ForeColor = System.Drawing.Color.DarkBlue;
            this.alrtPedidos.AppearanceText.Options.UseFont = true;
            this.alrtPedidos.AppearanceText.Options.UseForeColor = true;
            this.alrtPedidos.AppearanceText.Options.UseTextOptions = true;
            this.alrtPedidos.AppearanceText.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.alrtPedidos.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.alrtPedidos.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.TopRight;
            this.alrtPedidos.FormMaxCount = 5;
            this.alrtPedidos.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideVertical;
            this.alrtPedidos.LookAndFeel.SkinMaskColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.alrtPedidos.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Firebrick;
            this.alrtPedidos.LookAndFeel.UseDefaultLookAndFeel = false;
            this.alrtPedidos.AlertClick += new DevExpress.XtraBars.Alerter.AlertClickEventHandler(this.alrtPedidos_AlertClick);
            this.alrtPedidos.BeforeFormShow += new DevExpress.XtraBars.Alerter.AlertFormEventHandler(this.alrtPedidos_BeforeFormShow);
            // 
            // tmAccion
            // 
            this.tmAccion.Interval = 1000;
            this.tmAccion.Tick += new System.EventHandler(this.tmAccion_Tick);
            // 
            // niIcono
            // 
            this.niIcono.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niIcono.Icon = ((System.Drawing.Icon)(resources.GetObject("niIcono.Icon")));
            this.niIcono.Text = "Notificador de Pedidos";
            this.niIcono.Visible = true;
            this.niIcono.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.niIcono_MouseDoubleClick);
            // 
            // bgwConsultar
            // 
            this.bgwConsultar.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgwConsultar_DoWork);
            this.bgwConsultar.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgwConsultar_RunWorkerCompleted);
            // 
            // peSalir
            // 
            this.peSalir.EditValue = ((object)(resources.GetObject("peSalir.EditValue")));
            this.peSalir.Location = new System.Drawing.Point(458, 43);
            this.peSalir.Name = "peSalir";
            this.peSalir.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSalir.Properties.ZoomPercent = 9;
            this.peSalir.Size = new System.Drawing.Size(68, 43);
            this.peSalir.TabIndex = 25;
            this.peSalir.ToolTip = "Cerrar";
            this.peSalir.Click += new System.EventHandler(this.peSalir_Click);
            this.peSalir.MouseLeave += new System.EventHandler(this.peSalir_MouseLeave);
            this.peSalir.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peSalir_MouseMove);
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblVersion.Location = new System.Drawing.Point(439, 382);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(93, 13);
            this.lblVersion.TabIndex = 26;
            this.lblVersion.Text = "Copyright ©  2018";
            // 
            // lblVersion1
            // 
            this.lblVersion1.AutoSize = true;
            this.lblVersion1.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lblVersion1.Location = new System.Drawing.Point(398, 382);
            this.lblVersion1.Name = "lblVersion1";
            this.lblVersion1.Size = new System.Drawing.Size(40, 13);
            this.lblVersion1.TabIndex = 27;
            this.lblVersion1.Text = "1.0.0.0";
            // 
            // frm_Configura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(538, 401);
            this.ControlBox = false;
            this.Controls.Add(this.lblVersion1);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.peSalir);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbSegundos);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Configura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notificador Universal";
            this.Load += new System.EventHandler(this.frm_Configura_Load);
            this.Shown += new System.EventHandler(this.frm_Configura_Shown);
            this.groupBox1.ResumeLayout(false);
            this.gbUsu.ResumeLayout(false);
            this.gbUsu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pePlay.Properties)).EndInit();
            this.gbDB.ResumeLayout(false);
            this.gbDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peGCxn.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSalir.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbSegundos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.ComboBox cmbSucursales;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbBasesDeDatos;
        private System.Windows.Forms.TextBox txbContraseña;
        private System.Windows.Forms.TextBox txbUsuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbServidor;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraBars.Alerter.AlertControl alrtPedidos;
        public System.Windows.Forms.Timer tmAccion;
        private System.Windows.Forms.NotifyIcon niIcono;
        private System.ComponentModel.BackgroundWorker bgwConsultar;
        private DevExpress.XtraEditors.PictureEdit peGCxn;
        private System.Windows.Forms.GroupBox gbUsu;
        private DevExpress.XtraEditors.PictureEdit pePlay;
        private System.Windows.Forms.GroupBox gbDB;
        private DevExpress.XtraEditors.PictureEdit peSalir;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblVersion1;
    }
}