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
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;


namespace Bitrix
{
    public partial class MainForm : Form
    {

        BitrixAPI bitrix = new BitrixAPI();
        public MainForm()
        {
            InitializeComponent();
        }
        //Button start
        private void butStartResponse_Click(object sender, EventArgs e)
        {
            var Data = bitrix.SendRequest(
                tbUserID.Text,
                tbSecretKey.Text,
                "tasks.task.list",
                "limit=100"
                //"select=TITLE&ID&limit=100"
                );
            tbResult.Text = Data;
            GetTaskList(Data);
        }


        //Parse JSON for get TaskList Bitrix
        void GetTaskList(string Data)
        {
            string s = "";
            var Temp = JsonConvert.DeserializeObject<BitrixTasks>(Data);
            string[] TaskList = new string[Temp.result.tasks.Length];
            for (int i = 0; i < Temp.result.tasks.Length; i++)
            {
                
                TaskList[i] = Temp.result.tasks[i].id;
                listBox1.Items.Add(Temp.result.tasks[i].id + " " + Temp.result.tasks[i].title);
            }

            //tbOutResult.Text = s;
            label4.Text = "Кол-во задач: " + listBox1.Items.Count.ToString();
        }

        private void _ButGetComments_Click(object sender, EventArgs e)
        {
            GetComments();
        }

        void GetComments()
        {
            //for (int i = 0; i < TaskList.Length; i++)
            //    var Data = bitrix.SendRequest(
            //        tbUserID.Text,
            //        tbSecretKey.Text,
            //        "task.commentitem.getlist",
            //        $"ID{TaskList[i]}"
            //        );

        }
    }

}
