﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FieldOperationForm
{
    public class Notice_Service
    {
        public List<Notice_Vo> NoticeList()
        {
            Notice_Dac dac = new Notice_Dac();
            return dac.NoticeList();
        }
        public bool GetNotice(Notice_Vo item)
        {
            Notice_Dac dac = new Notice_Dac();
            return dac.GetNotice(item);
        }
    }
}
