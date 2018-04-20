namespace Generador_de_num_ps
{
    partial class Generador
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
            this.numSemilla = new System.Windows.Forms.NumericUpDown();
            this.numA = new System.Windows.Forms.NumericUpDown();
            this.numC = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.numN = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.TablaResulatdos = new System.Windows.Forms.DataGridView();
            this.ColumnaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaXn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaXn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numSemilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaResulatdos)).BeginInit();
            this.SuspendLayout();
            // 
            // numSemilla
            // 
            this.numSemilla.AccessibleName = "";
            this.numSemilla.Location = new System.Drawing.Point(64, 66);
            this.numSemilla.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numSemilla.Name = "numSemilla";
            this.numSemilla.Size = new System.Drawing.Size(71, 20);
            this.numSemilla.TabIndex = 0;
            this.toolTip1.SetToolTip(this.numSemilla, "Xo es le valor inicialo la semilla");
            this.numSemilla.Enter += new System.EventHandler(this.numSemilla_Enter);
            // 
            // numA
            // 
            this.numA.Location = new System.Drawing.Point(64, 93);
            this.numA.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numA.Name = "numA";
            this.numA.Size = new System.Drawing.Size(71, 20);
            this.numA.TabIndex = 1;
            this.toolTip1.SetToolTip(this.numA, "a es el multiplicador");
            this.numA.Enter += new System.EventHandler(this.numA_Enter);
            // 
            // numC
            // 
            this.numC.Location = new System.Drawing.Point(64, 119);
            this.numC.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numC.Name = "numC";
            this.numC.Size = new System.Drawing.Size(71, 20);
            this.numC.TabIndex = 2;
            this.toolTip1.SetToolTip(this.numC, "c es la constante aditiva");
            this.numC.Enter += new System.EventHandler(this.numC_Enter);
            // 
            // numM
            // 
            this.numM.Location = new System.Drawing.Point(64, 145);
            this.numM.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(71, 20);
            this.numM.TabIndex = 3;
            this.toolTip1.SetToolTip(this.numM, "m es el modulo");
            this.numM.Enter += new System.EventHandler(this.numM_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(379, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Generador de numeros pseudoaleatorios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Xo = ";
            this.toolTip1.SetToolTip(this.label2, "Xo es le valor inicialo la semilla");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "a =";
            this.toolTip1.SetToolTip(this.label3, "a es el multiplicador");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "c = ";
            this.toolTip1.SetToolTip(this.label4, "c es la constante aditiva");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "m =";
            this.toolTip1.SetToolTip(this.label5, "m es el modulo");
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(556, 343);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.btn_Aceptar.TabIndex = 9;
            this.btn_Aceptar.Text = "&Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // numN
            // 
            this.numN.Location = new System.Drawing.Point(64, 172);
            this.numN.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numN.Name = "numN";
            this.numN.Size = new System.Drawing.Size(71, 20);
            this.numN.TabIndex = 4;
            this.toolTip1.SetToolTip(this.numN, "n es el numero de iteraciones o de numeros que \r\nse desean imprmir\r\n");
            this.numN.Enter += new System.EventHandler(this.numN_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "n = ";
            this.toolTip1.SetToolTip(this.label6, "n es el numero de iteraciones o de numeros que \r\nse desean imprmir\r\n");
            // 
            // TablaResulatdos
            // 
            this.TablaResulatdos.AllowUserToAddRows = false;
            this.TablaResulatdos.AllowUserToDeleteRows = false;
            this.TablaResulatdos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaResulatdos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaN,
            this.ColumnaXn,
            this.ColumnaXn1,
            this.ColumnaR});
            this.TablaResulatdos.Location = new System.Drawing.Point(177, 66);
            this.TablaResulatdos.Name = "TablaResulatdos";
            this.TablaResulatdos.ReadOnly = true;
            this.TablaResulatdos.Size = new System.Drawing.Size(444, 260);
            this.TablaResulatdos.TabIndex = 12;
            // 
            // ColumnaN
            // 
            this.ColumnaN.HeaderText = "n";
            this.ColumnaN.Name = "ColumnaN";
            this.ColumnaN.ReadOnly = true;
            // 
            // ColumnaXn
            // 
            this.ColumnaXn.HeaderText = "Xn";
            this.ColumnaXn.Name = "ColumnaXn";
            this.ColumnaXn.ReadOnly = true;
            // 
            // ColumnaXn1
            // 
            this.ColumnaXn1.HeaderText = "Xn+1";
            this.ColumnaXn1.Name = "ColumnaXn1";
            this.ColumnaXn1.ReadOnly = true;
            // 
            // ColumnaR
            // 
            this.ColumnaR.HeaderText = "Rn";
            this.ColumnaR.Name = "ColumnaR";
            this.ColumnaR.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(537, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Acerca de";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(42, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "nueva mdificacion";
            // 
            // Generador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 378);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.TablaResulatdos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numN);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numM);
            this.Controls.Add(this.numC);
            this.Controls.Add(this.numA);
            this.Controls.Add(this.numSemilla);
            this.Controls.Add(this.label1);
            this.Name = "Generador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador";
            ((System.ComponentModel.ISupportInitialize)(this.numSemilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TablaResulatdos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numSemilla;
        private System.Windows.Forms.NumericUpDown numA;
        private System.Windows.Forms.NumericUpDown numC;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.NumericUpDown numN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView TablaResulatdos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaXn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaXn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaR;
        private System.Windows.Forms.Label label8;
    }
}

