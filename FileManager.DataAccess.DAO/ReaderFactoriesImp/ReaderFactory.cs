using FileManager.DataAccess.DAO.ReaderFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileManager.DataAccess.DAO.ReaderFactoriesImp
{
    class ReaderFactory : IReaderFactory
    {
        public IReader CreateReaderJson()
        {
            return new ReaderJson();
        }

        public IReader CreateReaderTxt()
        {
            return new ReaderTxt();
        }

        public IReader CreateReaderXml()
        {
            return new ReaderXml();
        }
    }
}
