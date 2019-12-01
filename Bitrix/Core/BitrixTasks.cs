using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrix.Core
{
    public class BitrixTasks
    {
        public Result result { get; set; }
       // public int total { get; set; }
       // public Time time { get; set; }
    }

    public class Result
    {
        public Task[] tasks { get; set; }
    }

    public class Task
    {
        public string title { get; set; }
        public string id { get; set; }
    }

    //public class Time
    //{
    //    public float start { get; set; }
    //    public float finish { get; set; }
    //    public float duration { get; set; }
    //    public float processing { get; set; }
    //    public DateTime date_start { get; set; }
    //    public DateTime date_finish { get; set; }
    //}
}
