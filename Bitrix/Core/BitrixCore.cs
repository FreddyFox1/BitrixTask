using Bitrix.Core.Entities;
using Guna.UI.WinForms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void GetComments(string _UserID, string _SecretKey, int TaskID, string Title, Guna.UI.WinForms.GunaDataGridView Grid)
        {
            var Response = BitrixAPI.SendRequest(_UserID, _SecretKey, "task.commentitem.getlist", $"TASKID={TaskID}");
            if (Response.Contains("POST_MESSAGE"))
            {
                var Temp = JsonConvert.DeserializeObject<BitrixComments>(Response);
                string[] list = new string[Temp.result.Length];
                for (int i = 0; i < Temp.result.Length; i++)
                    Grid.Rows.Add(TaskID, Temp.result[i].ID, Temp.result[i].AUTHOR_ID, Temp.result[i].POST_MESSAGE, Title);
            }
        }

        public static string[] SearchCopyes(string[] Comments, string[] TaskList)
        {
            string[] result = new string[Comments.Length];
            int i = 0;
            IEnumerable<string> Temp = Comments.Intersect(TaskList);
            foreach (string line in Temp)
            {
                result[i] = line;
                i++;
            }
            return result;
        }

        public static string[] CreateArrayGrid(GunaDataGridView Grid, int ColIndex)
        {
            string[] result = new string[Grid.Rows.Count - 1];
            for (int i = 0; i < Grid.ColumnCount; i++)
            {
                result[i] = Grid[ColIndex, i].Value.ToString();
            }
            return result;
        }

        public static bool SendComments(string Portal, string _SecretKey, string _UserID, GunaDataGridView GridComments, GunaDataGridView GridTasks)
        {
            var Copy = SearchCopyes(CreateArrayGrid(GridComments, 0), CreateArrayGrid(GridTasks, 0));
            try
            {
                for (int i = 0; i < GridComments.Rows.Count; i++)
                    for (int j = 0; j < Copy.Length; j++)
                    {
                        if (GridComments[0, i].Value.ToString() == Copy[j])
                        {
                            BitrixAPI.SendRequest(_UserID, _SecretKey, "task.commentitem.add", $"TASKID={Copy[j]}&FIELDS[POST_MESSAGE]={GridComments[3, i].Value.ToString()}");
                        }
                    }
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                //return false;
            }
            return true;
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
