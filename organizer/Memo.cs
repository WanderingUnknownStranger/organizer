using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace organizer
{
    class Memo
    {
        private String memory_text;
        private DateTime create_time;

        public Memo(String str)
        {
            create_time = DateTime.Now;
            memory_text = str;
        }

        public String GetMemo()
        {
            return create_time.ToString() +"\t"+ memory_text;
        }
        public void Edit(String str)
        {
            memory_text = str;
        }
    }
}
