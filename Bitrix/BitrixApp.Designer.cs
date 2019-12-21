namespace Bitrix
{
    partial class BitrixApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TabPage TabPageGetTasks;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitrixApp));
            this.MainPageTabControl = new System.Windows.Forms.TabControl();
            this.TabPageGetComments = new System.Windows.Forms.TabPage();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.DataGridComments = new Guna.UI.WinForms.GunaDataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDAuthor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TextCommentary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabPageSendComments = new System.Windows.Forms.TabPage();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.gunaTextBox5 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox6 = new Guna.UI.WinForms.GunaTextBox();
            this.gunaTextBox7 = new Guna.UI.WinForms.GunaTextBox();
            this.butEditReceiver = new Guna.UI.WinForms.GunaButton();
            this.tbPortalAdress = new Guna.UI.WinForms.GunaTextBox();
            this.tbSecretKey = new Guna.UI.WinForms.GunaTextBox();
            this.tbUserID = new Guna.UI.WinForms.GunaTextBox();
            this.tbTaskLimit = new Guna.UI.WinForms.GunaTextBox();
            this.DataGridTaskList = new Guna.UI.WinForms.GunaDataGridView();
            this.TitleTask = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTaskID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MainFormBackground = new Guna.UI.WinForms.GunaGradientPanel();
            this.butEditFirstPortal = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox1 = new Guna.UI.WinForms.GunaGroupBox();
            this.butGetTaskList = new Guna.UI.WinForms.GunaButton();
            this.gunaGroupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.pbGetTasks = new Guna.UI.WinForms.GunaWinCircleProgressIndicator();
            TabPageGetTasks = new System.Windows.Forms.TabPage();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            TabPageGetTasks.SuspendLayout();
            this.MainPageTabControl.SuspendLayout();
            this.TabPageGetComments.SuspendLayout();
            this.gunaGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComments)).BeginInit();
            this.TabPageSendComments.SuspendLayout();
            this.gunaGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTaskList)).BeginInit();
            this.MainFormBackground.SuspendLayout();
            this.gunaGroupBox1.SuspendLayout();
            this.gunaGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPageGetTasks
            // 
            TabPageGetTasks.Controls.Add(this.MainFormBackground);
            TabPageGetTasks.Location = new System.Drawing.Point(4, 34);
            TabPageGetTasks.Name = "TabPageGetTasks";
            TabPageGetTasks.Padding = new System.Windows.Forms.Padding(3);
            TabPageGetTasks.Size = new System.Drawing.Size(756, 377);
            TabPageGetTasks.TabIndex = 0;
            TabPageGetTasks.Text = "TaskList";
            TabPageGetTasks.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = System.Drawing.Color.Transparent;
            label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label6.ForeColor = System.Drawing.Color.White;
            label6.Location = new System.Drawing.Point(53, 134);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(59, 17);
            label6.TabIndex = 5;
            label6.Text = "User ID :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.Transparent;
            label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label7.ForeColor = System.Drawing.Color.White;
            label7.Location = new System.Drawing.Point(34, 50);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(78, 17);
            label7.TabIndex = 3;
            label7.Text = "Secret Key :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.Transparent;
            label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label8.ForeColor = System.Drawing.Color.White;
            label8.Location = new System.Drawing.Point(8, 91);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(104, 17);
            label8.TabIndex = 1;
            label8.Text = "Portal Address :";
            // 
            // MainPageTabControl
            // 
            this.MainPageTabControl.Controls.Add(TabPageGetTasks);
            this.MainPageTabControl.Controls.Add(this.TabPageGetComments);
            this.MainPageTabControl.Controls.Add(this.TabPageSendComments);
            this.MainPageTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPageTabControl.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.MainPageTabControl.HotTrack = true;
            this.MainPageTabControl.ItemSize = new System.Drawing.Size(52, 30);
            this.MainPageTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainPageTabControl.Name = "MainPageTabControl";
            this.MainPageTabControl.SelectedIndex = 0;
            this.MainPageTabControl.Size = new System.Drawing.Size(764, 415);
            this.MainPageTabControl.TabIndex = 1;
            // 
            // TabPageGetComments
            // 
            this.TabPageGetComments.Controls.Add(this.gunaGradientPanel1);
            this.TabPageGetComments.Location = new System.Drawing.Point(4, 34);
            this.TabPageGetComments.Name = "TabPageGetComments";
            this.TabPageGetComments.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGetComments.Size = new System.Drawing.Size(756, 377);
            this.TabPageGetComments.TabIndex = 1;
            this.TabPageGetComments.Text = "Get Comments";
            this.TabPageGetComments.UseVisualStyleBackColor = true;
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Controls.Add(this.DataGridComments);
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.Blue;
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.Silver;
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientPanel1.Location = new System.Drawing.Point(3, 3);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(750, 371);
            this.gunaGradientPanel1.TabIndex = 1;
            // 
            // DataGridComments
            // 
            this.DataGridComments.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.DataGridComments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridComments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridComments.BackgroundColor = System.Drawing.Color.White;
            this.DataGridComments.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridComments.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridComments.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridComments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridComments.ColumnHeadersHeight = 21;
            this.DataGridComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.IDAuthor,
            this.TextCommentary});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridComments.DefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridComments.EnableHeadersVisualStyles = false;
            this.DataGridComments.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridComments.Location = new System.Drawing.Point(22, 12);
            this.DataGridComments.Name = "DataGridComments";
            this.DataGridComments.ReadOnly = true;
            this.DataGridComments.RowHeadersVisible = false;
            this.DataGridComments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridComments.Size = new System.Drawing.Size(706, 300);
            this.DataGridComments.TabIndex = 11;
            this.DataGridComments.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridComments.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridComments.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridComments.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridComments.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridComments.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridComments.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridComments.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridComments.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.DataGridComments.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridComments.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridComments.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridComments.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridComments.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridComments.ThemeStyle.ReadOnly = true;
            this.DataGridComments.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridComments.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridComments.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridComments.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DataGridComments.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridComments.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridComments.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Task";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Task Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // IDAuthor
            // 
            this.IDAuthor.HeaderText = "ID Author";
            this.IDAuthor.Name = "IDAuthor";
            this.IDAuthor.ReadOnly = true;
            // 
            // TextCommentary
            // 
            this.TextCommentary.HeaderText = "TextComment";
            this.TextCommentary.Name = "TextCommentary";
            this.TextCommentary.ReadOnly = true;
            // 
            // TabPageSendComments
            // 
            this.TabPageSendComments.Controls.Add(this.gunaGradientPanel2);
            this.TabPageSendComments.Location = new System.Drawing.Point(4, 34);
            this.TabPageSendComments.Name = "TabPageSendComments";
            this.TabPageSendComments.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageSendComments.Size = new System.Drawing.Size(756, 377);
            this.TabPageSendComments.TabIndex = 2;
            this.TabPageSendComments.Text = "Send Comments";
            this.TabPageSendComments.UseVisualStyleBackColor = true;
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Controls.Add(this.gunaGroupBox2);
            this.gunaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradientPanel2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.Blue;
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.Silver;
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.DeepSkyBlue;
            this.gunaGradientPanel2.Location = new System.Drawing.Point(3, 3);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(750, 371);
            this.gunaGradientPanel2.TabIndex = 1;
            // 
            // gunaTextBox5
            // 
            this.gunaTextBox5.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox5.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox5.Enabled = false;
            this.gunaTextBox5.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox5.FocusedBorderColor = System.Drawing.Color.Black;
            this.gunaTextBox5.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox5.Location = new System.Drawing.Point(118, 130);
            this.gunaTextBox5.Name = "gunaTextBox5";
            this.gunaTextBox5.PasswordChar = '\0';
            this.gunaTextBox5.Size = new System.Drawing.Size(200, 26);
            this.gunaTextBox5.TabIndex = 6;
            // 
            // gunaTextBox6
            // 
            this.gunaTextBox6.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox6.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox6.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox6.Enabled = false;
            this.gunaTextBox6.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox6.FocusedBorderColor = System.Drawing.Color.Black;
            this.gunaTextBox6.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox6.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.gunaTextBox6.Location = new System.Drawing.Point(118, 46);
            this.gunaTextBox6.Name = "gunaTextBox6";
            this.gunaTextBox6.PasswordChar = '\0';
            this.gunaTextBox6.Size = new System.Drawing.Size(200, 26);
            this.gunaTextBox6.TabIndex = 4;
            // 
            // gunaTextBox7
            // 
            this.gunaTextBox7.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox7.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox7.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox7.Enabled = false;
            this.gunaTextBox7.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox7.FocusedBorderColor = System.Drawing.Color.Black;
            this.gunaTextBox7.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaTextBox7.Location = new System.Drawing.Point(118, 87);
            this.gunaTextBox7.Name = "gunaTextBox7";
            this.gunaTextBox7.PasswordChar = '\0';
            this.gunaTextBox7.Size = new System.Drawing.Size(200, 26);
            this.gunaTextBox7.TabIndex = 2;
            // 
            // butEditReceiver
            // 
            this.butEditReceiver.AnimationHoverSpeed = 0.07F;
            this.butEditReceiver.AnimationSpeed = 0.03F;
            this.butEditReceiver.BaseColor = System.Drawing.Color.Silver;
            this.butEditReceiver.BorderColor = System.Drawing.Color.Black;
            this.butEditReceiver.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butEditReceiver.FocusedColor = System.Drawing.Color.Empty;
            this.butEditReceiver.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butEditReceiver.ForeColor = System.Drawing.Color.White;
            this.butEditReceiver.Image = null;
            this.butEditReceiver.ImageSize = new System.Drawing.Size(20, 20);
            this.butEditReceiver.Location = new System.Drawing.Point(214, 213);
            this.butEditReceiver.Name = "butEditReceiver";
            this.butEditReceiver.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.butEditReceiver.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butEditReceiver.OnHoverForeColor = System.Drawing.Color.White;
            this.butEditReceiver.OnHoverImage = null;
            this.butEditReceiver.OnPressedColor = System.Drawing.Color.LightGray;
            this.butEditReceiver.Size = new System.Drawing.Size(104, 30);
            this.butEditReceiver.TabIndex = 0;
            this.butEditReceiver.Text = "Edit";
            this.butEditReceiver.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(8, 91);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(104, 17);
            label1.TabIndex = 1;
            label1.Text = "Portal Address :";
            // 
            // tbPortalAdress
            // 
            this.tbPortalAdress.BaseColor = System.Drawing.Color.White;
            this.tbPortalAdress.BorderColor = System.Drawing.Color.Silver;
            this.tbPortalAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPortalAdress.Enabled = false;
            this.tbPortalAdress.FocusedBaseColor = System.Drawing.Color.White;
            this.tbPortalAdress.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbPortalAdress.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbPortalAdress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbPortalAdress.Location = new System.Drawing.Point(118, 87);
            this.tbPortalAdress.Name = "tbPortalAdress";
            this.tbPortalAdress.PasswordChar = '\0';
            this.tbPortalAdress.Size = new System.Drawing.Size(200, 26);
            this.tbPortalAdress.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = System.Drawing.Color.Transparent;
            label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(34, 50);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 17);
            label2.TabIndex = 3;
            label2.Text = "Secret Key :";
            // 
            // tbSecretKey
            // 
            this.tbSecretKey.BaseColor = System.Drawing.Color.White;
            this.tbSecretKey.BorderColor = System.Drawing.Color.Silver;
            this.tbSecretKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSecretKey.Enabled = false;
            this.tbSecretKey.FocusedBaseColor = System.Drawing.Color.White;
            this.tbSecretKey.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbSecretKey.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbSecretKey.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.tbSecretKey.Location = new System.Drawing.Point(118, 46);
            this.tbSecretKey.Name = "tbSecretKey";
            this.tbSecretKey.PasswordChar = '\0';
            this.tbSecretKey.Size = new System.Drawing.Size(200, 26);
            this.tbSecretKey.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.Transparent;
            label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(53, 134);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(59, 17);
            label3.TabIndex = 5;
            label3.Text = "User ID :";
            // 
            // tbUserID
            // 
            this.tbUserID.BaseColor = System.Drawing.Color.White;
            this.tbUserID.BorderColor = System.Drawing.Color.Silver;
            this.tbUserID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUserID.Enabled = false;
            this.tbUserID.FocusedBaseColor = System.Drawing.Color.White;
            this.tbUserID.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbUserID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbUserID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbUserID.Location = new System.Drawing.Point(118, 130);
            this.tbUserID.Name = "tbUserID";
            this.tbUserID.PasswordChar = '\0';
            this.tbUserID.Size = new System.Drawing.Size(200, 26);
            this.tbUserID.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(38, 175);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(74, 17);
            label4.TabIndex = 7;
            label4.Text = "Task Limit :";
            // 
            // tbTaskLimit
            // 
            this.tbTaskLimit.BaseColor = System.Drawing.Color.White;
            this.tbTaskLimit.BorderColor = System.Drawing.Color.Silver;
            this.tbTaskLimit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTaskLimit.Enabled = false;
            this.tbTaskLimit.FocusedBaseColor = System.Drawing.Color.White;
            this.tbTaskLimit.FocusedBorderColor = System.Drawing.Color.Black;
            this.tbTaskLimit.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.tbTaskLimit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbTaskLimit.Location = new System.Drawing.Point(118, 171);
            this.tbTaskLimit.Name = "tbTaskLimit";
            this.tbTaskLimit.PasswordChar = '\0';
            this.tbTaskLimit.Size = new System.Drawing.Size(200, 26);
            this.tbTaskLimit.TabIndex = 8;
            // 
            // DataGridTaskList
            // 
            this.DataGridTaskList.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataGridTaskList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridTaskList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridTaskList.BackgroundColor = System.Drawing.Color.White;
            this.DataGridTaskList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridTaskList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridTaskList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridTaskList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridTaskList.ColumnHeadersHeight = 21;
            this.DataGridTaskList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnTaskID,
            this.TitleTask});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridTaskList.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridTaskList.EnableHeadersVisualStyles = false;
            this.DataGridTaskList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTaskList.Location = new System.Drawing.Point(352, 12);
            this.DataGridTaskList.Name = "DataGridTaskList";
            this.DataGridTaskList.ReadOnly = true;
            this.DataGridTaskList.RowHeadersVisible = false;
            this.DataGridTaskList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridTaskList.Size = new System.Drawing.Size(386, 300);
            this.DataGridTaskList.TabIndex = 10;
            this.DataGridTaskList.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.DataGridTaskList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTaskList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataGridTaskList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataGridTaskList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataGridTaskList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataGridTaskList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTaskList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTaskList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.DataGridTaskList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridTaskList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridTaskList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataGridTaskList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataGridTaskList.ThemeStyle.HeaderStyle.Height = 21;
            this.DataGridTaskList.ThemeStyle.ReadOnly = true;
            this.DataGridTaskList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataGridTaskList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataGridTaskList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DataGridTaskList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataGridTaskList.ThemeStyle.RowsStyle.Height = 22;
            this.DataGridTaskList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataGridTaskList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // TitleTask
            // 
            this.TitleTask.HeaderText = "Task Title";
            this.TitleTask.Name = "TitleTask";
            this.TitleTask.ReadOnly = true;
            // 
            // ColumnTaskID
            // 
            this.ColumnTaskID.HeaderText = "ID Task";
            this.ColumnTaskID.Name = "ColumnTaskID";
            this.ColumnTaskID.ReadOnly = true;
            // 
            // MainFormBackground
            // 
            this.MainFormBackground.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainFormBackground.BackgroundImage")));
            this.MainFormBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainFormBackground.Controls.Add(this.pbGetTasks);
            this.MainFormBackground.Controls.Add(this.butGetTaskList);
            this.MainFormBackground.Controls.Add(this.DataGridTaskList);
            this.MainFormBackground.Controls.Add(this.gunaGroupBox1);
            this.MainFormBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainFormBackground.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MainFormBackground.GradientColor1 = System.Drawing.Color.Blue;
            this.MainFormBackground.GradientColor2 = System.Drawing.Color.DeepSkyBlue;
            this.MainFormBackground.GradientColor3 = System.Drawing.Color.Silver;
            this.MainFormBackground.GradientColor4 = System.Drawing.Color.DeepSkyBlue;
            this.MainFormBackground.Location = new System.Drawing.Point(3, 3);
            this.MainFormBackground.Name = "MainFormBackground";
            this.MainFormBackground.Size = new System.Drawing.Size(750, 371);
            this.MainFormBackground.TabIndex = 0;
            // 
            // butEditFirstPortal
            // 
            this.butEditFirstPortal.AnimationHoverSpeed = 0.07F;
            this.butEditFirstPortal.AnimationSpeed = 0.03F;
            this.butEditFirstPortal.BaseColor = System.Drawing.Color.Silver;
            this.butEditFirstPortal.BorderColor = System.Drawing.Color.Black;
            this.butEditFirstPortal.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butEditFirstPortal.FocusedColor = System.Drawing.Color.Empty;
            this.butEditFirstPortal.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butEditFirstPortal.ForeColor = System.Drawing.Color.White;
            this.butEditFirstPortal.Image = null;
            this.butEditFirstPortal.ImageSize = new System.Drawing.Size(20, 20);
            this.butEditFirstPortal.Location = new System.Drawing.Point(214, 213);
            this.butEditFirstPortal.Name = "butEditFirstPortal";
            this.butEditFirstPortal.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.butEditFirstPortal.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butEditFirstPortal.OnHoverForeColor = System.Drawing.Color.White;
            this.butEditFirstPortal.OnHoverImage = null;
            this.butEditFirstPortal.OnPressedColor = System.Drawing.Color.LightGray;
            this.butEditFirstPortal.Size = new System.Drawing.Size(104, 30);
            this.butEditFirstPortal.TabIndex = 11;
            this.butEditFirstPortal.Text = "Edit";
            this.butEditFirstPortal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.butEditFirstPortal.Click += new System.EventHandler(this.butEditFirstPortal_Click);
            // 
            // gunaGroupBox1
            // 
            this.gunaGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.Controls.Add(this.butEditFirstPortal);
            this.gunaGroupBox1.Controls.Add(this.tbUserID);
            this.gunaGroupBox1.Controls.Add(label1);
            this.gunaGroupBox1.Controls.Add(this.tbTaskLimit);
            this.gunaGroupBox1.Controls.Add(this.tbPortalAdress);
            this.gunaGroupBox1.Controls.Add(label4);
            this.gunaGroupBox1.Controls.Add(label2);
            this.gunaGroupBox1.Controls.Add(this.tbSecretKey);
            this.gunaGroupBox1.Controls.Add(label3);
            this.gunaGroupBox1.LineBottom = 3;
            this.gunaGroupBox1.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox1.LineLeft = 3;
            this.gunaGroupBox1.LineRight = 3;
            this.gunaGroupBox1.Location = new System.Drawing.Point(6, 12);
            this.gunaGroupBox1.Name = "gunaGroupBox1";
            this.gunaGroupBox1.Size = new System.Drawing.Size(330, 260);
            this.gunaGroupBox1.TabIndex = 12;
            this.gunaGroupBox1.Text = "API information of сloud storage";
            this.gunaGroupBox1.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // butGetTaskList
            // 
            this.butGetTaskList.AnimationHoverSpeed = 0.07F;
            this.butGetTaskList.AnimationSpeed = 0.03F;
            this.butGetTaskList.BaseColor = System.Drawing.Color.Silver;
            this.butGetTaskList.BorderColor = System.Drawing.Color.Black;
            this.butGetTaskList.DialogResult = System.Windows.Forms.DialogResult.None;
            this.butGetTaskList.FocusedColor = System.Drawing.Color.Empty;
            this.butGetTaskList.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.butGetTaskList.ForeColor = System.Drawing.Color.White;
            this.butGetTaskList.Image = null;
            this.butGetTaskList.ImageSize = new System.Drawing.Size(20, 20);
            this.butGetTaskList.Location = new System.Drawing.Point(634, 325);
            this.butGetTaskList.Name = "butGetTaskList";
            this.butGetTaskList.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.butGetTaskList.OnHoverBorderColor = System.Drawing.Color.Black;
            this.butGetTaskList.OnHoverForeColor = System.Drawing.Color.White;
            this.butGetTaskList.OnHoverImage = null;
            this.butGetTaskList.OnPressedColor = System.Drawing.Color.LightGray;
            this.butGetTaskList.Size = new System.Drawing.Size(104, 30);
            this.butGetTaskList.TabIndex = 12;
            this.butGetTaskList.Text = "Get Tasks";
            this.butGetTaskList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaGroupBox2
            // 
            this.gunaGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BaseColor = System.Drawing.Color.Transparent;
            this.gunaGroupBox2.BorderColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox6);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox5);
            this.gunaGroupBox2.Controls.Add(this.butEditReceiver);
            this.gunaGroupBox2.Controls.Add(label6);
            this.gunaGroupBox2.Controls.Add(label8);
            this.gunaGroupBox2.Controls.Add(this.gunaTextBox7);
            this.gunaGroupBox2.Controls.Add(label7);
            this.gunaGroupBox2.LineBottom = 3;
            this.gunaGroupBox2.LineColor = System.Drawing.Color.Gainsboro;
            this.gunaGroupBox2.LineLeft = 3;
            this.gunaGroupBox2.LineRight = 3;
            this.gunaGroupBox2.Location = new System.Drawing.Point(6, 12);
            this.gunaGroupBox2.Name = "gunaGroupBox2";
            this.gunaGroupBox2.Size = new System.Drawing.Size(330, 260);
            this.gunaGroupBox2.TabIndex = 7;
            this.gunaGroupBox2.Text = "API information of local storage";
            this.gunaGroupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // pbGetTasks
            // 
            this.pbGetTasks.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbGetTasks.Location = new System.Drawing.Point(603, 327);
            this.pbGetTasks.Name = "pbGetTasks";
            this.pbGetTasks.ProgressColor = System.Drawing.Color.White;
            this.pbGetTasks.Size = new System.Drawing.Size(25, 25);
            this.pbGetTasks.TabIndex = 13;
            this.pbGetTasks.Visible = false;
            // 
            // BitrixApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 415);
            this.Controls.Add(this.MainPageTabControl);
            this.Name = "BitrixApp";
            this.Text = "BitrixTransfer";
            TabPageGetTasks.ResumeLayout(false);
            this.MainPageTabControl.ResumeLayout(false);
            this.TabPageGetComments.ResumeLayout(false);
            this.gunaGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridComments)).EndInit();
            this.TabPageSendComments.ResumeLayout(false);
            this.gunaGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTaskList)).EndInit();
            this.MainFormBackground.ResumeLayout(false);
            this.gunaGroupBox1.ResumeLayout(false);
            this.gunaGroupBox1.PerformLayout();
            this.gunaGroupBox2.ResumeLayout(false);
            this.gunaGroupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl MainPageTabControl;
        private System.Windows.Forms.TabPage TabPageGetComments;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaDataGridView DataGridComments;
        private System.Windows.Forms.TabPage TabPageSendComments;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox5;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox6;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox7;
        private Guna.UI.WinForms.GunaButton butEditReceiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAuthor;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextCommentary;
        private Guna.UI.WinForms.GunaGradientPanel MainFormBackground;
        private Guna.UI.WinForms.GunaDataGridView DataGridTaskList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTaskID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TitleTask;
        private Guna.UI.WinForms.GunaTextBox tbTaskLimit;
        private Guna.UI.WinForms.GunaTextBox tbUserID;
        private Guna.UI.WinForms.GunaTextBox tbSecretKey;
        private Guna.UI.WinForms.GunaTextBox tbPortalAdress;
        private Guna.UI.WinForms.GunaButton butEditFirstPortal;
        private Guna.UI.WinForms.GunaButton butGetTaskList;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox1;
        private Guna.UI.WinForms.GunaGroupBox gunaGroupBox2;
        private Guna.UI.WinForms.GunaWinCircleProgressIndicator pbGetTasks;
    }
}