//
// UIEvent.cs: Extensions to the UIEvent class
//
// Authors:
//   Miguel de Icaza
//
// Copyright 2012, Xamarin Inc
//

#if !WATCH

using System;
using XamCore.ObjCRuntime;
using XamCore.Foundation;

namespace XamCore.UIKit {
	public partial class UIEvent {

		public override string ToString ()
		{
			return String.Format ("[Time={0} ({1}{2})]", Timestamp, Type, Subtype != UIEventSubtype.None ? "." + Subtype : "");
		}
	}
}

#endif // !WATCH
