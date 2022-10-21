namespace WindowsFormsColaNormal
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtdato = new System.Windows.Forms.TextBox();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.listacola = new System.Windows.Forms.ListBox();
            this.DATO = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lime;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(244, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "AGREGAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtdato
            // 
            this.txtdato.Location = new System.Drawing.Point(73, 54);
            this.txtdato.Name = "txtdato";
            this.txtdato.Size = new System.Drawing.Size(153, 20);
            this.txtdato.TabIndex = 1;
            // 
            // btneliminar
            // 
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.White;
            this.btneliminar.Location = new System.Drawing.Point(244, 92);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(96, 32);
            this.btneliminar.TabIndex = 0;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnvaciar
            // 
            this.btnvaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnvaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvaciar.ForeColor = System.Drawing.Color.White;
            this.btnvaciar.Location = new System.Drawing.Point(244, 130);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(96, 32);
            this.btnvaciar.TabIndex = 0;
            this.btnvaciar.Text = "VACIAR";
            this.btnvaciar.UseVisualStyleBackColor = false;
            this.btnvaciar.Click += new System.EventHandler(this.btnvaciar_Click);
            // 
            // listacola
            // 
            this.listacola.FormattingEnabled = true;
            this.listacola.Location = new System.Drawing.Point(73, 92);
            this.listacola.Name = "listacola";
            this.listacola.Size = new System.Drawing.Size(153, 121);
            this.listacola.TabIndex = 2;
            // 
            // DATO
            // 
            this.DATO.AutoSize = true;
            this.DATO.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DATO.Location = new System.Drawing.Point(70, 38);
            this.DATO.Name = "DATO";
            this.DATO.Size = new System.Drawing.Size(39, 15);
            this.DATO.TabIndex = 3;
            this.DATO.Text = "DATO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "LISTA COLA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "COLA NORMAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 241);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DATO);
            this.Controls.Add(this.listacola);
            this.Controls.Add(this.txtdato);
            this.Controls.Add(this.btnvaciar);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "COLA NORMAL";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtdato;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.ListBox listacola;
        private System.Windows.Forms.Label DATO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

