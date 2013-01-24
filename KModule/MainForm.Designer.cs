namespace KModule
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listModules = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listParts = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonUninstall = new System.Windows.Forms.Button();
            this.buttonInstall = new System.Windows.Forms.Button();
            this.buttonMinimise = new KModule.PictureButton();
            this.buttonClose = new KModule.PictureButton();
            this.titleBar1 = new KModule.TitleBar();
            this.pictureButton1 = new KModule.PictureButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimise)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // listModules
            // 
            this.listModules.BackColor = System.Drawing.Color.White;
            this.listModules.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.listModules.FormattingEnabled = true;
            this.listModules.Location = new System.Drawing.Point(15, 50);
            this.listModules.Name = "listModules";
            this.listModules.Size = new System.Drawing.Size(195, 199);
            this.listModules.TabIndex = 3;
            this.listModules.SelectedIndexChanged += new System.EventHandler(this.listModules_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modules";
            // 
            // listParts
            // 
            this.listParts.BackColor = System.Drawing.Color.White;
            this.listParts.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.listParts.FormattingEnabled = true;
            this.listParts.Location = new System.Drawing.Point(318, 50);
            this.listParts.Name = "listParts";
            this.listParts.Size = new System.Drawing.Size(195, 238);
            this.listParts.TabIndex = 5;
            this.listParts.SelectedIndexChanged += new System.EventHandler(this.listParts_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label2.Location = new System.Drawing.Point(315, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Parts";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 7;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(114, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 8;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonUninstall
            // 
            this.buttonUninstall.Enabled = false;
            this.buttonUninstall.Location = new System.Drawing.Point(216, 147);
            this.buttonUninstall.Name = "buttonUninstall";
            this.buttonUninstall.Size = new System.Drawing.Size(96, 32);
            this.buttonUninstall.TabIndex = 10;
            this.buttonUninstall.Text = "Uninstall";
            this.buttonUninstall.UseVisualStyleBackColor = true;
            this.buttonUninstall.Click += new System.EventHandler(this.buttonUninstall_Click);
            // 
            // buttonInstall
            // 
            this.buttonInstall.Enabled = false;
            this.buttonInstall.Location = new System.Drawing.Point(216, 109);
            this.buttonInstall.Name = "buttonInstall";
            this.buttonInstall.Size = new System.Drawing.Size(96, 32);
            this.buttonInstall.TabIndex = 9;
            this.buttonInstall.Text = "Install";
            this.buttonInstall.UseVisualStyleBackColor = true;
            this.buttonInstall.Click += new System.EventHandler(this.buttonInstall_Click);
            // 
            // buttonMinimise
            // 
            this.buttonMinimise.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimise.Image = global::KModule.Properties.Resources.minimise;
            this.buttonMinimise.ImageDown = global::KModule.Properties.Resources.minimise_down;
            this.buttonMinimise.ImageHover = global::KModule.Properties.Resources.minimise_hover;
            this.buttonMinimise.Location = new System.Drawing.Point(476, 1);
            this.buttonMinimise.Name = "buttonMinimise";
            this.buttonMinimise.Size = new System.Drawing.Size(24, 24);
            this.buttonMinimise.TabIndex = 2;
            this.buttonMinimise.TabStop = false;
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.Image = global::KModule.Properties.Resources.close;
            this.buttonClose.ImageDown = global::KModule.Properties.Resources.close_down;
            this.buttonClose.ImageHover = global::KModule.Properties.Resources.close_hover;
            this.buttonClose.Location = new System.Drawing.Point(500, 1);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(24, 24);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.TabStop = false;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.Transparent;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.titleBar1.Location = new System.Drawing.Point(1, 1);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(523, 24);
            this.titleBar1.TabIndex = 1;
            this.titleBar1.Text = "Version 1.0";
            this.titleBar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureButton1
            // 
            this.pictureButton1.BackColor = System.Drawing.Color.Transparent;
            this.pictureButton1.Image = global::KModule.Properties.Resources.help;
            this.pictureButton1.ImageDown = global::KModule.Properties.Resources.help_down;
            this.pictureButton1.ImageHover = global::KModule.Properties.Resources.help_hover;
            this.pictureButton1.Location = new System.Drawing.Point(452, 1);
            this.pictureButton1.Name = "pictureButton1";
            this.pictureButton1.Size = new System.Drawing.Size(24, 24);
            this.pictureButton1.TabIndex = 11;
            this.pictureButton1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::KModule.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(525, 300);
            this.Controls.Add(this.pictureButton1);
            this.Controls.Add(this.buttonUninstall);
            this.Controls.Add(this.buttonInstall);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listParts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listModules);
            this.Controls.Add(this.buttonMinimise);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.titleBar1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KModule";
            ((System.ComponentModel.ISupportInitialize)(this.buttonMinimise)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureButton buttonClose;
        private TitleBar titleBar1;
        private PictureButton buttonMinimise;
        private System.Windows.Forms.ListBox listModules;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonUninstall;
        private System.Windows.Forms.Button buttonInstall;
        private PictureButton pictureButton1;


    }
}

