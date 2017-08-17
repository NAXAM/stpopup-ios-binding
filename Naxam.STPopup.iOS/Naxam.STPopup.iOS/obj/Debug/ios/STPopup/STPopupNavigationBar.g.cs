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
	[Register("STPopupNavigationBar", true)]
	public unsafe partial class STPopupNavigationBar : global::UIKit.UINavigationBar {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("STPopupNavigationBar");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public STPopupNavigationBar () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public STPopupNavigationBar (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;

			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected STPopupNavigationBar (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal STPopupNavigationBar (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual bool Draggable {
			[Export ("draggable")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("draggable"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("draggable"));
				}
			}
			
			[Export ("setDraggable:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setDraggable:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setDraggable:"), value);
				}
			}
		}
		
		public partial class STPopupNavigationBarAppearance : global::UIKit.UINavigationBar.UINavigationBarAppearance {
			protected internal STPopupNavigationBarAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new STPopupNavigationBarAppearance Appearance {
			get { return new STPopupNavigationBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new STPopupNavigationBarAppearance GetAppearance<T> () where T: STPopupNavigationBar {
			return new STPopupNavigationBarAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new STPopupNavigationBarAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new STPopupNavigationBarAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new STPopupNavigationBarAppearance GetAppearance (UITraitCollection traits) {
			return new STPopupNavigationBarAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new STPopupNavigationBarAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new STPopupNavigationBarAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new STPopupNavigationBarAppearance GetAppearance<T> (UITraitCollection traits) where T: STPopupNavigationBar {
			return new STPopupNavigationBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new STPopupNavigationBarAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: STPopupNavigationBar{
			return new STPopupNavigationBarAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class STPopupNavigationBar */
}
