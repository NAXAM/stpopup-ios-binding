//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using Photos;
using ModelIO;
using SceneKit;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace STPopup {
	public unsafe static partial class UIViewController_STPopup  {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("UIViewController");
		
		[Export ("contentSizeInPopup")]
		[CompilerGenerated]
		public static CGSize ContentSizeInPopup (this global::UIKit.UIViewController This)
		{
			CGSize ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("contentSizeInPopup"));
				} else {
					global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("contentSizeInPopup"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("contentSizeInPopup"));
			} else {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("contentSizeInPopup"));
			}
			return ret;
		}
		
		[Export ("landscapeContentSizeInPopup")]
		[CompilerGenerated]
		public static CGSize LandscapeContentSizeInPopup (this global::UIKit.UIViewController This)
		{
			CGSize ret;
			if (Runtime.Arch == Arch.DEVICE) {
				if (IntPtr.Size == 8) {
					ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("landscapeContentSizeInPopup"));
				} else {
					global::ApiDefinition.Messaging.CGSize_objc_msgSend_stret (out ret, This.Handle, Selector.GetHandle ("landscapeContentSizeInPopup"));
				}
			} else if (IntPtr.Size == 8) {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("landscapeContentSizeInPopup"));
			} else {
				ret = global::ApiDefinition.Messaging.CGSize_objc_msgSend (This.Handle, Selector.GetHandle ("landscapeContentSizeInPopup"));
			}
			return ret;
		}
		
		[Export ("popupController")]
		[CompilerGenerated]
		public static STPopupController PopupController (this global::UIKit.UIViewController This)
		{
			return  Runtime.GetNSObject<STPopupController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("popupController")));
		}
		
		[Export ("setContentSizeInPopup:")]
		[CompilerGenerated]
		public static void SetContentSizeInPopup (this global::UIKit.UIViewController This, CGSize size)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("setContentSizeInPopup:"), size);
		}
		
		[Export ("setLandscapeContentSizeInPopup:")]
		[CompilerGenerated]
		public static void SetLandscapeContentSizeInPopup (this global::UIKit.UIViewController This, CGSize size)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_CGSize (This.Handle, Selector.GetHandle ("setLandscapeContentSizeInPopup:"), size);
		}
		
	} /* class UIViewController_STPopup */
}
