namespace Practica7
{
    partial class ENCUESTA
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cal = new System.Windows.Forms.MonthCalendar();
            this.stdo = new System.Windows.Forms.ComboBox();
            this.spa = new System.Windows.Forms.CheckBox();
            this.ing = new System.Windows.Forms.CheckBox();
            this.alm = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mas = new System.Windows.Forms.RadioButton();
            this.fem = new System.Windows.Forms.RadioButton();
            this.num = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.com = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.imp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.num)).BeginInit();
            this.SuspendLayout();
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(299, 89);
            this.cal.Name = "cal";
            this.cal.TabIndex = 0;
            // 
            // stdo
            // 
            this.stdo.FormattingEnabled = true;
            this.stdo.Items.AddRange(new object[] {
            "JALISCO",
            "YUCATAN",
            "NUEVO LEON ",
            "CHIPAS",
            "VERACRUZ",
            "DURANGO",
            "SINALOA",
            "BAJA CALIFORNIA ",
            "ZACATECAS",
            "COLIMA",
            "OAXACA",
            "TABASCO",
            "MEXICO"});
            this.stdo.Location = new System.Drawing.Point(12, 30);
            this.stdo.Name = "stdo";
            this.stdo.Size = new System.Drawing.Size(90, 21);
            this.stdo.TabIndex = 1;
            this.stdo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // spa
            // 
            this.spa.AutoSize = true;
            this.spa.Location = new System.Drawing.Point(12, 114);
            this.spa.Name = "spa";
            this.spa.Size = new System.Drawing.Size(76, 17);
            this.spa.TabIndex = 2;
            this.spa.Text = "ESPAÑOL";
            this.spa.UseVisualStyleBackColor = true;
            // 
            // ing
            // 
            this.ing.AutoSize = true;
            this.ing.Location = new System.Drawing.Point(12, 146);
            this.ing.Name = "ing";
            this.ing.Size = new System.Drawing.Size(65, 17);
            this.ing.TabIndex = 3;
            this.ing.Text = "INGLES";
            this.ing.UseVisualStyleBackColor = true;
            // 
            // alm
            // 
            this.alm.AutoSize = true;
            this.alm.Location = new System.Drawing.Point(12, 175);
            this.alm.Name = "alm";
            this.alm.Size = new System.Drawing.Size(70, 17);
            this.alm.TabIndex = 4;
            this.alm.Text = "ALEMAN";
            this.alm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESTADO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IDIOMAS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "SEXO";
            // 
            // mas
            // 
            this.mas.AutoSize = true;
            this.mas.Location = new System.Drawing.Point(7, 234);
            this.mas.Name = "mas";
            this.mas.Size = new System.Drawing.Size(88, 17);
            this.mas.TabIndex = 8;
            this.mas.TabStop = true;
            this.mas.Text = "MASCULINO";
            this.mas.UseVisualStyleBackColor = true;
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(7, 257);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(81, 17);
            this.fem.TabIndex = 9;
            this.fem.TabStop = true;
            this.fem.Text = "FEMENINO";
            this.fem.UseVisualStyleBackColor = true;
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(7, 315);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(52, 20);
            this.num.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "EDAD";
            // 
            // com
            // 
            this.com.Location = new System.Drawing.Point(7, 341);
            this.com.Multiline = true;
            this.com.Name = "com";
            this.com.Size = new System.Drawing.Size(846, 87);
            this.com.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "COMENTARIOS";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(366, 67);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "FECHA DE NACIMIENTO ";
            // 
            // imp
            // 
            this.imp.Location = new System.Drawing.Point(645, 184);
            this.imp.Name = "imp";
            this.imp.Size = new System.Drawing.Size(132, 47);
            this.imp.TabIndex = 16;
            this.imp.Text = "IMPRIMIR";
            this.imp.UseVisualStyleBackColor = true;
            // 
            // ENCUESTA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.imp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.com);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.num);
            this.Controls.Add(this.fem);
            this.Controls.Add(this.mas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.alm);
            this.Controls.Add(this.ing);
            this.Controls.Add(this.spa);
            this.Controls.Add(this.stdo);
            this.Controls.Add(this.cal);
            this.Name = "ENCUESTA";
            this.Text = "ENCUESTA";
            this.Load += new System.EventHandler(this.ENCUESTA_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar cal;
        private System.Windows.Forms.ComboBox stdo;
        private System.Windows.Forms.CheckBox spa;
        private System.Windows.Forms.CheckBox ing;
        private System.Windows.Forms.CheckBox alm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton mas;
        private System.Windows.Forms.RadioButton fem;
        private System.Windows.Forms.NumericUpDown num;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox com;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button imp;
    }
}

