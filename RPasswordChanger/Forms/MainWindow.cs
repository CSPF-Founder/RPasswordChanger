using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPasswordChanger.Controller;
using RPasswordChanger.Model;
using System.IO;
using System.Configuration;
using System.Threading;

namespace RPasswordChanger.Forms
{
    public partial class MainWindow : Form
    {
        private ComputersListRetriever sysRetriever;

        public MainWindow()
        {
            InitializeComponent();
            this.displayComputerList();
        }

        private void getComputerListButton_Click(object sender, EventArgs e)
        {
            if (backgroundListRetriever.IsBusy)
            {
                Utils.displayError("List Retrieving Process already started");
            }
            else
            {
                if (!String.IsNullOrEmpty(domainTextBox.Text) && !String.IsNullOrEmpty(usernameTextBox.Text)
               && !String.IsNullOrEmpty(passwordTextBox.Text) && !String.IsNullOrEmpty(ipTextBox.Text))
                {
                    statusLabel.Text = "App is retrieving the Computers List From AD server..";
                    AppSession.Domain = domainTextBox.Text.Trim();
                    AppSession.UserName = usernameTextBox.Text.Trim();
                    AppSession.Password = passwordTextBox.Text.Trim();
                    AppSession.ServerIP = ipTextBox.Text.Trim();
                    backgroundListRetriever.RunWorkerAsync();
                }
                else
                {
                    Utils.displayError("Please Fill all the inputs");
                } 

                
            }
        }

        //Background Works:

        //Background work for retrieving computer list
        private void backgroundListRetriever_DoWork(object sender, DoWorkEventArgs e)
        {
            sysRetriever = new ComputersListRetriever();
            sysRetriever.retrieve();
        }
        private void backgroundListRetriever_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (sysRetriever != null )
            {
                if (sysRetriever.getError() == "")
                {
                    statusLabel.Text = "Successfully Retrieved";
                    this.displayComputerList();
                    mainTabControl.SelectedTab = passwordChangeTab;
                }
                else
                {
                    statusLabel.Text = "Last computer retrieval attempt failed!";
                    Utils.displayError(sysRetriever.getError());
                }
            }
            else
            {
                Utils.displayError("Unable to create Computer List Retriever object");
            }
        }

