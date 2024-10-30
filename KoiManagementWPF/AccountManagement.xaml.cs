using BusinessObjects.Entities;
using Services;
using Services.Impl;
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

namespace KoiManagementWPF
{
    /// <summary>
    /// Interaction logic for AccountManagement.xaml
    /// </summary>
    public partial class AccountManagement : Window
    {
        private readonly AccountService _accountService;
        private readonly RoleService _roleService; // Add RoleService

        public AccountManagement()
        {
            InitializeComponent();
            _accountService = new AccountServiceImpl();
            _roleService = new RoleServiceImpl();

            LoadAccounts();
            LoadRoles(); // Load roles into ComboBox
        }

        private void LoadAccounts()
        {
            try
            {
                var accounts = _accountService.GetAllAccounts();
                AccountGrid.ItemsSource = accounts;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading accounts: {ex.Message}");
            }
        }

        private void LoadRoles()
        {
            try
            {
                var roles = _roleService.GetAllRoles();
                cbbRole.ItemsSource = roles;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading roles: {ex.Message}");
            }
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                    string.IsNullOrWhiteSpace(txtPassword.Text) ||
                    string.IsNullOrWhiteSpace(txtEmail.Text) ||
                    cbbRole.SelectedValue == null)
                {
                    MessageBox.Show("Please fill out all fields correctly.");
                    return;
                }

                var account = new Account
                {
                    Username = txtUsername.Text,
                    Email = txtEmail.Text,
                    PasswordHash = txtPassword.Text,
                    RoleId = (int)cbbRole.SelectedValue // Get selected RoleId
                };

                bool isAdded = _accountService.AddAccount(account);

                if (isAdded)
                {
                    MessageBox.Show("Account added successfully!");
                    LoadAccounts();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Failed to add account.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void UpdateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AccountGrid.SelectedItem is Account selectedAccount)
                {
                    if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                        string.IsNullOrWhiteSpace(txtEmail.Text) ||
                        cbbRole.SelectedValue == null)
                    {
                        MessageBox.Show("Please fill out all fields correctly.");
                        return;
                    }

                    selectedAccount.Username = txtUsername.Text;
                    selectedAccount.Email = txtEmail.Text;
                    selectedAccount.RoleId = (int)cbbRole.SelectedValue;

                    _accountService.UpdateAccount(selectedAccount);
                    MessageBox.Show("Account updated successfully!");
                    LoadAccounts();
                    ClearInputFields();
                }
                else
                {
                    MessageBox.Show("Please select an account to update.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (AccountGrid.SelectedItem is Account selectedAccount)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete '{selectedAccount.Username}'?",
                        "Confirm Deletion", MessageBoxButton.YesNo, MessageBoxImage.Warning);

                    if (result == MessageBoxResult.Yes)
                    {
                        bool deleted = _accountService.DeleteAccount(selectedAccount.AccountId);
                        MessageBox.Show("Account deleted successfully!");
                        LoadAccounts();
                        ClearInputFields();
                    }
                }
                else
                {
                    MessageBox.Show("Please select an account to delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void ClearInputFields()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtEmail.Clear();
            cbbRole.SelectedIndex = -1; // Clear ComboBox selection
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            AdminDashboard adminDashboard = new AdminDashboard();
            adminDashboard.Show();
            this.Hide();
        }


        private void AccountGrid_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            if (AccountGrid.SelectedItem is Account selectedAccount)
            {
                txtUsername.Text = selectedAccount.Username;
                txtEmail.Text = selectedAccount.Email;
                cbbRole.SelectedValue = selectedAccount.RoleId;
                txtPassword.Text = selectedAccount.PasswordHash;
            }
        }
    }
}
