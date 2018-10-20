namespace APPFORMS
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
            this.sc = new System.Windows.Forms.SplitContainer();
            this.pbMenuHide = new System.Windows.Forms.PictureBox();
            this.pbCloseApp = new System.Windows.Forms.PictureBox();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile2 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTile4 = new MetroFramework.Controls.MetroTile();
            this.metroTile5 = new MetroFramework.Controls.MetroTile();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).BeginInit();
            this.SuspendLayout();
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.Location = new System.Drawing.Point(20, 60);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.metroTile5);
            this.sc.Panel1.Controls.Add(this.metroTile4);
            this.sc.Panel1.Controls.Add(this.metroTile3);
            this.sc.Panel1.Controls.Add(this.metroTile2);
            this.sc.Panel1.Controls.Add(this.metroTile1);
            this.sc.Panel1MinSize = 1;
            this.sc.Size = new System.Drawing.Size(787, 425);
            this.sc.SplitterDistance = 167;
            this.sc.SplitterWidth = 1;
            this.sc.TabIndex = 0;
            // 
            // pbMenuHide
            // 
            this.pbMenuHide.BackColor = System.Drawing.Color.Transparent;
            this.pbMenuHide.Image = global::APPFORMS.Properties.Resources.arrowLeft;
            this.pbMenuHide.Location = new System.Drawing.Point(180, 252);
            this.pbMenuHide.Name = "pbMenuHide";
            this.pbMenuHide.Size = new System.Drawing.Size(14, 24);
            this.pbMenuHide.TabIndex = 2;
            this.pbMenuHide.TabStop = false;
            this.pbMenuHide.Click += new System.EventHandler(this.pbMenuHide_Click);
            this.pbMenuHide.MouseEnter += new System.EventHandler(this.pbMenuHide_MouseEnter);
            // 
            // pbCloseApp
            // 
            this.pbCloseApp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbCloseApp.Image = global::APPFORMS.Properties.Resources.cancel;
            this.pbCloseApp.Location = new System.Drawing.Point(798, 10);
            this.pbCloseApp.Name = "pbCloseApp";
            this.pbCloseApp.Size = new System.Drawing.Size(24, 24);
            this.pbCloseApp.TabIndex = 1;
            this.pbCloseApp.TabStop = false;
            this.pbCloseApp.Click += new System.EventHandler(this.pbCloseApp_Click);
            this.pbCloseApp.MouseEnter += new System.EventHandler(this.pbCloseApp_MouseEnter);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(3, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(150, 75);
            this.metroTile1.TabIndex = 0;
            this.metroTile1.Text = "metroTile1";
            this.metroTile1.UseSelectable = true;
            // 
            // metroTile2
            // 
            this.metroTile2.ActiveControl = null;
            this.metroTile2.Location = new System.Drawing.Point(3, 84);
            this.metroTile2.Name = "metroTile2";
            this.metroTile2.Size = new System.Drawing.Size(150, 75);
            this.metroTile2.TabIndex = 1;
            this.metroTile2.Text = "metroTile2";
            this.metroTile2.UseSelectable = true;
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(3, 165);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(150, 76);
            this.metroTile3.TabIndex = 2;
            this.metroTile3.Text = "metroTile3";
            this.metroTile3.UseSelectable = true;
            // 
            // metroTile4
            // 
            this.metroTile4.ActiveControl = null;
            this.metroTile4.Location = new System.Drawing.Point(3, 247);
            this.metroTile4.Name = "metroTile4";
            this.metroTile4.Size = new System.Drawing.Size(150, 75);
            this.metroTile4.TabIndex = 3;
            this.metroTile4.Text = "metroTile4";
            this.metroTile4.UseSelectable = true;
            // 
            // metroTile5
            // 
            this.metroTile5.ActiveControl = null;
            this.metroTile5.Location = new System.Drawing.Point(3, 328);
            this.metroTile5.Name = "metroTile5";
            this.metroTile5.Size = new System.Drawing.Size(150, 75);
            this.metroTile5.TabIndex = 4;
            this.metroTile5.Text = "metroTile5";
            this.metroTile5.UseSelectable = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 505);
            this.ControlBox = false;
            this.Controls.Add(this.pbMenuHide);
            this.Controls.Add(this.pbCloseApp);
            this.Controls.Add(this.sc);
            this.Name = "Form1";
            this.Resizable = false;
            this.Text = "Metro Show/Hide Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.sc.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenuHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCloseApp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.PictureBox pbCloseApp;
        private System.Windows.Forms.PictureBox pbMenuHide;
        private MetroFramework.Controls.MetroTile metroTile5;
        private MetroFramework.Controls.MetroTile metroTile4;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile2;
        private MetroFramework.Controls.MetroTile metroTile1;
    }
}

