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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.instrucciones = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.next = new System.Windows.Forms.Button();
            this.nombretb = new System.Windows.Forms.TextBox();
            this.addresstb = new System.Windows.Forms.TextBox();
            this.phonetb = new System.Windows.Forms.TextBox();
            this.birthtb = new System.Windows.Forms.TextBox();
            this.nombrelabel = new System.Windows.Forms.Label();
            this.direccionlabel = new System.Windows.Forms.Label();
            this.telefonolabel = new System.Windows.Forms.Label();
            this.fechalabel = new System.Windows.Forms.Label();
            this.idlabel = new System.Windows.Forms.Label();
            this.next2 = new System.Windows.Forms.Button();
            this.idtb = new System.Windows.Forms.TextBox();
            this.updateboton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Show Friends";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(214, 70);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Add Friend";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(334, 70);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(114, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Friend";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(454, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(114, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update Friend";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(272, 99);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(114, 23);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("AR BONNIE", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 41);
            this.label1.TabIndex = 5;
            this.label1.Text = "WELCOME TO FRIENDS APP!";
            // 
            // instrucciones
            // 
            this.instrucciones.AutoSize = true;
            this.instrucciones.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instrucciones.Location = new System.Drawing.Point(9, 123);
            this.instrucciones.Name = "instrucciones";
            this.instrucciones.Size = new System.Drawing.Size(238, 23);
            this.instrucciones.TabIndex = 6;
            this.instrucciones.Text = "--------------------------------------";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(61, 338);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 150);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(415, 263);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 8;
            this.next.Text = "Next";
            this.next.UseVisualStyleBackColor = true;
            this.next.Visible = false;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // nombretb
            // 
            this.nombretb.Location = new System.Drawing.Point(12, 238);
            this.nombretb.Name = "nombretb";
            this.nombretb.Size = new System.Drawing.Size(151, 20);
            this.nombretb.TabIndex = 9;
            this.nombretb.Visible = false;
            // 
            // addresstb
            // 
            this.addresstb.Location = new System.Drawing.Point(11, 302);
            this.addresstb.Name = "addresstb";
            this.addresstb.Size = new System.Drawing.Size(152, 20);
            this.addresstb.TabIndex = 10;
            this.addresstb.Visible = false;
            this.addresstb.TextChanged += new System.EventHandler(this.addresstb_TextChanged);
            // 
            // phonetb
            // 
            this.phonetb.Location = new System.Drawing.Point(210, 238);
            this.phonetb.Name = "phonetb";
            this.phonetb.Size = new System.Drawing.Size(155, 20);
            this.phonetb.TabIndex = 11;
            this.phonetb.Visible = false;
            // 
            // birthtb
            // 
            this.birthtb.Location = new System.Drawing.Point(210, 302);
            this.birthtb.Name = "birthtb";
            this.birthtb.Size = new System.Drawing.Size(155, 20);
            this.birthtb.TabIndex = 12;
            this.birthtb.Visible = false;
            // 
            // nombrelabel
            // 
            this.nombrelabel.AutoSize = true;
            this.nombrelabel.Location = new System.Drawing.Point(8, 215);
            this.nombrelabel.Name = "nombrelabel";
            this.nombrelabel.Size = new System.Drawing.Size(124, 13);
            this.nombrelabel.TabIndex = 13;
            this.nombrelabel.Text = "INGRESA EL NOMBRE:";
            this.nombrelabel.Visible = false;
            // 
            // direccionlabel
            // 
            this.direccionlabel.AutoSize = true;
            this.direccionlabel.Location = new System.Drawing.Point(9, 273);
            this.direccionlabel.Name = "direccionlabel";
            this.direccionlabel.Size = new System.Drawing.Size(136, 13);
            this.direccionlabel.TabIndex = 14;
            this.direccionlabel.Text = "INGRESA LA DIRECCIÓN:";
            this.direccionlabel.Visible = false;
            // 
            // telefonolabel
            // 
            this.telefonolabel.AutoSize = true;
            this.telefonolabel.Location = new System.Drawing.Point(207, 215);
            this.telefonolabel.Name = "telefonolabel";
            this.telefonolabel.Size = new System.Drawing.Size(134, 13);
            this.telefonolabel.TabIndex = 15;
            this.telefonolabel.Text = "INGRESA EL TELÉFONO:";
            this.telefonolabel.Visible = false;
            // 
            // fechalabel
            // 
            this.fechalabel.AutoSize = true;
            this.fechalabel.Location = new System.Drawing.Point(207, 273);
            this.fechalabel.Name = "fechalabel";
            this.fechalabel.Size = new System.Drawing.Size(155, 13);
            this.fechalabel.TabIndex = 16;
            this.fechalabel.Text = "INGRESA LA FECHA DE NAC:";
            this.fechalabel.Visible = false;
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Location = new System.Drawing.Point(9, 149);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(88, 13);
            this.idlabel.TabIndex = 17;
            this.idlabel.Text = "INGRESA EL ID:";
            this.idlabel.Visible = false;
            // 
            // next2
            // 
            this.next2.Location = new System.Drawing.Point(210, 175);
            this.next2.Name = "next2";
            this.next2.Size = new System.Drawing.Size(75, 23);
            this.next2.TabIndex = 18;
            this.next2.Text = "Next";
            this.next2.UseVisualStyleBackColor = true;
            this.next2.Visible = false;
            this.next2.Click += new System.EventHandler(this.next2_Click);
            // 
            // idtb
            // 
            this.idtb.Location = new System.Drawing.Point(12, 175);
            this.idtb.Name = "idtb";
            this.idtb.Size = new System.Drawing.Size(151, 20);
            this.idtb.TabIndex = 19;
            this.idtb.Visible = false;
            // 
            // updateboton
            // 
            this.updateboton.Location = new System.Drawing.Point(415, 215);
            this.updateboton.Name = "updateboton";
            this.updateboton.Size = new System.Drawing.Size(75, 23);
            this.updateboton.TabIndex = 20;
            this.updateboton.Text = "Next";
            this.updateboton.UseVisualStyleBackColor = true;
            this.updateboton.Visible = false;
            this.updateboton.Click += new System.EventHandler(this.updateboton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 500);
            this.Controls.Add(this.updateboton);
            this.Controls.Add(this.idtb);
            this.Controls.Add(this.next2);
            this.Controls.Add(this.idlabel);
            this.Controls.Add(this.fechalabel);
            this.Controls.Add(this.telefonolabel);
            this.Controls.Add(this.direccionlabel);
            this.Controls.Add(this.nombrelabel);
            this.Controls.Add(this.birthtb);
            this.Controls.Add(this.phonetb);
            this.Controls.Add(this.addresstb);
            this.Controls.Add(this.nombretb);
            this.Controls.Add(this.next);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.instrucciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label instrucciones;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.TextBox nombretb;
        private System.Windows.Forms.TextBox addresstb;
        private System.Windows.Forms.TextBox phonetb;
        private System.Windows.Forms.TextBox birthtb;
        private System.Windows.Forms.Label nombrelabel;
        private System.Windows.Forms.Label direccionlabel;
        private System.Windows.Forms.Label telefonolabel;
        private System.Windows.Forms.Label fechalabel;
        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.Button next2;
        private System.Windows.Forms.TextBox idtb;
        private System.Windows.Forms.Button updateboton;
    }
}

