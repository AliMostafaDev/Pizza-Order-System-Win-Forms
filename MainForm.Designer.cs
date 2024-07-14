namespace Pizza_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThinCrust = new System.Windows.Forms.RadioButton();
            this.rbThickCrust = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.chkExtraCheese = new System.Windows.Forms.CheckBox();
            this.chkMushrooms = new System.Windows.Forms.CheckBox();
            this.chkTomatoes = new System.Windows.Forms.CheckBox();
            this.chkGreenPeppers = new System.Windows.Forms.CheckBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkOnion = new System.Windows.Forms.CheckBox();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.labelSizeAnswer = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelToppings = new System.Windows.Forms.Label();
            this.labelToppingsAnswer = new System.Windows.Forms.Label();
            this.labelCrustType = new System.Windows.Forms.Label();
            this.labelCrustTypeAnswer = new System.Windows.Forms.Label();
            this.labelWhereToEat = new System.Windows.Forms.Label();
            this.labelWhereToEatAnswer = new System.Windows.Forms.Label();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPriceAnswer = new System.Windows.Forms.Label();
            this.gbOrderSummary = new System.Windows.Forms.GroupBox();
            this.labelDollar = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.labelMakeYourPizza = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.gbOrderSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(24, 34);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(4);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(62, 20);
            this.rbSmall.TabIndex = 0;
            this.rbSmall.Tag = "20";
            this.rbSmall.Text = "Small";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Checked = true;
            this.rbMedium.Location = new System.Drawing.Point(24, 74);
            this.rbMedium.Margin = new System.Windows.Forms.Padding(4);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(76, 20);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "30";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(24, 114);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(4);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(63, 20);
            this.rbLarge.TabIndex = 2;
            this.rbLarge.Tag = "40";
            this.rbLarge.Text = "Large";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbSmall);
            this.gbSize.Controls.Add(this.rbMedium);
            this.gbSize.Location = new System.Drawing.Point(75, 91);
            this.gbSize.Margin = new System.Windows.Forms.Padding(4);
            this.gbSize.Name = "gbSize";
            this.gbSize.Padding = new System.Windows.Forms.Padding(4);
            this.gbSize.Size = new System.Drawing.Size(115, 166);
            this.gbSize.TabIndex = 3;
            this.gbSize.TabStop = false;
            this.gbSize.Tag = "30";
            this.gbSize.Text = "Size";
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThinCrust);
            this.gbCrustType.Controls.Add(this.rbThickCrust);
            this.gbCrustType.Location = new System.Drawing.Point(75, 305);
            this.gbCrustType.Margin = new System.Windows.Forms.Padding(4);
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.Padding = new System.Windows.Forms.Padding(4);
            this.gbCrustType.Size = new System.Drawing.Size(131, 119);
            this.gbCrustType.TabIndex = 4;
            this.gbCrustType.TabStop = false;
            this.gbCrustType.Tag = "0";
            this.gbCrustType.Text = "Crust Type";
            // 
            // rbThinCrust
            // 
            this.rbThinCrust.AutoSize = true;
            this.rbThinCrust.Checked = true;
            this.rbThinCrust.Location = new System.Drawing.Point(17, 34);
            this.rbThinCrust.Margin = new System.Windows.Forms.Padding(4);
            this.rbThinCrust.Name = "rbThinCrust";
            this.rbThinCrust.Size = new System.Drawing.Size(87, 20);
            this.rbThinCrust.TabIndex = 0;
            this.rbThinCrust.TabStop = true;
            this.rbThinCrust.Tag = "0";
            this.rbThinCrust.Text = "Thin Crust";
            this.rbThinCrust.UseVisualStyleBackColor = true;
            this.rbThinCrust.CheckedChanged += new System.EventHandler(this.rbThinCrust_CheckedChanged);
            // 
            // rbThickCrust
            // 
            this.rbThickCrust.AutoSize = true;
            this.rbThickCrust.Location = new System.Drawing.Point(17, 74);
            this.rbThickCrust.Margin = new System.Windows.Forms.Padding(4);
            this.rbThickCrust.Name = "rbThickCrust";
            this.rbThickCrust.Size = new System.Drawing.Size(94, 20);
            this.rbThickCrust.TabIndex = 1;
            this.rbThickCrust.Tag = "10";
            this.rbThickCrust.Text = "Thick Crust";
            this.rbThickCrust.UseVisualStyleBackColor = true;
            this.rbThickCrust.CheckedChanged += new System.EventHandler(this.rbThickCrust_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Location = new System.Drawing.Point(373, 322);
            this.gbWhereToEat.Margin = new System.Windows.Forms.Padding(4);
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.Padding = new System.Windows.Forms.Padding(4);
            this.gbWhereToEat.Size = new System.Drawing.Size(239, 78);
            this.gbWhereToEat.TabIndex = 5;
            this.gbWhereToEat.TabStop = false;
            this.gbWhereToEat.Text = "Where To Eat?";
            // 
            // rbEatIn
            // 
            this.rbEatIn.AutoSize = true;
            this.rbEatIn.Checked = true;
            this.rbEatIn.Location = new System.Drawing.Point(24, 34);
            this.rbEatIn.Margin = new System.Windows.Forms.Padding(4);
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.Size = new System.Drawing.Size(61, 20);
            this.rbEatIn.TabIndex = 0;
            this.rbEatIn.TabStop = true;
            this.rbEatIn.Text = "Eat In";
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // rbTakeOut
            // 
            this.rbTakeOut.AutoSize = true;
            this.rbTakeOut.Location = new System.Drawing.Point(119, 34);
            this.rbTakeOut.Margin = new System.Windows.Forms.Padding(4);
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.Size = new System.Drawing.Size(83, 20);
            this.rbTakeOut.TabIndex = 1;
            this.rbTakeOut.Text = "Take Out";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // chkExtraCheese
            // 
            this.chkExtraCheese.AutoSize = true;
            this.chkExtraCheese.Location = new System.Drawing.Point(11, 39);
            this.chkExtraCheese.Margin = new System.Windows.Forms.Padding(4);
            this.chkExtraCheese.Name = "chkExtraCheese";
            this.chkExtraCheese.Size = new System.Drawing.Size(107, 20);
            this.chkExtraCheese.TabIndex = 6;
            this.chkExtraCheese.Text = "Extra cheese";
            this.chkExtraCheese.UseVisualStyleBackColor = true;
            this.chkExtraCheese.CheckedChanged += new System.EventHandler(this.chkExtraCheese_CheckedChanged);
            // 
            // chkMushrooms
            // 
            this.chkMushrooms.AutoSize = true;
            this.chkMushrooms.Location = new System.Drawing.Point(13, 96);
            this.chkMushrooms.Margin = new System.Windows.Forms.Padding(4);
            this.chkMushrooms.Name = "chkMushrooms";
            this.chkMushrooms.Size = new System.Drawing.Size(99, 20);
            this.chkMushrooms.TabIndex = 7;
            this.chkMushrooms.Text = "Mushrooms";
            this.chkMushrooms.UseVisualStyleBackColor = true;
            this.chkMushrooms.CheckedChanged += new System.EventHandler(this.chkMushrooms_CheckedChanged);
            // 
            // chkTomatoes
            // 
            this.chkTomatoes.AutoSize = true;
            this.chkTomatoes.Location = new System.Drawing.Point(13, 145);
            this.chkTomatoes.Margin = new System.Windows.Forms.Padding(4);
            this.chkTomatoes.Name = "chkTomatoes";
            this.chkTomatoes.Size = new System.Drawing.Size(91, 20);
            this.chkTomatoes.TabIndex = 8;
            this.chkTomatoes.Text = "Tomatoes";
            this.chkTomatoes.UseVisualStyleBackColor = true;
            this.chkTomatoes.CheckedChanged += new System.EventHandler(this.chkTomatoes_CheckedChanged);
            // 
            // chkGreenPeppers
            // 
            this.chkGreenPeppers.AutoSize = true;
            this.chkGreenPeppers.Location = new System.Drawing.Point(149, 145);
            this.chkGreenPeppers.Margin = new System.Windows.Forms.Padding(4);
            this.chkGreenPeppers.Name = "chkGreenPeppers";
            this.chkGreenPeppers.Size = new System.Drawing.Size(121, 20);
            this.chkGreenPeppers.TabIndex = 11;
            this.chkGreenPeppers.Text = "Green Peppers\r\n";
            this.chkGreenPeppers.UseVisualStyleBackColor = true;
            this.chkGreenPeppers.CheckedChanged += new System.EventHandler(this.chkGreenPeppers_CheckedChanged);
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(147, 96);
            this.chkOlives.Margin = new System.Windows.Forms.Padding(4);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(67, 20);
            this.chkOlives.TabIndex = 10;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            this.chkOlives.CheckedChanged += new System.EventHandler(this.chkOlives_CheckedChanged);
            // 
            // chkOnion
            // 
            this.chkOnion.AutoSize = true;
            this.chkOnion.Location = new System.Drawing.Point(148, 39);
            this.chkOnion.Margin = new System.Windows.Forms.Padding(4);
            this.chkOnion.Name = "chkOnion";
            this.chkOnion.Size = new System.Drawing.Size(64, 20);
            this.chkOnion.TabIndex = 9;
            this.chkOnion.Text = "Onion";
            this.chkOnion.UseVisualStyleBackColor = true;
            this.chkOnion.CheckedChanged += new System.EventHandler(this.chkOnion_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.BackColor = System.Drawing.SystemColors.Control;
            this.gbToppings.Controls.Add(this.chkOlives);
            this.gbToppings.Controls.Add(this.chkGreenPeppers);
            this.gbToppings.Controls.Add(this.chkExtraCheese);
            this.gbToppings.Controls.Add(this.chkMushrooms);
            this.gbToppings.Controls.Add(this.chkOnion);
            this.gbToppings.Controls.Add(this.chkTomatoes);
            this.gbToppings.Location = new System.Drawing.Point(343, 91);
            this.gbToppings.Margin = new System.Windows.Forms.Padding(4);
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.Padding = new System.Windows.Forms.Padding(4);
            this.gbToppings.Size = new System.Drawing.Size(308, 224);
            this.gbToppings.TabIndex = 12;
            this.gbToppings.TabStop = false;
            this.gbToppings.Tag = "0";
            this.gbToppings.Text = "Toppings";
            // 
            // labelSizeAnswer
            // 
            this.labelSizeAnswer.AutoSize = true;
            this.labelSizeAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelSizeAnswer.Location = new System.Drawing.Point(68, 50);
            this.labelSizeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSizeAnswer.Name = "labelSizeAnswer";
            this.labelSizeAnswer.Size = new System.Drawing.Size(59, 18);
            this.labelSizeAnswer.TabIndex = 15;
            this.labelSizeAnswer.Text = "Medium";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSize.Location = new System.Drawing.Point(16, 50);
            this.labelSize.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(44, 17);
            this.labelSize.TabIndex = 16;
            this.labelSize.Text = "Size:";
            // 
            // labelToppings
            // 
            this.labelToppings.AutoSize = true;
            this.labelToppings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelToppings.Location = new System.Drawing.Point(16, 158);
            this.labelToppings.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToppings.Name = "labelToppings";
            this.labelToppings.Size = new System.Drawing.Size(80, 17);
            this.labelToppings.TabIndex = 17;
            this.labelToppings.Text = "Toppings:";
            // 
            // labelToppingsAnswer
            // 
            this.labelToppingsAnswer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelToppingsAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelToppingsAnswer.Location = new System.Drawing.Point(28, 186);
            this.labelToppingsAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelToppingsAnswer.Name = "labelToppingsAnswer";
            this.labelToppingsAnswer.Size = new System.Drawing.Size(255, 55);
            this.labelToppingsAnswer.TabIndex = 18;
            this.labelToppingsAnswer.Text = "No Toppings";
            // 
            // labelCrustType
            // 
            this.labelCrustType.AutoSize = true;
            this.labelCrustType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrustType.Location = new System.Drawing.Point(13, 89);
            this.labelCrustType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrustType.Name = "labelCrustType";
            this.labelCrustType.Size = new System.Drawing.Size(92, 17);
            this.labelCrustType.TabIndex = 19;
            this.labelCrustType.Text = "Crust Type:";
            // 
            // labelCrustTypeAnswer
            // 
            this.labelCrustTypeAnswer.AutoSize = true;
            this.labelCrustTypeAnswer.Location = new System.Drawing.Point(113, 89);
            this.labelCrustTypeAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCrustTypeAnswer.Name = "labelCrustTypeAnswer";
            this.labelCrustTypeAnswer.Size = new System.Drawing.Size(71, 18);
            this.labelCrustTypeAnswer.TabIndex = 20;
            this.labelCrustTypeAnswer.Text = "Thin Crust";
            // 
            // labelWhereToEat
            // 
            this.labelWhereToEat.AutoSize = true;
            this.labelWhereToEat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWhereToEat.Location = new System.Drawing.Point(13, 124);
            this.labelWhereToEat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhereToEat.Name = "labelWhereToEat";
            this.labelWhereToEat.Size = new System.Drawing.Size(113, 17);
            this.labelWhereToEat.TabIndex = 21;
            this.labelWhereToEat.Text = "Where To Eat:";
            // 
            // labelWhereToEatAnswer
            // 
            this.labelWhereToEatAnswer.AutoSize = true;
            this.labelWhereToEatAnswer.Location = new System.Drawing.Point(141, 124);
            this.labelWhereToEatAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWhereToEatAnswer.Name = "labelWhereToEatAnswer";
            this.labelWhereToEatAnswer.Size = new System.Drawing.Size(43, 18);
            this.labelWhereToEatAnswer.TabIndex = 22;
            this.labelWhereToEatAnswer.Text = "Eat In";
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.AutoSize = true;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(16, 263);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(92, 17);
            this.labelTotalPrice.TabIndex = 23;
            this.labelTotalPrice.Text = "Total Price:";
            // 
            // labelTotalPriceAnswer
            // 
            this.labelTotalPriceAnswer.AutoSize = true;
            this.labelTotalPriceAnswer.BackColor = System.Drawing.Color.Transparent;
            this.labelTotalPriceAnswer.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPriceAnswer.ForeColor = System.Drawing.Color.Blue;
            this.labelTotalPriceAnswer.Location = new System.Drawing.Point(152, 276);
            this.labelTotalPriceAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTotalPriceAnswer.Name = "labelTotalPriceAnswer";
            this.labelTotalPriceAnswer.Size = new System.Drawing.Size(75, 47);
            this.labelTotalPriceAnswer.TabIndex = 24;
            this.labelTotalPriceAnswer.Text = "30";
            // 
            // gbOrderSummary
            // 
            this.gbOrderSummary.BackColor = System.Drawing.SystemColors.Control;
            this.gbOrderSummary.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbOrderSummary.BackgroundImage")));
            this.gbOrderSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbOrderSummary.Controls.Add(this.labelTotalPriceAnswer);
            this.gbOrderSummary.Controls.Add(this.labelDollar);
            this.gbOrderSummary.Controls.Add(this.labelSizeAnswer);
            this.gbOrderSummary.Controls.Add(this.labelSize);
            this.gbOrderSummary.Controls.Add(this.labelTotalPrice);
            this.gbOrderSummary.Controls.Add(this.labelToppings);
            this.gbOrderSummary.Controls.Add(this.labelWhereToEatAnswer);
            this.gbOrderSummary.Controls.Add(this.labelToppingsAnswer);
            this.gbOrderSummary.Controls.Add(this.labelWhereToEat);
            this.gbOrderSummary.Controls.Add(this.labelCrustTypeAnswer);
            this.gbOrderSummary.Controls.Add(this.labelCrustType);
            this.gbOrderSummary.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.gbOrderSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbOrderSummary.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOrderSummary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbOrderSummary.Location = new System.Drawing.Point(747, 98);
            this.gbOrderSummary.Margin = new System.Windows.Forms.Padding(4);
            this.gbOrderSummary.Name = "gbOrderSummary";
            this.gbOrderSummary.Padding = new System.Windows.Forms.Padding(4);
            this.gbOrderSummary.Size = new System.Drawing.Size(353, 338);
            this.gbOrderSummary.TabIndex = 25;
            this.gbOrderSummary.TabStop = false;
            this.gbOrderSummary.Text = "Order Summary:";
            // 
            // labelDollar
            // 
            this.labelDollar.AutoSize = true;
            this.labelDollar.BackColor = System.Drawing.Color.Transparent;
            this.labelDollar.Font = new System.Drawing.Font("Elephant", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDollar.ForeColor = System.Drawing.Color.Blue;
            this.labelDollar.Location = new System.Drawing.Point(115, 276);
            this.labelDollar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDollar.Name = "labelDollar";
            this.labelDollar.Size = new System.Drawing.Size(46, 47);
            this.labelDollar.TabIndex = 25;
            this.labelDollar.Text = "$";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnOrderPizza.FlatAppearance.BorderSize = 2;
            this.btnOrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnOrderPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnOrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderPizza.Location = new System.Drawing.Point(343, 426);
            this.btnOrderPizza.Margin = new System.Windows.Forms.Padding(4);
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.Size = new System.Drawing.Size(147, 63);
            this.btnOrderPizza.TabIndex = 26;
            this.btnOrderPizza.Text = "Order Pizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnResetForm.FlatAppearance.BorderSize = 2;
            this.btnResetForm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aqua;
            this.btnResetForm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnResetForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResetForm.Location = new System.Drawing.Point(525, 426);
            this.btnResetForm.Margin = new System.Windows.Forms.Padding(4);
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.Size = new System.Drawing.Size(153, 63);
            this.btnResetForm.TabIndex = 27;
            this.btnResetForm.Text = "Reset Form";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // labelMakeYourPizza
            // 
            this.labelMakeYourPizza.AutoSize = true;
            this.labelMakeYourPizza.BackColor = System.Drawing.Color.Transparent;
            this.labelMakeYourPizza.Font = new System.Drawing.Font("Showcard Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMakeYourPizza.ForeColor = System.Drawing.Color.Blue;
            this.labelMakeYourPizza.Location = new System.Drawing.Point(263, 9);
            this.labelMakeYourPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMakeYourPizza.Name = "labelMakeYourPizza";
            this.labelMakeYourPizza.Size = new System.Drawing.Size(485, 62);
            this.labelMakeYourPizza.TabIndex = 28;
            this.labelMakeYourPizza.Text = "MAKE YOUR PIZZA";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(81, 467);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(98, 22);
            this.numericUpDown1.TabIndex = 29;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Pizza Count:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1053, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelMakeYourPizza);
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.gbOrderSummary);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Pizza Menu";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.gbOrderSummary.ResumeLayout(false);
            this.gbOrderSummary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThinCrust;
        private System.Windows.Forms.RadioButton rbThickCrust;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.CheckBox chkExtraCheese;
        private System.Windows.Forms.CheckBox chkMushrooms;
        private System.Windows.Forms.CheckBox chkTomatoes;
        private System.Windows.Forms.CheckBox chkGreenPeppers;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkOnion;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.Label labelSizeAnswer;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelToppings;
        private System.Windows.Forms.Label labelToppingsAnswer;
        private System.Windows.Forms.Label labelCrustType;
        private System.Windows.Forms.Label labelCrustTypeAnswer;
        private System.Windows.Forms.Label labelWhereToEat;
        private System.Windows.Forms.Label labelWhereToEatAnswer;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalPriceAnswer;
        private System.Windows.Forms.GroupBox gbOrderSummary;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
        private System.Windows.Forms.Label labelDollar;
        private System.Windows.Forms.Label labelMakeYourPizza;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
    }
}

