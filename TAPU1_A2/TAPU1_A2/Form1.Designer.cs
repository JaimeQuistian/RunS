namespace TAPU1_A2
{
    partial class frmRunS
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRunS));
            this.anmPersona = new TAPU2_LibreriaControles.Animacion();
            this.tmrJoyStick = new System.Windows.Forms.Timer(this.components);
            this.tmrMovimiento = new System.Windows.Forms.Timer(this.components);
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.anmPersona2 = new TAPU2_LibreriaControles.Animacion();
            this.tmrMovimientoP2 = new System.Windows.Forms.Timer(this.components);
            this.cbListasJoysticks = new System.Windows.Forms.ComboBox();
            this.cbListas2 = new System.Windows.Forms.ComboBox();
            this.tblTexP2 = new System.Windows.Forms.Label();
            this.lblTextP1 = new System.Windows.Forms.Label();
            this.tmrJoystick2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // anmPersona
            // 
            this.anmPersona.BackColor = System.Drawing.Color.Transparent;
            this.anmPersona.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anmPersona.BackgroundImage")));
            this.anmPersona.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.anmPersona.Location = new System.Drawing.Point(1, 331);
            this.anmPersona.Name = "anmPersona";
            this.anmPersona.Size = new System.Drawing.Size(94, 102);
            this.anmPersona.TabIndex = 0;
            // 
            // tmrJoyStick
            // 
            this.tmrJoyStick.Tick += new System.EventHandler(this.tmrJoyStick_Tick);
            // 
            // tmrMovimiento
            // 
            this.tmrMovimiento.Tick += new System.EventHandler(this.tmrMovimiento_Tick);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.Location = new System.Drawing.Point(29, 436);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(64, 17);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.Location = new System.Drawing.Point(29, 316);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(68, 17);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "Player 2";
            // 
            // anmPersona2
            // 
            this.anmPersona2.BackColor = System.Drawing.Color.Transparent;
            this.anmPersona2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("anmPersona2.BackgroundImage")));
            this.anmPersona2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.anmPersona2.Location = new System.Drawing.Point(1, 211);
            this.anmPersona2.Name = "anmPersona2";
            this.anmPersona2.Size = new System.Drawing.Size(94, 102);
            this.anmPersona2.TabIndex = 4;
            // 
            // tmrMovimientoP2
            // 
            this.tmrMovimientoP2.Tick += new System.EventHandler(this.tmrMovimientoP2_Tick);
            // 
            // cbListasJoysticks
            // 
            this.cbListasJoysticks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListasJoysticks.FormattingEnabled = true;
            this.cbListasJoysticks.Location = new System.Drawing.Point(12, 12);
            this.cbListasJoysticks.Name = "cbListasJoysticks";
            this.cbListasJoysticks.Size = new System.Drawing.Size(245, 21);
            this.cbListasJoysticks.TabIndex = 1;
            this.cbListasJoysticks.Text = "Conectar Joystick";
            // 
            // cbListas2
            // 
            this.cbListas2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbListas2.FormattingEnabled = true;
            this.cbListas2.Location = new System.Drawing.Point(543, 12);
            this.cbListas2.Name = "cbListas2";
            this.cbListas2.Size = new System.Drawing.Size(245, 21);
            this.cbListas2.TabIndex = 6;
            this.cbListas2.Text = "Conectar Joystick";
            this.cbListas2.SelectionChangeCommitted += new System.EventHandler(this.cbListas2_SelectionChangeCommitted);
            // 
            // tblTexP2
            // 
            this.tblTexP2.AutoSize = true;
            this.tblTexP2.BackColor = System.Drawing.Color.Transparent;
            this.tblTexP2.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tblTexP2.ForeColor = System.Drawing.Color.Red;
            this.tblTexP2.Location = new System.Drawing.Point(546, 36);
            this.tblTexP2.Name = "tblTexP2";
            this.tblTexP2.Size = new System.Drawing.Size(258, 17);
            this.tblTexP2.TabIndex = 7;
            this.tblTexP2.Text = "Player 2: Seleccionar para conectar";
            // 
            // lblTextP1
            // 
            this.lblTextP1.AutoSize = true;
            this.lblTextP1.BackColor = System.Drawing.Color.Transparent;
            this.lblTextP1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextP1.ForeColor = System.Drawing.Color.Blue;
            this.lblTextP1.Location = new System.Drawing.Point(9, 36);
            this.lblTextP1.Name = "lblTextP1";
            this.lblTextP1.Size = new System.Drawing.Size(203, 17);
            this.lblTextP1.TabIndex = 8;
            this.lblTextP1.Text = "Player 1: Clic para conectar";
            // 
            // tmrJoystick2
            // 
            this.tmrJoystick2.Tick += new System.EventHandler(this.tmrJoystick2_Tick);
            // 
            // frmRunS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TAPU1_A2.Properties.Resources.Paisaje;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.lblTextP1);
            this.Controls.Add(this.tblTexP2);
            this.Controls.Add(this.cbListas2);
            this.Controls.Add(this.anmPersona2);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.cbListasJoysticks);
            this.Controls.Add(this.anmPersona);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "frmRunS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RunS";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmRunS_Load);
            this.Click += new System.EventHandler(this.frmRunS_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TAPU2_LibreriaControles.Animacion anmPersona;
        private System.Windows.Forms.Timer tmrJoyStick;
        private System.Windows.Forms.Timer tmrMovimiento;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private TAPU2_LibreriaControles.Animacion anmPersona2;
        private System.Windows.Forms.Timer tmrMovimientoP2;
        private System.Windows.Forms.ComboBox cbListasJoysticks;
        private System.Windows.Forms.ComboBox cbListas2;
        private System.Windows.Forms.Label tblTexP2;
        private System.Windows.Forms.Label lblTextP1;
        private System.Windows.Forms.Timer tmrJoystick2;
    }
}

