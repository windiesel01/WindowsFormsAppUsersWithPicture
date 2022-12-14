namespace WindowsFormsAppUsersWithPicture
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hozzáadásToolStripMenuItem_insert = new System.Windows.Forms.ToolStripMenuItem();
            this.módosításToolStripMenuItem_update = new System.Windows.Forms.ToolStripMenuItem();
            this.törlésToolStripMenuItem_delete = new System.Windows.Forms.ToolStripMenuItem();
            this.listBox_felhasznalok = new System.Windows.Forms.ListBox();
            this.pictureBox_felhasznalo_kep = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_nev = new System.Windows.Forms.TextBox();
            this.dateTimePicker_szuletes = new System.Windows.Forms.DateTimePicker();
            this.textBox_kep_neve = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.képFeltöltésToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_felhasznalo_kep)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hozzáadásToolStripMenuItem_insert,
            this.módosításToolStripMenuItem_update,
            this.törlésToolStripMenuItem_delete,
            this.képFeltöltésToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hozzáadásToolStripMenuItem_insert
            // 
            this.hozzáadásToolStripMenuItem_insert.Name = "hozzáadásToolStripMenuItem_insert";
            this.hozzáadásToolStripMenuItem_insert.Size = new System.Drawing.Size(75, 20);
            this.hozzáadásToolStripMenuItem_insert.Text = "Hozzáadás";
            this.hozzáadásToolStripMenuItem_insert.Click += new System.EventHandler(this.hozzáadásToolStripMenuItem_insert_Click);
            // 
            // módosításToolStripMenuItem_update
            // 
            this.módosításToolStripMenuItem_update.Name = "módosításToolStripMenuItem_update";
            this.módosításToolStripMenuItem_update.Size = new System.Drawing.Size(74, 20);
            this.módosításToolStripMenuItem_update.Text = "Módosítás";
            this.módosításToolStripMenuItem_update.Click += new System.EventHandler(this.módosításToolStripMenuItem_update_Click);
            // 
            // törlésToolStripMenuItem_delete
            // 
            this.törlésToolStripMenuItem_delete.Name = "törlésToolStripMenuItem_delete";
            this.törlésToolStripMenuItem_delete.Size = new System.Drawing.Size(49, 20);
            this.törlésToolStripMenuItem_delete.Text = "Törlés";
            this.törlésToolStripMenuItem_delete.Click += new System.EventHandler(this.törlésToolStripMenuItem_delete_Click);
            // 
            // listBox_felhasznalok
            // 
            this.listBox_felhasznalok.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox_felhasznalok.FormattingEnabled = true;
            this.listBox_felhasznalok.Location = new System.Drawing.Point(0, 260);
            this.listBox_felhasznalok.Name = "listBox_felhasznalok";
            this.listBox_felhasznalok.Size = new System.Drawing.Size(800, 381);
            this.listBox_felhasznalok.TabIndex = 1;
            this.listBox_felhasznalok.SelectedIndexChanged += new System.EventHandler(this.listBox_felhasznalok_SelectedIndexChanged);
            // 
            // pictureBox_felhasznalo_kep
            // 
            this.pictureBox_felhasznalo_kep.Location = new System.Drawing.Point(550, 49);
            this.pictureBox_felhasznalo_kep.Name = "pictureBox_felhasznalo_kep";
            this.pictureBox_felhasznalo_kep.Size = new System.Drawing.Size(229, 200);
            this.pictureBox_felhasznalo_kep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_felhasznalo_kep.TabIndex = 2;
            this.pictureBox_felhasznalo_kep.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Név";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(12, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Felhasznalo képének neve";
            // 
            // textBox_nev
            // 
            this.textBox_nev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_nev.Location = new System.Drawing.Point(16, 108);
            this.textBox_nev.Name = "textBox_nev";
            this.textBox_nev.Size = new System.Drawing.Size(138, 26);
            this.textBox_nev.TabIndex = 6;
            // 
            // dateTimePicker_szuletes
            // 
            this.dateTimePicker_szuletes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dateTimePicker_szuletes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_szuletes.Location = new System.Drawing.Point(16, 165);
            this.dateTimePicker_szuletes.Name = "dateTimePicker_szuletes";
            this.dateTimePicker_szuletes.Size = new System.Drawing.Size(138, 26);
            this.dateTimePicker_szuletes.TabIndex = 7;
            // 
            // textBox_kep_neve
            // 
            this.textBox_kep_neve.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_kep_neve.Location = new System.Drawing.Point(16, 223);
            this.textBox_kep_neve.Name = "textBox_kep_neve";
            this.textBox_kep_neve.Size = new System.Drawing.Size(233, 26);
            this.textBox_kep_neve.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID";
            // 
            // textBox_id
            // 
            this.textBox_id.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox_id.Location = new System.Drawing.Point(16, 52);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.ReadOnly = true;
            this.textBox_id.Size = new System.Drawing.Size(40, 26);
            this.textBox_id.TabIndex = 10;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // képFeltöltésToolStripMenuItem
            // 
            this.képFeltöltésToolStripMenuItem.Name = "képFeltöltésToolStripMenuItem";
            this.képFeltöltésToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.képFeltöltésToolStripMenuItem.Text = "Kép feltöltés";
            this.képFeltöltésToolStripMenuItem.Click += new System.EventHandler(this.képFeltöltésToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_kep_neve);
            this.Controls.Add(this.dateTimePicker_szuletes);
            this.Controls.Add(this.textBox_nev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_felhasznalo_kep);
            this.Controls.Add(this.listBox_felhasznalok);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Felhasznalok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_felhasznalo_kep)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hozzáadásToolStripMenuItem_insert;
        private System.Windows.Forms.ToolStripMenuItem módosításToolStripMenuItem_update;
        private System.Windows.Forms.ToolStripMenuItem törlésToolStripMenuItem_delete;
        private System.Windows.Forms.ListBox listBox_felhasznalok;
        private System.Windows.Forms.PictureBox pictureBox_felhasznalo_kep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBox_id;
        public System.Windows.Forms.TextBox textBox_nev;
        public System.Windows.Forms.DateTimePicker dateTimePicker_szuletes;
        public System.Windows.Forms.TextBox textBox_kep_neve;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem képFeltöltésToolStripMenuItem;
    }
}

