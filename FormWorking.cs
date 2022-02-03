using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace USBCopy_v2
{
    public partial class FormWorking : Form
    {
        public FormWorking()
        {
            InitializeComponent();
        }

        public FormWorking(string labelText)
        {
            InitializeComponent();
            labelWorking.Text = labelText;
        }

    }
}
