﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Triton.Model.Applications.Tables;
using Triton.Model.Applications.Custom;

namespace Triton.Model.Applications.Custom
{
    public class tblBranchPettyCashModel 
    {
        public tblBranchPettyCash PettyCash { get; set; }
        public tblMasterBranches Branch { get; set; }

    }
}
