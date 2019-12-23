using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitrix.Core.Entities
{

    public class BitrixComments
    {
        public Result[] result { get; set; }
        public Time time { get; set; }
    }

    public class Time
    {
        public float start { get; set; }
        public float finish { get; set; }
        public float duration { get; set; }
        public float processing { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
    }

    public class Result
    {
        public string POST_MESSAGE_HTML { get; set; }
        public string ID { get; set; }
        public string AUTHOR_ID { get; set; }
        public string AUTHOR_NAME { get; set; }
        public string AUTHOR_EMAIL { get; set; }
        public DateTime POST_DATE { get; set; }
        public string POST_MESSAGE { get; set; }
    }


}
