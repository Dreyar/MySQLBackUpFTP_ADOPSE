using MySQLBackUpFTP_ADOPSE.Work;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace MySQLBackUpFTP_ADOPSE
{
    public partial class RemoveDB : Form
    {
        private string db;
        private MainWindow mainWindow;

        public RemoveDB(string db,MainWindow mainWindow)
        {
            InitializeComponent();
            this.db = db;
            this.mainWindow = mainWindow;
            label1.Text = "Delete \""+db+"\"?";
            this.Visible = true;
        }

        private void RemoveDB_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            MainWindow.isRemoveDBOpen = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ArrayList databases = BinarySerialization.DeserializeArrayList(BinarySerialization.DATABASES_ARRAYLIST);
            if (databases!=null)
            {
                for (int i = 0; i < databases.Count; i++)
                {
                    Database database = (Database)databases[i];
                    if (database.GetAlias().Equals(db))
                    {
                        databases.RemoveAt(i);
                        break;
                    }
                }
                BinarySerialization.Serialize(databases,BinarySerialization.DATABASES_ARRAYLIST);
                mainWindow.RefreshDBList();
            }
            this.Close();
            MainWindow.isRemoveDBOpen = false;
        }
    }
}
