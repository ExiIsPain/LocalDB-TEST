using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

       private void LoginBT_Click(object sender, EventArgs e)
        {
            
            string connstr;
            SqlConnection conn;
            connstr = $@"Data Source=DESKTOP-5TD5E74\SQLEXPRESS;Integrated Security = false;User ID={usrnameTB.Text};Password={passwordTB.Text}";
            DataTable dt = new DataTable();
            conn = new SqlConnection(connstr);
            conn.Open();
            try
            {

                SqlCommand cmd = new SqlCommand("INSERT INTO dbo.Login(Username, Password) VALUES  ('Me', 'You');", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Inserting Data Successfully");
                conn.Close();
            }
            catch (Exception err)
            {

                MessageBox.Show("You done " +err);
            }




                /*using (SqlBulkCopy sbc = new SqlBulkCopy(connstr, SqlBulkCopyOptions.KeepIdentity))
                {
                    sbc.DestinationTableName = "dbo.Login";
                    sbc.ColumnMappings.Add("ID", "1");
                    sbc.ColumnMappings.Add("Username", "Username");
                    sbc.ColumnMappings.Add("Password", "Password");
                   // Debugger.Break();
                    
                    sbc.WriteToServer(dt);

                    MessageBox.Show("CG");
                  */






       }
            
            
      

        public void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var Filestream = openFileDialog.OpenFile();

                using (StreamReader reader = new StreamReader(Filestream))
                {
                    string  _obsah = reader.ReadToEnd();
                    string[] obsah = _obsah.Split(new char[] {'\n', '\t'});
                }
                

            }
            Debugger.Break();
            

        }
        
 
    }
}
