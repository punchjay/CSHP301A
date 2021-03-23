// Exercise 08
// Gibble, Jay ejg2
using System.Windows;
using VendingMachine;

namespace VendingMachineWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VendMachineController vendingMachine = new VendMachineController();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vendingMachine;
            itemsControlCanRackContents.ItemsSource = vendingMachine.Rack.CanRackDisplayData;
            listViewInsertedCoinBox.ItemsSource = vendingMachine.TempCoinBox.CoinBoxDisplayData;
            listViewMainCoinBox.ItemsSource = vendingMachine.MainCoinBox.CoinBoxDisplayData;
        }

        private void ButtonInsertHalftDollar_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.TempCoinBox.Deposit(new Coin(Coin.Denomination.HALFDOLLAR));
        }

        private void ButtonInsertQuarter_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.TempCoinBox.Deposit(new Coin(Coin.Denomination.QUARTER));
        }

        private void ButtontnsertDime_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.TempCoinBox.Deposit(new Coin(Coin.Denomination.DIME));
        }

        private void ButtonInsertNickel_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.TempCoinBox.Deposit(new Coin(Coin.Denomination.NICKEL));
        }

        private void ButtonCoinReturn_Click(object sender, RoutedEventArgs e)
        {
            decimal amount = vendingMachine.TempCoinBox.ValueOf;
            vendingMachine.TempCoinBox.Withdraw(vendingMachine.TempCoinBox.ValueOf);
            vendingMachine.CustomerMessage = $"Here is your {amount:c} back.";
        }

        private void ButtonEjectRegular_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.EjectCan(Flavor.REGULAR);
        }

        private void ButtonEjectOrange_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.EjectCan(Flavor.ORANGE);
        }

        private void ButtonEjectLemon_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.EjectCan(Flavor.LEMON);
        }

        private void ButtonRefillCanRack_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.Rack.FillTheCanRack();
        }

        private void ButtonEmptyMainCoinBox_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.MainCoinBox.Withdraw(vendingMachine.MainCoinBox.ValueOf);
        }

        private void ButtonEmptyInsertedCoinBox_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.TempCoinBox.Withdraw(vendingMachine.TempCoinBox.ValueOf);
        }

        private void ButtonServiceNotes_Click(object sender, RoutedEventArgs e)
        {
            WindowServiceNotes windowServiceNotes = new WindowServiceNotes();
            windowServiceNotes.Show();
        }
    }
}
