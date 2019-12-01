using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrix.Core
{
    public class BitrixTasks
    {
        public ResultTasks result { get; set; }
    }

    public class ResultTasks
    {
        public Task[] tasks { get; set; }
    }

    public class Task
    {
        public string title { get; set; }
        public string id { get; set; }
    }
}
