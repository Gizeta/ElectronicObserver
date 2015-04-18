using System;
using System.Collections.Generic;
using Windows.UI.Notifications;

namespace ElectronicObserver
{
	public class Toast
	{
		public static bool IsSupported
		{
			get
			{
				var version = Environment.OSVersion.Version;
				return (version.Major == 6 && version.Minor >= 2) || version.Major > 6;

			}
		}
		public Toast(string header, string body)
		{
			var toastXml = ToastNotificationManager.GetTemplateContent(ToastTemplateType.ToastText02);
			var stringElements = toastXml.GetElementsByTagName("text");
			if (stringElements.Length == 2)
			{
				stringElements[0].AppendChild(toastXml.CreateTextNode(header));
				stringElements[1].AppendChild(toastXml.CreateTextNode(body));
			}
            ToastNotificationManager.CreateToastNotifier("@AtrisMio.WindowsNotification").Show(new ToastNotification(toastXml));
		}
	}
}
