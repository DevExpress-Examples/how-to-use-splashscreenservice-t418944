Imports DevExpress.UI.Xaml.Layout

Public NotInheritable Partial Class App
    Inherits Application

    Public Sub New()
        Microsoft.ApplicationInsights.WindowsAppInitializer.
            InitializeAsync(Microsoft.ApplicationInsights.WindowsCollectors.Metadata Or Microsoft.ApplicationInsights.WindowsCollectors.Session)
        Me.InitializeComponent()
    End Sub

    Protected Overrides Sub OnLaunched(ByVal e As LaunchActivatedEventArgs)
        Dim rootFrame As Frame = TryCast(Window.Current.Content, Frame)
        If rootFrame Is Nothing Then
            rootFrame = New DXFrame()

            AddHandler rootFrame.NavigationFailed, AddressOf OnNavigationFailed
            Window.Current.Content = rootFrame
        End If

        If e.PrelaunchActivated = False Then
            If rootFrame.Content Is Nothing Then
                rootFrame.Navigate(GetType(MainPage), e.Arguments)
            End If
            Window.Current.Activate()
        End If
    End Sub

    Private Sub OnNavigationFailed(ByVal sender As Object, ByVal e As NavigationFailedEventArgs)
        Throw New Exception("Failed to load Page " & e.SourcePageType.FullName)
    End Sub

End Class