        private void mainTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentTabIndex = (sender as TabControl).SelectedIndex;
            switch (currentTabIndex)
            {//Based on current tab, do action

                case 0:
                    if (!String.IsNullOrWhiteSpace(AppSession.UserName))
                    {
                        adUsernameBox.Text = AppSession.UserName;
                    }
                    if (!String.IsNullOrWhiteSpace(AppSession.Password))
                    {
                        adPasswordBox.Text = AppSession.Password;
                    }
                    if (!String.IsNullOrWhiteSpace(AppSession.Domain))
                    {
                        adDomainBox.Text = AppSession.Domain;
                    }
                    break;
                case 1:
                  
                   if (!String.IsNullOrEmpty(AppSession.UserName))
                    {
                        usernameTextBox.Text = AppSession.UserName;
                    }
                    if (!String.IsNullOrEmpty(AppSession.Password))
                    {
                        passwordTextBox.Text = AppSession.Password;
                    }
                    if (!String.IsNullOrEmpty(AppSession.Domain))
                    {
                        domainTextBox.Text = AppSession.Domain;
                    }
                    if (!String.IsNullOrEmpty(AppSession.ServerIP))
                    {
                        ipTextBox.Text = AppSession.ServerIP;
                    }
                   break;
                case 2:
                    passwordsGridView.Rows.Clear();
                    passwordsGridView.Refresh();

                    RemoteUserTableHandler rUserHandler = new RemoteUserTableHandler();
                    List<RemoteUser> rUsers = rUserHandler.getAllRemoteUsers();
                    foreach (RemoteUser rUser in rUsers)
                    {
                        passwordsGridView.Rows.Add(rUser.getSystemName(), rUser.getUsername(), rUser.getPassword(), rUser.getModifiedDateStr(),rUser.getStatus());
                    }
                    break;
            }
        }

        public void displayComputerList()
        {
            //Clear Checkbox first:
            computersCheckBox.Items.Clear(); 

            //Display Systems list in checkbox
            RemoteSystemTableHandler rSystemHandler = new RemoteSystemTableHandler();
            if (rSystemHandler.getRowCount() > 0)
            {
                List<RemoteSystem> rSystems = rSystemHandler.getAllSystems();
                foreach (RemoteSystem rSystem in rSystems)
                {
                    if (rSystem.isIgnored())
                    {
                        computersCheckBox.Items.Add(rSystem.getSystemName(), false);
                    }
                    else
                    {
                        computersCheckBox.Items.Add(rSystem.getSystemName(), true);
                    }
                }
            }
                   
        }

        private void browseListButton_Click(object sender, EventArgs e)
        {
            this.loadListFromFile();
        }
        private void loadListFromFile()
        {
            //Load system's name from a file
            if (openListFileDialog.ShowDialog() == DialogResult.OK)
            {
                string srcFileName = openListFileDialog.FileName;

                using (StreamReader srcFile = new StreamReader(srcFileName))
                {
                    RemoteSystemTableHandler rSystemHandler = new RemoteSystemTableHandler();
                    string line;
                    while ((line = srcFile.ReadLine()) != null)
                    {
                        RemoteSystem rSystem = new RemoteSystem();
                        rSystem.setSystemName(line);
                        if (!rSystemHandler.exists(rSystem))
                        {
                            rSystemHandler.addSystem(rSystem);
                        }

                    }
                }
                this.displayComputerList();
                mainTabControl.SelectedTab = passwordChangeTab;
            }
        }
        private void adCredButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(adUsernameBox.Text) && !String.IsNullOrEmpty(adPasswordBox.Text)
                && !String.IsNullOrEmpty(adDomainBox.Text))
            {
                AppSession.UserName = adUsernameBox.Text.Trim();
                AppSession.Password = adPasswordBox.Text.Trim();
                AppSession.Domain = adDomainBox.Text.Trim();
            }
            else
            {
                Utils.displayError("Please Fill all the inputs");
            } 
        }

        private void changePasswordButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm changing the password?", "Confirm Password Change", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (!String.IsNullOrEmpty(adUsernameBox.Text) && !String.IsNullOrEmpty(adPasswordBox.Text)
               && !String.IsNullOrEmpty(adDomainBox.Text))
                {
                    AppSession.UserName = adUsernameBox.Text.Trim();
                    AppSession.Password = adPasswordBox.Text.Trim();
                    AppSession.Domain = adDomainBox.Text.Trim();
                    if (!passwordWorker.IsBusy)
                    {
                        statusLabel.Text = "Password Changing process is started. Please wait..";
                        passwordProgress.Value = 0;
                        passwordWorker.RunWorkerAsync();

                    }
                }
                else
                {
                    Utils.displayError("Please Give AD Details");
                }
            }
        }

        private void passwordWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Password changing function that runs in background without disrupting the GUI
            int checkedCount = computersCheckBox.CheckedItems.Count;
            int percentageInc = (100 / computersCheckBox.CheckedItems.Count);
            int percentageCompleted = 0;

            bool allAdmins = allAdminsRadio.Checked;

            RemoteUserTableHandler rUserHandler = new RemoteUserTableHandler();

            for (int i = 0; i < checkedCount; i++)
            {
                List<String> userAccounts = new List<String>();

                String target = (String)computersCheckBox.CheckedItems[i];
                if (allAdmins)
                {
                    userAccounts = Utils.getRemoteAdmins(target);
                }
                else
                {
                    userAccounts.Add("Administrator");
                }

                foreach (String username in userAccounts)
                {
                    String newPassword = this.passwordGenerate();
                    PasswordChanger rc = new PasswordChanger(target);
                    RemoteUser rUser = new RemoteUser();
                    rUser.setSystemName(target);
                    rUser.setUsername(username);

                    if (rc.change(username, newPassword))
                    {//Successfully changed the password
                        rUser.setPassword(newPassword);
                        if (rUserHandler.exists(rUser))
                        {
                            rUserHandler.updatePassword(rUser);
                        }
                        else
                        {
                            rUserHandler.addUser(rUser);
                        }
                    }
                    else
                    {//Fails to chang the password
                        rUser.setStatus(rc.getError());
                        if (rUserHandler.exists(rUser))
                        {
                            rUserHandler.updateStatus(rUser);
                        }
                        else
                        {
                            rUserHandler.addUser(rUser);
                        }
                    }
                }

                percentageCompleted = ((i + 1) * percentageInc);
                passwordWorker.ReportProgress(percentageCompleted);

                if (passwordWorker.CancellationPending)
                {
                    e.Cancel = true;
                    passwordWorker.ReportProgress(0);
                    return;
                }

                Thread.Sleep(100);
            }

            passwordWorker.ReportProgress(100);

        }

        private void passwordWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //Function to update progress bar
            passwordProgress.Value = e.ProgressPercentage;
        }

        private void passwordWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //Function that called password changing process is done
            if (e.Cancelled)
            {
                statusLabel.Text = "Password change cancelled ";
            }
            else if (e.Error != null)
            {
                Utils.displayError("ERROR" + e.Error.Message);
            }
            else
            {
                statusLabel.Text = "Password changing process is completed";
                this.mainTabControl.SelectedTab = passwordsTab;
            }
        }
        private string passwordGenerate()
        {
            return Utils.RandomPassword(this.getPasswordLength());
        }
        private int getPasswordLength()
        {

            int passwordLength = 12;
            try
            {
                String passLength = ConfigurationManager.AppSettings["password_length"];
                passwordLength = Int32.Parse(passLength);
            }
            catch (Exception e)
            {
                Utils.displayError("Invalid Password Length in App.config file ");
            }

            return passwordLength;
        }

        private void passwordsTabContextMenu_Click(object sender, EventArgs e)
        {
            //Users Export Function 
            exportFileDialog.Filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";
            if (exportFileDialog.ShowDialog() == DialogResult.OK)
            {
                string destFileName = exportFileDialog.FileName;
                if (RPasswordChanger.Model.Utils.isDirWritable(destFileName, false))
                {
                    using (StreamWriter file = new StreamWriter(destFileName))
                    {
                        file.WriteLine(
                               "\"System\","
                               + "\"Username\","
                               + "\"Password\","
                               + "\"Modified Date\"");
                        //Reading from Grid view
                        for (int row = 0; row < passwordsGridView.Rows.Count; row++)
                        {
                            file.WriteLine(
                               "\"" + passwordsGridView.Rows[row].Cells[0].Value.ToString() + "\","
                               + "\"" + passwordsGridView.Rows[row].Cells[1].Value.ToString() + "\","
                               + "\"" + passwordsGridView.Rows[row].Cells[2].Value.ToString() + "\","
                               + "\"" + passwordsGridView.Rows[row].Cells[3].Value.ToString() + "\"");
                        }
                    }
                }
                else
                {
                    MessageBox.Show(this, "Directory is not Writable", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.MinimizeBox = false;
            ab.MaximizeBox = false;
            ab.ShowDialog();
        }

        private void removeComputer_Click(object sender, EventArgs e)
        {
            //Delete system from the local list
            for(int i =0; i<computersCheckBox.CheckedItems.Count;i++)
            {
                object checkedItem = computersCheckBox.CheckedItems[i];
                RemoteSystem rSystem = new RemoteSystem();
                rSystem.setSystemName((String)checkedItem);
                computersCheckBox.Items.Remove(checkedItem);

                RemoteSystemTableHandler rsHandler = new RemoteSystemTableHandler();
                rsHandler.deleteSystem(rSystem);
            }

        }

        private void selectAllComputersCheckbox_Click(object sender, EventArgs e)
        {
            //To select or deselect all computers in the checkbox
            if(computersCheckBox.Items.Count != computersCheckBox.CheckedItems.Count)
            {
                selectAllComputersCheckbox.Checked = true;
                for (int i = 0; i < computersCheckBox.Items.Count; i++)
                {
                    computersCheckBox.SetItemChecked(i, true);
                }
            }
            else
            {
                selectAllComputersCheckbox.Checked = false;
                for (int i = 0; i < computersCheckBox.Items.Count; i++)
                {
                    computersCheckBox.SetItemChecked(i, false);
                }
            }
        }

        private void disableComputerButton_Click(object sender, EventArgs e)
        {
            //Ignore system in the local list
            CheckedListBox.CheckedItemCollection checkedItems = computersCheckBox.CheckedItems;
            foreach (object itemChecked in checkedItems)
            {
                RemoteSystem rSystem = new RemoteSystem();
                rSystem.setSystemName(itemChecked.ToString());
                RemoteSystemTableHandler rsHandler = new RemoteSystemTableHandler();
                rsHandler.setIgnoreFlag(rSystem, 1);
            }
        }

        private void enableComputerButton_Click(object sender, EventArgs e)
        {
            //Enable system in the local list
            CheckedListBox.CheckedItemCollection checkedItems = computersCheckBox.CheckedItems;
            foreach (object itemChecked in checkedItems)
            {
                RemoteSystem rSystem = new RemoteSystem();
                rSystem.setSystemName(itemChecked.ToString());
                RemoteSystemTableHandler rsHandler = new RemoteSystemTableHandler();
                rsHandler.setIgnoreFlag(rSystem, 0);
            }
        }

        private void loadListFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loadListFromFile();
        }
    }
}
