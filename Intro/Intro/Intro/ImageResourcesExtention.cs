using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intro
{
    [ContentProperty(nameof(Source))]
    class ImageResourcesExtention : IMarkupExtension
    {
        public string Source { set; get; }
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
                return null;

            var imageSource = ImageSource.FromResource(Source, typeof(ImageResourcesExtention).GetTypeInfo().Assembly);
            return imageSource;
        }
    }
}
