using System;
using Foundation;
using UIKit;
using CoreGraphics;
using STPopup;

namespace Naxam.STPopup.QuickStart
{
    public class PopupVC: UIViewController
    {
        public PopupVC(): base()
        {
        }

        public bool HasNext = false;

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            var label = new UILabel()
            {
                Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum",
                Lines = 0
            };
            if (HasNext) {
				Title = "First popup";
				NavigationItem.RightBarButtonItem = new UIBarButtonItem("Next", UIBarButtonItemStyle.Plain, DidTapNext);
            }
            else {
                Title = "Second popup";
				label.Text = "Sed ut perspiciatis unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam, eaque ipsa quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt explicabo. Nemo enim ipsam voluptatem quia voluptas sit aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos qui ratione voluptatem sequi nesciunt. Neque porro quisquam est, qui dolorem ipsum quia dolor sit amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit qui in ea voluptate velit esse quam nihil molestiae consequatur, vel illum qui dolorem eum fugiat quo voluptas nulla pariatur?";
			}

            var attributes = new UIStringAttributes()
            {
                Font = label.Font
            };
            var size = ((NSString)label.Text).GetBoundingRect(new CGSize(UIScreen.MainScreen.Bounds.Size.Width * 0.7, nfloat.PositiveInfinity),
                                                    NSStringDrawingOptions.UsesLineFragmentOrigin,
                                                    attributes,
                                                    null
                                                             ).Size;
            this.SetContentSizeInPopup(size);
            this.SetLandscapeContentSizeInPopup(new CGSize(size.Height, size.Width));

            View.AddSubview(label);
            label.TranslatesAutoresizingMaskIntoConstraints = false;
            var views = NSDictionary.FromObjectAndKey(label, (NSString) "label");
            View.AddConstraints(NSLayoutConstraint.FromVisualFormat("H:|-8-[label]-8-|", 0, null, views));
            View.AddConstraints(NSLayoutConstraint.FromVisualFormat("V:|-8-[label]-8-|", 0, null, views));
        }

        private void DidTapNext(object sender, EventArgs e)
        {
            this.PopupController().PushViewController(new PopupVC(), true);
        }
    }
}
