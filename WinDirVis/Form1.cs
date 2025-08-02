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
using WinDirVis.Logs;

namespace WinDirVis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Gets all the systems logical drives
            string[] drives = Environment.GetLogicalDrives();

            //foreach(string drive in drives)
                LoadPath(drives[0], recusionLimit: 1000);
        }

        /// <summary>
        /// Recursive method to load all paths to t
        /// </summary>
        /// <param name="path"></param>
        public int LoadPath(string path, int recusionLimit = 0, int level = 5)
        {
            if (recusionLimit > 0 && level == recusionLimit)
                return level;

            try
            {
                string[] subpaths = Directory.GetDirectories(path);

                if (subpaths != null)
                {
                    foreach (string subpath in subpaths)
                    {
                        dirList.Rows.Add(subpath);
                        LoadPath(subpath, recusionLimit, level+1);
                    }
                }

                return level;
            }
            catch (Exception ex)
            {
                Logging.LogMessage(ex.Message);
                return 0;
            }
        }
    }
}
