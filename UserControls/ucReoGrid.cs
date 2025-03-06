using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using unvell.ReoGrid;
using unvell.ReoGrid.Data;
using unvell.ReoGrid.DataFormat;
using System.Drawing.Text;
using unvell.ReoGrid.IO.OpenXML.Schema;
using static System.Net.WebRequestMethods;
using Renci.SshNet;

namespace dotNetExample.UserControls
{
    public partial class ucReoGrid: UserControl
    {
        public ucReoGrid()
        {
            InitializeComponent();
        }

        private void ucReoGrid_Load(object sender, EventArgs e)
        {
            init();
        }

        #region 檔案
        /// <summary>
        /// 開啟
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFileOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel Files|*.xlsx";
            if (ofd.ShowDialog() != DialogResult.OK) { return; }

            try
            {
                rg.Load(ofd.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);

                rg.CurrentWorksheet.SelectionRangeChanged += CurrentWorksheet_SelectionRangeChanged;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "錯誤訊息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFileNew_Click(object sender, EventArgs e)
        {
            rg.Reset();
        }
        
        /// <summary>
        /// 另存新檔
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFileSaveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Files|*.xlsx";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                rg.Save(sfd.FileName, unvell.ReoGrid.IO.FileFormat.Excel2007);
                MessageBox.Show("儲存成功", "儲存檔案", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion

        #region 編輯
        private void tsbtnCut_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Cut();
        }

        private void tsbtnCopy_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Copy();
        }

        private void tsbtnPaste_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Paste();
        }
        #endregion

        #region 格式化選取範圍

