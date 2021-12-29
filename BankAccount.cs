namespace Learning.oop.homework3
{
    internal class BankAccount
    {
        private int _accountNmber;
        private decimal _accountBalance;
        private TypeAccountEnum _accountType;
        private static int _countAccount;

        public BankAccount()
        {
            _accountNmber = SetAccountNumber();
        }

        public BankAccount(decimal accountBalance) : this()
        {
            _accountBalance = accountBalance;
        }

        public BankAccount(TypeAccountEnum accountType) : this()
        {
            _accountType = accountType;
        }

        public BankAccount(decimal accountBalance, TypeAccountEnum accountType) : this()
        {
            _accountBalance = accountBalance;
            _accountType = accountType;
        }

        public int AccountNumber { 
            get => _accountNmber;
            set { _accountNmber = value; }
        }
        public decimal AccountBalance {
            get => _accountBalance;
            set { _accountBalance = value; }
        }
        public TypeAccountEnum AccountType
        {
            get => _accountType;
            set { _accountType = value; }
        }

        private int SetAccountNumber() { return _countAccount++; }

        public void Transaction(BankAccount sender, decimal summa)
        {
            if (sender!.AccountBalance > summa)
            {
                AccountBalance = summa;
                sender.AccountBalance -= summa;
            }
        }
    }
}
