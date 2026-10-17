using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Maui.Handlers;
using Microsoft.Maui.Platform;
using NexcraftDemo.Controls;

namespace NexcraftDemo.Handlers
{
    public static class NexEntryCustomization
    {
        public static void Register()
        {
            
            EntryHandler.Mapper.AppendToMapping(nameof(NexEntry.AccentColor), (handler, view) =>
            {
              
                if (view is not NexEntry nexEntry)
                    return;

#if ANDROID
            var fondo = new Android.Graphics.Drawables.GradientDrawable();
            fondo.SetShape(Android.Graphics.Drawables.ShapeType.Rectangle);
            fondo.SetCornerRadius(30f);
            fondo.SetColor(Android.Graphics.Color.White);
            fondo.SetStroke(5, nexEntry.AccentColor.ToPlatform());

            handler.PlatformView.Background = fondo;          // quita el subrayado
            handler.PlatformView.SetPadding(40, 28, 40, 28);
            handler.PlatformView.SetSelectAllOnFocus(true);   // selecciona todo al enfocar
#endif
            });
        }
    }
}
