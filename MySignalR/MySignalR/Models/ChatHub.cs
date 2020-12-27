using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace MySignalR.Models
{
    public class ChatHub : Hub
    {
        //public async Task Send(string nick, string message)
        //{
        //    await Clients.All.SendAsync("Send", nick, message);
        //}

        public async Task Send()
        {
            SqlConnection con = new SqlConnection("data source=.; database=MyDb; integrated security=SSPI");
            SqlCommand cm = new SqlCommand("Select * from Cards", con);
            con.Open();
            SqlDataReader sdr = cm.ExecuteReader();
            StringBuilder sb = new StringBuilder();
            while (sdr.Read())
            {
                sb.Append(sdr["Title"]);
            }

            con.Close();

            await Clients.All.SendAsync("Send", sb.ToString());
        }
    }
}
