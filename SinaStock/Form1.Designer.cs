namespace SinaStock
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
            this.txtSavePath = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimeBegin = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeEnd = new System.Windows.Forms.DateTimePicker();
            this.btnBeginEarly = new System.Windows.Forms.Button();
            this.btnBeginToday = new System.Windows.Forms.Button();
            this.btnEndToday = new System.Windows.Forms.Button();
            this.btnGetList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSavePath
            // 
            this.txtSavePath.Location = new System.Drawing.Point(71, 12);
            this.txtSavePath.Name = "txtSavePath";
            this.txtSavePath.Size = new System.Drawing.Size(500, 21);
            this.txtSavePath.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 73);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(165, 305);
            this.textBox2.TabIndex = 1;
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(577, 10);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(75, 23);
            this.btnSelectFolder.TabIndex = 2;
            this.btnSelectFolder.Text = "选择";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "存储路径";
            // 
            // dateTimeBegin
            // 
            this.dateTimeBegin.Location = new System.Drawing.Point(71, 46);
            this.dateTimeBegin.Name = "dateTimeBegin";
            this.dateTimeBegin.Size = new System.Drawing.Size(165, 21);
            this.dateTimeBegin.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "开始时间";
            // 
            // dateTimeEnd
            // 
            this.dateTimeEnd.Location = new System.Drawing.Point(404, 46);
            this.dateTimeEnd.Name = "dateTimeEnd";
            this.dateTimeEnd.Size = new System.Drawing.Size(165, 21);
            this.dateTimeEnd.TabIndex = 6;
            // 
            // btnBeginEarly
            // 
            this.btnBeginEarly.Location = new System.Drawing.Point(242, 47);
            this.btnBeginEarly.Name = "btnBeginEarly";
            this.btnBeginEarly.Size = new System.Drawing.Size(75, 23);
            this.btnBeginEarly.TabIndex = 7;
            this.btnBeginEarly.Text = "最早";
            this.btnBeginEarly.UseVisualStyleBackColor = true;
            // 
            // btnBeginToday
            // 
            this.btnBeginToday.Location = new System.Drawing.Point(323, 46);
            this.btnBeginToday.Name = "btnBeginToday";
            this.btnBeginToday.Size = new System.Drawing.Size(75, 23);
            this.btnBeginToday.TabIndex = 8;
            this.btnBeginToday.Text = "今天";
            this.btnBeginToday.UseVisualStyleBackColor = true;
            // 
            // btnEndToday
            // 
            this.btnEndToday.Location = new System.Drawing.Point(577, 47);
            this.btnEndToday.Name = "btnEndToday";
            this.btnEndToday.Size = new System.Drawing.Size(75, 23);
            this.btnEndToday.TabIndex = 9;
            this.btnEndToday.Text = "今天";
            this.btnEndToday.UseVisualStyleBackColor = true;
            // 
            // btnGetList
            // 
            this.btnGetList.Location = new System.Drawing.Point(242, 355);
            this.btnGetList.Name = "btnGetList";
            this.btnGetList.Size = new System.Drawing.Size(75, 23);
            this.btnGetList.TabIndex = 10;
            this.btnGetList.Text = "股票列表";
            this.btnGetList.UseVisualStyleBackColor = true;
            this.btnGetList.Click += new System.EventHandler(this.btnGetList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btnGetList);
            this.Controls.Add(this.btnEndToday);
            this.Controls.Add(this.btnBeginToday);
            this.Controls.Add(this.btnBeginEarly);
            this.Controls.Add(this.dateTimeEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimeBegin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSavePath);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSavePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimeBegin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeEnd;
        private System.Windows.Forms.Button btnBeginEarly;
        private System.Windows.Forms.Button btnBeginToday;
        private System.Windows.Forms.Button btnEndToday;
        private System.Windows.Forms.Button btnGetList;
    }
}

