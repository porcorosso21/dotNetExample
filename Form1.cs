using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetExample
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //設定Form Text
            String formName = ".Net Example";
            this.Text = formName;

            menuStrip1.Visible = false;

            //取得Example資料夾內所有Form
            Type[] types = Assembly.GetExecutingAssembly().GetTypes();
            String namePpace = String.Format("{0}.Example", Assembly.GetExecutingAssembly().GetName().Name);
            List<Type> typeList = types.Where(t => t.BaseType.Name == nameof(Form) && t.Namespace.Contains(namePpace)).ToList();
            foreach (Type t in typeList)
            {
                Form f = (Form)Activator.CreateInstance(t);

                //建立下拉式選單
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Margin = new Padding(0, 3, 0, 3);
                tsmi.Text = f.Text;
                f.Text = "";
                tsmi.Click += new EventHandler((tsmis, tsmie) => //綁定點擊時顯示對應的From，若已存在則帶到最前面
                {
                    List<Form> childrenFrom = this.MdiChildren.Where(c => c.Name == f.Name).ToList();

                    if (childrenFrom.Count == 0)
                    {
                        f.MdiParent = this;
                        f.WindowState = FormWindowState.Maximized;
                        f.Show();
                    }
                    else
                    {
                        f.BringToFront();
                    }

                    this.Text = string.Format("{0} - {1}", formName, ((ToolStripMenuItem)tsmis).Text);
                });
                tsddbtnMenu.DropDownItems.Add(tsmi);
            }
        }
    }
}
