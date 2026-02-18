namespace SP3_BankAccount
{
    public partial class BankForm : Form
    {

        private Dictionary<string, BankAccount> accountList = new Dictionary<string, BankAccount>();
        private List<Transaction> transactionList = new List<Transaction>();
        private BankAccount currentAccount;
       
        /* accountList holds bank accounts in a key value pair: accounts are fetched by last+first string
         * transactionList holds a list of all transactions: either deposit or withdrawal
         */

        private BankAccount GetAccount()
        {
            string first = FN_Text.Text, last = LN_Text.Text;

            if (first == "" || last == "") // return null if either name field is blank
                return null;
            else
                if (accountList.ContainsKey(last + first)) // if the account exists already, fetch
                    return accountList[last + first];
            else // else, create a new account
            {
                accountList[last + first] = new BankAccount(first, last);
                return accountList[last + first];
            }
        }

        public BankForm()
        {
            InitializeComponent();
        }
        //Button used to withdraw money after amount is entered
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double withdrawAmount; // make sure amount field is valid
            if (!double.TryParse(amountText.Text, out withdrawAmount) || withdrawAmount <= 0)
            {
                MessageBox.Show("Invalid amount!");
                return;
            }
            withdrawAmount = Math.Round(withdrawAmount, 2);

            currentAccount = GetAccount(); // fetch current account
            if (currentAccount == null)
            {
                MessageBox.Show("Invalid Credentials: Selected account doesn't exist!");
                return;
            }
            else
            {
                if (currentAccount.GetBalance() - withdrawAmount >= 0) // prevent withdrawal if insufficent balance
                {
                    currentAccount.Withdraw(withdrawAmount);

                    Transaction thisTran = new(currentAccount, -withdrawAmount);
                    transactionList.Add(thisTran); // create new transaction, add to the list
                    MessageBox.Show(thisTran.TransactionString());
                }
                else
                    MessageBox.Show($"{currentAccount.GetName()}: Cannot withdrawal ${withdrawAmount} from ${currentAccount.GetBalance()}");
            }
        }

        //Button used to deposit money after amount is entered
        private void depositButton_Click(object sender, EventArgs e)
        {
            double depositAmount; // make sure amount field is valid
            if (!double.TryParse(amountText.Text,out depositAmount) || depositAmount <= 0)
            {
                MessageBox.Show("Invalid amount!");
                return;
            }
            depositAmount = Math.Round(depositAmount,2);

            currentAccount = GetAccount(); // fetch current account
            if (currentAccount == null)
            {
                MessageBox.Show("Invalid Credentials: Selected account doesn't exist!");
                return;
            }
            else
            {
                if (depositAmount > 1000) // check for maximum deposit limit
                {
                    MessageBox.Show("Error: Maximum deposit amount is $1000");
                    return;
                }
                currentAccount.Deposit(depositAmount);

                Transaction thisTran = new(currentAccount,depositAmount);
                transactionList.Add(thisTran); // create new transaction, add to the list
                MessageBox.Show(thisTran.TransactionString());
            }
        }

        //Button used to show balance in bank account when Last and First Name is entered
        private void showBalanceButton_Click(object sender, EventArgs e)
        {
            currentAccount = GetAccount();
            if (currentAccount == null)
            {
                MessageBox.Show("Invalid Credentials: Selected account doesn't exist!");
                return;
            }
            else
                MessageBox.Show($"{currentAccount.GetName()}: ${currentAccount.GetBalance()}");
        }

        //Button used to exit application
        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Button used to bring up list of recent transactions
        private void recentTransButton_Click(object sender, EventArgs e)
        {
            if (transactionList.Count == 0)
                MessageBox.Show("No transactions!");
            else
            {
                string totalMessage = "";
                for (int i = 0; i < transactionList.Count; i++)
                    totalMessage += transactionList[i].TransactionString() + "\n";
                MessageBox.Show(totalMessage);
            }
        }
    }
}
