namespace KvalWork_Project
{
    partial class frmTitle
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTitle));
            this.panelTop = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btExit = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.btPlay = new System.Windows.Forms.Button();
            this.btRecord = new System.Windows.Forms.Button();
            this.panelCrutch = new System.Windows.Forms.Panel();
            this.pbUX = new System.Windows.Forms.PictureBox();
            this.btTitle = new System.Windows.Forms.Button();
            this.btTheory = new System.Windows.Forms.Button();
            this.btMode1 = new System.Windows.Forms.Button();
            this.btMode2 = new System.Windows.Forms.Button();
            this.btInfo = new System.Windows.Forms.Button();
            this.timerUX = new System.Windows.Forms.Timer(this.components);
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timerPW = new System.Windows.Forms.Timer(this.components);
            this.tabTitle1 = new KvalWork_Project.TabTitle();
            this.tabFAQ1 = new KvalWork_Project.TabFAQ();
            this.tabMode21 = new KvalWork_Project.TabMode2();
            this.tabMode11 = new KvalWork_Project.TabMode1();
            this.tabTheory1 = new KvalWork_Project.TabTheory();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUX)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelTop.Controls.Add(this.pictureBox1);
            this.panelTop.Controls.Add(this.btExit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(830, 34);
            this.panelTop.TabIndex = 0;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btExit.FlatAppearance.BorderSize = 0;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btExit.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btExit.Image = ((System.Drawing.Image)(resources.GetObject("btExit.Image")));
            this.btExit.Location = new System.Drawing.Point(796, 0);
            this.btExit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(34, 34);
            this.btExit.TabIndex = 1;
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.panelRight.Controls.Add(this.btPlay);
            this.panelRight.Controls.Add(this.btRecord);
            this.panelRight.Controls.Add(this.panelCrutch);
            this.panelRight.Controls.Add(this.pbUX);
            this.panelRight.Controls.Add(this.btTitle);
            this.panelRight.Controls.Add(this.btTheory);
            this.panelRight.Controls.Add(this.btMode1);
            this.panelRight.Controls.Add(this.btMode2);
            this.panelRight.Controls.Add(this.btInfo);
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelRight.Location = new System.Drawing.Point(657, 34);
            this.panelRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(173, 439);
            this.panelRight.TabIndex = 1;
            // 
            // btPlay
            // 
            this.btPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btPlay.FlatAppearance.BorderSize = 0;
            this.btPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btPlay.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btPlay.Image = ((System.Drawing.Image)(resources.GetObject("btPlay.Image")));
            this.btPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btPlay.Location = new System.Drawing.Point(87, 0);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(86, 39);
            this.btPlay.TabIndex = 3;
            this.btPlay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btPlay.UseVisualStyleBackColor = false;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btRecord
            // 
            this.btRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btRecord.FlatAppearance.BorderSize = 0;
            this.btRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRecord.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRecord.Image = ((System.Drawing.Image)(resources.GetObject("btRecord.Image")));
            this.btRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btRecord.Location = new System.Drawing.Point(0, 0);
            this.btRecord.Name = "btRecord";
            this.btRecord.Size = new System.Drawing.Size(86, 39);
            this.btRecord.TabIndex = 3;
            this.btRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btRecord.UseVisualStyleBackColor = false;
            this.btRecord.Click += new System.EventHandler(this.btRecord_Click);
            // 
            // panelCrutch
            // 
            this.panelCrutch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(103)))), ((int)(((byte)(199)))));
            this.panelCrutch.Location = new System.Drawing.Point(163, 39);
            this.panelCrutch.Name = "panelCrutch";
            this.panelCrutch.Size = new System.Drawing.Size(10, 80);
            this.panelCrutch.TabIndex = 2;
            // 
            // pbUX
            // 
            this.pbUX.Location = new System.Drawing.Point(163, 39);
            this.pbUX.Name = "pbUX";
            this.pbUX.Size = new System.Drawing.Size(10, 400);
            this.pbUX.TabIndex = 2;
            this.pbUX.TabStop = false;
            // 
            // btTitle
            // 
            this.btTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btTitle.FlatAppearance.BorderSize = 0;
            this.btTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTitle.Image = ((System.Drawing.Image)(resources.GetObject("btTitle.Image")));
            this.btTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTitle.Location = new System.Drawing.Point(2, 39);
            this.btTitle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTitle.Name = "btTitle";
            this.btTitle.Size = new System.Drawing.Size(161, 80);
            this.btTitle.TabIndex = 0;
            this.btTitle.Text = "   Title";
            this.btTitle.UseVisualStyleBackColor = false;
            this.btTitle.Click += new System.EventHandler(this.btTitle_Click);
            // 
            // btTheory
            // 
            this.btTheory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btTheory.FlatAppearance.BorderSize = 0;
            this.btTheory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btTheory.Image = ((System.Drawing.Image)(resources.GetObject("btTheory.Image")));
            this.btTheory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btTheory.Location = new System.Drawing.Point(2, 119);
            this.btTheory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btTheory.Name = "btTheory";
            this.btTheory.Size = new System.Drawing.Size(161, 80);
            this.btTheory.TabIndex = 0;
            this.btTheory.Text = "   Theory";
            this.btTheory.UseVisualStyleBackColor = false;
            this.btTheory.Click += new System.EventHandler(this.btTheory_Click);
            // 
            // btMode1
            // 
            this.btMode1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btMode1.FlatAppearance.BorderSize = 0;
            this.btMode1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMode1.Image = ((System.Drawing.Image)(resources.GetObject("btMode1.Image")));
            this.btMode1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMode1.Location = new System.Drawing.Point(2, 199);
            this.btMode1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMode1.Name = "btMode1";
            this.btMode1.Size = new System.Drawing.Size(161, 80);
            this.btMode1.TabIndex = 0;
            this.btMode1.Text = "   Mode 1";
            this.btMode1.UseVisualStyleBackColor = false;
            this.btMode1.Click += new System.EventHandler(this.btMode1_Click);
            // 
            // btMode2
            // 
            this.btMode2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btMode2.FlatAppearance.BorderSize = 0;
            this.btMode2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMode2.Image = ((System.Drawing.Image)(resources.GetObject("btMode2.Image")));
            this.btMode2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btMode2.Location = new System.Drawing.Point(2, 279);
            this.btMode2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btMode2.Name = "btMode2";
            this.btMode2.Size = new System.Drawing.Size(161, 80);
            this.btMode2.TabIndex = 0;
            this.btMode2.Text = "   Mode 2";
            this.btMode2.UseVisualStyleBackColor = false;
            this.btMode2.Click += new System.EventHandler(this.btMode2_Click);
            // 
            // btInfo
            // 
            this.btInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(248)))), ((int)(((byte)(203)))));
            this.btInfo.FlatAppearance.BorderSize = 0;
            this.btInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btInfo.Image = ((System.Drawing.Image)(resources.GetObject("btInfo.Image")));
            this.btInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btInfo.Location = new System.Drawing.Point(2, 359);
            this.btInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btInfo.Name = "btInfo";
            this.btInfo.Size = new System.Drawing.Size(161, 80);
            this.btInfo.TabIndex = 0;
            this.btInfo.Text = "   FAQ";
            this.btInfo.UseVisualStyleBackColor = false;
            this.btInfo.Click += new System.EventHandler(this.btInfo_Click);
            // 
            // timerUX
            // 
            this.timerUX.Tick += new System.EventHandler(this.timerUX_Tick);
            // 
            // timerPW
            // 
            this.timerPW.Tick += new System.EventHandler(this.timerPW_Tick);
            // 
            // tabTitle1
            // 
            this.tabTitle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.tabTitle1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabTitle1.Location = new System.Drawing.Point(0, 34);
            this.tabTitle1.Margin = new System.Windows.Forms.Padding(6);
            this.tabTitle1.Name = "tabTitle1";
            this.tabTitle1.Size = new System.Drawing.Size(657, 439);
            this.tabTitle1.TabIndex = 2;
            // 
            // tabFAQ1
            // 
            this.tabFAQ1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.tabFAQ1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabFAQ1.Location = new System.Drawing.Point(0, 34);
            this.tabFAQ1.Margin = new System.Windows.Forms.Padding(6);
            this.tabFAQ1.Name = "tabFAQ1";
            this.tabFAQ1.Size = new System.Drawing.Size(657, 439);
            this.tabFAQ1.TabIndex = 0;
            // 
            // tabMode21
            // 
            this.tabMode21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.tabMode21.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMode21.Location = new System.Drawing.Point(0, 34);
            this.tabMode21.Margin = new System.Windows.Forms.Padding(6);
            this.tabMode21.Name = "tabMode21";
            this.tabMode21.Size = new System.Drawing.Size(657, 439);
            this.tabMode21.TabIndex = 5;
            // 
            // tabMode11
            // 
            this.tabMode11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.tabMode11.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabMode11.Location = new System.Drawing.Point(0, 34);
            this.tabMode11.Margin = new System.Windows.Forms.Padding(6);
            this.tabMode11.Name = "tabMode11";
            this.tabMode11.Size = new System.Drawing.Size(657, 439);
            this.tabMode11.TabIndex = 4;
            // 
            // tabTheory1
            // 
            this.tabTheory1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.tabTheory1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabTheory1.Location = new System.Drawing.Point(0, 34);
            this.tabTheory1.Margin = new System.Windows.Forms.Padding(6);
            this.tabTheory1.Name = "tabTheory1";
            this.tabTheory1.Size = new System.Drawing.Size(657, 439);
            this.tabTheory1.TabIndex = 3;
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(255)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(830, 473);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.tabTitle1);
            this.Controls.Add(this.tabFAQ1);
            this.Controls.Add(this.tabMode21);
            this.Controls.Add(this.tabMode11);
            this.Controls.Add(this.tabTheory1);
            this.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "frmTitle";
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbUX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Button btTitle;
        private System.Windows.Forms.Button btTheory;
        private System.Windows.Forms.Button btMode1;
        private System.Windows.Forms.Button btMode2;
        private System.Windows.Forms.Button btInfo;
        private System.Windows.Forms.PictureBox pbUX;
        private System.Windows.Forms.Timer timerUX;
        private System.Windows.Forms.Panel panelCrutch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private TabTitle tabTitle1;
        private TabTheory tabTheory1;
        private TabMode1 tabMode11;
        private TabMode2 tabMode21;
        private TabFAQ tabFAQ1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btRecord;
        private System.Windows.Forms.Button btPlay;
        private System.Windows.Forms.Timer timerPW;
    }
}

