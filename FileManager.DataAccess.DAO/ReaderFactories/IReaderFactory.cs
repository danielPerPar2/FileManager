using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.ReaderFactories
{
    interface IReaderFactory
    {
        IReader CreateReaderTxt();
        IReader CreateReaderXml();
        IReader CreateReaderJson();
    }
}
