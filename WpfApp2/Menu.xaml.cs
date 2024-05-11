using LibraryBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        Bank bank = new Bank("MyBank");
        AutomatedTellerMachine atm;
        List<Account> accounts;
        string cardNumber;
        DatabaseHelper databaseHelper;
        private Account clientAccount;
        public Menu(string cardNumber, List<Account> accounts, AutomatedTellerMachine atm, DatabaseHelper databaseHelper)
        {
            InitializeComponent();

            this.cardNumber = cardNumber;
            this.accounts = accounts;
            this.atm = atm;
            this.databaseHelper = databaseHelper;
            this.clientAccount = clientAccount;
        }
    }
}
