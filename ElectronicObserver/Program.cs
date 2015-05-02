using ElectronicObserver.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectronicObserver {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main() {
            Utility.Configuration.Instance.Load();

            System.Threading.Thread.CurrentThread.CurrentUICulture = Utility.CultureHelper.GetCultureInfo(Utility.Configuration.Config.UI.Language);

            Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );
			Application.Run( new FormMain() );
		}
	}
}
