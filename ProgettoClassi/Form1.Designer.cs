namespace ProgettoClassi
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pNameLbl = new System.Windows.Forms.Label();
            this.pHpLbl = new System.Windows.Forms.Label();
            this.pHpBar = new System.Windows.Forms.ProgressBar();
            this.playerPanel = new System.Windows.Forms.Panel();
            this.pPicture = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ePicture = new System.Windows.Forms.PictureBox();
            this.eNameLbl = new System.Windows.Forms.Label();
            this.eHpBar = new System.Windows.Forms.ProgressBar();
            this.eHpLbl = new System.Windows.Forms.Label();
            this.prevButt = new System.Windows.Forms.Button();
            this.nextButt = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.logs = new System.Windows.Forms.ListBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.playerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pNameLbl
            // 
            this.pNameLbl.AutoSize = true;
            this.pNameLbl.Location = new System.Drawing.Point(12, 10);
            this.pNameLbl.Name = "pNameLbl";
            this.pNameLbl.Size = new System.Drawing.Size(69, 13);
            this.pNameLbl.TabIndex = 1;
            this.pNameLbl.Text = "Nome mostro";
            // 
            // pHpLbl
            // 
            this.pHpLbl.AutoSize = true;
            this.pHpLbl.Location = new System.Drawing.Point(12, 34);
            this.pHpLbl.Name = "pHpLbl";
            this.pHpLbl.Size = new System.Drawing.Size(66, 13);
            this.pHpLbl.TabIndex = 2;
            this.pHpLbl.Text = "100/100 HP";
            this.pHpLbl.Click += new System.EventHandler(this.label1_Click);
            // 
            // pHpBar
            // 
            this.pHpBar.Location = new System.Drawing.Point(15, 59);
            this.pHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.pHpBar.Name = "pHpBar";
            this.pHpBar.Size = new System.Drawing.Size(202, 20);
            this.pHpBar.TabIndex = 3;
            // 
            // playerPanel
            // 
            this.playerPanel.Controls.Add(this.pPicture);
            this.playerPanel.Controls.Add(this.pNameLbl);
            this.playerPanel.Controls.Add(this.pHpBar);
            this.playerPanel.Controls.Add(this.pHpLbl);
            this.playerPanel.Location = new System.Drawing.Point(12, 12);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(232, 259);
            this.playerPanel.TabIndex = 4;
            // 
            // pPicture
            // 
            this.pPicture.Location = new System.Drawing.Point(15, 95);
            this.pPicture.Name = "pPicture";
            this.pPicture.Size = new System.Drawing.Size(202, 148);
            this.pPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pPicture.TabIndex = 4;
            this.pPicture.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ePicture);
            this.panel1.Controls.Add(this.eNameLbl);
            this.panel1.Controls.Add(this.eHpBar);
            this.panel1.Controls.Add(this.eHpLbl);
            this.panel1.Location = new System.Drawing.Point(307, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 259);
            this.panel1.TabIndex = 5;
            // 
            // ePicture
            // 
            this.ePicture.Location = new System.Drawing.Point(15, 101);
            this.ePicture.Name = "ePicture";
            this.ePicture.Size = new System.Drawing.Size(202, 148);
            this.ePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ePicture.TabIndex = 4;
            this.ePicture.TabStop = false;
            // 
            // eNameLbl
            // 
            this.eNameLbl.AutoSize = true;
            this.eNameLbl.Location = new System.Drawing.Point(12, 10);
            this.eNameLbl.Name = "eNameLbl";
            this.eNameLbl.Size = new System.Drawing.Size(69, 13);
            this.eNameLbl.TabIndex = 1;
            this.eNameLbl.Text = "Nome mostro";
            // 
            // eHpBar
            // 
            this.eHpBar.Location = new System.Drawing.Point(15, 59);
            this.eHpBar.Margin = new System.Windows.Forms.Padding(2);
            this.eHpBar.Name = "eHpBar";
            this.eHpBar.Size = new System.Drawing.Size(202, 20);
            this.eHpBar.TabIndex = 3;
            // 
            // eHpLbl
            // 
            this.eHpLbl.AutoSize = true;
            this.eHpLbl.Location = new System.Drawing.Point(12, 34);
            this.eHpLbl.Name = "eHpLbl";
            this.eHpLbl.Size = new System.Drawing.Size(66, 13);
            this.eHpLbl.TabIndex = 2;
            this.eHpLbl.Text = "100/100 HP";
            // 
            // prevButt
            // 
            this.prevButt.Location = new System.Drawing.Point(75, 315);
            this.prevButt.Margin = new System.Windows.Forms.Padding(2);
            this.prevButt.Name = "prevButt";
            this.prevButt.Size = new System.Drawing.Size(50, 25);
            this.prevButt.TabIndex = 6;
            this.prevButt.Text = "<";
            this.prevButt.UseVisualStyleBackColor = true;
            this.prevButt.Click += new System.EventHandler(this.prevButt_Click);
            // 
            // nextButt
            // 
            this.nextButt.Location = new System.Drawing.Point(307, 315);
            this.nextButt.Name = "nextButt";
            this.nextButt.Size = new System.Drawing.Size(50, 25);
            this.nextButt.TabIndex = 7;
            this.nextButt.Text = ">";
            this.nextButt.UseVisualStyleBackColor = true;
            this.nextButt.Click += new System.EventHandler(this.nextButt_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(430, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // logs
            // 
            this.logs.FormattingEnabled = true;
            this.logs.Location = new System.Drawing.Point(579, 12);
            this.logs.Name = "logs";
            this.logs.Size = new System.Drawing.Size(264, 264);
            this.logs.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(505, 293);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(166, 125);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 443);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.logs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.nextButt);
            this.Controls.Add(this.prevButt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.playerPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.playerPanel.ResumeLayout(false);
            this.playerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label pNameLbl;
        private System.Windows.Forms.Label pHpLbl;
        private System.Windows.Forms.ProgressBar pHpBar;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.PictureBox pPicture;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox ePicture;
        private System.Windows.Forms.Label eNameLbl;
        private System.Windows.Forms.ProgressBar eHpBar;
        private System.Windows.Forms.Label eHpLbl;
        private System.Windows.Forms.Button prevButt;
        private System.Windows.Forms.Button nextButt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox logs;
        private System.Windows.Forms.ListView listView1;
    }
}

