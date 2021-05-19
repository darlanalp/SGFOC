using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SqlServer.Management.Sdk.Sfc;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer;
using System.IO;


namespace SGFOC
{
    public static class BackupSQL
    {
        public static void BackupBanco(string caminho, string dataBase)
        {            
            Server svr = new Server();            
            Backup bkp = new Backup();
            bkp.Devices.AddDevice(caminho, DeviceType.File);
            bkp.Database = dataBase;
            bkp.Action = BackupActionType.Database;
            bkp.Initialize = true;
            bkp.PercentCompleteNotification = 10;
            bkp.PercentComplete += new PercentCompleteEventHandler(bkp_PercentComplete);
            bkp.SqlBackup(svr);
        }

        static void bkp_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            Console.WriteLine(e.Percent.ToString() + "% backed up");
        }
    }
}

