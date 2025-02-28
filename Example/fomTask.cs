using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dotNetExample.Examples
{
    public partial class fomTask: Form
    {
        Task t; 
        CancellationTokenSource cts;

        public fomTask()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTask_Click(object sender, EventArgs e)
        {
            if (t != null && !t.IsCompleted) //如果尚未執行 OR 尚未完成
            {
                this.Invoke(new Action(() =>
                {
                    btnTask.Text = "開始";

                }));
                cts.Cancel();
            }
            else
            {
                //執行兩個Task
                cts = new CancellationTokenSource();
                t = Task.Run(() =>
                {
                    this.Invoke(new Action(() =>
                    {
                        btnTask.Text = "中止";
                    }));

                    Task t1 = Task.Run(Thread1); //方法1

                    Task t2 = Task.Run(async () =>
                    {
                        await Task2();
                    }); //方法2

                    Task.WaitAll(t1, t2);
                    this.Invoke(new Action(() =>
                    {
                        btnTask.Text = "開始";
                        MessageBox.Show("FINISH");
                    }));
                });
            }
        }

        /// <summary>
        /// Thread1
        /// </summary>
        /// <returns></returns>
        private void Thread1()
        {
            UpdateStatus(1, true, string.Empty);

            try
            {
                UpdateStatus(1, true, "TASK1 START");
                for (int i = 1; i <= 5; i++)
                {
                    cts.Token.ThrowIfCancellationRequested();
                    UpdateStatus(1, true, "TASK1 PROCESS " + i.ToString());
                    Thread.Sleep(1000);
                }
                UpdateStatus(1, false, "TASK1 DONE");
            }
            catch (OperationCanceledException)
            {
                UpdateStatus(1, false, "TASK1 CANCEL");
            }
            catch (Exception ex)
            {
                UpdateStatus(1, false, "TASK1 ERROR");
            }
            finally
            {

            }
        }

        /// <summary>
        /// Task2
        /// </summary>
        /// <returns></returns>
        private async Task Task2()
        {
            UpdateStatus(2, true, String.Empty);
            try
            {
                UpdateStatus(2, true, "TASK2 START");
                for (int i = 1; i <= 5; i++)
                {
                    cts.Token.ThrowIfCancellationRequested();
                    UpdateStatus(2, true, "TASK2 PROCESS " + i.ToString());
                    await Task.Delay(2000);
                }
                UpdateStatus(2, false, "TASK2 DONE");
            }
            catch (OperationCanceledException)
            {
                UpdateStatus(2, false, "TASK2 CANCEL");
            }
            catch (Exception ex)
            {
                UpdateStatus(2, false, "TASK2 ERROR");
            }
            finally
            {

            }
        }

        /// <summary>
        /// 更新UI
        /// </summary>
        /// <param name="task"></param>
        /// <param name="LockUI"></param>
        /// <param name="value">若空值則全部清除</param>
        private void UpdateStatus(Int32 task, Boolean LockUI, string value)
        {
            if (this.InvokeRequired) //目前的執行緒是否非建立UI元件的執行緒
            {
                this.Invoke(new Action(() => //將方法回送主UI執行續
                {
                    UpdateStatus(task, LockUI, value);
                }));
            }
            else
            {
                //更新對應的狀態訊息欄位
                switch (task)
                {
                    case 1:
                        rtbTask1.Enabled = !LockUI;
                        rtbTask1.Text = value == string.Empty ? string.Empty : value + Environment.NewLine + rtbTask1.Text;
                        break;

                    case 2:
                        rtbTask2.Enabled = !LockUI;
                        rtbTask2.Text = value == string.Empty ? string.Empty : value + Environment.NewLine + rtbTask2.Text;
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
