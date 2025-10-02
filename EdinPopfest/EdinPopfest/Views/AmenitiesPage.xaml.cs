using ReactiveUI;
using ReactiveUI.Maui;
using System.Reactive.Disposables;
namespace EdinPopFest;
public class AmenitiesViewBase : ReactiveContentPage<AmenitiesViewModel> { }
public partial class AmenitiesPage : AmenitiesViewBase
{
    public AmenitiesPage(AmenitiesViewModel viewModel)
    {
        ViewModel = viewModel;
        InitializeComponent();
        this.WhenActivated(disposables =>
        {
            this.OneWayBind(ViewModel, vm => vm.Mashouse, v => v.mashhouselabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.MainRoom, v => v.mainroomlabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Parking, v => v.parkinglabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Parkopedia, v => v.parkopedia.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.ParkopediaLink, v => v.parkopedia.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Emergencies, v => v.emergencieslabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.LothianBuses, v => v.lothianbuseslabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Scotrail, v => v.scotraillabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Taxi, v => v.taxilabel.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.EdinburghStreetFood, v => v.edbstreetfood.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.EdinburghStreetFoodLink, v => v.edbstreetfood.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.LetMeEatToo, v => v.letmeeattoo.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.LetMeEatTooLink, v => v.letmeeattoo.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.HolyCow, v => v.holycow.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.HolyCowLink, v => v.holycow.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.FruitMarketCafe, v => v.fruitmarketcafe.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.FruitMarketCafeLink, v => v.fruitmarketcafe.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.IkigaiRamen, v => v.ikigairamen.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.IkigaiRamenLink, v => v.ikigairamen.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.PieMaker, v => v.piemaker.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.PieMakerLink, v => v.piemaker.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.MosqueKitchen, v => v.mosquekitchen.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.MosqueKitchenLink, v => v.mosquekitchen.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Civerinos, v => v.civerinos.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.CiverinosLink, v => v.civerinos.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.Bowls, v => v.bowls.LinkInfo).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.BowlsLink, v => v.bowls.LinkText).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.FoodInfo1, v => v.foodinfo1.Text).DisposeWith(disposables);
            this.OneWayBind(ViewModel, vm => vm.FoodInfo2, v => v.foodinfo2.Text).DisposeWith(disposables);
        });

    }
}