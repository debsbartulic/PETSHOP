using APPFORMS.Properties;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APPFORMS
{
    public partial class Form1 : MetroForm
    {
        private bool menuAberto = true;
        private ToolTip tt = new ToolTip();

        public Form1()
        {
            InitializeComponent();
        }

        private void MoveIcone()
        {
            if (menuAberto)
            {
                pbMenuHide.Location = new Point(sc.SplitterDistance + sc.Location.X - pbMenuHide.Width / 2, sc.Height / 2 + sc.Location.Y / 2);
                this.MinimumSize = new Size(827, 505);
                this.MaximumSize = new Size(827, 505);
                this.Size = new Size(827, 505);
                pbMenuHide.Image = Resources.arrowLeft;
            }
            else
            {
                pbMenuHide.Location = new Point(sc.Location.X - pbMenuHide.Width, sc.Height / 2 + sc.Location.Y / 2);
                this.MinimumSize = new Size(660, 505);
                this.MaximumSize = new Size(660, 505);
                this.Size = new Size(660, 505);
                pbMenuHide.Image = Resources.arrowRight;

            }
            pbCloseApp.Location = new Point(this.Width - 25, 6);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                this.sc.SplitterDistance = 167;
            }
            else
            {
                this.sc.SplitterDistance = 1;
            }
            MoveIcone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbMenuHide.BackColor = Color.Transparent;
            this.pbMenuHide.Focus();
            pbMenuHide.Location = new Point(sc.SplitterDistance + sc.Location.X - pbMenuHide.Width / 2, sc.Height / 2 + sc.Location.Y / 2);
        }

        private void pbCloseApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pbCloseApp_MouseEnter(object sender, EventArgs e)
        {
            tt.SetToolTip(this.pbCloseApp, "Fechar");
        }

        private void pbMenuHide_Click(object sender, EventArgs e)
        {
            if (menuAberto)
            {
                menuAberto = false;
                this.sc.Panel1.Hide();
                this.sc.SplitterDistance = 167;
                this.MinimumSize = new Size(827, 505);
                this.Size = new Size(827, 505);
                MoveIcone();
            }
            else
            {
                menuAberto = true;
                this.sc.Panel1.Show();
                this.sc.SplitterDistance = 1;
                this.MinimumSize = new Size(660, 505);
                this.Size = new Size(660, 505);
                MoveIcone();
            }
        }

        private void pbMenuHide_MouseEnter(object sender, EventArgs e)
        {
            if (menuAberto)
                tt.SetToolTip(this.pbMenuHide, "Esconder Menu");
            else
                tt.SetToolTip(this.pbMenuHide, "Exibir Menu");
        }
    }
}
