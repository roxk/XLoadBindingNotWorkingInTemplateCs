![Incorrect obj2 usage](img.png)

As shown in the screenshot, it's using obj2, which is
- not declared
- not assigned

On top of that, it probably shouldn't use `FindName`, but `GetTemplateChild`