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
            var Data = bitrix.SendRequest(tbUserID.Text, tbSecretKey.Text, "tasks.task.list", "select=TITLE&ID");
            label3.Text = "Длина: " + Data.Length;
            tbResult.Text = Data;
            ParseJson(Data);
        }


        //Parser response
        void ParseJson(string Data)
        {

            string s = "";
            var Temp = JsonConvert.DeserializeObject<BitrixTasks>(Data);
            string[] TaskList = new string[Temp.result.tasks.Length];
            for (int i = 0; i < Temp.result.tasks.Length; i++)
            {
                s += Temp.result.tasks[i].id + Temp.result.tasks[i].title + "\n";
                tbOutResult.Text = s;
                TaskList[i] = Temp.result.tasks[i].id;
            }
        }
    }

}
