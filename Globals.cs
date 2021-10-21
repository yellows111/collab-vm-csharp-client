namespace CollabClient
{
    internal class Globals
    {
        public static string vmip = "IP here, node name ->";
        public static string vmname = "here";
        public static string vmusername = "collabvm-csharp-user";
		public static bool vmdiscovery = false;
		public static ushort GetKeycodeByName(System.Windows.Forms.KeyEventArgs Keyevent, ushort fallback) {
			System.Windows.Forms.Keys Keyname = Keyevent.KeyCode;
			string keystring = Keyname.ToString();
			ushort kc = (char) Keyevent.KeyValue;
			ushort keycode = 0;
			switch (keystring)
			{
				case "Escape":
					keycode = 0xff1b;
					break;
				case "F1":
					keycode = 0xffbe;
					break;
				case "F2":
					keycode = 0xffbf;
					break;
				case "F3":
					keycode = 0xffc0;
					break;
				case "F4":
					keycode = 0xffc1;
					break;
				case "F5":
					keycode = 0xffc2;
					break;
				case "F6":
					keycode = 0xffc3;
					break;
				case "F7":
					keycode = 0xffc4;
					break;
				case "F8":
					keycode = 0xffc5;
					break;
				case "F9":
					keycode = 0xffc6;
					break;
				case "F10":
					keycode = 0xffc7;
					break;
				case "F11":
					keycode = 0xffc8;
					break;
				case "F12":
					keycode = 0xffc9;
					break;
				case "Oem8": // `/¬/¦
					keycode = 0x0060;
					break;
				case "OemMinus":
					keycode = 0x002d;
					break;
				case "Oemplus":
					keycode = 0x002b;
					break;
				case "Back": //...space
					keycode = 0xff08;
					break;
				case "Return": //...space
					keycode = 0xff0d;
					break;
				case "ShiftKey": // both of them, lol .net
					keycode = 0xffe1;
					break;
				case "Oemcomma":
					keycode = 0x002c;
					break;
				case "OemPeriod":
					keycode = 0x002e;
					break;
				case "OemQuestion":
					keycode = 0x003f;
					break;
				case "ControlKey":
					keycode = 0xffe3;
					break;
				case "Menu": // Alt, windows calls this Menu but XK_MENU is KC 93 lol
					keycode = 0xffe9;
					break;
				case "LWin":
					keycode = 0xffeb;
					break;
				case "Apps":
					keycode = 0xff67;
					break;
				case "Insert":
					keycode = 0xff63;
					break;
				case "Delete":
					keycode = 0xffff;
					break;
				case "Home":
					keycode = 0xff50;
					break;
				case "End":
					keycode = 0xff57;
					break;
				case "PageUp":
					keycode = 0xff55;
					break;
				case "Next":
					keycode = 0xff56;
					break;
				case "Left":
					keycode = 0xff51;
					break;
				case "Up":
					keycode = 0xff52;
					break;
				case "Right":
					keycode = 0xff53;
					break;
				case "Down":
					keycode = 0xff54;
					break;
					/**
					 * Do you ever just feel pain? I do.
					 * This is the part where I put in the (ambigious) OEM keys.
					 * - yellows111
					 */
				case "OemOpenBrackets": {
					switch (kc)
					{
						case 219:
							keycode = 0x007b;
							break;
						case 251:
							keycode = 0x005b;
							break;
					}
					break;
				}
				case "Oem1":
					keycode = 0x003b;
					break;
				case "Oem5": {
					switch (kc)
					{
						case 220:
							keycode = 0x007c;
							break;
						case 252:
							keycode = 0x005c;
							break;
					}
					break;
				}
				case "Oem6": {
					switch (kc)
					{
						case 221:
							keycode = 0x007d;
							break;
						case 253:
							keycode = 0x005d;
							break;
					}
					break;
				}					
				case "Oem7": {
					switch (kc)
					{
						case 222: // "
							keycode = 0x0022;
							break;
						case 254: // '
							keycode = 0x0027;
							break;
					}
					break;
				}
				case "Oemtilde": { // not to be confused with Oem8
					switch (kc)
					{
						case 192: // ~
							keycode = 0x007e;
							break;
						case 224: // `
							keycode = 0x0060;
							break;
					}
					break;
				}
				case "OemBackslash": { // on 102-key US keyboards or equiv... dupe of Oem5
					switch (kc)
					{
						case 194:
							keycode = 0x007c;
							break;
						case 226:
							keycode = 0x005c;
							break;
					}
					break;
				}
				// Return to sanity?
				case "Tab":
					keycode = 0xff09;
					break;
				case "Capital":
					keycode = 0xffe5;
					break;
				case "Pause":
					keycode = 0xff6b;
					break;
				case "PrintScreen":
					keycode = 0xff15;
					break;
				case "Scroll":
					keycode = 0xff14;
					break;
				case "BrowserSearch": //X11 doesn't define Media Keys, so we have to do massive assumptions or make them keys you can't press normally
					keycode = 0xff09;
					break;
					// bonus round: keypad with NL on
				case "NumPad0":
					keycode = 0xffb0;
					break;
				case "NumPad1":
					keycode = 0xffb1;
					break;
				case "NumPad2":
					keycode = 0xffb2;
					break;
				case "NumPad3":
					keycode = 0xffb3;
					break;
				case "NumPad4":
					keycode = 0xffb4;
					break;
				case "NumPad5":
					keycode = 0xffb5;
					break;
				case "NumPad6":
					keycode = 0xffb6;
					break;
				case "NumPad7":
					keycode = 0xffb7;
					break;
				case "NumPad8":
					keycode = 0xffb8;
					break;
				case "NumPad9":
					keycode = 0xffb9;
					break;
				case "Decimal":
					keycode = 0xffae;
					break;
				case "Add":
					keycode = 0xffab;
					break;
				case "Divide":
					keycode = 0xffaf;
					break;
				case "Multiply":
					keycode = 0xffaa;
					break;
				case "Subtract":
					keycode = 0xffad;
					break;
				case "NumLock":
					keycode = 0xff7f;
					break;
				default: // every key *not* listed here fallbacks to this...
					keycode = fallback;
					break;
			}
			return keycode;
		}
    }
}
