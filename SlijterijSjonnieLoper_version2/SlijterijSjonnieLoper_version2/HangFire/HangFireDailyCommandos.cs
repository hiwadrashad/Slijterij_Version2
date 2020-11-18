using SlijterijSjonnieLoper_version2.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SlijterijSjonnieLoper_version2.HangFire
{
    public static class HangFireDailyCommandos
    {
        public static void UpdateIfReservationIsDoneDaily()
        {
            MockdataService.GetMockdataService().CheckAndAssignIfOrderIsDoneTroughCheckingDateOfCompletion();
        }
    }
}