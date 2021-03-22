namespace Exercise_07._1_Vend_Service
{
    partial class FormVending
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVending));
            this.pictureBoxRegularSoda = new System.Windows.Forms.PictureBox();
            this.pictureBoxOrangeSoda = new System.Windows.Forms.PictureBox();
            this.pictureBoxLemonSoda = new System.Windows.Forms.PictureBox();
            this.buttonRegularEject = new System.Windows.Forms.Button();
            this.buttonOrangeEject = new System.Windows.Forms.Button();
            this.buttonLemonEject = new System.Windows.Forms.Button();
            this.buttonHalfDollar = new System.Windows.Forms.Button();
            this.buttonQuarter = new System.Windows.Forms.Button();
            this.buttonDime = new System.Windows.Forms.Button();
            this.buttonNickel = new System.Windows.Forms.Button();
            this.labelPleaseInsert = new System.Windows.Forms.Label();
            this.labelTotalInserted = new System.Windows.Forms.Label();
            this.labelTotalInsertedDisplay = new System.Windows.Forms.Label();
            this.labelExactChange = new System.Windows.Forms.Label();
            this.buttonCoinReturn = new System.Windows.Forms.Button();
            this.tabControlVending = new System.Windows.Forms.TabControl();
            this.tabPageVend = new System.Windows.Forms.TabPage();
            this.pageTabService = new System.Windows.Forms.TabPage();
            this.groupCoinBox = new System.Windows.Forms.GroupBox();
            this.buttonEmptyInsertedCoinsCoinBox = new System.Windows.Forms.Button();
            this.buttonEmptyMainCoinBox = new System.Windows.Forms.Button();
            this.listViewInsertedCoins = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelInsertedCoinDisplay = new System.Windows.Forms.Label();
            this.labelMainCoinBoxDisplay = new System.Windows.Forms.Label();
            this.listViewCoinBox = new System.Windows.Forms.ListView();
            this.columnHeaderCoins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxCanRack = new System.Windows.Forms.GroupBox();
            this.buttonFillTheCanRack = new System.Windows.Forms.Button();
            this.listViewCanRack = new System.Windows.Forms.ListView();
            this.columnHeaderFlavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderCanNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonServiceLock = new System.Windows.Forms.Button();
            this.buttonPasswordOK = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelMessageToCustomer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeSoda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonSoda)).BeginInit();
            this.tabControlVending.SuspendLayout();
            this.tabPageVend.SuspendLayout();
            this.pageTabService.SuspendLayout();
            this.groupCoinBox.SuspendLayout();
            this.groupBoxCanRack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRegularSoda
            // 
            this.pictureBoxRegularSoda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRegularSoda.Image")));
            this.pictureBoxRegularSoda.Location = new System.Drawing.Point(25, 48);
            this.pictureBoxRegularSoda.Name = "pictureBoxRegularSoda";
            this.pictureBoxRegularSoda.Size = new System.Drawing.Size(198, 218);
            this.pictureBoxRegularSoda.TabIndex = 0;
            this.pictureBoxRegularSoda.TabStop = false;
            // 
            // pictureBoxOrangeSoda
            // 
            this.pictureBoxOrangeSoda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxOrangeSoda.Image")));
            this.pictureBoxOrangeSoda.Location = new System.Drawing.Point(229, 48);
            this.pictureBoxOrangeSoda.Name = "pictureBoxOrangeSoda";
            this.pictureBoxOrangeSoda.Size = new System.Drawing.Size(198, 218);
            this.pictureBoxOrangeSoda.TabIndex = 1;
            this.pictureBoxOrangeSoda.TabStop = false;
            // 
            // pictureBoxLemonSoda
            // 
            this.pictureBoxLemonSoda.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLemonSoda.Image")));
            this.pictureBoxLemonSoda.Location = new System.Drawing.Point(433, 48);
            this.pictureBoxLemonSoda.Name = "pictureBoxLemonSoda";
            this.pictureBoxLemonSoda.Size = new System.Drawing.Size(198, 218);
            this.pictureBoxLemonSoda.TabIndex = 2;
            this.pictureBoxLemonSoda.TabStop = false;
            // 
            // buttonRegularEject
            // 
            this.buttonRegularEject.Enabled = false;
            this.buttonRegularEject.Location = new System.Drawing.Point(85, 281);
            this.buttonRegularEject.Name = "buttonRegularEject";
            this.buttonRegularEject.Size = new System.Drawing.Size(75, 23);
            this.buttonRegularEject.TabIndex = 3;
            this.buttonRegularEject.Text = "Eject";
            this.buttonRegularEject.UseVisualStyleBackColor = true;
            this.buttonRegularEject.Click += new System.EventHandler(this.buttonRegularEject_Click);
            // 
            // buttonOrangeEject
            // 
            this.buttonOrangeEject.Enabled = false;
            this.buttonOrangeEject.Location = new System.Drawing.Point(298, 281);
            this.buttonOrangeEject.Name = "buttonOrangeEject";
            this.buttonOrangeEject.Size = new System.Drawing.Size(75, 23);
            this.buttonOrangeEject.TabIndex = 4;
            this.buttonOrangeEject.Text = "Eject";
            this.buttonOrangeEject.UseVisualStyleBackColor = true;
            this.buttonOrangeEject.Click += new System.EventHandler(this.buttonOrangeEject_Click);
            // 
            // buttonLemonEject
            // 
            this.buttonLemonEject.Enabled = false;
            this.buttonLemonEject.Location = new System.Drawing.Point(490, 281);
            this.buttonLemonEject.Name = "buttonLemonEject";
            this.buttonLemonEject.Size = new System.Drawing.Size(75, 23);
            this.buttonLemonEject.TabIndex = 5;
            this.buttonLemonEject.Text = "Eject";
            this.buttonLemonEject.UseVisualStyleBackColor = true;
            this.buttonLemonEject.Click += new System.EventHandler(this.buttonLemonEject_Click);
            // 
            // buttonHalfDollar
            // 
            this.buttonHalfDollar.Location = new System.Drawing.Point(25, 329);
            this.buttonHalfDollar.Name = "buttonHalfDollar";
            this.buttonHalfDollar.Size = new System.Drawing.Size(75, 23);
            this.buttonHalfDollar.TabIndex = 6;
            this.buttonHalfDollar.Text = "Half Dollar";
            this.buttonHalfDollar.UseVisualStyleBackColor = true;
            this.buttonHalfDollar.Click += new System.EventHandler(this.buttonHalfDollar_Click);
            // 
            // buttonQuarter
            // 
            this.buttonQuarter.Location = new System.Drawing.Point(106, 329);
            this.buttonQuarter.Name = "buttonQuarter";
            this.buttonQuarter.Size = new System.Drawing.Size(75, 23);
            this.buttonQuarter.TabIndex = 7;
            this.buttonQuarter.Text = "Quarter";
            this.buttonQuarter.UseVisualStyleBackColor = true;
            this.buttonQuarter.Click += new System.EventHandler(this.buttonQuarter_Click);
            // 
            // buttonDime
            // 
            this.buttonDime.Location = new System.Drawing.Point(187, 329);
            this.buttonDime.Name = "buttonDime";
            this.buttonDime.Size = new System.Drawing.Size(75, 23);
            this.buttonDime.TabIndex = 8;
            this.buttonDime.Text = "Dime";
            this.buttonDime.UseVisualStyleBackColor = true;
            this.buttonDime.Click += new System.EventHandler(this.buttonDime_Click);
            // 
            // buttonNickel
            // 
            this.buttonNickel.Location = new System.Drawing.Point(268, 329);
            this.buttonNickel.Name = "buttonNickel";
            this.buttonNickel.Size = new System.Drawing.Size(75, 23);
            this.buttonNickel.TabIndex = 9;
            this.buttonNickel.Text = "Nickel";
            this.buttonNickel.UseVisualStyleBackColor = true;
            this.buttonNickel.Click += new System.EventHandler(this.buttonNickel_Click);
            // 
            // labelPleaseInsert
            // 
            this.labelPleaseInsert.AutoSize = true;
            this.labelPleaseInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPleaseInsert.Location = new System.Drawing.Point(69, 3);
            this.labelPleaseInsert.Name = "labelPleaseInsert";
            this.labelPleaseInsert.Size = new System.Drawing.Size(477, 33);
            this.labelPleaseInsert.TabIndex = 10;
            this.labelPleaseInsert.Text = "Please Insert 35 cents for a Soda";
            // 
            // labelTotalInserted
            // 
            this.labelTotalInserted.AutoSize = true;
            this.labelTotalInserted.Location = new System.Drawing.Point(417, 339);
            this.labelTotalInserted.Name = "labelTotalInserted";
            this.labelTotalInserted.Size = new System.Drawing.Size(72, 13);
            this.labelTotalInserted.TabIndex = 11;
            this.labelTotalInserted.Text = "Total Inserted";
            // 
            // labelTotalInsertedDisplay
            // 
            this.labelTotalInsertedDisplay.AutoSize = true;
            this.labelTotalInsertedDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalInsertedDisplay.Location = new System.Drawing.Point(495, 339);
            this.labelTotalInsertedDisplay.Name = "labelTotalInsertedDisplay";
            this.labelTotalInsertedDisplay.Size = new System.Drawing.Size(15, 15);
            this.labelTotalInsertedDisplay.TabIndex = 12;
            this.labelTotalInsertedDisplay.Text = "0";
            // 
            // labelExactChange
            // 
            this.labelExactChange.AutoSize = true;
            this.labelExactChange.ForeColor = System.Drawing.Color.Red;
            this.labelExactChange.Location = new System.Drawing.Point(164, 365);
            this.labelExactChange.Name = "labelExactChange";
            this.labelExactChange.Size = new System.Drawing.Size(120, 13);
            this.labelExactChange.TabIndex = 13;
            this.labelExactChange.Text = "Exact Change Required";
            this.labelExactChange.Visible = false;
            // 
            // buttonCoinReturn
            // 
            this.buttonCoinReturn.Enabled = false;
            this.buttonCoinReturn.Location = new System.Drawing.Point(435, 365);
            this.buttonCoinReturn.Name = "buttonCoinReturn";
            this.buttonCoinReturn.Size = new System.Drawing.Size(75, 23);
            this.buttonCoinReturn.TabIndex = 14;
            this.buttonCoinReturn.Text = "Coin Return";
            this.buttonCoinReturn.UseVisualStyleBackColor = true;
            this.buttonCoinReturn.Click += new System.EventHandler(this.buttonCoinReturn_Click);
            // 
            // tabControlVending
            // 
            this.tabControlVending.Controls.Add(this.tabPageVend);
            this.tabControlVending.Controls.Add(this.pageTabService);
            this.tabControlVending.Location = new System.Drawing.Point(12, 12);
            this.tabControlVending.Name = "tabControlVending";
            this.tabControlVending.SelectedIndex = 0;
            this.tabControlVending.Size = new System.Drawing.Size(674, 461);
            this.tabControlVending.TabIndex = 15;
            this.tabControlVending.Click += new System.EventHandler(this.tabControlVending_Click);
            // 
            // tabPageVend
            // 
            this.tabPageVend.Controls.Add(this.labelMessageToCustomer);
            this.tabPageVend.Controls.Add(this.labelPleaseInsert);
            this.tabPageVend.Controls.Add(this.buttonCoinReturn);
            this.tabPageVend.Controls.Add(this.labelExactChange);
            this.tabPageVend.Controls.Add(this.labelTotalInsertedDisplay);
            this.tabPageVend.Controls.Add(this.labelTotalInserted);
            this.tabPageVend.Controls.Add(this.buttonRegularEject);
            this.tabPageVend.Controls.Add(this.buttonOrangeEject);
            this.tabPageVend.Controls.Add(this.buttonNickel);
            this.tabPageVend.Controls.Add(this.buttonLemonEject);
            this.tabPageVend.Controls.Add(this.buttonDime);
            this.tabPageVend.Controls.Add(this.buttonHalfDollar);
            this.tabPageVend.Controls.Add(this.buttonQuarter);
            this.tabPageVend.Controls.Add(this.pictureBoxLemonSoda);
            this.tabPageVend.Controls.Add(this.pictureBoxOrangeSoda);
            this.tabPageVend.Controls.Add(this.pictureBoxRegularSoda);
            this.tabPageVend.Location = new System.Drawing.Point(4, 22);
            this.tabPageVend.Name = "tabPageVend";
            this.tabPageVend.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVend.Size = new System.Drawing.Size(666, 435);
            this.tabPageVend.TabIndex = 0;
            this.tabPageVend.Text = "Vend";
            this.tabPageVend.UseVisualStyleBackColor = true;
            // 
            // pageTabService
            // 
            this.pageTabService.Controls.Add(this.groupCoinBox);
            this.pageTabService.Controls.Add(this.labelPassword);
            this.pageTabService.Controls.Add(this.groupBoxCanRack);
            this.pageTabService.Controls.Add(this.buttonServiceLock);
            this.pageTabService.Controls.Add(this.buttonPasswordOK);
            this.pageTabService.Controls.Add(this.textBoxPassword);
            this.pageTabService.Location = new System.Drawing.Point(4, 22);
            this.pageTabService.Name = "pageTabService";
            this.pageTabService.Padding = new System.Windows.Forms.Padding(3);
            this.pageTabService.Size = new System.Drawing.Size(666, 392);
            this.pageTabService.TabIndex = 1;
            this.pageTabService.Text = "Service";
            this.pageTabService.UseVisualStyleBackColor = true;
            // 
            // groupCoinBox
            // 
            this.groupCoinBox.Controls.Add(this.buttonEmptyInsertedCoinsCoinBox);
            this.groupCoinBox.Controls.Add(this.buttonEmptyMainCoinBox);
            this.groupCoinBox.Controls.Add(this.listViewInsertedCoins);
            this.groupCoinBox.Controls.Add(this.labelInsertedCoinDisplay);
            this.groupCoinBox.Controls.Add(this.labelMainCoinBoxDisplay);
            this.groupCoinBox.Controls.Add(this.listViewCoinBox);
            this.groupCoinBox.Location = new System.Drawing.Point(306, 10);
            this.groupCoinBox.Name = "groupCoinBox";
            this.groupCoinBox.Size = new System.Drawing.Size(339, 379);
            this.groupCoinBox.TabIndex = 1;
            this.groupCoinBox.TabStop = false;
            this.groupCoinBox.Text = "Coin Box";
            this.groupCoinBox.Visible = false;
            // 
            // buttonEmptyInsertedCoinsCoinBox
            // 
            this.buttonEmptyInsertedCoinsCoinBox.Location = new System.Drawing.Point(256, 210);
            this.buttonEmptyInsertedCoinsCoinBox.Name = "buttonEmptyInsertedCoinsCoinBox";
            this.buttonEmptyInsertedCoinsCoinBox.Size = new System.Drawing.Size(75, 146);
            this.buttonEmptyInsertedCoinsCoinBox.TabIndex = 12;
            this.buttonEmptyInsertedCoinsCoinBox.Text = "Empty Inserted Coins Coin Box";
            this.buttonEmptyInsertedCoinsCoinBox.UseVisualStyleBackColor = true;
            this.buttonEmptyInsertedCoinsCoinBox.Click += new System.EventHandler(this.buttonEmptyInsertedCoinsCoinBox_Click);
            // 
            // buttonEmptyMainCoinBox
            // 
            this.buttonEmptyMainCoinBox.Location = new System.Drawing.Point(256, 35);
            this.buttonEmptyMainCoinBox.Name = "buttonEmptyMainCoinBox";
            this.buttonEmptyMainCoinBox.Size = new System.Drawing.Size(75, 146);
            this.buttonEmptyMainCoinBox.TabIndex = 11;
            this.buttonEmptyMainCoinBox.Text = "Empty Main Coin Box";
            this.buttonEmptyMainCoinBox.UseVisualStyleBackColor = true;
            this.buttonEmptyMainCoinBox.Click += new System.EventHandler(this.buttonEmptyMainCoinBox_Click);
            // 
            // listViewInsertedCoins
            // 
            this.listViewInsertedCoins.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewInsertedCoins.GridLines = true;
            this.listViewInsertedCoins.Location = new System.Drawing.Point(6, 210);
            this.listViewInsertedCoins.Name = "listViewInsertedCoins";
            this.listViewInsertedCoins.Size = new System.Drawing.Size(244, 146);
            this.listViewInsertedCoins.TabIndex = 10;
            this.listViewInsertedCoins.UseCompatibleStateImageBehavior = false;
            this.listViewInsertedCoins.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Coins";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Number";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Value";
            // 
            // labelInsertedCoinDisplay
            // 
            this.labelInsertedCoinDisplay.AutoSize = true;
            this.labelInsertedCoinDisplay.Location = new System.Drawing.Point(6, 194);
            this.labelInsertedCoinDisplay.Name = "labelInsertedCoinDisplay";
            this.labelInsertedCoinDisplay.Size = new System.Drawing.Size(74, 13);
            this.labelInsertedCoinDisplay.TabIndex = 8;
            this.labelInsertedCoinDisplay.Text = "Inserted Coins";
            // 
            // labelMainCoinBoxDisplay
            // 
            this.labelMainCoinBoxDisplay.AutoSize = true;
            this.labelMainCoinBoxDisplay.Location = new System.Drawing.Point(6, 19);
            this.labelMainCoinBoxDisplay.Name = "labelMainCoinBoxDisplay";
            this.labelMainCoinBoxDisplay.Size = new System.Drawing.Size(75, 13);
            this.labelMainCoinBoxDisplay.TabIndex = 7;
            this.labelMainCoinBoxDisplay.Text = "Main Coin Box";
            // 
            // listViewCoinBox
            // 
            this.listViewCoinBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderCoins,
            this.columnHeaderNumber,
            this.columnHeaderValue});
            this.listViewCoinBox.GridLines = true;
            this.listViewCoinBox.Location = new System.Drawing.Point(6, 35);
            this.listViewCoinBox.Name = "listViewCoinBox";
            this.listViewCoinBox.Size = new System.Drawing.Size(244, 146);
            this.listViewCoinBox.TabIndex = 6;
            this.listViewCoinBox.UseCompatibleStateImageBehavior = false;
            this.listViewCoinBox.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderCoins
            // 
            this.columnHeaderCoins.Text = "Coins";
            this.columnHeaderCoins.Width = 120;
            // 
            // columnHeaderNumber
            // 
            this.columnHeaderNumber.Text = "Number";
            // 
            // columnHeaderValue
            // 
            this.columnHeaderValue.Text = "Value";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(259, 135);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password";
            // 
            // groupBoxCanRack
            // 
            this.groupBoxCanRack.Controls.Add(this.buttonFillTheCanRack);
            this.groupBoxCanRack.Controls.Add(this.listViewCanRack);
            this.groupBoxCanRack.Location = new System.Drawing.Point(22, 7);
            this.groupBoxCanRack.Name = "groupBoxCanRack";
            this.groupBoxCanRack.Size = new System.Drawing.Size(264, 207);
            this.groupBoxCanRack.TabIndex = 5;
            this.groupBoxCanRack.TabStop = false;
            this.groupBoxCanRack.Text = "Can Rack";
            this.groupBoxCanRack.Visible = false;
            // 
            // buttonFillTheCanRack
            // 
            this.buttonFillTheCanRack.Location = new System.Drawing.Point(6, 157);
            this.buttonFillTheCanRack.Name = "buttonFillTheCanRack";
            this.buttonFillTheCanRack.Size = new System.Drawing.Size(248, 23);
            this.buttonFillTheCanRack.TabIndex = 1;
            this.buttonFillTheCanRack.Text = "Fill The Can Rack";
            this.buttonFillTheCanRack.UseVisualStyleBackColor = true;
            this.buttonFillTheCanRack.Click += new System.EventHandler(this.buttonFillTheCanRack_Click);
            // 
            // listViewCanRack
            // 
            this.listViewCanRack.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderFlavor,
            this.columnHeaderCanNumber});
            this.listViewCanRack.GridLines = true;
            this.listViewCanRack.Location = new System.Drawing.Point(6, 19);
            this.listViewCanRack.Name = "listViewCanRack";
            this.listViewCanRack.Size = new System.Drawing.Size(248, 132);
            this.listViewCanRack.TabIndex = 0;
            this.listViewCanRack.UseCompatibleStateImageBehavior = false;
            this.listViewCanRack.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderFlavor
            // 
            this.columnHeaderFlavor.Text = "Flavor";
            this.columnHeaderFlavor.Width = 120;
            // 
            // columnHeaderCanNumber
            // 
            this.columnHeaderCanNumber.Text = "Number of Cans Left";
            this.columnHeaderCanNumber.Width = 120;
            // 
            // buttonServiceLock
            // 
            this.buttonServiceLock.Location = new System.Drawing.Point(31, 351);
            this.buttonServiceLock.Name = "buttonServiceLock";
            this.buttonServiceLock.Size = new System.Drawing.Size(75, 23);
            this.buttonServiceLock.TabIndex = 3;
            this.buttonServiceLock.Text = "Lock";
            this.buttonServiceLock.UseVisualStyleBackColor = true;
            this.buttonServiceLock.Visible = false;
            this.buttonServiceLock.Click += new System.EventHandler(this.buttonServiceLock_Click);
            // 
            // buttonPasswordOK
            // 
            this.buttonPasswordOK.Location = new System.Drawing.Point(433, 135);
            this.buttonPasswordOK.Name = "buttonPasswordOK";
            this.buttonPasswordOK.Size = new System.Drawing.Size(75, 23);
            this.buttonPasswordOK.TabIndex = 1;
            this.buttonPasswordOK.Text = "OK";
            this.buttonPasswordOK.UseVisualStyleBackColor = true;
            this.buttonPasswordOK.Click += new System.EventHandler(this.buttonPasswordOK_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(318, 132);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 0;
            this.textBoxPassword.Text = "cs";
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.VisibleChanged += new System.EventHandler(this.textBoxPassword_VisibleChanged);
            // 
            // labelMessageToCustomer
            // 
            this.labelMessageToCustomer.AutoSize = true;
            this.labelMessageToCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessageToCustomer.Location = new System.Drawing.Point(223, 396);
            this.labelMessageToCustomer.Name = "labelMessageToCustomer";
            this.labelMessageToCustomer.Size = new System.Drawing.Size(0, 36);
            this.labelMessageToCustomer.TabIndex = 6;
            // 
            // FormVending
            // 
            this.AcceptButton = this.buttonPasswordOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 485);
            this.Controls.Add(this.tabControlVending);
            this.Name = "FormVending";
            this.Text = ".NET C# Vending Machine";
            this.Load += new System.EventHandler(this.FormVending_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegularSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOrangeSoda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLemonSoda)).EndInit();
            this.tabControlVending.ResumeLayout(false);
            this.tabPageVend.ResumeLayout(false);
            this.tabPageVend.PerformLayout();
            this.pageTabService.ResumeLayout(false);
            this.pageTabService.PerformLayout();
            this.groupCoinBox.ResumeLayout(false);
            this.groupCoinBox.PerformLayout();
            this.groupBoxCanRack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRegularSoda;
        private System.Windows.Forms.PictureBox pictureBoxOrangeSoda;
        private System.Windows.Forms.PictureBox pictureBoxLemonSoda;
        private System.Windows.Forms.Button buttonRegularEject;
        private System.Windows.Forms.Button buttonOrangeEject;
        private System.Windows.Forms.Button buttonLemonEject;
        private System.Windows.Forms.Button buttonHalfDollar;
        private System.Windows.Forms.Button buttonQuarter;
        private System.Windows.Forms.Button buttonDime;
        private System.Windows.Forms.Button buttonNickel;
        private System.Windows.Forms.Label labelPleaseInsert;
        private System.Windows.Forms.Label labelTotalInserted;
        private System.Windows.Forms.Label labelTotalInsertedDisplay;
        private System.Windows.Forms.Label labelExactChange;
        private System.Windows.Forms.Button buttonCoinReturn;
        private System.Windows.Forms.TabControl tabControlVending;
        private System.Windows.Forms.TabPage tabPageVend;
        private System.Windows.Forms.TabPage pageTabService;
        private System.Windows.Forms.Button buttonPasswordOK;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonServiceLock;
        private System.Windows.Forms.GroupBox groupBoxCanRack;
        private System.Windows.Forms.ListView listViewCanRack;
        private System.Windows.Forms.ColumnHeader columnHeaderFlavor;
        private System.Windows.Forms.ColumnHeader columnHeaderCanNumber;
        private System.Windows.Forms.GroupBox groupCoinBox;
        private System.Windows.Forms.ListView listViewCoinBox;
        private System.Windows.Forms.ColumnHeader columnHeaderCoins;
        private System.Windows.Forms.ColumnHeader columnHeaderNumber;
        private System.Windows.Forms.ColumnHeader columnHeaderValue;
        private System.Windows.Forms.Label labelInsertedCoinDisplay;
        private System.Windows.Forms.Label labelMainCoinBoxDisplay;
        private System.Windows.Forms.ListView listViewInsertedCoins;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button buttonFillTheCanRack;
        private System.Windows.Forms.Button buttonEmptyInsertedCoinsCoinBox;
        private System.Windows.Forms.Button buttonEmptyMainCoinBox;
        private System.Windows.Forms.Label labelMessageToCustomer;
    }
}



