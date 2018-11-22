***IMPORTANT NOTE:** I decided to move this effort into the post series [Xamarin.Forms XAML](https://marcoscobena.com/?i=xf-xaml) so won't be updating this project anymore.*

# Xamarin Crumbs

A set of source code files —including XAML ones— which I tend to reuse once and again.

Instead of going to the last project I made, the idea is to look here. NuGet looks too much for me here, that's the reason why a simple Shared Project aglutinates everything I may need. I simply take all those pieces likely to reuse, clean them a little bit up (as changing its namespace, for instance) and ready to go.

**NOTE:** It's not intended to provide a buildable project, it hasn't got value per se. Its actual value is to server as a small repository of files which can be copied into our actual solutions.

## How can I use this?

Ideally, you can clone this repo as a submodule into your current project. Adding XamarinCrumbs.shproj to your Solution will make it easier to pick any file.

However, you can also navigate through GitHub and simply copy & paste.

## Project structure

### XamarinForms/

We recommend writting XAML by having one attribute per line —we call this Merge-friendly XAML. The main reason's just 
that: merges are easier to handle when changes appear per line, instead of having to look which attribute/s were changed 
among a bunch. Also, having a limit of 120 chars per line help us work with multiple files open as columns.

    <ContentView
        VerticalOptions="Start">
        <ContentView.Padding>
            <Thickness
                Top="{StaticResource DefaultMargin}"
                Right="{StaticResource DefaultMargin}"
                Bottom="{StaticResource DefaultMargin}"/>
        </ContentView.Padding>
        <Label
            Text="{Binding Key}"
            Style="{StaticResource 20BoldFontStyle}"
            TextColor="{StaticResource WhiteColor}"/>
    </ContentView>

### Settings.StyleCop

1. With a Solution opened, add [StyleCop.MSBuild](https://www.nuget.org/packages/StyleCop.MSBuild/) NuGet to every project you'd like to enforce coding guidelines
2. On such same projects, edit the .csproj to add the following line:

```
<PropertyGroup>
  [...]
  <!-- This' the line! -->
  <StyleCopTreatErrorsAsWarnings>false</StyleCopTreatErrorsAsWarnings>
</PropertyGroup>
```

1. At the Solution root, place a Settings.StyleCop file like [this](https://marcoscobena.com/items/documents/Settings.StyleCop)
2. Bonus: You can edit visually which rules to apply by running this through CMD:

`PathToYourSolution\packages\StyleCop.MSBuild.5.0.0\tools>StyleCop.SettingsEditor.exe ..\..\..\Settings.StyleCop`
