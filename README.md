IconView for Xamarin Forms
===================

A control for Xamarin Forms to draw a local image with a color.
See [Xamarin Form documentation for Local Images](http://developer.xamarin.com/guides/cross-platform/xamarin-forms/working-with/images/#Local_Images) 

Usage
-------

An example of a Page using the IconView control

    <?xml version="1.0" encoding="UTF-8"?>
    <ContentPage xmlns="http://xamarin.com/schemas/2014/forms"
                 xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
                 x:Class="IconApp.MyPage"
                 xmlns:controls="clr-namespace:IconApp;assembly=IconApp">
      <controls:IconView Source="monkey"
                         Foreground="#FF00000"
                         WidthRequest="100"
                         HeightRequest="100"
                         HorizontalOptions="Center"
                         VerticalOptions="Center" />
    </ContentPage>

It draws the "monkey" image with red color:

![Android screenshot](s.png)


