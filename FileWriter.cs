using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace TransGenerator
{
    public class FileWriter
    {
        private int transactionCount = 0;
        private int transesPerPartition = 30000;
        private int fileSizeLimit = 17000000;

        private StringBuilder sb;
        private int fileCounter = 0;
        
        public string DirectoryPath { get; private set; }

        public FileWriter(string directoryPath)
        {
            sb = new StringBuilder();
            DirectoryPath = directoryPath;
        }

        private string GetFullFileName()
        {
            fileCounter++;
            string fileName = string.Format("InsertToAcrtrans_{0}_{1}.asq", DateTime.Now.ToString("ddMMyyyy"), fileCounter);
            return Path.Combine(DirectoryPath + @"\", fileName);
        }

        public void AddInsertStatements(List<Transaction> transactions, string table)
        {
            foreach (var t in transactions)
            {
                if(t.Reconciliation)
                {
                    sb.AppendLine(t.GetReconciliationASQ());
                    sb.AppendLine(@"/");
                }
                else
                {
                    sb.AppendLine(t.GetInsertASQ(table));
                    sb.AppendLine(@"/");
                }
                
                
            }
            transactionCount += transactions.Count;
            if (transactionCount >= transesPerPartition || sb.Length > fileSizeLimit)
            {
                SaveFile();
                sb = new StringBuilder();
                transactionCount = 0;

            }
        }
        public void SaveFile()
        {
            using (StreamWriter writer = new StreamWriter(GetFullFileName()))
            {
                writer.Write(sb.ToString());
            }
        }

  /*      public void WriteReconciliationDefinition(string fileName, Generator_config config)
        {
            string fullFileName = Path.Combine(DirectoryPath + @"\", fileName + ".asq");

        }
  */

    }
}
