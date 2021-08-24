
namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtasunto = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtcuerpo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtdestino = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtasunto
            // 
            this.txtasunto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtasunto.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtasunto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtasunto.HintForeColor = System.Drawing.Color.Empty;
            this.txtasunto.HintText = "";
            this.txtasunto.isPassword = false;
            this.txtasunto.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtasunto.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtasunto.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtasunto.LineThickness = 3;
            this.txtasunto.Location = new System.Drawing.Point(97, 82);
            this.txtasunto.Margin = new System.Windows.Forms.Padding(4);
            this.txtasunto.Name = "txtasunto";
            this.txtasunto.Size = new System.Drawing.Size(236, 33);
            this.txtasunto.TabIndex = 2;
            this.txtasunto.Text = "Asunto";
            this.txtasunto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Turquoise;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 4;
            this.bunifuFlatButton1.ButtonText = "Enviar ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(97, 209);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(153, 48);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "Enviar ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // txtcuerpo
            // 
            this.txtcuerpo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcuerpo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtcuerpo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcuerpo.HintForeColor = System.Drawing.Color.Empty;
            this.txtcuerpo.HintText = "";
            this.txtcuerpo.isPassword = false;
            this.txtcuerpo.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtcuerpo.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtcuerpo.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtcuerpo.LineThickness = 3;
            this.txtcuerpo.Location = new System.Drawing.Point(97, 136);
            this.txtcuerpo.Margin = new System.Windows.Forms.Padding(4);
            this.txtcuerpo.Name = "txtcuerpo";
            this.txtcuerpo.Size = new System.Drawing.Size(236, 33);
            this.txtcuerpo.TabIndex = 3;
            this.txtcuerpo.Text = "Mensaje";
            this.txtcuerpo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtdestino
            // 
            this.txtdestino.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtdestino.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtdestino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtdestino.HintForeColor = System.Drawing.Color.Empty;
            this.txtdestino.HintText = "";
            this.txtdestino.isPassword = false;
            this.txtdestino.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtdestino.LineIdleColor = System.Drawing.Color.DeepSkyBlue;
            this.txtdestino.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtdestino.LineThickness = 3;
            this.txtdestino.Location = new System.Drawing.Point(97, 31);
            this.txtdestino.Margin = new System.Windows.Forms.Padding(4);
            this.txtdestino.Name = "txtdestino";
            this.txtdestino.Size = new System.Drawing.Size(236, 33);
            this.txtdestino.TabIndex = 1;
            this.txtdestino.Text = "demo@gmail.com";
            this.txtdestino.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(45, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Para:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Teal;
            this.label2.Location = new System.Drawing.Point(31, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Asunto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(31, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mensaje:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(392, 279);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtdestino);
            this.Controls.Add(this.txtcuerpo);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.txtasunto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Text = "Envio de correo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtasunto;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtcuerpo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtdestino;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

