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
	[Register("STPopupLeftBarItem", true)]
	public unsafe partial class STPopupLeftBarItem : global::UIKit.UIBarButtonItem {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("STPopupLeftBarItem");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public STPopupLeftBarItem () : base (NSObjectFlag.Empty)
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
		public STPopupLeftBarItem (NSCoder coder) : base (NSObjectFlag.Empty)
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
		protected STPopupLeftBarItem (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal STPopupLeftBarItem (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithTarget:action:")]
		[CompilerGenerated]
		public STPopupLeftBarItem (NSObject target, Selector action)
			: base (NSObjectFlag.Empty)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (action == null)
				throw new ArgumentNullException ("action");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initWithTarget:action:"), target.Handle, action.Handle), "initWithTarget:action:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithTarget:action:"), target.Handle, action.Handle), "initWithTarget:action:");
			}
		}
		
		[Export ("setType:animated:")]
		[CompilerGenerated]
		public virtual void SetType (STPopupLeftBarItemType type, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_UInt64_bool (this.Handle, Selector.GetHandle ("setType:animated:"), (UInt64)type, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64_bool (this.SuperHandle, Selector.GetHandle ("setType:animated:"), (UInt64)type, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual STPopupLeftBarItemType Type {
			[Export ("type", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (STPopupLeftBarItemType) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("type"));
				} else {
					return (STPopupLeftBarItemType) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("type"));
				}
			}
			
			[Export ("setType:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setType:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setType:"), (UInt64)value);
				}
			}
		}
		
		public partial class STPopupLeftBarItemAppearance : global::UIKit.UIBarButtonItem.UIBarButtonItemAppearance {
			protected internal STPopupLeftBarItemAppearance (IntPtr handle) : base (handle) {}
		}
		
		public static new STPopupLeftBarItemAppearance Appearance {
			get { return new STPopupLeftBarItemAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, ObjCRuntime.Selector.GetHandle ("appearance"))); }
		}
		
		public static new STPopupLeftBarItemAppearance GetAppearance<T> () where T: STPopupLeftBarItem {
			return new STPopupLeftBarItemAppearance (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (Class.GetHandle (typeof (T)), ObjCRuntime.Selector.GetHandle ("appearance")));
		}
		
		public static new STPopupLeftBarItemAppearance AppearanceWhenContainedIn (params Type [] containers)
		{
			return new STPopupLeftBarItemAppearance (UIAppearance.GetAppearance (class_ptr, containers));
		}
		
		public static new STPopupLeftBarItemAppearance GetAppearance (UITraitCollection traits) {
			return new STPopupLeftBarItemAppearance (UIAppearance.GetAppearance (class_ptr, traits));
		}
		
		public static new STPopupLeftBarItemAppearance GetAppearance (UITraitCollection traits, params Type [] containers) {
			return new STPopupLeftBarItemAppearance (UIAppearance.GetAppearance (class_ptr, traits, containers));
		}
		
		public static new STPopupLeftBarItemAppearance GetAppearance<T> (UITraitCollection traits) where T: STPopupLeftBarItem {
			return new STPopupLeftBarItemAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), traits));
		}
		
		public static new STPopupLeftBarItemAppearance GetAppearance<T> (UITraitCollection traits, params Type [] containers) where T: STPopupLeftBarItem{
			return new STPopupLeftBarItemAppearance (UIAppearance.GetAppearance (Class.GetHandle (typeof (T)), containers));
		}
		
		
	} /* class STPopupLeftBarItem */
}
