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
	public unsafe static partial class VersionInfo  {
		
		[Field ("STPopupVersionNumber",  "__Internal")]
		public static global::System.Double Number {
			get {
				return Dlfcn.GetDouble (Libraries.__Internal.Handle, "STPopupVersionNumber");
			}
		}
		[CompilerGenerated]
		static NSString _String;
		[Field ("STPopupVersionString",  "__Internal")]
		public static NSString String {
			get {
				if (_String == null)
					_String = Dlfcn.GetStringConstant (Libraries.__Internal.Handle, "STPopupVersionString");
				return _String;
			}
		}
	} /* class VersionInfo */
}
