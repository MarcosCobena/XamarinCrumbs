## StyleCop

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

## XamarinForms/

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

