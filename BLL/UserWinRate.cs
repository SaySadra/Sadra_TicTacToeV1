using System;
using System.Collections;
using System.Collections.Generic;
using DAL;

namespace BLL
{
    public class UserWinRate
    {
        public static bool Winner(string player)
        {
            if (DataApplication.inputPlayer[0] == player && DataApplication.inputPlayer[1] == player && DataApplication.inputPlayer[2] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[3] == player && DataApplication.inputPlayer[4] == player && DataApplication.inputPlayer[5] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[6] == player && DataApplication.inputPlayer[7] == player && DataApplication.inputPlayer[8] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[0] == player && DataApplication.inputPlayer[3] == player && DataApplication.inputPlayer[6] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[1] == player && DataApplication.inputPlayer[4] == player && DataApplication.inputPlayer[7] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[2] == player && DataApplication.inputPlayer[5] == player && DataApplication.inputPlayer[8] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[0] == player && DataApplication.inputPlayer[4] == player && DataApplication.inputPlayer[8] == player)
            {
                return true;
            }
            if (DataApplication.inputPlayer[2] == player && DataApplication.inputPlayer[4] == player && DataApplication.inputPlayer[6] == player)
            {
                return true;
            }
            return false;
        }
    }
}
