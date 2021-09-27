
namespace SystemFix
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.FormControl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRegDevice = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnDevicePend = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.shapeContainer2 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label1 = new System.Windows.Forms.Label();
            this.lineShape2 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer3 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1526, 6);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(16, 18);
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1556, 6);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(16, 18);
            this.btnCerrar.TabIndex = 9;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // FormControl
            // 
            this.FormControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.FormControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.FormControl.Location = new System.Drawing.Point(0, 0);
            this.FormControl.Name = "FormControl";
            this.FormControl.Size = new System.Drawing.Size(1584, 31);
            this.FormControl.TabIndex = 11;
            this.FormControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FormControl_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(103)))), ((int)(((byte)(1)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnRegDevice);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.btnDevicePend);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.shapeContainer2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 830);
            this.panel1.TabIndex = 13;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(9, 734);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(308, 58);
            this.btnLogOut.TabIndex = 27;
            this.btnLogOut.Text = "CERRAR SESIÓN";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRegDevice
            // 
            this.btnRegDevice.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegDevice.FlatAppearance.BorderSize = 0;
            this.btnRegDevice.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.btnRegDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegDevice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnRegDevice.ForeColor = System.Drawing.Color.White;
            this.btnRegDevice.Image = ((System.Drawing.Image)(resources.GetObject("btnRegDevice.Image")));
            this.btnRegDevice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRegDevice.Location = new System.Drawing.Point(9, 129);
            this.btnRegDevice.Name = "btnRegDevice";
            this.btnRegDevice.Size = new System.Drawing.Size(308, 58);
            this.btnRegDevice.TabIndex = 25;
            this.btnRegDevice.Text = "REGISTRAR EQUIPO";
            this.btnRegDevice.UseVisualStyleBackColor = true;
            this.btnRegDevice.Click += new System.EventHandler(this.btnRegDevice_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.panel7.Location = new System.Drawing.Point(0, 734);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 58);
            this.panel7.TabIndex = 16;
            // 
            // btnDevicePend
            // 
            this.btnDevicePend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevicePend.FlatAppearance.BorderSize = 0;
            this.btnDevicePend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.btnDevicePend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevicePend.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnDevicePend.ForeColor = System.Drawing.Color.White;
            this.btnDevicePend.Image = ((System.Drawing.Image)(resources.GetObject("btnDevicePend.Image")));
            this.btnDevicePend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDevicePend.Location = new System.Drawing.Point(9, 211);
            this.btnDevicePend.Name = "btnDevicePend";
            this.btnDevicePend.Size = new System.Drawing.Size(308, 58);
            this.btnDevicePend.TabIndex = 21;
            this.btnDevicePend.Text = "      EQUIPOS REGISTRADOS";
            this.btnDevicePend.UseVisualStyleBackColor = true;
            this.btnDevicePend.Click += new System.EventHandler(this.btnDevicePend_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.panel4.Location = new System.Drawing.Point(0, 211);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 58);
            this.panel4.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(69)))), ((int)(((byte)(0)))));
            this.panel3.Location = new System.Drawing.Point(0, 129);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 58);
            this.panel3.TabIndex = 12;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(31, 28);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(250, 46);
            this.lblUser.TabIndex = 11;
            this.lblUser.Text = "OPERADOR";
            // 
            // shapeContainer2
            // 
            this.shapeContainer2.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer2.Name = "shapeContainer2";
            this.shapeContainer2.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer2.Size = new System.Drawing.Size(320, 830);
            this.shapeContainer2.TabIndex = 0;
            this.shapeContainer2.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderColor = System.Drawing.Color.White;
            this.lineShape1.BorderWidth = 2;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 16;
            this.lineShape1.X2 = 297;
            this.lineShape1.Y1 = 99;
            this.lineShape1.Y2 = 99;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 50.25F);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(336, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(629, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "SystemFix Software";
            // 
            // lineShape2
            // 
            this.lineShape2.BorderColor = System.Drawing.Color.White;
            this.lineShape2.BorderWidth = 2;
            this.lineShape2.Name = "lineShape2";
            this.lineShape2.X1 = 438;
            this.lineShape2.X2 = 1457;
            this.lineShape2.Y1 = 209;
            this.lineShape2.Y2 = 208;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 60.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(678, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(612, 105);
            this.label2.TabIndex = 0;
            this.label2.Text = "SYSTEMFIX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.75F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(370, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(614, 78);
            this.label3.TabIndex = 1;
            this.label3.Text = "    CONTROL DE REGISTROS PARA \r\nMANTENIMIENTO DE DISPOSITIVOS";
            // 
            // shapeContainer3
            // 
            this.shapeContainer3.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer3.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer3.Name = "shapeContainer3";
            this.shapeContainer3.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape2});
            this.shapeContainer3.Size = new System.Drawing.Size(1584, 861);
            this.shapeContainer3.TabIndex = 15;
            this.shapeContainer3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panel2.Location = new System.Drawing.Point(320, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1263, 828);
            this.panel2.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(601, 359);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(729, 94);
            this.label4.TabIndex = 18;
            this.label4.Text = "    SISTEMA DE CONTROL PARA \r\nMANTENIMIENTO DE DISPOSITIVOS";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.FormControl);
            this.Controls.Add(this.shapeContainer3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.Panel FormControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblUser;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnDevicePend;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnRegDevice;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape2;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
    }
}