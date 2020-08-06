# Sample Animated Login Screen

Sample of how animate your login screen by "flipping" the log-in prompt and display the registration form, then flip back agin.

Sponsored by Xeno Innovations, this project was made with nerd-love using _Xamarin.Forms and Prism with DryIoc.

## References
Google searching came up with these results

* [Animate Transitions](https://github.com/AlecDTucker/LoginAnimations)
* [Using EventTriggers to animate a login page in Xamarin.Forms](https://blog.alectucker.com/2017/06/27/using-eventtriggers-to-animate-a/)
* [Animation on CLick Button - Flash background](https://stackoverflow.com/questions/50367476/xamarin-forms-animation-on-click-button-flash-background)

### Tap Gesture Recognizer
Though not used in this sample, here's another way to trigger animations by creating a custom image that scales it's pressed. Source, [StackOverflow - How I can create animation in Xamarin.Forms using MVVM](https://stackoverflow.com/questions/46276132/how-i-can-create-animation-in-xamarin-forms-using-mvvm).

```cs
public class CustomImage : Image
{
  public CustomImage() : base()
  {
    const int _animationTime = 10;
    var iconTap = new TapGestureRecognizer();
    iconTap.Tapped += async (sender, e) =>
    {
      try
      {
        var btn = (CustomImage)sender;
        await btn.ScaleTo(5, _animationTime);
        //await btn.ScaleTo(1, _animationTime);
      }
      catch (Exception ex)
      {
        ex.Track();
      }
    };
  }
}
```
