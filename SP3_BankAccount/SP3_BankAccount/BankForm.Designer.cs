namespace SP3_BankAccount
{
    partial class BankForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankForm));
            titleLabel = new Label();
            FN_Text = new TextBox();
            LN_Text = new TextBox();
            LN_Label = new Label();
            FN_Label = new Label();
            withdrawButton = new Button();
            depositButton = new Button();
            exitButton = new Button();
            showBalanceButton = new Button();
            amountText = new TextBox();
            amountLabel = new Label();
            mobileBankingImage = new PictureBox();
            recentTransButton = new Button();
            instructionBox = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)mobileBankingImage).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 40.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(204, 6);
            titleLabel.Margin = new Padding(2, 0, 2, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(678, 89);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "Banking Application";
            // 
            // FN_Text
            // 
            FN_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FN_Text.Location = new Point(257, 246);
            FN_Text.Margin = new Padding(2);
            FN_Text.Multiline = true;
            FN_Text.Name = "FN_Text";
            FN_Text.Size = new Size(346, 73);
            FN_Text.TabIndex = 1;
            // 
            // LN_Text
            // 
            LN_Text.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LN_Text.Location = new Point(257, 124);
            LN_Text.Margin = new Padding(2);
            LN_Text.Multiline = true;
            LN_Text.Name = "LN_Text";
            LN_Text.Size = new Size(346, 66);
            LN_Text.TabIndex = 0;
            // 
            // LN_Label
            // 
            LN_Label.AutoSize = true;
            LN_Label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LN_Label.Location = new Point(14, 124);
            LN_Label.Margin = new Padding(2, 0, 2, 0);
            LN_Label.Name = "LN_Label";
            LN_Label.Size = new Size(240, 41);
            LN_Label.TabIndex = 3;
            LN_Label.Text = "Enter Last Name:";
            // 
            // FN_Label
            // 
            FN_Label.AutoSize = true;
            FN_Label.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FN_Label.Location = new Point(14, 246);
            FN_Label.Margin = new Padding(2, 0, 2, 0);
            FN_Label.Name = "FN_Label";
            FN_Label.Size = new Size(243, 41);
            FN_Label.TabIndex = 4;
            FN_Label.Text = "Enter First Name:";
            // 
            // withdrawButton
            // 
            withdrawButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            withdrawButton.Location = new Point(64, 502);
            withdrawButton.Margin = new Padding(2);
            withdrawButton.Name = "withdrawButton";
            withdrawButton.Size = new Size(169, 75);
            withdrawButton.TabIndex = 3;
            withdrawButton.Text = "Withdraw";
            withdrawButton.UseVisualStyleBackColor = true;
            withdrawButton.Click += withdrawButton_Click;
            // 
            // depositButton
            // 
            depositButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            depositButton.Location = new Point(257, 502);
            depositButton.Margin = new Padding(2);
            depositButton.Name = "depositButton";
            depositButton.Size = new Size(169, 75);
            depositButton.TabIndex = 4;
            depositButton.Text = "Deposit";
            depositButton.UseVisualStyleBackColor = true;
            depositButton.Click += depositButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(842, 502);
            exitButton.Margin = new Padding(2);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(169, 75);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit Application";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // showBalanceButton
            // 
            showBalanceButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showBalanceButton.Location = new Point(455, 502);
            showBalanceButton.Margin = new Padding(2);
            showBalanceButton.Name = "showBalanceButton";
            showBalanceButton.Size = new Size(169, 75);
            showBalanceButton.TabIndex = 5;
            showBalanceButton.Text = "Show Balance";
            showBalanceButton.UseVisualStyleBackColor = true;
            showBalanceButton.Click += showBalanceButton_Click;
            // 
            // amountText
            // 
            amountText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountText.Location = new Point(257, 370);
            amountText.Margin = new Padding(2);
            amountText.Multiline = true;
            amountText.Name = "amountText";
            amountText.Size = new Size(346, 74);
            amountText.TabIndex = 2;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            amountLabel.Location = new Point(14, 370);
            amountLabel.Margin = new Padding(2, 0, 2, 0);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new Size(208, 41);
            amountLabel.TabIndex = 10;
            amountLabel.Text = "Enter Amount:";
            // 
            // mobileBankingImage
            // 
            mobileBankingImage.BorderStyle = BorderStyle.Fixed3D;
            mobileBankingImage.Image = (Image)resources.GetObject("mobileBankingImage.Image");
            mobileBankingImage.Location = new Point(664, 164);
            mobileBankingImage.Margin = new Padding(2);
            mobileBankingImage.Name = "mobileBankingImage";
            mobileBankingImage.Size = new Size(312, 226);
            mobileBankingImage.SizeMode = PictureBoxSizeMode.StretchImage;
            mobileBankingImage.TabIndex = 11;
            mobileBankingImage.TabStop = false;
            // 
            // recentTransButton
            // 
            recentTransButton.Font = new Font("Segoe UI", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recentTransButton.Location = new Point(649, 502);
            recentTransButton.Margin = new Padding(2);
            recentTransButton.Name = "recentTransButton";
            recentTransButton.Size = new Size(169, 75);
            recentTransButton.TabIndex = 6;
            recentTransButton.Text = "Recent Transactions";
            recentTransButton.UseVisualStyleBackColor = true;
            recentTransButton.Click += recentTransButton_Click;
            // 
            // instructionBox
            // 
            instructionBox.AutoSize = true;
            instructionBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            instructionBox.Location = new Point(14, 450);
            instructionBox.Margin = new Padding(2, 0, 2, 0);
            instructionBox.Name = "instructionBox";
            instructionBox.Size = new Size(747, 28);
            instructionBox.TabIndex = 13;
            instructionBox.Text = "Enter Last Name, First Name, and the Amount you would like to withdraw or deposit.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(11, 9);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(207, 28);
            label1.TabIndex = 14;
            label1.Text = "Nicholas, Beth, Landen";
            // 
            // BankForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1071, 605);
            Controls.Add(label1);
            Controls.Add(instructionBox);
            Controls.Add(recentTransButton);
            Controls.Add(mobileBankingImage);
            Controls.Add(amountLabel);
            Controls.Add(amountText);
            Controls.Add(showBalanceButton);
            Controls.Add(exitButton);
            Controls.Add(depositButton);
            Controls.Add(withdrawButton);
            Controls.Add(FN_Label);
            Controls.Add(LN_Label);
            Controls.Add(LN_Text);
            Controls.Add(FN_Text);
            Controls.Add(titleLabel);
            Margin = new Padding(2);
            Name = "BankForm";
            Text = "Bank Account Application";
            ((System.ComponentModel.ISupportInitialize)mobileBankingImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private TextBox FN_Text;
        private TextBox LN_Text;
        private Label LN_Label;
        private Label FN_Label;
        private Button withdrawButton;
        private Button depositButton;
        private Button exitButton;
        private Button showBalanceButton;
        private TextBox amountText;
        private Label amountLabel;
        private PictureBox mobileBankingImage;
        private Button recentTransButton;
        private Label instructionBox;
        private Label label1;
    }
}
