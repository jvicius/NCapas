namespace EjemploNCapas.GUI
{
    partial class UserInterface
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.deleteAmigo1 = new EjemploNCapas.GUI.DeleteAmigo();
            this.addAmigo1 = new EjemploNCapas.GUI.AddAmigo();
            this.show_Amigo1 = new EjemploNCapas.GUI.Show_Amigo();
            this.updateamigo1 = new EjemploNCapas.GUI.updateamigo();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(61, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(87, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Amigo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(61, 72);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Show Amigo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(61, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(87, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete Amigo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(61, 302);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Update Amigos";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // deleteAmigo1
            // 
            this.deleteAmigo1.Location = new System.Drawing.Point(286, 38);
            this.deleteAmigo1.Name = "deleteAmigo1";
            this.deleteAmigo1.Size = new System.Drawing.Size(433, 353);
            this.deleteAmigo1.TabIndex = 6;
            // 
            // addAmigo1
            // 
            this.addAmigo1.Location = new System.Drawing.Point(313, 63);
            this.addAmigo1.Name = "addAmigo1";
            this.addAmigo1.Size = new System.Drawing.Size(371, 291);
            this.addAmigo1.TabIndex = 5;
            // 
            // show_Amigo1
            // 
            this.show_Amigo1.Location = new System.Drawing.Point(202, 0);
            this.show_Amigo1.Name = "show_Amigo1";
            this.show_Amigo1.Size = new System.Drawing.Size(569, 421);
            this.show_Amigo1.TabIndex = 4;
            // 
            // updateamigo1
            // 
            this.updateamigo1.Location = new System.Drawing.Point(355, 72);
            this.updateamigo1.Name = "updateamigo1";
            this.updateamigo1.Size = new System.Drawing.Size(304, 272);
            this.updateamigo1.TabIndex = 7;
            // 
            // UserInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.updateamigo1);
            this.Controls.Add(this.deleteAmigo1);
            this.Controls.Add(this.addAmigo1);
            this.Controls.Add(this.show_Amigo1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserInterface";
            this.Text = "UserInterface";
            this.Load += new System.EventHandler(this.UserInterface_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private Show_Amigo show_Amigo1;
        private AddAmigo addAmigo1;
        private DeleteAmigo deleteAmigo1;
        private updateamigo updateamigo1;
    }
}