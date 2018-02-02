using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SldWorksSN;
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swconst;
//using SwconstSN;
using System.Reflection;
using System.IO;

namespace TestingSWApi
{
    public partial class Form1 : Form
    {
        private SldWorks _swApp;
        private string _exePath;

        public Form1()
        {
            InitializeComponent();
            _exePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _swApp = new SldWorks();
            _swApp.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int errors = 0;
            int warnings = 0;
            var swPartFileFullName = Path.Combine(_exePath, "24036600.sldprt");
            _swApp.OpenDoc6(swPartFileFullName, (int)swDocumentTypes_e.swDocPART, (int)swOpenDocOptions_e.swOpenDocOptions_Silent, "",ref errors, ref warnings);
        }
    }
}
