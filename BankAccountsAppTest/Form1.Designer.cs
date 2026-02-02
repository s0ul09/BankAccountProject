namespace BankAccountsAppTest
{
    partial class Form1
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
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountsGrid = new DataGridView();
            DepositBtn = new Button();
            WitdrawBtn = new Button();
            CreateAccountBtn = new Button();
            label3 = new Label();
            InterestRateNum = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 54);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 45);
            label1.TabIndex = 0;
            label1.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 433);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 45);
            label2.TabIndex = 1;
            label2.Text = "Amount";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Location = new Point(217, 54);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(265, 50);
            OwnerTxt.TabIndex = 2;
            // 
            // AmountNum
            // 
            AmountNum.Location = new Point(232, 428);
            AmountNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            AmountNum.Minimum = new decimal(new int[] { 999999, 0, 0, int.MinValue });
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(250, 50);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountsGrid
            // 
            BankAccountsGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountsGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountsGrid.Location = new Point(516, 54);
            BankAccountsGrid.Name = "BankAccountsGrid";
            BankAccountsGrid.RowHeadersWidth = 62;
            BankAccountsGrid.Size = new Size(689, 370);
            BankAccountsGrid.TabIndex = 4;
            // 
            // DepositBtn
            // 
            DepositBtn.Location = new Point(527, 441);
            DepositBtn.Name = "DepositBtn";
            DepositBtn.Size = new Size(338, 93);
            DepositBtn.TabIndex = 5;
            DepositBtn.Text = "Deposit";
            DepositBtn.UseVisualStyleBackColor = true;
            DepositBtn.Click += DepositBtn_Click;
            // 
            // WitdrawBtn
            // 
            WitdrawBtn.Location = new Point(886, 441);
            WitdrawBtn.Name = "WitdrawBtn";
            WitdrawBtn.Size = new Size(319, 93);
            WitdrawBtn.TabIndex = 6;
            WitdrawBtn.Text = "Withdraw";
            WitdrawBtn.UseVisualStyleBackColor = true;
            WitdrawBtn.Click += WitdrawBtn_Click;
            // 
            // CreateAccountBtn
            // 
            CreateAccountBtn.Location = new Point(218, 229);
            CreateAccountBtn.Name = "CreateAccountBtn";
            CreateAccountBtn.Size = new Size(264, 93);
            CreateAccountBtn.TabIndex = 7;
            CreateAccountBtn.Text = "Create account";
            CreateAccountBtn.UseVisualStyleBackColor = true;
            CreateAccountBtn.Click += CreateAccountBtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(5, 140);
            label3.Name = "label3";
            label3.Size = new Size(200, 45);
            label3.TabIndex = 8;
            label3.Text = "Interest Rate";
            // 
            // InterestRateNum
            // 
            InterestRateNum.Location = new Point(218, 138);
            InterestRateNum.Name = "InterestRateNum";
            InterestRateNum.Size = new Size(264, 50);
            InterestRateNum.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 546);
            Controls.Add(InterestRateNum);
            Controls.Add(label3);
            Controls.Add(CreateAccountBtn);
            Controls.Add(WitdrawBtn);
            Controls.Add(DepositBtn);
            Controls.Add(BankAccountsGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountsGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)InterestRateNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountsGrid;
        private Button DepositBtn;
        private Button WitdrawBtn;
        private Button CreateAccountBtn;
        private Label label3;
        private NumericUpDown InterestRateNum;
    }
}
