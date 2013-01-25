using System;
using Gtk;

namespace ArduinoCom
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			ArduinoComWindow win = new ArduinoComWindow ();
			win.Show ();
			Application.Run ();
		}
	}
}
