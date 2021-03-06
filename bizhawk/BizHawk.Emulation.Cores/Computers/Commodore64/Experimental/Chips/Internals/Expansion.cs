﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using BizHawk.Common;

namespace BizHawk.Emulation.Cores.Computers.Commodore64.Experimental
{
	public class Expansion
	{
		virtual public bool ExRom { get { return true; } }
		virtual public bool Game { get { return true; } }
		virtual public bool IRQ { get { return true; } }
		virtual public bool NMI { get { return true; } }
		public bool OutputExRom() { return ExRom; }
		public bool OutputGame() { return Game; }
		public bool OutputIRQ() { return IRQ; }
		public bool OutputNMI() { return NMI; }
		virtual public void SyncState(Serializer ser) { SaveState.SyncObject(ser, this); }
	}
}
