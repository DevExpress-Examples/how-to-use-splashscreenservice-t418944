Imports DevExpress.Mvvm


Public Class MainViewModel
	Inherits ViewModelBase

	Public Property ShowSplashScreenCommand() As ICommand
		Get
			Return m_ShowSplashScreenCommand
		End Get
		Private Set
			m_ShowSplashScreenCommand = Value
		End Set
	End Property

	Private m_ShowSplashScreenCommand As ICommand

    Public Property ShowProgressBarSplashScreenCommand() As ICommand
		Get
			Return m_ShowProgressBarSplashScreenCommand
		End Get
		Private Set
			m_ShowProgressBarSplashScreenCommand = Value
		End Set
	End Property

    Private m_ShowProgressBarSplashScreenCommand As ICommand

    Public ReadOnly Property DefaultSplashScreenService() As ISplashScreenService
		Get
			Return Me.GetService(Of ISplashScreenService)("DefaultSplashScreen")
		End Get
	End Property

    Public ReadOnly Property ProgressBarSplashScreenService() As ISplashScreenService
		Get
			Return Me.GetService(Of ISplashScreenService)("ProgressBarSplashScreen")
		End Get
	End Property

	Public Sub New()
		ShowSplashScreenCommand = New DelegateCommand(AddressOf OnShowSplashScreenCommandExecute)
		ShowProgressBarSplashScreenCommand = New DelegateCommand(AddressOf OnShowProgressBarSplashScreenCommandExecute)
	End Sub

	Private Async Sub OnShowSplashScreenCommandExecute()
		DefaultSplashScreenService.ShowSplashScreen()
		Await Task.Delay(4000)
		DefaultSplashScreenService.HideSplashScreen()
	End Sub

	Private Async Sub OnShowProgressBarSplashScreenCommandExecute()
		ProgressBarSplashScreenService.ShowSplashScreen()

		ProgressBarSplashScreenService.SetSplashScreenState("Loading...")
		ProgressBarSplashScreenService.SetSplashScreenProgress(20, 100)
		Await Task.Delay(2000)
		ProgressBarSplashScreenService.SetSplashScreenState("Initializing...")
		ProgressBarSplashScreenService.SetSplashScreenProgress(80, 100)
		Await Task.Delay(2000)
		ProgressBarSplashScreenService.SetSplashScreenState("Finishing...")
		ProgressBarSplashScreenService.SetSplashScreenProgress(100, 100)
		Await Task.Delay(2000)
		ProgressBarSplashScreenService.HideSplashScreen()
	End Sub
End Class

