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
	[Protocol (Name = "STPopupControllerTransitioning", WrapperType = typeof (STPopupControllerTransitioningWrapper))]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopupControllerTransitionDuration", Selector = "popupControllerTransitionDuration:", ReturnType = typeof (double), ParameterType = new Type [] { typeof (STPopup.STPopupControllerTransitioningContext) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = true, IsProperty = false, IsStatic = false, Name = "PopupControllerAnimateTransition", Selector = "popupControllerAnimateTransition:completion:", ParameterType = new Type [] { typeof (STPopup.STPopupControllerTransitioningContext), typeof (Action) }, ParameterByRef = new bool [] { false, false })]
	public interface ISTPopupControllerTransitioning : INativeObject, IDisposable
	{
		[CompilerGenerated]
		[Export ("popupControllerTransitionDuration:")]
		[Preserve (Conditional = true)]
		global::System.Double PopupControllerTransitionDuration (STPopupControllerTransitioningContext context);
		
		[CompilerGenerated]
		[Export ("popupControllerAnimateTransition:completion:")]
		[Preserve (Conditional = true)]
		unsafe void PopupControllerAnimateTransition (STPopupControllerTransitioningContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		
	}
	
	internal sealed class STPopupControllerTransitioningWrapper : BaseWrapper, ISTPopupControllerTransitioning {
		[Preserve (Conditional = true)]
		public STPopupControllerTransitioningWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
		[Export ("popupControllerTransitionDuration:")]
		[CompilerGenerated]
		public global::System.Double PopupControllerTransitionDuration (STPopupControllerTransitioningContext context)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			return global::ApiDefinition.Messaging.Double_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("popupControllerTransitionDuration:"), context.Handle);
		}
		
		[Export ("popupControllerAnimateTransition:completion:")]
		[CompilerGenerated]
		public unsafe void PopupControllerAnimateTransition (STPopupControllerTransitioningContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion)
		{
			if (context == null)
				throw new ArgumentNullException ("context");
			if (completion == null)
				throw new ArgumentNullException ("completion");
			BlockLiteral *block_ptr_completion;
			BlockLiteral block_completion;
			block_completion = new BlockLiteral ();
			block_ptr_completion = &block_completion;
			block_completion.SetupBlock (Trampolines.SDAction.Handler, completion);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("popupControllerAnimateTransition:completion:"), context.Handle, (IntPtr) block_ptr_completion);
			block_ptr_completion->CleanupBlock ();
			
		}
		
	}
}
namespace STPopup {
	[Protocol]
	[Register("STPopupControllerTransitioning", false)]
	[Model]
	public unsafe abstract partial class STPopupControllerTransitioning : NSObject, ISTPopupControllerTransitioning {
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		protected STPopupControllerTransitioning () : base (NSObjectFlag.Empty)
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
		protected STPopupControllerTransitioning (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal STPopupControllerTransitioning (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("popupControllerAnimateTransition:completion:")]
		[CompilerGenerated]
		public unsafe abstract void PopupControllerAnimateTransition (STPopupControllerTransitioningContext context, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDAction))]global::System.Action completion);
		[Export ("popupControllerTransitionDuration:")]
		[CompilerGenerated]
		public abstract global::System.Double PopupControllerTransitionDuration (STPopupControllerTransitioningContext context);
	} /* class STPopupControllerTransitioning */
}
