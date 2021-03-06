//
// Copyright 2010, Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using MonoMac.Foundation;
using MonoMac.ObjCRuntime;

namespace MonoMac.AppKit {

	public partial class NSWindow {
		static IntPtr selInitWithWindowRef = Selector.GetHandle ("initWithWindowRef:");

		[Export ("initWithWindowRef:")]
		public NSWindow (IntPtr windowRef, NSObjectFlag x) : base (NSObjectFlag.Empty)
		{
			if (IsDirectBinding) {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSend (this.Handle, selInitWithWindowRef);
			} else {
				Handle = MonoMac.ObjCRuntime.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selInitWithWindowRef);
			}
		}

		static public NSWindow FromWindowRef (IntPtr windowRef)
		{
			return new NSWindow (windowRef, NSObjectFlag.Empty);
		}
		
// NSString NSWindowDidBecomeKeyNotification;
// NSString NSWindowDidBecomeMainNotification;
// NSString NSWindowDidChangeScreenNotification;
// NSString NSWindowDidDeminiaturizeNotification;
// NSString NSWindowDidExposeNotification;
// NSString NSWindowDidMiniaturizeNotification;
// NSString NSWindowDidMoveNotification;
// NSString NSWindowDidResignKeyNotification;
// NSString NSWindowDidResignMainNotification;
// NSString NSWindowDidResizeNotification;
// NSString NSWindowDidUpdateNotification;
// NSString NSWindowWillCloseNotification;
// NSString NSWindowWillMiniaturizeNotification;
// NSString NSWindowWillMoveNotification;
// NSString NSWindowWillBeginSheetNotification;
// NSString NSWindowDidEndSheetNotification;
// NSString NSWindowDidChangeScreenProfileNotification
// NSString NSWindowWillStartLiveResizeNotification
// NSString NSWindowDidEndLiveResizeNotification

		
	}
}
