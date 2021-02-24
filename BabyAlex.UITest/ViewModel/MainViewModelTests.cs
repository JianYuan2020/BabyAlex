using Xunit;
using BabyAlex.UI.ViewModel;

namespace BabyAlex.UITest.ViewModel
{
  public class MainViewModelTests
  {
    private MainViewModel _viewModel;

    public MainViewModelTests()
    {
      _viewModel = new MainViewModel();
    }

    [Fact]
    public void ShouldCallTheLoadMethodOfTheNavigationViewModel()
    {
      _viewModel.Load();

      //_navigationViewModelMock.Verify(vm => vm.Load(), Times.Once);
    }

  }
}
