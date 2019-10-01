namespace EjemploNCapas
{
    partial class InterfazGrafica
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
            this.BShow = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.Bdelete = new System.Windows.Forms.Button();
            this.Bupdate = new System.Windows.Forms.Button();
            this.Bexit = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.Lname = new System.Windows.Forms.Label();
            this.Laddress = new System.Windows.Forms.Label();
            this.LPNum = new System.Windows.Forms.Label();
            this.LBD = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TAddress = new System.Windows.Forms.TextBox();
            this.TPN = new System.Windows.Forms.TextBox();
            this.TBD = new System.Windows.Forms.TextBox();
            this.Baccept = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.LID = new System.Windows.Forms.Label();
            this.TID = new System.Windows.Forms.TextBox();
            this.BAcceptID = new System.Windows.Forms.Button();
            this.BAcceptUpdate = new System.Windows.Forms.Button();
            this.Bclone = new System.Windows.Forms.Button();
            this.BaceptarClone = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BShow
            // 
            this.BShow.Location = new System.Drawing.Point(23, 46);
            this.BShow.Name = "BShow";
            this.BShow.Size = new System.Drawing.Size(75, 23);
            this.BShow.TabIndex = 0;
            this.BShow.Text = "Show";
            this.BShow.UseVisualStyleBackColor = true;
            this.BShow.Click += new System.EventHandler(this.BShow_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(116, 46);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(75, 23);
            this.BAdd.TabIndex = 1;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // Bdelete
            // 
            this.Bdelete.Location = new System.Drawing.Point(210, 46);
            this.Bdelete.Name = "Bdelete";
            this.Bdelete.Size = new System.Drawing.Size(75, 23);
            this.Bdelete.TabIndex = 2;
            this.Bdelete.Text = "Delete";
            this.Bdelete.UseVisualStyleBackColor = true;
            this.Bdelete.Click += new System.EventHandler(this.Bdelete_Click);
            // 
            // Bupdate
            // 
            this.Bupdate.Location = new System.Drawing.Point(297, 46);
            this.Bupdate.Name = "Bupdate";
            this.Bupdate.Size = new System.Drawing.Size(75, 23);
            this.Bupdate.TabIndex = 3;
            this.Bupdate.Text = "Update";
            this.Bupdate.UseVisualStyleBackColor = true;
            this.Bupdate.Click += new System.EventHandler(this.Bupdate_Click);
            // 
            // Bexit
            // 
            this.Bexit.Location = new System.Drawing.Point(345, 260);
            this.Bexit.Name = "Bexit";
            this.Bexit.Size = new System.Drawing.Size(75, 23);
            this.Bexit.TabIndex = 4;
            this.Bexit.Text = "Exit";
            this.Bexit.UseVisualStyleBackColor = true;
            this.Bexit.Click += new System.EventHandler(this.Bexit_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(207, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(41, 13);
            this.Title.TabIndex = 5;
            this.Title.Text = "Amigos";
            // 
            // Lname
            // 
            this.Lname.AutoSize = true;
            this.Lname.Location = new System.Drawing.Point(20, 94);
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(35, 13);
            this.Lname.TabIndex = 6;
            this.Lname.Text = "Name";
            this.Lname.Visible = false;
            // 
            // Laddress
            // 
            this.Laddress.AutoSize = true;
            this.Laddress.Location = new System.Drawing.Point(20, 126);
            this.Laddress.Name = "Laddress";
            this.Laddress.Size = new System.Drawing.Size(45, 13);
            this.Laddress.TabIndex = 7;
            this.Laddress.Text = "Address";
            this.Laddress.Visible = false;
            // 
            // LPNum
            // 
            this.LPNum.AutoSize = true;
            this.LPNum.Location = new System.Drawing.Point(20, 159);
            this.LPNum.Name = "LPNum";
            this.LPNum.Size = new System.Drawing.Size(78, 13);
            this.LPNum.TabIndex = 8;
            this.LPNum.Text = "Phone Number";
            this.LPNum.Visible = false;
            // 
            // LBD
            // 
            this.LBD.AutoSize = true;
            this.LBD.Location = new System.Drawing.Point(20, 193);
            this.LBD.Name = "LBD";
            this.LBD.Size = new System.Drawing.Size(50, 13);
            this.LBD.TabIndex = 9;
            this.LBD.Text = "Birth Day";
            this.LBD.Visible = false;
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(133, 87);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(287, 20);
            this.TName.TabIndex = 10;
            this.TName.Visible = false;
            this.TName.WordWrap = false;
            // 
            // TAddress
            // 
            this.TAddress.Location = new System.Drawing.Point(133, 123);
            this.TAddress.Name = "TAddress";
            this.TAddress.Size = new System.Drawing.Size(287, 20);
            this.TAddress.TabIndex = 11;
            this.TAddress.Visible = false;
            this.TAddress.WordWrap = false;
            // 
            // TPN
            // 
            this.TPN.Location = new System.Drawing.Point(133, 152);
            this.TPN.Name = "TPN";
            this.TPN.Size = new System.Drawing.Size(287, 20);
            this.TPN.TabIndex = 12;
            this.TPN.Visible = false;
            this.TPN.WordWrap = false;
            // 
            // TBD
            // 
            this.TBD.Location = new System.Drawing.Point(133, 190);
            this.TBD.Name = "TBD";
            this.TBD.Size = new System.Drawing.Size(287, 20);
            this.TBD.TabIndex = 13;
            this.TBD.Visible = false;
            this.TBD.WordWrap = false;
            // 
            // Baccept
            // 
            this.Baccept.Location = new System.Drawing.Point(23, 216);
            this.Baccept.Name = "Baccept";
            this.Baccept.Size = new System.Drawing.Size(397, 23);
            this.Baccept.TabIndex = 14;
            this.Baccept.Text = "Accept";
            this.Baccept.UseVisualStyleBackColor = true;
            this.Baccept.Visible = false;
            this.Baccept.Click += new System.EventHandler(this.Baccept_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 87);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(397, 150);
            this.dataGridView1.TabIndex = 15;
            // 
            // LID
            // 
            this.LID.AutoSize = true;
            this.LID.Location = new System.Drawing.Point(20, 71);
            this.LID.Name = "LID";
            this.LID.Size = new System.Drawing.Size(44, 13);
            this.LID.TabIndex = 16;
            this.LID.Text = "Enter Id";
            this.LID.Visible = false;
            // 
            // TID
            // 
            this.TID.Location = new System.Drawing.Point(70, 71);
            this.TID.Name = "TID";
            this.TID.Size = new System.Drawing.Size(100, 20);
            this.TID.TabIndex = 17;
            this.TID.Visible = false;
            // 
            // BAcceptID
            // 
            this.BAcceptID.Location = new System.Drawing.Point(210, 101);
            this.BAcceptID.Name = "BAcceptID";
            this.BAcceptID.Size = new System.Drawing.Size(75, 23);
            this.BAcceptID.TabIndex = 18;
            this.BAcceptID.Text = "Accept";
            this.BAcceptID.UseVisualStyleBackColor = true;
            this.BAcceptID.Visible = false;
            this.BAcceptID.Click += new System.EventHandler(this.BAcceptID_Click);
            // 
            // BAcceptUpdate
            // 
            this.BAcceptUpdate.Location = new System.Drawing.Point(23, 231);
            this.BAcceptUpdate.Name = "BAcceptUpdate";
            this.BAcceptUpdate.Size = new System.Drawing.Size(397, 23);
            this.BAcceptUpdate.TabIndex = 19;
            this.BAcceptUpdate.Text = "Accept";
            this.BAcceptUpdate.UseVisualStyleBackColor = true;
            this.BAcceptUpdate.Visible = false;
            this.BAcceptUpdate.Click += new System.EventHandler(this.BAcceptUpdate_Click);
            // 
            // Bclone
            // 
            this.Bclone.Location = new System.Drawing.Point(387, 46);
            this.Bclone.Name = "Bclone";
            this.Bclone.Size = new System.Drawing.Size(75, 23);
            this.Bclone.TabIndex = 20;
            this.Bclone.Text = "Clone";
            this.Bclone.UseVisualStyleBackColor = true;
            this.Bclone.Click += new System.EventHandler(this.Bclone_Click);
            // 
            // BaceptarClone
            // 
            this.BaceptarClone.Location = new System.Drawing.Point(81, 101);
            this.BaceptarClone.Name = "BaceptarClone";
            this.BaceptarClone.Size = new System.Drawing.Size(75, 23);
            this.BaceptarClone.TabIndex = 21;
            this.BaceptarClone.Text = "Accept";
            this.BaceptarClone.UseVisualStyleBackColor = true;
            this.BaceptarClone.Visible = false;
            this.BaceptarClone.Click += new System.EventHandler(this.BaceptarClone_Click);
            // 
            // InterfazGrafica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 295);
            this.Controls.Add(this.BaceptarClone);
            this.Controls.Add(this.Bclone);
            this.Controls.Add(this.BAcceptUpdate);
            this.Controls.Add(this.BAcceptID);
            this.Controls.Add(this.TID);
            this.Controls.Add(this.LID);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Baccept);
            this.Controls.Add(this.TBD);
            this.Controls.Add(this.TPN);
            this.Controls.Add(this.TAddress);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.LBD);
            this.Controls.Add(this.LPNum);
            this.Controls.Add(this.Laddress);
            this.Controls.Add(this.Lname);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Bexit);
            this.Controls.Add(this.Bupdate);
            this.Controls.Add(this.Bdelete);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.BShow);
            this.Name = "InterfazGrafica";
            this.Text = "InterfazGrafica";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BShow;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Button Bdelete;
        private System.Windows.Forms.Button Bupdate;
        private System.Windows.Forms.Button Bexit;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Lname;
        private System.Windows.Forms.Label Laddress;
        private System.Windows.Forms.Label LPNum;
        private System.Windows.Forms.Label LBD;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TAddress;
        private System.Windows.Forms.TextBox TPN;
        private System.Windows.Forms.TextBox TBD;
        private System.Windows.Forms.Button Baccept;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label LID;
        private System.Windows.Forms.TextBox TID;
        private System.Windows.Forms.Button BAcceptID;
        private System.Windows.Forms.Button BAcceptUpdate;
        private System.Windows.Forms.Button Bclone;
        private System.Windows.Forms.Button BaceptarClone;
    }
}