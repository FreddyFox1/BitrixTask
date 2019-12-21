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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this._ButGetComments = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.SendComments = new System.Windows.Forms.Button();
            this.tbAPi = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SecretKey";
            // 
            // butStartResponse
            // 
            this.butStartResponse.Location = new System.Drawing.Point(495, 405);
            this.butStartResponse.Name = "butStartResponse";
            this.butStartResponse.Size = new System.Drawing.Size(75, 23);
            this.butStartResponse.TabIndex = 1;
            this.butStartResponse.Text = "Start";
            this.butStartResponse.UseVisualStyleBackColor = true;
            //this.butStartResponse.Click += new System.EventHandler(this.butStartResponse_Click);
            // 
            // tbSecretKey
            // 
            this.tbSecretKey.Location = new System.Drawing.Point(68, 29);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.Size = new System.Drawing.Size(335, 20);
            this.tbSecretKey.TabIndex = 2;
            this.tbSecretKey.Text = "id0nzg4f5ptwyrvz";
            // 
            // tbUserID
            // 
            this.tbUserID.Location = new System.Drawing.Point(68, 55);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.Size = new System.Drawing.Size(36, 20);
            this.tbUserID.TabIndex = 3;
            this.tbUserID.Text = "546";
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
            this.tbResult.Size = new System.Drawing.Size(236, 332);
            this.tbResult.TabIndex = 5;
            this.tbResult.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(591, 462);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tbAPi);
            this.tabPage1.Controls.Add(this.listBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbLimit);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.butStartResponse);
            this.tabPage1.Controls.Add(this.tbSecretKey);
            this.tabPage1.Controls.Add(this.tbResult);
            this.tabPage1.Controls.Add(this.tbUserID);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(583, 436);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список задач";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(251, 96);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 329);
            this.listBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(181, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Кол-во задач";
            // 
            // tbLimit
            // 
            this.tbLimit.Location = new System.Drawing.Point(184, 55);
            this.tbLimit.Name = "tbLimit";
            this.tbLimit.Size = new System.Drawing.Size(93, 20);
            this.tbLimit.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "LimitTasks";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBox2);
            this.tabPage2.Controls.Add(this._ButGetComments);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(583, 436);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Получение комментариев";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBox2
            // 
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(3, 3);
            this.listBox2.MultiColumn = true;
            this.listBox2.Name = "listBox2";
            this.listBox2.ScrollAlwaysVisible = true;
            this.listBox2.Size = new System.Drawing.Size(256, 430);
            this.listBox2.TabIndex = 1;
            // 
            // _ButGetComments
            // 
            this._ButGetComments.Location = new System.Drawing.Point(495, 405);
            this._ButGetComments.Name = "_ButGetComments";
            this._ButGetComments.Size = new System.Drawing.Size(75, 23);
            this._ButGetComments.TabIndex = 0;
            this._ButGetComments.Text = "Start";
            this._ButGetComments.UseVisualStyleBackColor = true;
            this._ButGetComments.Click += new System.EventHandler(this._ButGetComments_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.SendComments);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(583, 436);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отправка комментариев";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // SendComments
            // 
            this.SendComments.Location = new System.Drawing.Point(495, 405);
            this.SendComments.Name = "SendComments";
            this.SendComments.Size = new System.Drawing.Size(75, 23);
            this.SendComments.TabIndex = 0;
            this.SendComments.Text = "Start";
            this.SendComments.UseVisualStyleBackColor = true;
            this.SendComments.Click += new System.EventHandler(this.SendComments_Click);
            // 
            // tbAPi
            // 
            this.tbAPi.Location = new System.Drawing.Point(351, 58);
            this.tbAPi.Name = "tbAPi";
            this.tbAPi.Size = new System.Drawing.Size(93, 20);
            this.tbAPi.TabIndex = 12;
            this.tbAPi.Text = "https://zavodform.bitrix24.ru/rest/";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 462);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Bitrix";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butStartResponse;
        private System.Windows.Forms.TextBox tbSecretKey;
        private System.Windows.Forms.TextBox tbUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button _ButGetComments;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button SendComments;
        private System.Windows.Forms.TextBox tbAPi;
    }
}

