using System;
using System.Collections.Generic;
using System.Globalization;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bitrix.Core;


namespace Bitrix
{
    public partial class MainForm : Form
    {

        BitrixAPI bitrix = new BitrixAPI();
        public string[] TaskList { get; set; }
        public string[] CommentsList { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        //Button start
        private void butStartResponse_Click(object sender, EventArgs e)
        {
            var Data = bitrix.SendRequest(tbUserID.Text, tbSecretKey.Text, "tasks.task.list", "select=TITLE&ID");
            tbResult.Text = Data;
            TaskList = BitrixCore.GetTaskList(Data);
            listBox1.Items.AddRange(TaskList);
            label4.Text = "Count tasks: " + listBox1.Items.Count;
        }



        private void _ButGetComments_Click(object sender, EventArgs e)
        {
            //listBox2.Items.AddRange(BitrixCore.GetComments(tbUserID.Text, tbSecretKey.Text, TaskList));
            var a = BitrixCore.GetComments(tbUserID.Text, tbSecretKey.Text, 7);
            CommentsList = a;
            listBox2.Items.AddRange(a);
        }

        private void SendComments_Click(object sender, EventArgs e)
        {
            BitrixCore.SendComments(tbUserID.Text, tbSecretKey.Text, 21, CommentsList);
        }
    }

}
