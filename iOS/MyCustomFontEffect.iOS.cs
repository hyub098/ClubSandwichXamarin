﻿using ClubSandwich.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("Xamarin")]
[assembly: ExportEffect(typeof(MyCustomFontEffect), "CustomFontEffect")]
namespace ClubSandwich.iOS
{
    class MyCustomFontEffect : PlatformEffect
    {
        UIFont oldFont;

        protected override void OnAttached()
        {
            if (Element is Label == false)
                return;

            var label = Control as UILabel;

            oldFont = label.Font;

            label.Font = UIFont.FromName("Rubik-MediumItalic", label.Font.PointSize);
        }

        protected override void OnDetached()
        {
            if (oldFont != null)
            {
                var label = Control as UILabel;
                label.Font = oldFont;
            }
        }
    }
}