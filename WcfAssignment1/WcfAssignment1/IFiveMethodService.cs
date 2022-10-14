using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfAssignment1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IFiveMethodService
    {
        [OperationContract]
        bool IsPrime(int primeNumber);

        [OperationContract]
        int SumOfDigits(int sumNumber);

        [OperationContract]
        string Reverse(string sReverse);

        [OperationContract]
        string HTMLTag(string tag, string txt);

        [OperationContract]
        string SortNumbers(string sortType, int num1, int num2, int num3, int num4, int num5);
    }
}
