namespace Mentores.Forms
{
    partial class Sigin
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
            this.lbMesagge = new System.Windows.Forms.Label();
            this.cbUserRole = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSingup = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.tbEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbUserName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbLastName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.tbName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_Title = new System.Windows.Forms.Label();
            this.signinMessage = new System.Windows.Forms.Timer(this.components);
            this.kryptonSigin = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.SuspendLayout();
            // 
            // lbMesagge
            // 
            this.lbMesagge.BackColor = System.Drawing.Color.Transparent;
            this.lbMesagge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMesagge.ForeColor = System.Drawing.Color.Black;
            this.lbMesagge.Location = new System.Drawing.Point(70, 583);
            this.lbMesagge.Name = "lbMesagge";
            this.lbMesagge.Size = new System.Drawing.Size(389, 60);
            this.lbMesagge.TabIndex = 55;
            this.lbMesagge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbUserRole
            // 
            this.cbUserRole.AutoRoundedCorners = true;
            this.cbUserRole.BackColor = System.Drawing.Color.Transparent;
            this.cbUserRole.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.cbUserRole.BorderRadius = 17;
            this.cbUserRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserRole.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUserRole.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cbUserRole.ForeColor = System.Drawing.Color.Silver;
            this.cbUserRole.ItemHeight = 30;
            this.cbUserRole.Items.AddRange(new object[] {
            "Seleccione Un Rol De Usuario",
            "Alumno/a",
            "Mentor/a"});
            this.cbUserRole.Location = new System.Drawing.Point(74, 521);
            this.cbUserRole.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbUserRole.Name = "cbUserRole";
            this.cbUserRole.Size = new System.Drawing.Size(379, 36);
            this.cbUserRole.StartIndex = 0;
            this.cbUserRole.TabIndex = 56;
            // 
            // btnSingup
            // 
            this.btnSingup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSingup.Location = new System.Drawing.Point(153, 667);
            this.btnSingup.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.btnSingup.Name = "btnSingup";
            this.btnSingup.OverrideDefault.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSingup.OverrideDefault.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSingup.OverrideDefault.Back.ColorAngle = 70F;
            this.btnSingup.OverrideDefault.Border.Color1 = System.Drawing.Color.Black;
            this.btnSingup.OverrideDefault.Border.Color2 = System.Drawing.Color.Black;
            this.btnSingup.OverrideDefault.Border.ColorAngle = 45F;
            this.btnSingup.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingup.OverrideDefault.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSingup.OverrideDefault.Border.Rounding = 20;
            this.btnSingup.OverrideDefault.Border.Width = 1;
            this.btnSingup.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingup.Size = new System.Drawing.Size(217, 48);
            this.btnSingup.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSingup.StateCommon.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSingup.StateCommon.Back.ColorAngle = 70F;
            this.btnSingup.StateCommon.Border.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StateCommon.Border.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StateCommon.Border.ColorAngle = 70F;
            this.btnSingup.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingup.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSingup.StateCommon.Border.Rounding = 20;
            this.btnSingup.StateCommon.Border.Width = 1;
            this.btnSingup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingup.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSingup.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSingup.StatePressed.Back.ColorAngle = 200F;
            this.btnSingup.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSingup.StatePressed.Border.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StatePressed.Border.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StatePressed.Border.ColorAngle = 135F;
            this.btnSingup.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingup.StatePressed.Border.Rounding = 20;
            this.btnSingup.StatePressed.Border.Width = 1;
            this.btnSingup.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingup.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btnSingup.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btnSingup.StateTracking.Back.ColorAngle = 200F;
            this.btnSingup.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSingup.StateTracking.Border.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StateTracking.Border.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StateTracking.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Dashed;
            this.btnSingup.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnSingup.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.btnSingup.StateTracking.Border.Rounding = 20;
            this.btnSingup.StateTracking.Border.Width = 1;
            this.btnSingup.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.Black;
            this.btnSingup.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.Black;
            this.btnSingup.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSingup.TabIndex = 54;
            this.btnSingup.Values.Text = "Registrarse";
            this.btnSingup.Click += new System.EventHandler(this.btnSingup_Click);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(74, 379);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(374, 38);
            this.tbEmail.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbEmail.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.tbEmail.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.tbEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbEmail.StateCommon.Border.Rounding = 10;
            this.tbEmail.StateCommon.Border.Width = 1;
            this.tbEmail.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbEmail.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.TabIndex = 53;
            this.tbEmail.Text = "E-mail";
            this.tbEmail.Enter += new System.EventHandler(this.tbEmail_Enter);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(74, 448);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(374, 38);
            this.tbPassword.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbPassword.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.tbPassword.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.tbPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbPassword.StateCommon.Border.Rounding = 10;
            this.tbPassword.StateCommon.Border.Width = 1;
            this.tbPassword.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbPassword.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.TabIndex = 52;
            this.tbPassword.Text = "Contraseña";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // tbUserName
            // 
            this.tbUserName.Location = new System.Drawing.Point(74, 305);
            this.tbUserName.Margin = new System.Windows.Forms.Padding(4);
            this.tbUserName.Name = "tbUserName";
            this.tbUserName.Size = new System.Drawing.Size(374, 38);
            this.tbUserName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbUserName.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.tbUserName.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.tbUserName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbUserName.StateCommon.Border.Rounding = 10;
            this.tbUserName.StateCommon.Border.Width = 1;
            this.tbUserName.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbUserName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUserName.TabIndex = 51;
            this.tbUserName.Text = "Nombre de usuario";
            this.tbUserName.Enter += new System.EventHandler(this.tbUserName_Enter);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(74, 243);
            this.tbLastName.Margin = new System.Windows.Forms.Padding(4);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(374, 38);
            this.tbLastName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbLastName.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.tbLastName.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.tbLastName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbLastName.StateCommon.Border.Rounding = 10;
            this.tbLastName.StateCommon.Border.Width = 1;
            this.tbLastName.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbLastName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLastName.TabIndex = 50;
            this.tbLastName.Text = "Apellido";
            this.tbLastName.Enter += new System.EventHandler(this.tbLastName_Enter);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(74, 178);
            this.tbName.Margin = new System.Windows.Forms.Padding(4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(374, 38);
            this.tbName.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.tbName.StateCommon.Border.Color1 = System.Drawing.SystemColors.Control;
            this.tbName.StateCommon.Border.Color2 = System.Drawing.SystemColors.Control;
            this.tbName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.tbName.StateCommon.Border.Rounding = 10;
            this.tbName.StateCommon.Border.Width = 1;
            this.tbName.StateCommon.Content.Color1 = System.Drawing.Color.Silver;
            this.tbName.StateCommon.Content.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbName.TabIndex = 49;
            this.tbName.Text = "Nombre";
            this.tbName.Enter += new System.EventHandler(this.tbName_Enter);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(56, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(410, 62);
            this.label2.TabIndex = 48;
            this.label2.Text = "Sera Un Placer Tenerte\r\nCon Nosotros!";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Title
            // 
            this.lb_Title.BackColor = System.Drawing.Color.Transparent;
            this.lb_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_Title.Location = new System.Drawing.Point(10, -6);
            this.lb_Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_Title.Name = "lb_Title";
            this.lb_Title.Size = new System.Drawing.Size(502, 85);
            this.lb_Title.TabIndex = 47;
            this.lb_Title.Text = "Mentores";
            this.lb_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // signinMessage
            // 
            this.signinMessage.Tick += new System.EventHandler(this.signinMessage_Tick);
            // 
            // kryptonSigin
            // 
            this.kryptonSigin.Common.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSigin.Common.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonSigin.Common.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonSigin.Common.StateCommon.Border.Color2 = System.Drawing.Color.White;
            this.kryptonSigin.Common.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonSigin.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.kryptonSigin.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.White;
            // 
            // Sigin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(512, 726);
            this.Controls.Add(this.lbMesagge);
            this.Controls.Add(this.cbUserRole);
            this.Controls.Add(this.btnSingup);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUserName);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Title);
            this.Name = "Sigin";
            this.Palette = this.kryptonSigin;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "Sigin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMesagge;
        private Guna.UI2.WinForms.Guna2ComboBox cbUserRole;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnSingup;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbEmail;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbLastName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_Title;
        private System.Windows.Forms.Timer signinMessage;
        private ComponentFactory.Krypton.Toolkit.KryptonPalette kryptonSigin;
    }
}