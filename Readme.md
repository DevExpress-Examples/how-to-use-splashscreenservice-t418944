<!-- default file list -->
*Files to look at*:

* **[MainPage.xaml](./CS/App1/MainPage.xaml) (VB: [MainPage.xaml](./VB/App1/MainPage.xaml))**
* [MainViewModel.cs](./CS/App1/MainViewModel.cs) (VB: [MainViewModel.vb](./VB/App1/MainViewModel.vb))
<!-- default file list end -->
# How to use SplashScreenService


<p><br>Our <strong>SplashScreenService </strong>provides the capability to show the progress of certain processes in your application. This example illustrates how you can add SplashScreenServices to your application and show them when necessary.</p>
<p> </p>
<p>In the current implementation, there are two <strong>SplashScreenServices </strong>added to the main page: <strong>DefaultSplashScreen </strong>and <strong>ProgressBarSplashScreen</strong>. The first service uses the default splash screen appearance, which shows a progress ring when the <strong>ShowSplashScreen </strong>method is called. The second service is defined with <strong>ProgressBarSplashScreenView </strong>in its <strong>SplashScreenType </strong>property. This view contains a ProgressBar and a caption that allow you to show additional information. <strong>ProgressBarSplashScreenView </strong>is available out of the box in the <strong><em>DevExpress.Mvvm.UI</em></strong> namespace.</p>
<p> </p>
<p>Note that <strong>SplashScreenService </strong>works only when the <strong>DXFrame </strong>or <strong>HamburgerMenuFrame</strong> is used.</p>

<br/>


