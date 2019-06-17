using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.WriterFactoriesImpl
{
    public class WriterFactory : IWriterFactory
    {
        public IWriter CreateWriterJson()
        {
            return new WriterJson();
        }

        public IWriter CreateWriterTxt()
        {
            return new WriterTxt();
        }

        public IWriter CreateWriterXml()
        {
            return new WriterXml();
        }
    }
}
