using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public interface IPrint
    {
        void Print(string content);
    }

    public interface IScan
    {
        void Scan(string content);
    }

    public interface IFax
    {
        void Fax(string content);
    }

    public interface IStaple
    {
        void Staple(string content);
    }

}
