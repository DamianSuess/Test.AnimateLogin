﻿using System;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Test.Animations.Extensions
{
  [ContentProperty(nameof(Source))]
  public class ImageResourceExtension : IMarkupExtension
  {
    public string Source { get; set; }

    public object ProvideValue(IServiceProvider serviceProvider)
    {
      if (Source == null)
      {
        return null;
      }

      var imgSource = ImageSource.FromResource(Source, typeof(ImageResourceExtension).GetTypeInfo().Assembly);

      return imgSource;
    }
  }
}
