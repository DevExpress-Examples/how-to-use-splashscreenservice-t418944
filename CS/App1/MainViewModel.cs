using DevExpress.Mvvm;
using System.Threading.Tasks;
using System.Windows.Input;

namespace App1 {
    public class MainViewModel : ViewModelBase {

        public ICommand ShowSplashScreenCommand { get; private set; }
        public ICommand ShowProgressBarSplashScreenCommand { get; private set; }
        public ISplashScreenService DefaultSplashScreenService {
            get {
                return this.GetService<ISplashScreenService>("DefaultSplashScreen");
            }
        }
        public ISplashScreenService ProgressBarSplashScreenService {
            get {
                return this.GetService<ISplashScreenService>("ProgressBarSplashScreen");
            }
        }

        public MainViewModel() {
            ShowSplashScreenCommand = new DelegateCommand(OnShowSplashScreenCommandExecute);
            ShowProgressBarSplashScreenCommand = new DelegateCommand(OnShowProgressBarSplashScreenCommandExecute);
        }

        private async void OnShowSplashScreenCommandExecute() {
            DefaultSplashScreenService.ShowSplashScreen();
            await Task.Delay(4000);
            DefaultSplashScreenService.HideSplashScreen();
        }

        private async void OnShowProgressBarSplashScreenCommandExecute() {
            ProgressBarSplashScreenService.ShowSplashScreen();

            ProgressBarSplashScreenService.SetSplashScreenState("Loading...");
            ProgressBarSplashScreenService.SetSplashScreenProgress(20, 100);
            await Task.Delay(2000);
            ProgressBarSplashScreenService.SetSplashScreenState("Initializing...");
            ProgressBarSplashScreenService.SetSplashScreenProgress(80, 100);
            await Task.Delay(2000);
            ProgressBarSplashScreenService.SetSplashScreenState("Finishing...");
            ProgressBarSplashScreenService.SetSplashScreenProgress(100, 100);
            await Task.Delay(2000);
            ProgressBarSplashScreenService.HideSplashScreen();
        }
    }
}
