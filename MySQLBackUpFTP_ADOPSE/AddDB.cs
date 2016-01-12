using MySQLBackUpFTP_ADOPSE.Work;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class AddDB : Form
    {
        private Database db;
        private MainWindow mainWindow;

        public AddDB(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            db = new Database();
            db.RaiseConnectionSuccessful += new Database.ConnectionSuccessful(db_OnConnectionSuccessful);
            db.RaiseConnectionUnsuccessful += new Database.ConnectionUnsuccessful(db_OnConnectionUnsuccessful);
            this.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            waitP.Visible = true;
            db.SetBasics(hostTB.Text,databaseTB.Text,(short)portNUD.Value,usernameTB.Text,passwordTB.Text,requireSSLCB.Checked,true);
            db.CheckConnection();
        }

        private void db_OnConnectionSuccessful()
        {
            object[] p = new object[0];
            BeginInvoke(new Database.ConnectionSuccessful(ConnectionSucceeded), p);
        }

        private void db_OnConnectionUnsuccessful()
        {
            object[] p = new object[0];
            BeginInvoke(new Database.ConnectionUnsuccessful(ConnectionFailed),p);
        }

        private void ConnectionSucceeded()
        {
            ConnectionChecked(true);
        }

        private void ConnectionFailed()
        {
            ConnectionChecked(false);
        }

        private void ConnectionChecked(bool result)
        {
            if (result)
            {
                panel1.Enabled = false;
                panel2.Enabled = true;
                okB.Enabled = true;
                noConnectionL.Visible = false;
                aliasTB.Focus();
            }
            else
            {
                noConnectionL.Visible = true;
            }
            waitP.Visible = false;
        }

        private void okB_Click(object sender, EventArgs e)
        {
            bool inUseFlag = false;
            if (aliasTB.Text.Length >= 3)
            {
                invalidAliasL.Visible = false;
                db.SetAlias(aliasTB.Text);
                ArrayList databases = BinarySerialization.DeserializeArrayList(BinarySerialization.DATABASES_ARRAYLIST);
                if (databases!=null){
                    for (int i = 0; i < databases.Count; i++)
                    {
                        Database temp =(Database) databases[i];
                        if (temp.GetAlias().Equals(aliasTB.Text))
                            inUseFlag = true;
                    }
                }
                else
                {
                    databases = new ArrayList();
                }
                if (!inUseFlag)
                {
                    usedAliasL.Visible = false;
                    databases.Add(db);
                    BinarySerialization.Serialize(databases, BinarySerialization.DATABASES_ARRAYLIST);
                    mainWindow.RefreshDBList();
                    this.Close();
                    MainWindow.isAddDBOpen = false;
                }
                else
                    usedAliasL.Visible = true;
            }
            else
            {
                usedAliasL.Visible = false;
                invalidAliasL.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isAddDBOpen = false;
        }

        private void AddDB_Load(object sender, EventArgs e)
        {

        }
    }
}
