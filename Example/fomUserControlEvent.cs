using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetExample.Example
{
    public partial class fomUserControlEvent: Form
    {
        public fomUserControlEvent()
        {
            InitializeComponent();

            ucUserControlEvent1.LabelClick += new EventHandler((s, e) =>
            {
                MessageBox.Show(String.Format("點擊到UserControl中的Label了!!Label的文字為「{0}」", ((Label)s).Text));
            });
        }
    }
}
