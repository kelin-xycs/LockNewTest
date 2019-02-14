using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Threading;

namespace LockNewTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int taskCount;

        private bool isRunning;

        private object obj = new object();

        private DateTime beginDate;

        private void btnTestEmptyLoop_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                WriteMsg("请停止后再开始");
                return;
            }

            isRunning = true;

            taskCount = int.Parse(txtTaskCount.Text) * 10000;

            Thread thread = new Thread(TestEmptyLoop);
            thread.Start();
        }

        private void TestEmptyLoop()
        {

            WriteMsg("已开始");

            beginDate = DateTime.Now;

            for (int i = 0; i < taskCount; i++)
            {
                
            }

            isRunning = false;

            WriteMsg("已完成，共执行 " + taskCount + " 个 空循环，耗时 " + (DateTime.Now - beginDate).TotalSeconds.ToString() + " 秒");
        }

        private void WriteMsg(string msg)
        {
            txtMsg.AppendText(DateTime.Now.ToString("HH:mm:ss.fff") + " " + msg + "\r\n");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtMsg.Clear();
        }

        private void btnTestLock_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                WriteMsg("请停止后再开始");
                return;
            }

            isRunning = true;

            taskCount = int.Parse(txtTaskCount.Text) * 10000;

            Thread thread = new Thread(TestLock);
            thread.Start();
        }

        object lockObj = new object();

        private void TestLock()
        {

            WriteMsg("已开始");

            beginDate = DateTime.Now;

            for (int i = 0; i < taskCount; i++)
            {
                lock(lockObj)
                {

                }
            }

            isRunning = false;

            WriteMsg("已完成，共执行 " + taskCount + " 个 Lock，耗时 " + (DateTime.Now - beginDate).TotalSeconds.ToString() + " 秒");
        }

        private void btnTestNew_Click(object sender, EventArgs e)
        {
            if (isRunning)
            {
                WriteMsg("请停止后再开始");
                return;
            }

            isRunning = true;

            taskCount = int.Parse(txtTaskCount.Text) * 10000;

            Thread thread = new Thread(TestNew);
            thread.Start();
        }

        private void TestNew()
        {

            WriteMsg("已开始");

            beginDate = DateTime.Now;

            for (int i = 0; i < taskCount; i++)
            {
                new object();
            }

            isRunning = false;

            WriteMsg("已完成，共执行 " + taskCount + " 个 New，耗时 " + (DateTime.Now - beginDate).TotalSeconds.ToString() + " 秒");
        }
    }
}
