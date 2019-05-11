namespace XVM_EnableGoldFreeXPLocker
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.openDlgBtn = new System.Windows.Forms.Button();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBonStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelXPStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelStatusGold = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.openDlgBtn);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(354, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Папка WOT";
            // 
            // openDlgBtn
            // 
            this.openDlgBtn.Location = new System.Drawing.Point(290, 19);
            this.openDlgBtn.Name = "openDlgBtn";
            this.openDlgBtn.Size = new System.Drawing.Size(58, 20);
            this.openDlgBtn.TabIndex = 1;
            this.openDlgBtn.Text = "Обзор";
            this.openDlgBtn.UseVisualStyleBackColor = true;
            this.openDlgBtn.Click += new System.EventHandler(this.OpenDlgBtn_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Enabled = false;
            this.textBoxPath.Location = new System.Drawing.Point(6, 19);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(278, 20);
            this.textBoxPath.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBonStatus);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.labelXPStatus);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.labelStatusGold);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 67);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(354, 81);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // labelBonStatus
            // 
            this.labelBonStatus.AutoSize = true;
            this.labelBonStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelBonStatus.Location = new System.Drawing.Point(109, 51);
            this.labelBonStatus.Name = "labelBonStatus";
            this.labelBonStatus.Size = new System.Drawing.Size(16, 13);
            this.labelBonStatus.TabIndex = 5;
            this.labelBonStatus.Text = " - ";
            this.labelBonStatus.Click += new System.EventHandler(this.LabelBonStatus_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Замочек бонов:";
            // 
            // labelXPStatus
            // 
            this.labelXPStatus.AutoSize = true;
            this.labelXPStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelXPStatus.Location = new System.Drawing.Point(172, 38);
            this.labelXPStatus.Name = "labelXPStatus";
            this.labelXPStatus.Size = new System.Drawing.Size(16, 13);
            this.labelXPStatus.TabIndex = 3;
            this.labelXPStatus.Text = " - ";
            this.labelXPStatus.Click += new System.EventHandler(this.LabelXPStatus_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Замочек свободного опыта:";
            // 
            // labelStatusGold
            // 
            this.labelStatusGold.AutoSize = true;
            this.labelStatusGold.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelStatusGold.Location = new System.Drawing.Point(114, 25);
            this.labelStatusGold.Name = "labelStatusGold";
            this.labelStatusGold.Size = new System.Drawing.Size(16, 13);
            this.labelStatusGold.TabIndex = 1;
            this.labelStatusGold.Text = " - ";
            this.labelStatusGold.Click += new System.EventHandler(this.LabelStatusGold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Замочек золота:";
            // 
            // copy
            // 
            this.copy.AutoSize = true;
            this.copy.BackColor = System.Drawing.SystemColors.Control;
            this.copy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.copy.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copy.Location = new System.Drawing.Point(9, 151);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(105, 15);
            this.copy.TabIndex = 2;
            this.copy.Text = "Label of Copyright";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 169);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openDlgBtn;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelXPStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelStatusGold;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBonStatus;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label copy;
    }
}

