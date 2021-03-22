using Exercise_07._1_Vend_Lib;
using System.Globalization;
using System;
using System.Windows;
using System.Windows.Data;

namespace Ex_7._2_Vend_Service_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = machine;
            listViewMainCoinBox.ItemsSource = machine.MainCoinBox.CoinBoxDisplayData;
            listViewInsertedCoinBox.ItemsSource = machine.InsertedCoinBox.CoinBoxDisplayData;
            itemsControlCanRackContents.ItemsSource = machine.Rack.CanRackDisplayData;
        }

        #region PreviousExercise
        private VendingMachineViewModel machine = new VendingMachineViewModel();
        

        private void ButtonHalfDollar_Click(object sender, RoutedEventArgs e)
        {
            machine.InsertedCoinBox.Deposit(new Coin(Coin.Denomination.HALFDOLLAR));
        }
        private void ButtonQuarter_Click(object sender, RoutedEventArgs e)
        {
            machine.InsertedCoinBox.Deposit(new Coin(Coin.Denomination.QUARTER));
        }
        private void ButtonDime_Click(object sender, RoutedEventArgs e)
        {
            machine.InsertedCoinBox.Deposit(new Coin(Coin.Denomination.DIME));
        }
        private void ButtonNickel_Click(object sender, RoutedEventArgs e)
        {
            machine.InsertedCoinBox.Deposit(new Coin(Coin.Denomination.NICKEL));
        }

        private void ButtonCoinReturn_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.ReturnCoins();            
        }

        private void ButtonEjectRegular_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.EjectCan(Flavor.REGULAR);
        }

        private void ButtonEjectOrange_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.EjectCan(Flavor.ORANGE);
        }

        private void ButtonEjectLemon_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.EjectCan(Flavor.LEMON);
        }

        #endregion
        private void TabItemLabelService_MouseLeftButtonDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            
        }
        
        private void ButtonEmptyMainCoinBox_Click(object sender, RoutedEventArgs e)
        {
            machine.MainCoinBox.Withdraw(machine.MainCoinBox.ValueOf);
        }

        private void ButtonEmptyInsertedCoinBox_Click(object sender, RoutedEventArgs e)
        {
            machine.InsertedCoinBox.Withdraw(machine.InsertedCoinBox.ValueOf);
        }

        private void ButtonRefillCanRack_Click(object sender, RoutedEventArgs e)
        {
            machine.Rack.FillTheCanRack();
        }

        private void ButtonUnlock_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.LockServiceDisplay(passwordBoxUnlock.Password, false);
        }

        private void ButtonLock_Click(object sender, RoutedEventArgs e)
        {
            machine.VendController.LockServiceDisplay("cs", true);
        }
    }
   
}
