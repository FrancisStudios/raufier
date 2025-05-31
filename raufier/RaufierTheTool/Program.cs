/**
 *  ------ [ Property of Francis Studios ] ------
 * ===========================
 * github: https://github.com/francisstudios
 * ©2025 Francis Studios Softwares by L.
 * 
 * Project Started on 2025.05.31 | 19:56 BP, HU
*/

using System;
using System.Windows.Forms;

namespace RaufierTheTool
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Ablak());
		}
		
	}
}
