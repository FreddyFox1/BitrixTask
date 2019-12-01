namespace Bitrix
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.butStartResponse = new System.Windows.Forms.Button();
            this.tbSecretKey = new System.Windows.Forms.TextBox();
            this.tbUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOutResult = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SecretKey";
            // 
            // butStartResponse
            // 
            this.butStartResponse.Location = new System.Drawing.Point(389, 320);
            this.butStartResponse.Name = "butStartResponse";
            this.butStartResponse.Size = new System.Drawing.Size(75, 23);
            this.butStartResponse.TabIndex = 1;
            this.butStartResponse.Text = "Start";
            this.butStartResponse.UseVisualStyleBackColor = true;
            this.butStartResponse.Click += new System.EventHandler(this.butStartResponse_Click);
            // 
            // tbSecretKey
            // 
            this.tbSecretKey.Location = new System.Drawing.Point(68, 29);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.Size = new System.Drawing.Size(335, 20);
            this.tbSecretKey.TabIndex = 2;
            this.tbSecretKey.Text = "3jkf78vpvm617lsj";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(68, 55);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(36, 20);
            this.tbUserID.TabIndex = 3;
            this.tbUserID.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "User ID";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(9, 96);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(167, 224);
            this.tbResult.TabIndex = 5;
            this.tbResult.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Длина:";
            // 
            // tbOutResult
            // 
            this.tbOutResult.Location = new System.Drawing.Point(182, 96);
            this.tbOutResult.Name = "tbOutResult";
            this.tbOutResult.Size = new System.Drawing.Size(177, 224);
            this.tbOutResult.TabIndex = 7;
            this.tbOutResult.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 377);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbOutResult);
            this.tabPage1.Controls.Add(this.butStartResponse);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbSecretKey);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.tbUserID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(472, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(472, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 377);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Bitrix";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butStartResponse;
        private System.Windows.Forms.TextBox tbSecretKey;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox tbOutResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}

