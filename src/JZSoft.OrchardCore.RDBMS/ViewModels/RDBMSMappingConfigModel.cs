﻿using JZSoft.OrchardCore.RDBMS.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JZSoft.OrchardCore.RDBMS.ViewModels
{
    public class RDBMSMappingConfigViewModel
    {
        public string Id { get; set; }
        public string ConfigName { get; set; }
        public string ContentTypeName { get; set; }
        public SyncMappingDeriction SyncMappingDeriction { get; set; }
        public string ConnectionConfigId { get; set; }
        public string TargetTable { get; set; }
        public string MappingData { get; set; }

        public bool ReadOnly { get; set; }

        public bool EnableAutoSync { get; set; } 

    }

}
