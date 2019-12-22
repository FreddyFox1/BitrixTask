using Bitrix.Core;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            if (CheckTextBoxes(grbCloudBitrix))
            {
                GetTaskList();
            }
            else MessageBox.Show("Заполните пустые поля!");
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
            BitrixCore.GetTaskList(Data, DataGridTaskList);
            lbTaskCount.Visible = true;
            lbTaskCount.Text = "Task count: " + (DataGridTaskList.Rows.Count - 1).ToString();
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
            pbGetComments.Maximum = DataGridTaskList.Rows.Count;

            Thread thread = new Thread(new ThreadStart(delegate
            {
                for (int i = 0; i < DataGridTaskList.Rows.Count - 1; i++)
                {
                    this.Invoke(new ThreadStart(delegate
                    {
                        int k = Int32.Parse(DataGridTaskList[0, i].Value.ToString());

                        BitrixCore.GetComments(
                            tbUserID.Text,
                            tbSecretKey.Text,
                            k,
                            DataGridComments
                            );

                        pbGetComments.Value = i;
                    }));

                }
                pbGetComments.Value = DataGridTaskList.Rows.Count;
            }));
            thread.Start();
        }
        #endregion

        #region Third Page

        #endregion
        private void butLoadTaskFile_Click(object sender, EventArgs e)
        {

        }


    }
}
