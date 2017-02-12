using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


using Xamarin.Forms;

namespace Conntest
{
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}

        void Login_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Worked", "worked", "OK");
            //new I18N.West.CP1250();

            MySqlConnection conn;

            conn = new MySql.Data.MySqlClient.MySqlConnection("Server=54.215.148.52; Port=3306; Database=sql3158647; Uid=sql3158647; Pwd=jVWM7BrzzU;");

            try
            {

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                    Output.Text = "SUCCESS CONNECT";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Output.Text = ex.ToString();
            }
            finally
            {
                conn.Close();
            }

        }
	}
}
