namespace EjemploNCapas
{
    partial class GUI
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
            this.inicio = new System.Windows.Forms.Panel();
            this.deleteAmigos = new System.Windows.Forms.Button();
            this.addAmigos = new System.Windows.Forms.Button();
            this.showAmigos = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.amigos = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Panel();
            this.agregar = new System.Windows.Forms.Button();
            this.regresar2 = new System.Windows.Forms.Button();
            this.regresar1 = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Panel();
            this.eliminar = new System.Windows.Forms.Button();
            this.regresar3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addAddress = new System.Windows.Forms.TextBox();
            this.addPhone = new System.Windows.Forms.TextBox();
            this.addBirthDate = new System.Windows.Forms.TextBox();
            this.updateAmigos = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Panel();
            this.regresar4 = new System.Windows.Forms.Button();
            this.actualizar = new System.Windows.Forms.Button();
            this.updateBirthDate = new System.Windows.Forms.TextBox();
            this.updatePhone = new System.Windows.Forms.TextBox();
            this.updateAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.updateName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.updateId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.inicio.SuspendLayout();
            this.amigos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.add.SuspendLayout();
            this.delete.SuspendLayout();
            this.update.SuspendLayout();
            this.SuspendLayout();
            // 
            // inicio
            // 
            this.inicio.Controls.Add(this.updateAmigos);
            this.inicio.Controls.Add(this.deleteAmigos);
            this.inicio.Controls.Add(this.addAmigos);
            this.inicio.Controls.Add(this.showAmigos);
            this.inicio.Controls.Add(this.label1);
            this.inicio.Location = new System.Drawing.Point(12, 12);
            this.inicio.Name = "inicio";
            this.inicio.Size = new System.Drawing.Size(380, 197);
            this.inicio.TabIndex = 0;
            // 
            // deleteAmigos
            // 
            this.deleteAmigos.Location = new System.Drawing.Point(139, 119);
            this.deleteAmigos.Name = "deleteAmigos";
            this.deleteAmigos.Size = new System.Drawing.Size(104, 23);
            this.deleteAmigos.TabIndex = 3;
            this.deleteAmigos.Text = "Delete Amigos";
            this.deleteAmigos.UseVisualStyleBackColor = true;
            this.deleteAmigos.Click += new System.EventHandler(this.DeleteAmigos_Click);
            // 
            // addAmigos
            // 
            this.addAmigos.Location = new System.Drawing.Point(139, 79);
            this.addAmigos.Name = "addAmigos";
            this.addAmigos.Size = new System.Drawing.Size(104, 23);
            this.addAmigos.TabIndex = 2;
            this.addAmigos.Text = "Add Amigos";
            this.addAmigos.UseVisualStyleBackColor = true;
            this.addAmigos.Click += new System.EventHandler(this.AddAmigos_Click);
            // 
            // showAmigos
            // 
            this.showAmigos.Location = new System.Drawing.Point(139, 40);
            this.showAmigos.Name = "showAmigos";
            this.showAmigos.Size = new System.Drawing.Size(104, 23);
            this.showAmigos.TabIndex = 1;
            this.showAmigos.Text = "Show Amigos";
            this.showAmigos.UseVisualStyleBackColor = true;
            this.showAmigos.Click += new System.EventHandler(this.ShowAmigos_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "MENU";
            // 
            // amigos
            // 
            this.amigos.Controls.Add(this.add);
            this.amigos.Controls.Add(this.dataGridView1);
            this.amigos.Controls.Add(this.regresar1);
            this.amigos.Location = new System.Drawing.Point(12, 12);
            this.amigos.Name = "amigos";
            this.amigos.Size = new System.Drawing.Size(380, 197);
            this.amigos.TabIndex = 4;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(17, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(347, 146);
            this.dataGridView1.TabIndex = 2;
            // 
            // add
            // 
            this.add.Controls.Add(this.delete);
            this.add.Controls.Add(this.addBirthDate);
            this.add.Controls.Add(this.addPhone);
            this.add.Controls.Add(this.addAddress);
            this.add.Controls.Add(this.label6);
            this.add.Controls.Add(this.label5);
            this.add.Controls.Add(this.label4);
            this.add.Controls.Add(this.addName);
            this.add.Controls.Add(this.label3);
            this.add.Controls.Add(this.agregar);
            this.add.Controls.Add(this.regresar2);
            this.add.Location = new System.Drawing.Point(0, 0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(380, 197);
            this.add.TabIndex = 1;
            // 
            // agregar
            // 
            this.agregar.Location = new System.Drawing.Point(211, 159);
            this.agregar.Name = "agregar";
            this.agregar.Size = new System.Drawing.Size(75, 23);
            this.agregar.TabIndex = 1;
            this.agregar.Text = "Add";
            this.agregar.UseVisualStyleBackColor = true;
            this.agregar.Click += new System.EventHandler(this.Agregar_Click);
            // 
            // regresar2
            // 
            this.regresar2.Location = new System.Drawing.Point(93, 159);
            this.regresar2.Name = "regresar2";
            this.regresar2.Size = new System.Drawing.Size(75, 23);
            this.regresar2.TabIndex = 0;
            this.regresar2.Text = "Back";
            this.regresar2.UseVisualStyleBackColor = true;
            this.regresar2.Click += new System.EventHandler(this.Regresar2_Click);
            // 
            // regresar1
            // 
            this.regresar1.Location = new System.Drawing.Point(154, 159);
            this.regresar1.Name = "regresar1";
            this.regresar1.Size = new System.Drawing.Size(75, 23);
            this.regresar1.TabIndex = 0;
            this.regresar1.Text = "Back";
            this.regresar1.UseVisualStyleBackColor = true;
            this.regresar1.Click += new System.EventHandler(this.Regresar1_Click);
            // 
            // delete
            // 
            this.delete.Controls.Add(this.update);
            this.delete.Controls.Add(this.textBox1);
            this.delete.Controls.Add(this.label2);
            this.delete.Controls.Add(this.eliminar);
            this.delete.Controls.Add(this.regresar3);
            this.delete.Location = new System.Drawing.Point(0, 0);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(380, 197);
            this.delete.TabIndex = 2;
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(211, 159);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 1;
            this.eliminar.Text = "Delete";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // regresar3
            // 
            this.regresar3.Location = new System.Drawing.Point(93, 159);
            this.regresar3.Name = "regresar3";
            this.regresar3.Size = new System.Drawing.Size(75, 23);
            this.regresar3.TabIndex = 0;
            this.regresar3.Text = "Back";
            this.regresar3.UseVisualStyleBackColor = true;
            this.regresar3.Click += new System.EventHandler(this.Regresar3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 20);
            this.textBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // addName
            // 
            this.addName.Location = new System.Drawing.Point(211, 30);
            this.addName.Name = "addName";
            this.addName.Size = new System.Drawing.Size(100, 20);
            this.addName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(120, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(127, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(114, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "BirthDate:";
            // 
            // addAddress
            // 
            this.addAddress.Location = new System.Drawing.Point(211, 58);
            this.addAddress.Name = "addAddress";
            this.addAddress.Size = new System.Drawing.Size(100, 20);
            this.addAddress.TabIndex = 7;
            // 
            // addPhone
            // 
            this.addPhone.Location = new System.Drawing.Point(211, 86);
            this.addPhone.Name = "addPhone";
            this.addPhone.Size = new System.Drawing.Size(100, 20);
            this.addPhone.TabIndex = 8;
            // 
            // addBirthDate
            // 
            this.addBirthDate.Location = new System.Drawing.Point(211, 116);
            this.addBirthDate.Name = "addBirthDate";
            this.addBirthDate.Size = new System.Drawing.Size(100, 20);
            this.addBirthDate.TabIndex = 9;
            // 
            // updateAmigos
            // 
            this.updateAmigos.Location = new System.Drawing.Point(139, 159);
            this.updateAmigos.Name = "updateAmigos";
            this.updateAmigos.Size = new System.Drawing.Size(104, 23);
            this.updateAmigos.TabIndex = 4;
            this.updateAmigos.Text = "Update Amigos";
            this.updateAmigos.UseVisualStyleBackColor = true;
            this.updateAmigos.Click += new System.EventHandler(this.UpdateAmigos_Click);
            // 
            // update
            // 
            this.update.Controls.Add(this.updateId);
            this.update.Controls.Add(this.updateBirthDate);
            this.update.Controls.Add(this.label11);
            this.update.Controls.Add(this.actualizar);
            this.update.Controls.Add(this.updatePhone);
            this.update.Controls.Add(this.regresar4);
            this.update.Controls.Add(this.updateAddress);
            this.update.Controls.Add(this.label7);
            this.update.Controls.Add(this.label10);
            this.update.Controls.Add(this.label8);
            this.update.Controls.Add(this.updateName);
            this.update.Controls.Add(this.label9);
            this.update.Location = new System.Drawing.Point(0, 0);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(380, 197);
            this.update.TabIndex = 3;
            // 
            // regresar4
            // 
            this.regresar4.Location = new System.Drawing.Point(93, 159);
            this.regresar4.Name = "regresar4";
            this.regresar4.Size = new System.Drawing.Size(75, 23);
            this.regresar4.TabIndex = 0;
            this.regresar4.Text = "Back";
            this.regresar4.UseVisualStyleBackColor = true;
            this.regresar4.Click += new System.EventHandler(this.Regresar4_Click);
            // 
            // actualizar
            // 
            this.actualizar.Location = new System.Drawing.Point(210, 159);
            this.actualizar.Name = "actualizar";
            this.actualizar.Size = new System.Drawing.Size(75, 23);
            this.actualizar.TabIndex = 1;
            this.actualizar.Text = "Update";
            this.actualizar.UseVisualStyleBackColor = true;
            this.actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // updateBirthDate
            // 
            this.updateBirthDate.Location = new System.Drawing.Point(210, 116);
            this.updateBirthDate.Name = "updateBirthDate";
            this.updateBirthDate.Size = new System.Drawing.Size(100, 20);
            this.updateBirthDate.TabIndex = 17;
            // 
            // updatePhone
            // 
            this.updatePhone.Location = new System.Drawing.Point(210, 86);
            this.updatePhone.Name = "updatePhone";
            this.updatePhone.Size = new System.Drawing.Size(100, 20);
            this.updatePhone.TabIndex = 16;
            // 
            // updateAddress
            // 
            this.updateAddress.Location = new System.Drawing.Point(210, 58);
            this.updateAddress.Name = "updateAddress";
            this.updateAddress.Size = new System.Drawing.Size(100, 20);
            this.updateAddress.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "BirthDate:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Phone:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(119, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Address:";
            // 
            // updateName
            // 
            this.updateName.Location = new System.Drawing.Point(210, 30);
            this.updateName.Name = "updateName";
            this.updateName.Size = new System.Drawing.Size(100, 20);
            this.updateName.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(129, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Name:";
            // 
            // updateId
            // 
            this.updateId.Location = new System.Drawing.Point(52, 30);
            this.updateId.Name = "updateId";
            this.updateId.Size = new System.Drawing.Size(43, 20);
            this.updateId.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Id:";
            // 
            // GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 221);
            this.Controls.Add(this.amigos);
            this.Controls.Add(this.inicio);
            this.Name = "GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GUI";
            this.Load += new System.EventHandler(this.GUI_Load);
            this.inicio.ResumeLayout(false);
            this.inicio.PerformLayout();
            this.amigos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.add.ResumeLayout(false);
            this.add.PerformLayout();
            this.delete.ResumeLayout(false);
            this.delete.PerformLayout();
            this.update.ResumeLayout(false);
            this.update.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel inicio;
        private System.Windows.Forms.Button showAmigos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteAmigos;
        private System.Windows.Forms.Button addAmigos;
        private System.Windows.Forms.Panel amigos;
        private System.Windows.Forms.Button regresar1;
        private System.Windows.Forms.Panel add;
        private System.Windows.Forms.Button agregar;
        private System.Windows.Forms.Button regresar2;
        private System.Windows.Forms.Panel delete;
        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button regresar3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox addName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addBirthDate;
        private System.Windows.Forms.TextBox addPhone;
        private System.Windows.Forms.TextBox addAddress;
        private System.Windows.Forms.Button updateAmigos;
        private System.Windows.Forms.Panel update;
        private System.Windows.Forms.Button actualizar;
        private System.Windows.Forms.Button regresar4;
        private System.Windows.Forms.TextBox updateBirthDate;
        private System.Windows.Forms.TextBox updatePhone;
        private System.Windows.Forms.TextBox updateAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox updateName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox updateId;
        private System.Windows.Forms.Label label11;
    }
}