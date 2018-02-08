namespace firmas.GUIs
{
    partial class frm_Acceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Acceso));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPCancelar = new System.Windows.Forms.Button();
            this.btnPAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPCveAnt = new System.Windows.Forms.TextBox();
            this.tbPConfirmCve = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPCveNueva = new System.Windows.Forms.TextBox();
            this.btnCambCve = new System.Windows.Forms.Button();
            this.tbAccess = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.pnbotones = new System.Windows.Forms.Panel();
            this.peAceptar = new DevExpress.XtraEditors.PictureEdit();
            this.pePass = new DevExpress.XtraEditors.PictureEdit();
            this.peCancelar = new DevExpress.XtraEditors.PictureEdit();
            this.peCancelarC = new DevExpress.XtraEditors.PictureEdit();
            this.peGCxn = new DevExpress.XtraEditors.PictureEdit();
            this.panel1.SuspendLayout();
            this.pnbotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePass.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelarC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGCxn.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.peCancelarC);
            this.panel1.Controls.Add(this.peGCxn);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnPCancelar);
            this.panel1.Controls.Add(this.btnPAceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.tbPCveAnt);
            this.panel1.Controls.Add(this.tbPConfirmCve);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.tbPCveNueva);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(8, 167);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(272, 331);
            this.panel1.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(17, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(172, 27);
            this.label5.TabIndex = 7;
            this.label5.Text = "Cambiar Clave";
            // 
            // btnPCancelar
            // 
            this.btnPCancelar.Location = new System.Drawing.Point(219, 282);
            this.btnPCancelar.Name = "btnPCancelar";
            this.btnPCancelar.Size = new System.Drawing.Size(43, 38);
            this.btnPCancelar.TabIndex = 12;
            this.btnPCancelar.Text = "Cancelar";
            this.btnPCancelar.UseVisualStyleBackColor = true;
            this.btnPCancelar.Visible = false;
            this.btnPCancelar.Click += new System.EventHandler(this.btnPCancelar_Click);
            // 
            // btnPAceptar
            // 
            this.btnPAceptar.Location = new System.Drawing.Point(8, 282);
            this.btnPAceptar.Name = "btnPAceptar";
            this.btnPAceptar.Size = new System.Drawing.Size(36, 38);
            this.btnPAceptar.TabIndex = 11;
            this.btnPAceptar.Text = "Aceptar";
            this.btnPAceptar.UseVisualStyleBackColor = true;
            this.btnPAceptar.Visible = false;
            this.btnPAceptar.Click += new System.EventHandler(this.btnPAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Clave anterior";
            // 
            // tbPCveAnt
            // 
            this.tbPCveAnt.Location = new System.Drawing.Point(11, 94);
            this.tbPCveAnt.Name = "tbPCveAnt";
            this.tbPCveAnt.PasswordChar = '*';
            this.tbPCveAnt.Size = new System.Drawing.Size(251, 20);
            this.tbPCveAnt.TabIndex = 6;
            // 
            // tbPConfirmCve
            // 
            this.tbPConfirmCve.Location = new System.Drawing.Point(11, 233);
            this.tbPConfirmCve.Name = "tbPConfirmCve";
            this.tbPConfirmCve.PasswordChar = '*';
            this.tbPConfirmCve.Size = new System.Drawing.Size(251, 20);
            this.tbPConfirmCve.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Clave nueva";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Confirmar Clave";
            // 
            // tbPCveNueva
            // 
            this.tbPCveNueva.Location = new System.Drawing.Point(11, 162);
            this.tbPCveNueva.Name = "tbPCveNueva";
            this.tbPCveNueva.PasswordChar = '*';
            this.tbPCveNueva.Size = new System.Drawing.Size(251, 20);
            this.tbPCveNueva.TabIndex = 8;
            // 
            // btnCambCve
            // 
            this.btnCambCve.Location = new System.Drawing.Point(8, 111);
            this.btnCambCve.Name = "btnCambCve";
            this.btnCambCve.Size = new System.Drawing.Size(28, 38);
            this.btnCambCve.TabIndex = 24;
            this.btnCambCve.Text = "Cambiar Clave";
            this.btnCambCve.UseVisualStyleBackColor = true;
            this.btnCambCve.Visible = false;
            this.btnCambCve.Click += new System.EventHandler(this.btnCambCve_Click);
            // 
            // tbAccess
            // 
            this.tbAccess.Location = new System.Drawing.Point(8, 31);
            this.tbAccess.Name = "tbAccess";
            this.tbAccess.PasswordChar = '*';
            this.tbAccess.Size = new System.Drawing.Size(272, 20);
            this.tbAccess.TabIndex = 23;
            this.tbAccess.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAccess_KeyPress);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(249, 67);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(31, 38);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Introduzca la clave de acceso";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(8, 67);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(28, 38);
            this.btnAceptar.TabIndex = 20;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Visible = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // pnbotones
            // 
            this.pnbotones.Controls.Add(this.peAceptar);
            this.pnbotones.Controls.Add(this.pePass);
            this.pnbotones.Controls.Add(this.peCancelar);
            this.pnbotones.Location = new System.Drawing.Point(8, 57);
            this.pnbotones.Name = "pnbotones";
            this.pnbotones.Size = new System.Drawing.Size(272, 104);
            this.pnbotones.TabIndex = 29;
            // 
            // peAceptar
            // 
            this.peAceptar.EditValue = global::NotificadorUniversal.Properties.Resources.next_1_12;
            this.peAceptar.Location = new System.Drawing.Point(44, 2);
            this.peAceptar.Name = "peAceptar";
            this.peAceptar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAceptar.Properties.ZoomPercent = 15;
            this.peAceptar.Size = new System.Drawing.Size(68, 43);
            this.peAceptar.TabIndex = 26;
            this.peAceptar.ToolTip = "Iniciar";
            this.peAceptar.Click += new System.EventHandler(this.peAceptar_Click);
            this.peAceptar.MouseLeave += new System.EventHandler(this.peAceptar_MouseLeave);
            this.peAceptar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peAceptar_MouseMove);
            // 
            // pePass
            // 
            this.pePass.EditValue = ((object)(resources.GetObject("pePass.EditValue")));
            this.pePass.Location = new System.Drawing.Point(96, 55);
            this.pePass.Name = "pePass";
            this.pePass.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePass.Properties.ZoomPercent = 9;
            this.pePass.Size = new System.Drawing.Size(68, 43);
            this.pePass.TabIndex = 28;
            this.pePass.ToolTip = "Cambiar Contraseña";
            this.pePass.Click += new System.EventHandler(this.pePass_Click);
            this.pePass.MouseLeave += new System.EventHandler(this.pePass_MouseLeave);
            this.pePass.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pePass_MouseMove);
            // 
            // peCancelar
            // 
            this.peCancelar.EditValue = ((object)(resources.GetObject("peCancelar.EditValue")));
            this.peCancelar.Location = new System.Drawing.Point(147, 2);
            this.peCancelar.Name = "peCancelar";
            this.peCancelar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelar.Properties.ZoomPercent = 9;
            this.peCancelar.Size = new System.Drawing.Size(68, 43);
            this.peCancelar.TabIndex = 27;
            this.peCancelar.ToolTip = "Cerrar";
            this.peCancelar.Click += new System.EventHandler(this.peCancelar_Click);
            this.peCancelar.MouseLeave += new System.EventHandler(this.peCancelar_MouseLeave);
            this.peCancelar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peCancelar_MouseMove);
            // 
            // peCancelarC
            // 
            this.peCancelarC.EditValue = ((object)(resources.GetObject("peCancelarC.EditValue")));
            this.peCancelarC.Location = new System.Drawing.Point(145, 275);
            this.peCancelarC.Name = "peCancelarC";
            this.peCancelarC.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCancelarC.Properties.ZoomPercent = 9;
            this.peCancelarC.Size = new System.Drawing.Size(68, 43);
            this.peCancelarC.TabIndex = 28;
            this.peCancelarC.ToolTip = "Cerrar";
            this.peCancelarC.Click += new System.EventHandler(this.peCancelarC_Click);
            this.peCancelarC.MouseLeave += new System.EventHandler(this.peCancelarC_MouseLeave);
            this.peCancelarC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peCancelarC_MouseMove);
            // 
            // peGCxn
            // 
            this.peGCxn.EditValue = global::NotificadorUniversal.Properties.Resources.right_arrow_1;
            this.peGCxn.Location = new System.Drawing.Point(51, 275);
            this.peGCxn.Name = "peGCxn";
            this.peGCxn.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peGCxn.Properties.ZoomPercent = 15;
            this.peGCxn.Size = new System.Drawing.Size(68, 43);
            this.peGCxn.TabIndex = 24;
            this.peGCxn.ToolTip = "Guardar";
            this.peGCxn.Click += new System.EventHandler(this.peGCxn_Click);
            this.peGCxn.MouseLeave += new System.EventHandler(this.peGCxn_MouseLeave);
            this.peGCxn.MouseMove += new System.Windows.Forms.MouseEventHandler(this.peGCxn_MouseMove);
            // 
            // frm_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(288, 503);
            this.ControlBox = false;
            this.Controls.Add(this.pnbotones);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCambCve);
            this.Controls.Add(this.tbAccess);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAceptar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Acceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnbotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peAceptar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePass.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCancelarC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peGCxn.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnPCancelar;
        private System.Windows.Forms.Button btnPAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPCveAnt;
        private System.Windows.Forms.TextBox tbPConfirmCve;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPCveNueva;
        private System.Windows.Forms.Button btnCambCve;
        private System.Windows.Forms.TextBox tbAccess;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAceptar;
        private DevExpress.XtraEditors.PictureEdit peAceptar;
        private DevExpress.XtraEditors.PictureEdit peCancelar;
        private DevExpress.XtraEditors.PictureEdit pePass;
        private DevExpress.XtraEditors.PictureEdit peCancelarC;
        private DevExpress.XtraEditors.PictureEdit peGCxn;
        private System.Windows.Forms.Panel pnbotones;
    }
}