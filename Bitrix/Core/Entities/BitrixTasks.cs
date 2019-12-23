using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrix.Core.Entities
{
    public class BitrixTask
    {
        public class BitrixTasks
        {
            public Result result { get; set; }
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

    }
}
