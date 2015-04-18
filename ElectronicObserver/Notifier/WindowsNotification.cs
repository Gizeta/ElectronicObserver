using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ElectronicObserver.Notifier;
using MS.WindowsAPICodePack.Internal;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Diagnostics;

namespace ElectronicObserver.Notifier
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
        private bool useToast;
        public WindowsNotification(bool useToast, NotifierDialogData data)
        {
            this.useToast = useToast;
            DialogData = data.Clone();
        }

        public void Show()
        {
            if (Toast.IsSupported && useToast)
            {
                var exePath = Process.GetCurrentProcess().MainModule.FileName;
                var newShortcut = (IShellLinkW)new CShellLink();
                newShortcut.SetPath(exePath);
                newShortcut.SetArguments("");
                var newShortcutProperties = (IPropertyStore)newShortcut;
                using (var appId = new PropVariant(Toast.AppId))
                {
                    newShortcutProperties.SetValue(SystemProperties.System.AppUserModel.ID, appId);
                    newShortcutProperties.Commit();
                }
                var newShortcutSave = (IPersistFile)newShortcut;
                newShortcutSave.Save(Environment.GetFolderPath(Environment.SpecialFolder.StartMenu) + "\\Programs\\ElectronicObserver.lnk", true);
                new Toast(DialogData.Title, DialogData.Message);
            }
            else
            {
                if (WindowsNotification.NotifyIcon == null)
                    return;
                notifyIcon.ShowBalloonTip(1000, DialogData.Title, DialogData.Message, ToolTipIcon.None);
            }
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
