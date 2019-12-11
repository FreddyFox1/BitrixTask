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
        public static BitrixAPI API = new BitrixAPI();
        //Parse JSON for get TaskList Bitrix
        public static string[] GetTaskList(string Data)
        {
            var Temp = JsonConvert.DeserializeObject<BitrixTask.BitrixTasks>(Data);
            string[] TaskList = new string[Temp.result.tasks.Length];
            for (int i = 0; i < Temp.result.tasks.Length; i++)
            {
                TaskList[i] = Temp.result.tasks[i].id;
            }

            return TaskList;
        }

        public static string[] GetComments(string _UserID, string _SecretKey, int TaskOne)
        {
            var Response = API.SendRequest(_UserID, _SecretKey, "task.commentitem.getlist", $"TASKID={TaskOne}");
            if (Response.Contains("POST_MESSAGE"))
            {
                var Temp = JsonConvert.DeserializeObject<BitrixComments>(Response);
                string[] list = new string[Temp.result.Length];
                for (int i = 0; i < Temp.result.Length; i++)
                    list[i] = Temp.result[i].ID + " " + Temp.result[i].POST_MESSAGE;
                return list;
            }
            return null;
        }

        public static void SendComments(string _UserID, string _SecretKey, int TaskID, params string[] Comments)
        {
            for (int i = 0; i < Comments.Length; i++)
                API.SendRequest(_UserID, _SecretKey, "task.commentitem.add", $"TASKID={TaskID}&FIELDS[POST_MESSAGE]={Comments[i]}");
        }

    }
}
