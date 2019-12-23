using Bitrix.Core;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bitrix
{
    public partial class BitrixApp : Form
    {
        delegate void Progress(int value);

        public BitrixApp()
        {
            InitializeComponent();
        }

        #region FirstPage
        private void butEditFirstPortal_ClickEdit(object sender, EventArgs e)
        {
            BitrixCore.VisibleUI(grbCloudBitrix, true);
            butEditFirstPortal.Text = "Save";
            butEditFirstPortal.BaseColor = Color.Red;
            butEditFirstPortal.Click -= butEditFirstPortal_ClickEdit;
            butEditFirstPortal.Click += butEditFirstPortal_ClickSave;
        }
        private void butEditFirstPortal_ClickSave(object sender, EventArgs e)
        {
            BitrixCore.VisibleUI(grbCloudBitrix, false);
            butEditFirstPortal.Text = "Edit";
            butEditFirstPortal.BaseColor = Color.Silver;
            butEditFirstPortal.Click -= butEditFirstPortal_ClickSave;
            butEditFirstPortal.Click += butEditFirstPortal_ClickEdit;

        }

        private void butGetTaskList_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckTextBoxes(grbCloudBitrix))
                {
                    GetTaskList();
                }
                else MessageBox.Show("Заполните пустые поля!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка 404.");
            }
        }

        private bool CheckTextBoxes(Guna.UI.WinForms.GunaGroupBox grb)
        {
            foreach (var tb in grb.Controls.OfType<GunaTextBox>())
            {
                if (!String.IsNullOrWhiteSpace(tb.Text)) { }
                else return false;
            }
            return true;
        }

        private void GetTaskList()
        {
            BitrixAPI.API = tbPortalAdress.Text;
            var Data = BitrixAPI.SendRequest(tbUserID.Text, tbSecretKey.Text, "tasks.task.list", "select=TITLE&ID");
            BitrixCore.GetTaskList(Data, DataGridCloudTaskList);
            lbTaskCount.Visible = true;
            lbTaskCount.Text = "Task count: " + (DataGridCloudTaskList.Rows.Count - 1).ToString();
        }

        #endregion

        #region SecondPage
        private void butGetComments_Click(object sender, EventArgs e)
        {
            if (CheckTextBoxes(grbCloudBitrix))
            {
                GetCommentsList();
            }
            else MessageBox.Show("Fill null fields!");
        }

        private void GetCommentsList()
        {
            BitrixAPI.API = tbPortalAdress.Text;
            pbGetComments.Maximum = DataGridCloudTaskList.Rows.Count;

            Thread thread = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < DataGridCloudTaskList.Rows.Count - 1; i++)
                {
                    this.Invoke(new ThreadStart(delegate
                    {
                        int TaskID = Int32.Parse(DataGridCloudTaskList[0, i].Value.ToString());
                        string TaskTitle = DataGridCloudTaskList[1, i].Value.ToString();
                        BitrixCore.GetComments(tbUserID.Text, tbSecretKey.Text, TaskID, TaskTitle, DataGridComments);
                        pbGetComments.Value = i;
                    }));

                }
                pbGetComments.Value = DataGridCloudTaskList.Rows.Count;
            }));
            thread.Start();
        }
        #endregion

        #region Third Page
        private void butLoadTaskFile_Click(object sender, EventArgs e)
        {

            GetTasksFile(DataGridLocaTasks, pbSendComments);
        }

        void GetTasksFile(GunaDataGridView gridView, GunaProgressBar pb)
        {
            using (OpenFileDialog opf = new OpenFileDialog())
            {
                opf.Title = "Select *.txt files with tasks";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    butSendComments.Enabled = true;
                    LoadTaskFile(opf.FileName, gridView, pb);
                }
            }
        }

        void LoadTaskFile(string path, GunaDataGridView Grid, GunaProgressBar pb)
        {
            pb.Maximum = File.ReadAllLines(path).Count();

            Thread thread = new Thread(new ThreadStart(delegate
            {
                this.Invoke(new ThreadStart(delegate
                {
                    using (StreamReader sr = new StreamReader(path, Encoding.Default))
                    {
                        string line;
                        int i = 0;


                        while ((line = sr.ReadLine()) != null)
                        {
                            string[] Temp = line.Split(' ');
                            Grid.Rows.Add(Temp[0], Temp[1]);
                            pb.Value = i;
                            Grid.Update();
                            i++;
                        }
                    }
                }));
                pb.Value = Grid.Rows.Count;
                MessageBox.Show("All Done!  " + Grid[0, 0].Value.ToString());
                ;
            }));
            thread.Start();
        }

        private void butLoadFile_Click(object sender, EventArgs e)
        {
            DataGridCloudTaskList.Rows.Clear();
            DataGridComments.Rows.Clear();
            GetTasksFile(DataGridCloudTaskList, pbCloudTasks);
        }

        private void butSendComments_Click(object sender, EventArgs e)
        {
            try
            {
                BitrixAPI.API = tbLocalPortalAdress.Text;
                BitrixCore.SendComments(tbLocalPortalAdress.Text, tbLocalSecretKey.Text, tbLocalUserID.Text, DataGridComments, DataGridLocaTasks);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Заполните список задач!" + ex.Message.ToString());
            }
        }

        private void butEditReceiver_ClickEdit(object sender, EventArgs e)
        {
            BitrixCore.VisibleUI(grbLocalBitrix, true);
            butEditReceiver.Text = "Save";
            butEditReceiver.BaseColor = Color.Red;
            butEditReceiver.Click -= butEditReceiver_ClickEdit;
            butEditReceiver.Click += butEditReceiver_ClickSave;
        }

        private void butEditReceiver_ClickSave(object sender, EventArgs e)
        {
            BitrixCore.VisibleUI(grbLocalBitrix, false);
            butEditReceiver.Text = "Edit";
            butEditReceiver.BaseColor = Color.Silver;
            butEditReceiver.Click -= butEditReceiver_ClickSave;
            butEditReceiver.Click += butEditReceiver_ClickEdit;

        }
        #endregion
    }
}

