﻿namespace LockNewTest
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTaskCount = new System.Windows.Forms.TextBox();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnTestEmptyLoop = new System.Windows.Forms.Button();
            this.btnTestLock = new System.Windows.Forms.Button();
            this.btnTestNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 67;
            this.label2.Text = "万  个";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(419, 57);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 66;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 65;
            this.label1.Text = "任务数";
            // 
            // txtTaskCount
            // 
            this.txtTaskCount.Location = new System.Drawing.Point(59, 23);
            this.txtTaskCount.Name = "txtTaskCount";
            this.txtTaskCount.Size = new System.Drawing.Size(63, 21);
            this.txtTaskCount.TabIndex = 64;
            this.txtTaskCount.Text = "10";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(12, 86);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMsg.Size = new System.Drawing.Size(577, 250);
            this.txtMsg.TabIndex = 63;
            // 
            // btnTest
            // 
            this.btnTestEmptyLoop.Location = new System.Drawing.Point(12, 57);
            this.btnTestEmptyLoop.Name = "btnTest";
            this.btnTestEmptyLoop.Size = new System.Drawing.Size(110, 23);
            this.btnTestEmptyLoop.TabIndex = 62;
            this.btnTestEmptyLoop.Text = "测试 空循环";
            this.btnTestEmptyLoop.UseVisualStyleBackColor = true;
            this.btnTestEmptyLoop.Click += new System.EventHandler(this.btnTestEmptyLoop_Click);
            // 
            // btnTestLock
            // 
            this.btnTestLock.Location = new System.Drawing.Point(130, 57);
            this.btnTestLock.Name = "btnTestLock";
            this.btnTestLock.Size = new System.Drawing.Size(110, 23);
            this.btnTestLock.TabIndex = 68;
            this.btnTestLock.Text = "测试 Lock";
            this.btnTestLock.UseVisualStyleBackColor = true;
            this.btnTestLock.Click += new System.EventHandler(this.btnTestLock_Click);
            // 
            // btnTestNew
            // 
            this.btnTestNew.Location = new System.Drawing.Point(246, 57);
            this.btnTestNew.Name = "btnTestNew";
            this.btnTestNew.Size = new System.Drawing.Size(110, 23);
            this.btnTestNew.TabIndex = 69;
            this.btnTestNew.Text = "测试 New";
            this.btnTestNew.UseVisualStyleBackColor = true;
            this.btnTestNew.Click += new System.EventHandler(this.btnTestNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 350);
            this.Controls.Add(this.btnTestNew);
            this.Controls.Add(this.btnTestLock);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaskCount);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.btnTestEmptyLoop);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTaskCount;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnTestEmptyLoop;
        private System.Windows.Forms.Button btnTestLock;
        private System.Windows.Forms.Button btnTestNew;
    }
}

