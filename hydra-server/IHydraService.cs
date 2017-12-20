using System;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Hydra
{
    [ServiceContract]
    public interface IHydraService
    {

        [OperationContract]
        [WebGet(UriTemplate="myfirstget", ResponseFormat = WebMessageFormat.Json)]
        string GetData();

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);
    }


    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
