using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace ClovaTest.Control
{
    public class SetMain
    {
        #region SetMain

        public static DispatcherTimer SetMainTimer;

        /// <summary>
        /// SetMain
        /// </summary>
        /// <param name="sec">Return to Main Delay(second)</param>
        public static void GoMain(int sec = 30)
        {
            try
            {
                if (SetMainTimer != null)
                {
                    SetMainTimer.Stop();
                }
                if (sec == 0)
                {
                    return;
                }
                SetMainTimer = new System.Windows.Threading.DispatcherTimer();
                SetMainTimer.Interval = TimeSpan.FromSeconds(sec);
                SetMainTimer.Tick += delegate
                {
                    if (SetMainTimer != null)
                    {
                        Messenger.Default.Send<GotoPage>(new GotoPage(PageName.Main));
                        SetMainTimer.Stop();
                    }
                };
                SetMainTimer.Start();
            }
            catch (Exception ex)
            {
                //Common.WriteLog("SetMain Exception, " + ex.Message);
            }
        }

        #endregion SetMain
    }
}