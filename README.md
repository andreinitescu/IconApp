IconView for Xamarin Forms
===================

A control for Xamarin Forms to draw a local image with a color.

See [Xamarin Form documentation for Local Images](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-

with/images/#Local_Images) 

At this moment the implementation is for Android and iOS. Contributions for Windows support are welcome!


Usage
-------

An example of a Page using the IconView control

    <?xml version="1.0" encoding="UTF-8"?>
    <ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 x:Class="IconApp.MyPage"
                 xmlns:controls="clr-namespace:IconApp;assembly=IconApp">
      <controls:IconView Source="monkey"
                         Foreground="Red"
                         WidthRequest="100"
                         HeightRequest="100"
                         HorizontalOptions="Center"
                         VerticalOptions="Center" />
    </ContentPage>

It draws the "monkey" image with red color in the center of the screen:

![Android screenshot](s.jpg)


Adding to your project
-----------------------

1. Add [/IconApp/IconApp/IconView.cs](/IconApp/IconApp/IconView.cs) to your Xamarin Forms PCL project.

2. The control uses native renderes. You need to add the renderers to your Android and iOS project respectively:

       [/IconApp/IconApp.Droid/Renderers/IconViewRenderer.cs](/IconApp/IconApp.Droid/Renderers/IconViewRenderer.cs)
       [/IconApp/IconApp.Droid/Renderers/IconViewRenderer.cs](/IconApp/IconApp.Droid/Renderers/IconViewRenderer.cs)

Note you might need to update some namespaces.
