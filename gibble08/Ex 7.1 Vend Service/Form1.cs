using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using Supplied_06._0_Vend_Lib;

namespace Exercise_07._1_Vend_Service
{
    public partial class FormVending : Form
    {
        #region PreviousExerciseCode

        public FormVending()
        {
            InitializeComponent();
        }

        private CoinBox mainCoinBox = new CoinBox(new List<Coin> { 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME), 
                new Coin(Coin.Denomination.NICKEL), new Coin(Coin.Denomination.QUARTER), 
                new Coin(Coin.Denomination.QUARTER), new Coin(Coin.Denomination.DIME) });

        private CoinBox tempCoinBox = new CoinBox();
        private PurchasePrice sodaPrice = new PurchasePrice(0.35M);

        private CanRack theRack = new CanRack();

        private void updateInsertedTotal()
        {
            labelTotalInsertedDisplay.Text =
                string.Format("{0:c}", tempCoinBox.ValueOf);
            buttonCoinReturn.Enabled = tempCoinBox.ValueOf > 0M;  
        }

        private void putCoinInTempBox(Coin ACoin)
        {
            tempCoinBox.Deposit(ACoin);
            updateInsertedTotal();
            ejectButtonsReset();
        }

        private void ejectButtonsReset()
        {
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal)
            {
                buttonRegularEject.Enabled = !theRack.IsEmpty(Flavor.REGULAR);
                buttonOrangeEject.Enabled = !theRack.IsEmpty(Flavor.ORANGE);
                buttonLemonEject.Enabled = !theRack.IsEmpty(Flavor.LEMON);
            }
            else
            {
                buttonRegularEject.Enabled = false;
                buttonOrangeEject.Enabled = false;
                buttonLemonEject.Enabled = false;
            }
        }
 

        private void buttonHalfDollar_Click(object sender, EventArgs e)
        {
            Coin halfDollar = new Coin(Coin.Denomination.HALFDOLLAR);
            putCoinInTempBox(halfDollar);
        }

        private void buttonQuarter_Click(object sender, EventArgs e)
        {
            Coin quarter = new Coin(Coin.Denomination.QUARTER);
            putCoinInTempBox(quarter);
        }

        private void buttonDime_Click(object sender, EventArgs e)
        {
            Coin dime = new Coin(Coin.Denomination.DIME);
            putCoinInTempBox(dime);
        }

        private void buttonNickel_Click(object sender, EventArgs e)
        {
            Coin nickel = new Coin(Coin.Denomination.NICKEL);
            putCoinInTempBox(nickel);
        }

        private void buttonRegularEject_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.REGULAR, pictureBoxRegularSoda);
        }

        private void buttonOrangeEject_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.ORANGE, pictureBoxOrangeSoda);
        }

        private void buttonLemonEject_Click(object sender, EventArgs e)
        {
            ejectCan(Flavor.LEMON, pictureBoxLemonSoda);
        }

        private void ejectCan(Flavor flavorToBeEjected, PictureBox pictureToModify)
        {
            if (tempCoinBox.ValueOf >= sodaPrice.PriceDecimal && !theRack.IsEmpty(flavorToBeEjected))
            {
                decimal changeDue = tempCoinBox.ValueOf - sodaPrice.PriceDecimal;
                if (changeDue > 0M && mainCoinBox.CanMakeChange)
                {
                    mainCoinBox.Withdraw(changeDue);
                    labelMessageToCustomer.Text = string.Format("Here is your {0:c} in change", changeDue);
                }
                else
                {
                    labelMessageToCustomer.Text = "Enjoy!";
                }
                labelMessageToCustomer.Update();
                tempCoinBox.Transfer(mainCoinBox);
                updateInsertedTotal();
                theRack.RemoveACanOf(flavorToBeEjected);
                animateEjectCan(pictureToModify);
                ejectButtonsReset();

                labelExactChange.Visible = !mainCoinBox.CanMakeChange;
                labelMessageToCustomer.Text = string.Empty;
            }
        }

        private void animateEjectCan(PictureBox pictureToAnimate)
        {
            Point originalLocation = pictureToAnimate.Location;
            Point offBottomOfWindow = new Point(pictureToAnimate.Location.X, pictureToAnimate.Location.Y + 400);
            movePictureVertically(pictureToAnimate, pictureToAnimate.Location, offBottomOfWindow);
            pictureToAnimate.Location = new Point(originalLocation.X, originalLocation.Y - 275);
            movePictureVertically(pictureToAnimate, pictureToAnimate.Location, originalLocation);
        }

        private void movePictureVertically(PictureBox pictureToAnimate, Point start, Point end)
        {
            int step = start.Y > end.Y ? -1 : 1;
            while (pictureToAnimate.Location.Y != end.Y)
            {
                pictureToAnimate.Location = new Point(
                    pictureToAnimate.Location.X,
                    pictureToAnimate.Location.Y + step);
                if (pictureToAnimate.Location.Y % 2 == 0) System.Threading.Thread.Sleep(1);
                pictureToAnimate.Update();
            }
        }

        private void FormVending_Load(object sender, EventArgs e)
        {
            labelPleaseInsert.Text =
                string.Format("Please Insert {0} cents for a soda",
                sodaPrice.Price);
            labelExactChange.Visible = !mainCoinBox.CanMakeChange;
        }

        private void buttonCoinReturn_Click(object sender, EventArgs e)
        {
            decimal amountInserted = tempCoinBox.ValueOf;

            if (amountInserted > 0M)
            {
                tempCoinBox.Withdraw(tempCoinBox.ValueOf);
                updateInsertedTotal();
                MessageBox.Show(string.Format(
                    "Here is your {0:c} back", amountInserted));
            }
            
            ejectButtonsReset();

        }

        #endregion
        private Boolean machineLocked = true;

        private void setLockState(Boolean becomeLocked)
        {
            if (becomeLocked)
            {
                // turn the service related controls off
                groupBoxCanRack.Visible = false;
                groupCoinBox.Visible = false;

                // turn the password related controls on
                machineLocked = true;
                labelPassword.Visible = true;
                textBoxPassword.Visible = true;
                buttonPasswordOK.Visible = true;
                buttonServiceLock.Visible = false;
                textBoxPassword.Focus();
            }
            else
            {
                // turn the service related controls on
                constructRackDisplay();
                groupBoxCanRack.Visible = true; 
                constructCoinBoxDisplay(listViewCoinBox,mainCoinBox);
                constructCoinBoxDisplay(listViewInsertedCoins, tempCoinBox);
                groupCoinBox.Visible = true;

                // turn the password related controls off
                machineLocked = false;
                labelPassword.Visible = false;
                textBoxPassword.Visible = false;
                buttonPasswordOK.Visible = false;
                buttonServiceLock.Visible = true;                
            }
        }

        private void constructCoinBoxDisplay(ListView CoinBoxDisplay, CoinBox CoinBoxToDisplay)
        {
            CoinBoxDisplay.Items.Clear();
            List<Coin.Denomination> reverseCoinList = new List<Coin.Denomination>(Coin.AllDenominations);
            reverseCoinList.Reverse();

            foreach (Coin.Denomination coinDenomination in reverseCoinList)
            {
                int coinCount = CoinBoxToDisplay.coinCount(coinDenomination);
                decimal coinsValue = coinCount * Coin.ValueOfCoin(coinDenomination);
                ListViewItem coinRow = new ListViewItem(coinDenomination.ToString());
                coinRow.SubItems.Add(coinCount.ToString());
                coinRow.SubItems.Add(string.Format("{0:c}", coinsValue));
                CoinBoxDisplay.Items.Add(coinRow);
            }

            ListViewItem totalRow = new ListViewItem("Total");
            totalRow.SubItems.Add(string.Empty);
            totalRow.SubItems.Add(string.Format("{0:c}",
                CoinBoxToDisplay.ValueOf));
            CoinBoxDisplay.Items.Add(totalRow);
        }

        private void constructRackDisplay()
        {
            listViewCanRack.Items.Clear();

            foreach (Flavor aFlavor in FlavorOps.AllFlavors)
            {
                ListViewItem row = new ListViewItem(aFlavor.ToString());
                row.SubItems.Add(theRack[aFlavor].ToString());
                listViewCanRack.Items.Add(row);
            }
        }

        private void buttonPasswordOK_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == "cs")
            {
                setLockState(false);
            }
        }

        private void buttonServiceLock_Click(object sender, EventArgs e)
        {
            setLockState(true);
        }

        private void textBoxPassword_VisibleChanged(object sender, EventArgs e)
        {
            if ((sender as TextBox).Visible) textBoxPassword.Focus();
        }

        private void tabControlVending_Click(object sender, EventArgs e)
        {
            updateInsertedTotal();
            labelExactChange.Visible = !mainCoinBox.CanMakeChange;
            setLockState(machineLocked);
        }

        private void buttonFillTheCanRack_Click(object sender, EventArgs e)
        {
            theRack.FillTheCanRack();
            setLockState(machineLocked);
        }

        private void buttonEmptyMainCoinBox_Click(object sender, EventArgs e)
        {
            mainCoinBox.Withdraw(mainCoinBox.ValueOf);
            setLockState(machineLocked);
        }

        private void buttonEmptyInsertedCoinsCoinBox_Click(object sender, EventArgs e)
        {
            tempCoinBox.Withdraw(tempCoinBox.ValueOf);
            setLockState(machineLocked);
        }
    }
}