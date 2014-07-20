using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        Profile Login(string username, string password, string deviceToken);

        [OperationContract]
        Profile Login1(string username, string password, string deviceToken);

        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    [DataContract]
    public class Profile
    {
        [DataMember]
        public int UserId { get; set; }

        [DataMember]
        public int ErrorCode { get; set; }

        [DataMember]
        public string ErrorText { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string Phone { get; set; }

        [DataMember]
        public string Mobile { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string Passport { get; set; }
    }
}
