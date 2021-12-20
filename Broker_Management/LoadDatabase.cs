using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Broker_Management
{
    public class LoadDatabase
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=F:\Development\Visual_Studio\Brokerage\Database\BrokerDbase.mdf;Integrated Security=True;Connect Timeout=30");
       
    }
}
