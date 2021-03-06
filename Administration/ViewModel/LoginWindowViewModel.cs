using System;
using System.ComponentModel;
using System.Data;
using System.Windows;
using Administration.Interfaces;
using Administration.Properties;
using DataAccess;
using DataAccess.Connection;
using DataAccess.Model;

namespace Administration.ViewModel
{
    public class LoginWindowViewModel
    {
        private readonly BackgroundWorker checkConnectionWorker;
        private readonly ILoginWindow view;
        
        public LoginWindowViewModel(ILoginWindow view)
        {
            this.view = view;
            
            Server = Settings.Default.server;
            Database = Settings.Default.database;
            User = Settings.Default.user;
            Password = Settings.Default.password;

            checkConnectionWorker = new BackgroundWorker();
            checkConnectionWorker.DoWork += CheckConnectionWorkerOnDoWork;
        }

        public string Server { get; set; }
        public string Database { get; set; }
        public string User { get; set; }

        public string Password
        {
            get { return view.Password; }
            set { view.Password = value; }
        }

        private void CheckConnectionWorkerOnDoWork(object sender, DoWorkEventArgs doWorkEventArgs)
        {
            var connectionString = ConnectionStringBuilder.Build(Server, Database, User, Password);

            var executor = new CommandExecutor("dbo.CurrentRole", connectionString);
            var result = executor.ExecuteCommand();

            view.Dispatcher.Invoke(() =>
            {
                view.IndicateConnectingFinished();

                var exception = result as Exception;
                if (exception != null)
                {
                    MessageBox.Show(exception.Message);
                    return;
                }

                try
                {
                    var userTypeId = (result as DataSet).Tables[0].Rows[0].ItemArray[0].ToInt();
                    Settings.Default.currentRole = (UserType) (userTypeId - 1);

                    if (Settings.Default.currentRole == UserType.User)
                    {
                        throw new Exception();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(Resources.InvalidUserMessageText);
                    return;
                }

                Settings.Default.server = Server;
                Settings.Default.database = Database;
                Settings.Default.user = User;
                Settings.Default.password = Password;
                Settings.Default.Save();

                view.IndicateSuccess();
            });
        }

        public void CheckConnection()
        {
            view.IndicateConnecting();
            checkConnectionWorker.RunWorkerAsync();
        }
    }
}