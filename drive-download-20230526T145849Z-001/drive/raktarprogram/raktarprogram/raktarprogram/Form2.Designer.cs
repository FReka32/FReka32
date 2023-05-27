
namespace raktarprogram
{
    partial class Form2
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.termekTablazat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.termekTorles = new System.Windows.Forms.Button();
            this.torlendoCikkszam = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.felvitelError = new System.Windows.Forms.Label();
            this.termekFelvitel = new System.Windows.Forms.Button();
            this.ujTermeknev = new System.Windows.Forms.TextBox();
            this.ujCikkszam = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.torlesError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.termekTablazat)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.termekTablazat);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1038, 553);
            this.splitContainer1.SplitterDistance = 344;
            this.splitContainer1.TabIndex = 0;
            // 
            // termekTablazat
            // 
            this.termekTablazat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.termekTablazat.Location = new System.Drawing.Point(15, 60);
            this.termekTablazat.Name = "termekTablazat";
            this.termekTablazat.RowHeadersWidth = 51;
            this.termekTablazat.RowTemplate.Height = 24;
            this.termekTablazat.Size = new System.Drawing.Size(313, 351);
            this.termekTablazat.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Termékek listája";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.torlesError);
            this.panel3.Controls.Add(this.termekTorles);
            this.panel3.Controls.Add(this.torlendoCikkszam);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 268);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(683, 262);
            this.panel3.TabIndex = 1;
            // 
            // termekTorles
            // 
            this.termekTorles.Location = new System.Drawing.Point(466, 175);
            this.termekTorles.Name = "termekTorles";
            this.termekTorles.Size = new System.Drawing.Size(107, 44);
            this.termekTorles.TabIndex = 3;
            this.termekTorles.Text = "Törlés";
            this.termekTorles.UseVisualStyleBackColor = true;
            this.termekTorles.Click += new System.EventHandler(this.termekTorles_Click);
            // 
            // torlendoCikkszam
            // 
            this.torlendoCikkszam.Location = new System.Drawing.Point(142, 99);
            this.torlendoCikkszam.Name = "torlendoCikkszam";
            this.torlendoCikkszam.Size = new System.Drawing.Size(431, 22);
            this.torlendoCikkszam.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(62, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cikkszám";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(470, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Termék törlése";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.felvitelError);
            this.panel1.Controls.Add(this.termekFelvitel);
            this.panel1.Controls.Add(this.ujTermeknev);
            this.panel1.Controls.Add(this.ujCikkszam);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 262);
            this.panel1.TabIndex = 0;
            // 
            // felvitelError
            // 
            this.felvitelError.AutoSize = true;
            this.felvitelError.ForeColor = System.Drawing.Color.Red;
            this.felvitelError.Location = new System.Drawing.Point(266, 85);
            this.felvitelError.Name = "felvitelError";
            this.felvitelError.Size = new System.Drawing.Size(310, 17);
            this.felvitelError.TabIndex = 6;
            this.felvitelError.Text = "Ilyen cikkszám már szerepel, válasszon másikat!";
            this.felvitelError.Visible = false;
            // 
            // termekFelvitel
            // 
            this.termekFelvitel.Location = new System.Drawing.Point(469, 200);
            this.termekFelvitel.Name = "termekFelvitel";
            this.termekFelvitel.Size = new System.Drawing.Size(107, 42);
            this.termekFelvitel.TabIndex = 5;
            this.termekFelvitel.Text = "Felvitel";
            this.termekFelvitel.UseVisualStyleBackColor = true;
            this.termekFelvitel.Click += new System.EventHandler(this.termekFelvitel_Click);
            // 
            // ujTermeknev
            // 
            this.ujTermeknev.Location = new System.Drawing.Point(145, 130);
            this.ujTermeknev.Name = "ujTermeknev";
            this.ujTermeknev.Size = new System.Drawing.Size(431, 22);
            this.ujTermeknev.TabIndex = 4;
            // 
            // ujCikkszam
            // 
            this.ujCikkszam.Location = new System.Drawing.Point(144, 60);
            this.ujCikkszam.Name = "ujCikkszam";
            this.ujCikkszam.Size = new System.Drawing.Size(431, 22);
            this.ujCikkszam.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Terméknév";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cikkszám";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Új termék felvitele";
            // 
            // torlesError
            // 
            this.torlesError.AutoSize = true;
            this.torlesError.ForeColor = System.Drawing.Color.Red;
            this.torlesError.Location = new System.Drawing.Point(377, 126);
            this.torlesError.Name = "torlesError";
            this.torlesError.Size = new System.Drawing.Size(195, 17);
            this.torlesError.TabIndex = 4;
            this.torlesError.Text = "Nincs ilyen cikkszámú termék!";
            this.torlesError.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 553);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.termekTablazat)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button termekTorles;
        private System.Windows.Forms.TextBox torlendoCikkszam;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button termekFelvitel;
        private System.Windows.Forms.TextBox ujTermeknev;
        private System.Windows.Forms.TextBox ujCikkszam;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView termekTablazat;
        private System.Windows.Forms.Label felvitelError;
        private System.Windows.Forms.Label torlesError;
    }
}