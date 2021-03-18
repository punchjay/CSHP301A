// Exercise 07
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
        private VendMachineVM vendingMachine = new VendMachineVM();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = vendingMachine;
            // 7.2
            itemsControlCanRackContents.ItemsSource = vendingMachine.Rack.CanRackDisplayData;
            itemsControlCanRackContents.ItemsSource = vendingMachine.MainCoinBox.CoinBoxDisplayData;
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

        // 7.2
        private void ButtonRefillCanRack_Click(object sender, RoutedEventArgs e)
        {
            vendingMachine.Rack.FillTheCanRack();
        }

        // 7.2
        private void ButtonEmptyMainCoinBox_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
