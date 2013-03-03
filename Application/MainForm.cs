using System;

namespace Mossywell.LockConsole
{
	class LockThisComputer
	{
		#region Externals
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern void LockWorkStation();
		#endregion

		#region Main Entry Point
		[STAThread]
		static void Main(string[] args)
		{
			try
			{
				LockWorkStation();
			}
			catch(Exception ex)
			{
				System.Windows.Forms.MessageBox.Show(ex.Message);
			}
		}
		#endregion
	}
}
