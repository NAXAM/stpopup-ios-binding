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
	[Register("STPopupController", true)]
	public unsafe partial class STPopupController : NSObject {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("STPopupController");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public STPopupController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected STPopupController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal STPopupController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithRootViewController:")]
		[CompilerGenerated]
		public STPopupController (global::UIKit.UIViewController rootViewController)
			: base (NSObjectFlag.Empty)
		{
			if (rootViewController == null)
				throw new ArgumentNullException ("rootViewController");
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithRootViewController:"), rootViewController.Handle), "initWithRootViewController:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithRootViewController:"), rootViewController.Handle), "initWithRootViewController:");
			}
		}
		
		[Export ("dismiss")]
		[CompilerGenerated]
		public virtual void Dismiss ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dismiss"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dismiss"));
			}
		}
		
		[Export ("dismissWithCompletion:")]
		[CompilerGenerated]
		public unsafe virtual void DismissWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("dismissWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("dismissWithCompletion:"), (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("popViewControllerAnimated:")]
		[CompilerGenerated]
		public virtual void PopViewControllerAnimated (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("popViewControllerAnimated:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("popViewControllerAnimated:"), animated);
			}
		}
		
		[Export ("presentInViewController:")]
		[CompilerGenerated]
		public virtual void PresentInViewController (global::UIKit.UIViewController viewController)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("presentInViewController:"), viewController.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("presentInViewController:"), viewController.Handle);
			}
		}
		
		[Export ("presentInViewController:completion:")]
		[CompilerGenerated]
		public unsafe virtual void PresentInViewController (global::UIKit.UIViewController viewController, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			if (completion == null){
				block_ptr_completion = null;
			} else {
				block_completion = new BlockLiteral ();
				block_ptr_completion = &block_completion;
				block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			}
			
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("presentInViewController:completion:"), viewController.Handle, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("presentInViewController:completion:"), viewController.Handle, (IntPtr) block_ptr_completion);
			}
			if (block_ptr_completion != null)
				block_ptr_completion->CleanupBlock ();
			
		}
		
		[Export ("pushViewController:animated:")]
		[CompilerGenerated]
		public virtual void PushViewController (global::UIKit.UIViewController viewController, bool animated)
		{
			if (viewController == null)
				throw new ArgumentNullException ("viewController");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_bool (this.Handle, Selector.GetHandle ("pushViewController:animated:"), viewController.Handle, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_bool (this.SuperHandle, Selector.GetHandle ("pushViewController:animated:"), viewController.Handle, animated);
			}
		}
		
		[Export ("setNavigationBarHidden:animated:")]
		[CompilerGenerated]
		public virtual void SetNavigationBarHidden (bool navigationBarHidden, bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool_bool (this.Handle, Selector.GetHandle ("setNavigationBarHidden:animated:"), navigationBarHidden, animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool_bool (this.SuperHandle, Selector.GetHandle ("setNavigationBarHidden:animated:"), navigationBarHidden, animated);
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView BackgroundView {
			[Export ("backgroundView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("backgroundView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("backgroundView")));
				}
				return ret;
			}
			
			[Export ("setBackgroundView:", ArgumentSemantic.Retain)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBackgroundView:"), value == null ? IntPtr.Zero : value.Handle);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIView ContainerView {
			[Export ("containerView", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIView ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("containerView")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("containerView")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nfloat CornerRadius {
			[Export ("cornerRadius")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSend (this.Handle, Selector.GetHandle ("cornerRadius"));
				} else {
					return global::ApiDefinition.Messaging.nfloat_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("cornerRadius"));
				}
			}
			
			[Export ("setCornerRadius:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_nfloat (this.Handle, Selector.GetHandle ("setCornerRadius:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_nfloat (this.SuperHandle, Selector.GetHandle ("setCornerRadius:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool HidesCloseButton {
			[Export ("hidesCloseButton")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hidesCloseButton"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hidesCloseButton"));
				}
			}
			
			[Export ("setHidesCloseButton:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setHidesCloseButton:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setHidesCloseButton:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual STPopupNavigationBar NavigationBar {
			[Export ("navigationBar", ArgumentSemantic.Retain)]
			get {
				STPopupNavigationBar ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<STPopupNavigationBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBar")));
				} else {
					ret =  Runtime.GetNSObject<STPopupNavigationBar> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBar")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual bool NavigationBarHidden {
			[Export ("navigationBarHidden")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("navigationBarHidden"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("navigationBarHidden"));
				}
			}
			
			[Export ("setNavigationBarHidden:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("setNavigationBarHidden:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("setNavigationBarHidden:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual bool Presented {
			[Export ("presented")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("presented"));
				} else {
					return global::ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("presented"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual STPopupStyle Style {
			[Export ("style", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (STPopupStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("style"));
				} else {
					return (STPopupStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("style"));
				}
			}
			
			[Export ("setStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setStyle:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setStyle:"), (UInt64)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual global::UIKit.UIViewController TopViewController {
			[Export ("topViewController", ArgumentSemantic.Retain)]
			get {
				global::UIKit.UIViewController ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("topViewController")));
				} else {
					ret =  Runtime.GetNSObject<global::UIKit.UIViewController> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("topViewController")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual STPopupTransitionStyle TransitionStyle {
			[Export ("transitionStyle", ArgumentSemantic.UnsafeUnretained)]
			get {
				if (IsDirectBinding) {
					return (STPopupTransitionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSend (this.Handle, Selector.GetHandle ("transitionStyle"));
				} else {
					return (STPopupTransitionStyle) global::ApiDefinition.Messaging.UInt64_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transitionStyle"));
				}
			}
			
			[Export ("setTransitionStyle:", ArgumentSemantic.UnsafeUnretained)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_UInt64 (this.Handle, Selector.GetHandle ("setTransitionStyle:"), (UInt64)value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_UInt64 (this.SuperHandle, Selector.GetHandle ("setTransitionStyle:"), (UInt64)value);
				}
			}
		}
		
		[CompilerGenerated]
		object __mt_Transitioning_var;
		[CompilerGenerated]
		public virtual STPopupControllerTransitioning Transitioning {
			[Export ("transitioning", ArgumentSemantic.Weak)]
			get {
				STPopupControllerTransitioning ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<STPopupControllerTransitioning> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("transitioning")));
				} else {
					ret =  Runtime.GetNSObject<STPopupControllerTransitioning> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("transitioning")));
				}
				MarkDirty ();
				__mt_Transitioning_var = ret;
				return ret;
			}
			
			[Export ("setTransitioning:", ArgumentSemantic.Weak)]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setTransitioning:"), value == null ? IntPtr.Zero : value.Handle);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setTransitioning:"), value == null ? IntPtr.Zero : value.Handle);
				}
				MarkDirty ();
				__mt_Transitioning_var = value;
			}
		}
		
		[CompilerGenerated]
		protected override void Dispose (bool disposing)
		{
			base.Dispose (disposing);
			if (Handle == IntPtr.Zero) {
				__mt_Transitioning_var = null;
			}
		}
	} /* class STPopupController */
}
