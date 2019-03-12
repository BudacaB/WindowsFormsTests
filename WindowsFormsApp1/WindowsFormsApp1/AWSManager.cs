using Amazon.DynamoDBv2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class AWSManager
    {
        public AWSManager()
        {
            AmazonDynamoDBConfig clientConfig = new AmazonDynamoDBConfig();
            clientConfig.ServiceURL = "http://127.0.0.1:8000";
            clientConfig.Timeout = TimeSpan.FromSeconds(1);
            clientConfig.MaxErrorRetry = 1;
            AmazonDynamoDBClient client = new AmazonDynamoDBClient(clientConfig);
            var tables = client.ListTables();
        }
    }
}
