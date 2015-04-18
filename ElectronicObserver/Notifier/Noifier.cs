using System.Reflection;
using System.Windows.Forms;
using ElectronicObserver;

namespace ElectronicObserver.Notifier
{
    public class Noifier
    {
        public NotifierDialogData DialogData { get; set; }

        public Noifier(NotifierDialogData data)
        {
            DialogData = data.Clone();
        }
        
        public void Show()
        {
            if (Noifier.NotifyIcon == null)
                return;

            notifyIcon.ShowBalloonTip(1000, DialogData.Title, DialogData.Message, ToolTipIcon.None);
        }
    }
}
