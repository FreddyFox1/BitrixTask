using Guna.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrix.Core
{
    public class BitrixCore
    {
        //Parse JSON for get TaskList Bitrix
        public static void GetTaskList(string Data, Guna.UI.WinForms.GunaDataGridView Grid)
        {
            var Temp = JsonConvert.DeserializeObject<BitrixTask.BitrixTasks>(Data);
            for (int i = 0; i < Temp.result.tasks.Length; i++)
            {
                Grid.Rows.Add(Temp.result.tasks[i].id, Temp.result.tasks[i].title);
            }
        }

        public static void GetComments(string _UserID, string _SecretKey, int TaskOne, Guna.UI.WinForms.GunaDataGridView Grid)
        {
            var Response = BitrixAPI.SendRequest(_UserID, _SecretKey, "task.commentitem.getlist", $"TASKID={TaskOne}");
            if (Response.Contains("POST_MESSAGE"))
            {
                var Temp = JsonConvert.DeserializeObject<BitrixComments>(Response);
                string[] list = new string[Temp.result.Length];
                for (int i = 0; i < Temp.result.Length; i++)
                    Grid.Rows.Add(TaskOne, Temp.result[i].ID, Temp.result[i].AUTHOR_ID, Temp.result[i].POST_MESSAGE);
            }
        }

        public static void SendComments(string _UserID, string _SecretKey, int TaskID, params string[] Comments)
        {
            for (int i = 0; i < Comments.Length; i++)
                BitrixAPI.SendRequest(_UserID, _SecretKey, "task.commentitem.add", $"TASKID={TaskID}&FIELDS[POST_MESSAGE]={Comments[i]}");
        }


        public static void VisibleUI(Guna.UI.WinForms.GunaGroupBox grb, bool switcher)
        {
            foreach (var tb in grb.Controls.OfType<GunaTextBox>())
            {
                tb.Enabled = switcher;
            }
        }

    }
}
