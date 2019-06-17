using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO
{
    interface IWriterFactory
    {
        IWriter CreateWriterTxt();
        IWriter CreateWriterXml();
        IWriter CreateWriterJson();
    }
}
