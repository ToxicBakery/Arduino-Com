using System;

namespace ArduinoCom
{
	public partial class AcAboutDialog : Gtk.Dialog
	{

		public AcAboutDialog ()
		{
			this.Build ();
			this.eventboxURL.ButtonPressEvent += OnEventBoxURLButtonPressEvent;
		}

		public String Version {
			set {
				this.labelVersion.Text = "Version " + value;
			}
		}

		protected void OnEventBoxURLButtonPressEvent(object o, Gtk.ButtonPressEventArgs args) {
			System.Diagnostics.Process.Start("http://toxicbakery.com/");
		}
	}
}

