using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace STPopup
{
	// @interface STPopupNavigationBar : UINavigationBar
	[BaseType(typeof(UINavigationBar))]
	interface STPopupNavigationBar
	{
		// @property (assign, nonatomic) BOOL draggable;
		[Export("draggable")]
		bool Draggable { get; set; }
	}

	// @interface STPopupControllerTransitioningContext : NSObject
	[BaseType(typeof(NSObject))]
	interface STPopupControllerTransitioningContext
	{
		// @property (readonly, assign, nonatomic) STPopupControllerTransitioningAction action;
		[Export("action", ArgumentSemantic.Assign)]
		STPopupControllerTransitioningAction Action { get; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
		[Export("containerView", ArgumentSemantic.Strong)]
		UIView ContainerView { get; }
	}

	// @protocol STPopupControllerTransitioning <NSObject>
	[Protocol, Model]
	[BaseType(typeof(NSObject))]
	interface STPopupControllerTransitioning
	{
		// @required -(NSTimeInterval)popupControllerTransitionDuration:(STPopupControllerTransitioningContext * _Nonnull)context;
		[Abstract]
		[Export("popupControllerTransitionDuration:")]
		double PopupControllerTransitionDuration(STPopupControllerTransitioningContext context);

		// @required -(void)popupControllerAnimateTransition:(STPopupControllerTransitioningContext * _Nonnull)context completion:(void (^ _Nonnull)())completion;
		[Abstract]
		[Export("popupControllerAnimateTransition:completion:")]
		void PopupControllerAnimateTransition(STPopupControllerTransitioningContext context, Action completion);
	}

	// @interface STPopupController : NSObject
	[BaseType(typeof(NSObject))]
	interface STPopupController
	{
		// @property (assign, nonatomic) STPopupStyle style;
		[Export("style", ArgumentSemantic.Assign)]
		STPopupStyle Style { get; set; }

		// @property (assign, nonatomic) STPopupTransitionStyle transitionStyle;
		[Export("transitionStyle", ArgumentSemantic.Assign)]
		STPopupTransitionStyle TransitionStyle { get; set; }

		// @property (nonatomic, weak) id<STPopupControllerTransitioning> _Nullable transitioning;
		[NullAllowed, Export("transitioning", ArgumentSemantic.Weak)]
		STPopupControllerTransitioning Transitioning { get; set; }

		// @property (assign, nonatomic) CGFloat cornerRadius __attribute__((deprecated("Use containerView.layer.cornerRadius instead")));
		[Export("cornerRadius")]
		nfloat CornerRadius { get; set; }

		// @property (assign, nonatomic) BOOL navigationBarHidden;
		[Export("navigationBarHidden")]
		bool NavigationBarHidden { get; set; }

		// @property (assign, nonatomic) BOOL hidesCloseButton;
		[Export("hidesCloseButton")]
		bool HidesCloseButton { get; set; }

		// @property (readonly, nonatomic, strong) STPopupNavigationBar * _Nonnull navigationBar;
		[Export("navigationBar", ArgumentSemantic.Strong)]
		STPopupNavigationBar NavigationBar { get; }

		// @property (nonatomic, strong) UIView * _Nullable backgroundView;
		[NullAllowed, Export("backgroundView", ArgumentSemantic.Strong)]
		UIView BackgroundView { get; set; }

		// @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
		[Export("containerView", ArgumentSemantic.Strong)]
		UIView ContainerView { get; }

		// @property (readonly, nonatomic, strong) UIViewController * _Nullable topViewController;
		[NullAllowed, Export("topViewController", ArgumentSemantic.Strong)]
		UIViewController TopViewController { get; }

		// @property (readonly, assign, nonatomic) BOOL presented;
		[Export("presented")]
		bool Presented { get; }

		// -(instancetype _Nonnull)initWithRootViewController:(UIViewController * _Nonnull)rootViewController;
		[Export("initWithRootViewController:")]
		IntPtr Constructor(UIViewController rootViewController);

		// -(void)presentInViewController:(UIViewController * _Nonnull)viewController;
		[Export("presentInViewController:")]
		void PresentInViewController(UIViewController viewController);

		// -(void)presentInViewController:(UIViewController * _Nonnull)viewController completion:(void (^ _Nullable)(void))completion;
		[Export("presentInViewController:completion:")]
		void PresentInViewController(UIViewController viewController, [NullAllowed] Action completion);

		// -(void)dismiss;
		[Export("dismiss")]
		void Dismiss();

		// -(void)dismissWithCompletion:(void (^ _Nullable)(void))completion;
		[Export("dismissWithCompletion:")]
		void DismissWithCompletion([NullAllowed] Action completion);

		// -(void)pushViewController:(UIViewController * _Nonnull)viewController animated:(BOOL)animated;
		[Export("pushViewController:animated:")]
		void PushViewController(UIViewController viewController, bool animated);

		// -(void)popViewControllerAnimated:(BOOL)animated;
		[Export("popViewControllerAnimated:")]
		void PopViewControllerAnimated(bool animated);

		// -(void)setNavigationBarHidden:(BOOL)navigationBarHidden animated:(BOOL)animated;
		[Export("setNavigationBarHidden:animated:")]
		void SetNavigationBarHidden(bool navigationBarHidden, bool animated);
	}

	// @interface STPopup (UIViewController)
	[Category]
	[BaseType(typeof(UIViewController))]
	interface UIViewController_STPopup
	{
        // @property (assign, nonatomic) CGSize contentSizeInPopup;
        [Export("contentSizeInPopup")]
        //CGSize ContentSizeInPopup { get; set; }
        CGSize ContentSizeInPopup();

        [Export("setContentSizeInPopup:")]
        void SetContentSizeInPopup(CGSize size);

        // @property (assign, nonatomic) CGSize landscapeContentSizeInPopup;
        [Export("landscapeContentSizeInPopup")]
        //CGSize LandscapeContentSizeInPopup { get; set; }
        CGSize LandscapeContentSizeInPopup();
		[Export("setLandscapeContentSizeInPopup:")]
		void SetLandscapeContentSizeInPopup(CGSize size);


        // @property (readonly, nonatomic, weak) STPopupController * _Nullable popupController;
        [NullAllowed, Export("popupController")]
        STPopupController PopupController();
	}

    partial interface ISTPopupControllerTransitioning {}

	// @interface STPopupControllerTransitioningFade : NSObject <STPopupControllerTransitioning>
	[BaseType(typeof(NSObject))]
	interface STPopupControllerTransitioningFade : ISTPopupControllerTransitioning
	{
	}

	// @interface STPopupControllerTransitioningSlideVertical : NSObject <STPopupControllerTransitioning>
	[BaseType(typeof(NSObject))]
	interface STPopupControllerTransitioningSlideVertical : ISTPopupControllerTransitioning
	{
	}

	// @interface STPopupLeftBarItem : UIBarButtonItem
	[BaseType(typeof(UIBarButtonItem))]
	interface STPopupLeftBarItem
	{
		// @property (assign, nonatomic) STPopupLeftBarItemType type;
		[Export("type", ArgumentSemantic.Assign)]
		STPopupLeftBarItemType Type { get; set; }

		// -(instancetype _Nonnull)initWithTarget:(id _Nonnull)target action:(SEL _Nonnull)action;
		[Export("initWithTarget:action:")]
		IntPtr Constructor(NSObject target, Selector action);

		// -(void)setType:(STPopupLeftBarItemType)type animated:(BOOL)animated;
		[Export("setType:animated:")]
		void SetType(STPopupLeftBarItemType type, bool animated);
	}

    [Static]
    partial interface Notifications
	{
		// extern NSString *const STPopupFirstResponderDidChangeNotification;
		[Field("STPopupFirstResponderDidChangeNotification", "__Internal")]
		NSString STPopupFirstResponderDidChange { get; }
	}

    //// @interface STPopup (UIResponder)
    //[Category]
    //[BaseType(typeof(UIResponder))]
    //interface UIResponder_STPopup
    //{
    //}

    [Static]
    interface VersionInfo
	{
		// extern double STPopupVersionNumber;
		[Field("STPopupVersionNumber", "__Internal")]
		double Number { get; }

		// extern const unsigned char [] STPopupVersionString;
		[Field("STPopupVersionString", "__Internal")]
        NSString String { get; }
	}
}
