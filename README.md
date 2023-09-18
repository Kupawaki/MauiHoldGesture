# MauiHoldGesture

This week I wanted to have a button that would change color as long as you were holding it.
This turned out to be much more difficult than I expected.
MAUI does not have a hold, or long press gesture available.
This is strange to me.

Anyways I had to impliement one myself using Threads and tasks, as well as a Dispatcher, of which I am still learning about.
This ended up being successful, although I cannot speak to the quality of this code. I am not familar with good thread practices in MAUI.

### Lessons
- Some NuGet packages cost money
- Microsoft's NuGet packages are usually really stable and useful.

#### Important Sources
https://learn.microsoft.com/en-us/dotnet/maui/ - the .NET MAUI docs.
