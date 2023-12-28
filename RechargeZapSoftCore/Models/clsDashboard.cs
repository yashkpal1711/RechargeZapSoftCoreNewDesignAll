using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace RechargeZapSoftCore.Models
{
    public class clsDashboard
    {

        public string Username { get; set; }
        public string BalanceAmount { get; set; }
        public string SuccessRecharge { get; set; }
        public string FailedRecharge { get; set; }
        public string RewardPointBalance { get; set; }
        public string UserId { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DataTable dtdata { get; set; }

    }
}
