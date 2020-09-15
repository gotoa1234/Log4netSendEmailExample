using System;
using System.Windows.Forms;

namespace Log4netSendEmailExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger("Log4net發送Mail測試工具");
        private void Form1_Load(object sender, EventArgs e)
        {
            log.Info("今天天氣不錯");
        }
    }
}
