using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TarimOtomasyon
{
    public partial class CiftlikTVForm : Form
    {
        public CiftlikTVForm()
        {
            InitializeComponent();
        }

        private void CiftlikTVForm_Load(object sender, EventArgs e)
        {
            string link = System.Environment.CurrentDirectory + "\\video.mp4";
            axWindowsMediaPlayer1.URL = link;
            axWindowsMediaPlayer1.windowlessVideo = true;
            axWindowsMediaPlayer1.enableContextMenu = false;
            axWindowsMediaPlayer1.uiMode = "none";
            axWindowsMediaPlayer1.settings.autoStart = true;
            axWindowsMediaPlayer1.settings.setMode("loop", true);
            axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            axWindowsMediaPlayer1.Size = this.Size;
        }
    }
}
