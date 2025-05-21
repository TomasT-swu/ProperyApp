using CourseProject.ViewModel;
using Microsoft.Maui.Controls;

namespace CourseProject.View;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(Model.Property SelectedProperty)
	{
		InitializeComponent();
        var viewModel = new DetailsViewModel() { SelectedProperty = SelectedProperty };
        viewModel.PropertyImages = SelectedProperty.Images.Take(count: 2).ToList();
		viewModel.MoreItems = SelectedProperty.Images.Count - 2;

		this.BindingContext = viewModel;
		SetViemPosition();
		Loaded += (s, e) =>
		{
            FadeAndTranslate(popView, fadeLength: 1000, translateLength: 1000);
            FadeAndTranslate(addressView, fadeLength: 1000, translateLength: 1000);
            FadeAndScale(buyBtn, fadeLength: 1000, scaleLength: 1000);

            Task.Delay(millisecondsDelay: 500);
        };
	}
	private void SetViemPosition()
	{
		

		buyBtn.Opacity = 0;
		buyBtn.Scale = 0.2;


		addressView.TranslationX = addressView.TranslationY = -30;
		addressView.Opacity = 0;

        popView.TranslationY = 300;
        popView.Opacity = 0.5;
    }

	private void FadeAndTranslate(VisualElement view, uint fadeLength = 1000, uint translateLength = 1500)
	{
		view.FadeTo(opacity: 1, fadeLength, Easing.SinInOut);
		view.TranslateTo(x: 0, y: 0, translateLength, Easing.SinInOut);
	}
	private void FadeAndScale(VisualElement view, uint fadeLength = 1000, uint scaleLength = 1500)
	{
		view.FadeTo(opacity: 1, fadeLength, Easing.SinInOut);
		view.ScaleTo(scale: 1, scaleLength, Easing.SinInOut);
	}
	private void RotateView(VisualElement view) => view.RotateTo(rotation: 0, length: 1500, Easing.SinInOut);

}