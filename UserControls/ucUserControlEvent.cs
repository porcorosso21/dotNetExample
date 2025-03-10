using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetExample.UserControls
{
    public partial class ucUserControlEvent: UserControl
    {
        public EventHandler LabelClick;

        public ucUserControlEvent()
        {
            InitializeComponent();

            //綁定label的Click事件，並指定觸發LabelClick
            label1.Click += new EventHandler((s, e) =>
            {
                if (this.LabelClick != null)
                {
                    LabelClick(s, e);
                }
            });
        }


    }
}
