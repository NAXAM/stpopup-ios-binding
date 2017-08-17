using System;

namespace STPopup
{
    public enum STPopupControllerTransitioningAction : ulong
    {
        Present,
        Dismiss
    }

    public enum STPopupStyle : ulong
    {
        FormSheet,
        BottomSheet
    }

    public enum STPopupTransitionStyle : ulong
    {
        SlideVertical,
        Fade,
        Custom
    }

    public enum STPopupLeftBarItemType : ulong
    {
        Cross,
        Arrow
    }
}