        /// <summary>
        /// 文字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFormatText_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRangeDataFormat(
            rg.CurrentWorksheet.SelectionRange,
            CellDataFormatFlag.Text);
        }

        /// <summary>
        /// 數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFormatNumber_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRangeDataFormat(
            rg.CurrentWorksheet.SelectionRange,
            CellDataFormatFlag.Number,
            new NumberDataFormatter.NumberFormatArgs
            { 
                DecimalPlaces = 4,
                UseSeparator = false
            });
        }

        /// <summary>
        /// 百分比
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFormatPercent_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRangeDataFormat(
            rg.CurrentWorksheet.SelectionRange,
            CellDataFormatFlag.Percent,
            new NumberDataFormatter.NumberFormatArgs
            {
                DecimalPlaces = 2,
            });
        }
        /// <summary>
        /// 日期
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFormatDate_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRangeDataFormat(
                rg.CurrentWorksheet.SelectionRange,
                CellDataFormatFlag.DateTime,
                new DateTimeDataFormatter.DateTimeFormatArgs{
                    // culture
                    CultureName = "en-US",
                    // pattern
                    Format = "yyyy/MM/dd",
                });
        }

        /// <summary>
        /// 金錢
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiFormatCurrency_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRangeDataFormat(
            rg.CurrentWorksheet.SelectionRange,
            CellDataFormatFlag.Currency,
            new CurrencyDataFormatter.CurrencyFormatArgs
            {
                CultureEnglishName = "en-US",
                DecimalPlaces = 0,
                UseSeparator = true,
                PrefixSymbol = "$"
            });
        }
        #endregion

        #region 字體
        /// <summary>
        /// 粗體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnBold_Click(object sender, EventArgs e)
        {
            tsbtnBold.Checked = !tsbtnBold.Checked;
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.Bold = tsbtnBold.Checked;
            tsbtnBold.ForeColor = (tsbtnBold.Checked ? Color.RoyalBlue : SystemColors.ControlText);
        }

        /// <summary>
        /// 斜體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnItalic_Click(object sender, EventArgs e)
        {
            tsbtnItalic.Checked = !tsbtnItalic.Checked;
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.Italic = tsbtnItalic.Checked;
            tsbtnItalic.ForeColor = (tsbtnItalic.Checked ? Color.RoyalBlue : SystemColors.ControlText);
        }

        /// <summary>
        /// 底線
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnUnderline_Click(object sender, EventArgs e)
        {
            tsbtnUnderline.Checked = !tsbtnUnderline.Checked;
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.Underline = tsbtnUnderline.Checked;
            tsbtnUnderline.ForeColor = (tsbtnUnderline.Checked ? Color.RoyalBlue : SystemColors.ControlText);
        }
        #endregion

        #region 對齊
        private void tsmiAlignTop_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.VerticalAlign = ReoGridVerAlign.Top;
        }

        private void tsmiAlignMiddle_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.VerticalAlign = ReoGridVerAlign.Middle;
        }

        private void tsmiAlignBottom_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.VerticalAlign = ReoGridVerAlign.Bottom;
        }

        private void tsmiAlignLeft_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.HorizontalAlign = ReoGridHorAlign.Left;
        }

        private void tsmiAlignCenter_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.HorizontalAlign = ReoGridHorAlign.Center;
        }

        private void tsmiAlignRight_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.HorizontalAlign = ReoGridHorAlign.Right;
        }
        #endregion

        #region 凍結視窗
        /// <summary>
        /// 凍結視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnFreezeToCell_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Unfreeze();
            rg.CurrentWorksheet.FreezeToCell(rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.Col);
        }

        /// <summary>
        /// 取消凍結視窗
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnUnfreeze_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.Unfreeze();

        }
        #endregion

        #region 排序及過濾
        /// <summary>
        /// 排序及過濾
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsbtnSortFilter_Click(object sender, EventArgs e)
        {
            tsbtnSortFilter.Checked = !tsbtnSortFilter.Checked;
            rg.CurrentWorksheet.CreateColumnFilter(0, rg.CurrentWorksheet.ColumnCount - 1, 0, tsbtnSortFilter.Checked?AutoColumnFilterUI.DropdownButtonAndPanel: AutoColumnFilterUI.NoGUI);
            tsbtnSortFilter.ForeColor = (tsbtnSortFilter.Checked ? Color.RoyalBlue : SystemColors.ControlText);
        }
        #endregion

        #region ContextMenuRowHeader
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowInsert_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.InsertRows(rg.CurrentWorksheet.SelectionRange.Row, 1);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowDelete_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.DeleteRows(rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.EndRow - rg.CurrentWorksheet.SelectionRange.Row + 1);
        }

        /// <summary>
        /// 列高
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowHeight_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetRowsHeight(rg.CurrentWorksheet.SelectionRange.Row, (rg.CurrentWorksheet.SelectionRange.EndRow - rg.CurrentWorksheet.SelectionRange.Row + 1), Convert.ToUInt16(25));
        }

        /// <summary>
        /// 隱藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowHide_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.HideRows(rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.EndRow - rg.CurrentWorksheet.SelectionRange.Row + 1);
        }

        /// <summary>
        /// 取消隱藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiRowShow_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.ShowRows(rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.EndRow - rg.CurrentWorksheet.SelectionRange.Row + 1);
        }
        #endregion

        #region ContextMenuColumnHeader
        /// <summary>
        /// 插入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColumnInsert_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.InsertColumns(rg.CurrentWorksheet.SelectionRange.Col, 1);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColumnDelete_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.DeleteColumns(rg.CurrentWorksheet.SelectionRange.Col, rg.CurrentWorksheet.SelectionRange.EndCol - rg.CurrentWorksheet.SelectionRange.Col + 1);
        }

        /// <summary>
        /// 欄寬
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColumnWidth_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.SetColumnsWidth(rg.CurrentWorksheet.SelectionRange.Col, (rg.CurrentWorksheet.SelectionRange.EndCol - rg.CurrentWorksheet.SelectionRange.Col + 1), Convert.ToUInt16(80));
        }
        
        /// <summary>
        /// 隱藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColumnHide_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.HideColumns(rg.CurrentWorksheet.SelectionRange.Col, rg.CurrentWorksheet.SelectionRange.EndCol - rg.CurrentWorksheet.SelectionRange.Col + 1);
        }

        /// <summary>
        /// 取消隱藏
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiColumnShow_Click(object sender, EventArgs e)
        {
            rg.CurrentWorksheet.ShowColumns(rg.CurrentWorksheet.SelectionRange.Col, rg.CurrentWorksheet.SelectionRange.EndCol - rg.CurrentWorksheet.SelectionRange.Col + 1);
        }
        #endregion

        #region ContextMenuSheetTab
        /// <summary>
        /// 新增Sheet
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSheetTabCreate_Click(object sender, EventArgs e)
        {
            var sheet = rg.CreateWorksheet();
            rg.Worksheets.Add(sheet);
        }

        /// <summary>
        /// 刪除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSheetTabRemove_Click(object sender, EventArgs e)
        {
            rg.Worksheets.Remove(rg.CurrentWorksheet);
            rg.CurrentWorksheet.RequestInvalidate();
        }
        #endregion

        /// <summary>
        /// EVENT
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rg_CurrentWorksheetChanged(object sender, EventArgs e)
        {
            //取得目前顯示比例
            tsddbtnZoon.Text = Convert.ToInt32((rg.CurrentWorksheet.ScaleFactor * 100)).ToString() + "%";
        }

        /// <summary>
        /// METHOD 初始化
        /// </summary>
        private void init()
        {
            //字型
            String DefaultFontFamily = "標楷體";
            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            foreach (FontFamily ff in installedFontCollection.Families)
            {
                tscmbFontFamily.Items.Add(ff.Name);
            }
            //選擇預設字型
            if (installedFontCollection.Families.Where(ff => ff.Name == DefaultFontFamily).ToList().Count == 1) 
            {
                tscmbFontFamily.SelectedItem = DefaultFontFamily;
            }
            else
            {
                tscmbFontFamily.SelectedIndex = 0;
            }
            //綁定字型異動
            tscmbFontFamily.SelectedIndexChanged += new EventHandler((s, e) =>
            {
                rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.FontName = tscmbFontFamily.Text;
            });

            //字體大小
            Int32 DefaultFontSize = 12;
            List<Int32> FontSizeList = new List<int> { 6, 8, 9, 10, 11, 12, 14, 16, 18, 20, 22, 24, 26, 28, 36, 48, 72 };
            foreach (Int32 fs in FontSizeList)
            {
                tscmbFontSize.Items.Add(fs);
            }
            tscmbFontSize.SelectedItem = DefaultFontSize;
            tscmbFontSize.SelectedIndexChanged += new EventHandler((s, e) =>
            {
                rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.FontSize = (float)Convert.ToDecimal(tscmbFontSize.SelectedItem);
            });

            //文字顏色
            ReoGridColorPicker TextColorPicker = new ReoGridColorPicker();
            TextColorPicker.Pick += new EventHandler((s, e) =>
            {
                rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.TextColor = TextColorPicker.PickColor;
            });
            tsddbtnTextColor.DropDownItems.Add(TextColorPicker);

            //填滿色彩
            ReoGridColorPicker BackColorPicker = new ReoGridColorPicker();
            BackColorPicker.Pick += new EventHandler((s, e) =>
            {
                rg.CurrentWorksheet.Ranges[rg.CurrentWorksheet.SelectionRange.ToString()].Style.BackColor = BackColorPicker.PickColor;
            });
            tsddbtnBackColor.DropDownItems.Add(BackColorPicker);

            //排序及過濾中文化
            LanguageResource.Filter_SelectAll = "全部";
            LanguageResource.Filter_SortAtoZ = "排序AtoZ";
            LanguageResource.Filter_SortZtoA = "排序ZtoA";
            LanguageResource.Filter_Blanks = "空白";

            //選取範圍
            tstbSelectionRange.Text = "";
            rg.CurrentWorksheet.SelectionRangeChanged += CurrentWorksheet_SelectionRangeChanged;

            //修改值
            tstbCellText.LostFocus += new EventHandler((s, e) =>
            {
                if (rg.CurrentWorksheet.SelectionRange.Rows == 1 && rg.CurrentWorksheet.SelectionRange.Cols == 1)
                {
                    unvell.ReoGrid.Cell c = rg.CurrentWorksheet.Cells[rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.Col];
                    if (c != null)
                    {
                        rg.CurrentWorksheet[c.Address] = tstbCellText.Text;
                    }
                }
            });
            tstbCellText.KeyDown += new KeyEventHandler((s,e) => {
                if (e.KeyCode != Keys.Enter) { return; }

                if (rg.CurrentWorksheet.SelectionRange.Rows == 1 && rg.CurrentWorksheet.SelectionRange.Cols == 1)
                {
                    unvell.ReoGrid.Cell c = rg.CurrentWorksheet.Cells[rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.Col];
                    if (c != null)
                    {
                        rg.CurrentWorksheet[c.Address] = tstbCellText.Text;
                    }
                }
            });

            //Column 右鍵選單
            rg.ColumnHeaderContextMenuStrip = cmsColumnHeader;

            //Row 右鍵選單
            rg.RowHeaderContextMenuStrip = cmsRowHeader;

            //Sheet Tab Control
            rg.SheetTabWidth = Convert.ToInt32(this.Width / 3 * 2); //預設為總寬度2/3

            //Sheet Tab 右鍵選單中文化
            LanguageResource.Menu_InsertSheet = "新增Sheet";
            LanguageResource.Menu_DeleteSheet = "刪除Sheet";
            LanguageResource.Menu_RenameSheet = "重新命名";
            LanguageResource.Sheet_RenameDialog_Title = "Sheet重新命名";
            LanguageResource.Sheet_RenameDialog_NameLabel = "Sheet名稱";

            //顯示比例
            tsddbtnZoon.Text = "100%";
            for (int i = 10; i <= 200; i = i + 10)
            {
                ToolStripMenuItem tsmi = new ToolStripMenuItem();
                tsmi.Text = i.ToString() + "%";
                //綁定顯示比例異動
                tsmi.Click += new EventHandler((s, e) =>
                {
                    Decimal Scale = Convert.ToDecimal(((ToolStripMenuItem)s).Text.Replace("%", "")) / 100;
                    rg.CurrentWorksheet.ScaleFactor = (float)Scale;
                    tsddbtnZoon.Text = ((ToolStripMenuItem)s).Text;
                });
                tsddbtnZoon.DropDownItems.Add(tsmi);
            }
        }



        /// <summary>
        /// 選取範圍異動
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CurrentWorksheet_SelectionRangeChanged(object sender, unvell.ReoGrid.Events.RangeEventArgs e)
        {
            //顯次選取範圍
            tstbSelectionRange.Text = rg.CurrentWorksheet.SelectionRange.ToString();

            //帶出選擇資料
            if (rg.CurrentWorksheet.SelectionRange.Rows == 1 && rg.CurrentWorksheet.SelectionRange.Cols == 1)
            {
                unvell.ReoGrid.Cell c = rg.CurrentWorksheet.Cells[rg.CurrentWorksheet.SelectionRange.Row, rg.CurrentWorksheet.SelectionRange.Col];
                if (c != null)
                {
                    tstbCellText.Text = c.DisplayText;
                }
            }
            else
            {
                tstbCellText.Text = "";
            }
        }

        /// <summary>
        /// Class ColorPicker
        /// </summary>
        private class ReoGridColorPicker : ToolStripControlHost
        {
            /// <summary>
            /// 挑選的顏色
            /// </summary>
            public Color PickColor
            {
                get { return pickcolor; }
                set { pickcolor = value; }
            }
            private Color pickcolor = Color.Black;

            /// <summary>
            /// 挑選色彩事件
            /// </summary>
            public event EventHandler Pick;
            private void ReoGridColorPicker_LabelColor_Click(object sender, EventArgs e)
            {
                this.pickcolor = ((Label)sender).BackColor;
                Pick(this, e);
            }

            public ReoGridColorPicker()
                : base(new ReoGridColorPickerPanel())
            {
                //Int32 width = this.Width;
                this.Width = 168;
                this.Margin = new Padding(-33, 0, 0, 0);
                this.BackColor = SystemColors.Control;

                ((ReoGridColorPickerPanel)base.Control).LabelColor_Click += ReoGridColorPicker_LabelColor_Click;
            }

            private class ReoGridColorPickerPanel : Panel
            {
                /// <summary>
                /// 色彩Label點擊事件
                /// </summary>
                public event EventHandler LabelColor_Click;
                private void labelcolor_click(object sender, EventArgs e)
                {
                    LabelColor_Click(sender, e);
                }

                /// <summary>主題色彩</summary>
                private List<List<String>> themecolors = new List<List<String>>
                    {
                        new List<string> { "#F2F2F2", "#D8D8D8", "#BFBFBF", "#A5A5A5", "#7F7F7F" },
                        new List<string> { "#7F7F7F", "#595959", "#3F3F3F", "#262626", "#0C0C0C" },
                        new List<string> { "#D0CECE", "#AEABAB", "#757070", "#3A3838", "#171616" },
                        new List<string> { "#D6DCE4", "#ADB9CA", "#8496B0", "#323F4F", "#222A35" },
                        new List<string> { "#D7E5D5", "#F7CBAC", "#F4AB83", "#C55A11", "#833C0B" },
                        new List<string> { "#EDEDED", "#DBDBDB", "#C9C9C9", "#7B7B7B", "#525252" },
                        new List<string> { "#FFF2CC", "#FFE599", "#FFD965", "#BF9000", "#7F6000" },
                        new List<string> { "#DEEBF6", "#BDD7EA", "#9CC3E5", "#2E75B5", "#1E4E79" },
                        new List<string> { "#E2EFD9", "#C5E0B3", "#A8D08D", "#538135", "#375623" }
                    };

                /// <summary>系統顏色</summary>
                private List<String> systemcolors = new List<String> { "#C00000", "#FF0000", "#FFC000", "#92D050", "#00B050", "#00B0F0", "#0070C0", "#002060", "#0C30A0" };

                /// <summary>邊框顏色</summary>
                private String bordercolor { get { return "#A5A5A5"; } }

                /// <summary>色塊大小</summary>
                private Int32 colorsize = 20;

                /// <summary>色塊間距</summary>
                private Int32 colorpad = 5;

                public ReoGridColorPickerPanel()
                {
                    Panel PanelColor = new Panel();
                    PanelColor.AutoSize = true;
                    PanelColor.Location = new Point(colorpad, colorpad);
                    this.Controls.Add(PanelColor);

                    //主題色彩
                    foreach (List<String> cs in themecolors)
                    {
                        foreach (String c in cs)
                        {
                            Panel pl = new Panel();
                            pl.Location = new Point(
                                themecolors.IndexOf(cs) * (colorsize + colorpad),
                                cs.IndexOf(c) * (colorsize + colorpad)
                            );
                            pl.AutoSize = false;
                            pl.Width = this.colorsize;
                            pl.Height = this.colorsize;
                            pl.Padding = new Padding(1);
                            pl.BackColor = ColorTranslator.FromHtml(bordercolor);
                            PanelColor.Controls.Add(pl);

                            Label lb = new Label();
                            lb.BackColor = ColorTranslator.FromHtml(c);
                            lb.Dock = DockStyle.Fill;
                            lb.Click += labelcolor_click;
                            pl.Controls.Add(lb);
                        }
                    }

                    //系統顏色
                    foreach (String c in systemcolors)
                    {
                        Panel pl = new Panel();
                        pl.Location = new Point(
                            systemcolors.IndexOf(c) * (colorsize + colorpad),
                            (themecolors[0].Count) * (colorsize + colorpad) + (colorpad * 2)
                        );
                        pl.AutoSize = false;
                        pl.Width = this.colorsize;
                        pl.Height = this.colorsize;
                        pl.Padding = new Padding(1);
                        pl.BackColor = ColorTranslator.FromHtml("#A5A5A5");
                        PanelColor.Controls.Add(pl);

                        Label lb = new Label();
                        lb.BackColor = ColorTranslator.FromHtml(c);
                        lb.Dock = DockStyle.Fill;
                        lb.Click += labelcolor_click;
                        pl.Controls.Add(lb);
                    }
                }
            }
        }
    }

}
