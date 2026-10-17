using System;
using System.Collections.Generic;
using System.Text;

namespace NexcraftDemo.Controls
{
    public class NexEntry : Entry
    {
        public static readonly BindableProperty AccentColorProperty =
            BindableProperty.Create(
                nameof(AccentColor),
                typeof(Color),
                typeof(NexEntry),
                Colors.Orange,
                propertyChanged: (bindable, oldValue, newValue) =>
                    ((NexEntry)bindable).Handler?.UpdateValue(nameof(AccentColor)));

        public Color AccentColor
        {
            get => (Color)GetValue(AccentColorProperty);
            set => SetValue(AccentColorProperty, value);
        }
    }
}
