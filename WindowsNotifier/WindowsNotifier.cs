using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ElectronicObserver.Notifier;

namespace ElectronicObserver
{
     public class WindowsNotification
	{
        private static readonly NotifyIcon notifyIcon = new NotifyIcon
        {
            Icon = new System.Drawing.Icon(Assembly.GetExecutingAssembly().GetManifestResourceStream("ElectronicObserver.74eo.ico")),
            Visible = true
        };
        public static NotifyIcon NotifyIcon
        {
            get { return WindowsNotification.notifyIcon; }
        } 

        public NotifierDialogData DialogData { get; set; }

        public WindowsNotification(NotifierDialogData data)
        {
            DialogData = data.Clone();
        }

        public void Show()
        {
            if (Toast.IsSupported)
            {
                new Toast(DialogData.Title, DialogData.Message);
            }
            if (WindowsNotification.NotifyIcon == null)
                return;

            notifyIcon.ShowBalloonTip(1000, DialogData.Title, DialogData.Message, ToolTipIcon.None);
        }
		public void Dispose()
		{
            if (WindowsNotification.NotifyIcon != null)
			{
                WindowsNotification.NotifyIcon.Dispose();
			}
		}
	}
}
