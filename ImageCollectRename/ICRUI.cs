using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageCollectRename
{
    public partial class ICRUI : Form
    {
        public ICRUI()
        {
            InitializeComponent();
        }

        private void ICRUI_Load(object sender, EventArgs e)
        {
            string[] files = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory);
            foreach (var item in files)
            {
                if (Path.GetExtension(item) == ".jpg")
                {
                    Guid guid = Guid.NewGuid();
                    File.Move(item, guid.ToString() + ".jpg");
                }
            }

            Application.Exit();
        }
    }
}
