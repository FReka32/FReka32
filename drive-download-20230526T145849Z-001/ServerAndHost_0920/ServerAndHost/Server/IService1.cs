using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Server
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgyGalambAdatai/")
            ]
        Galamb EgyGalambGet();

        [OperationContract]
        Galamb EgyGalambGetCS();

        [OperationContract]
        Galamb EgyGalambPostCS();

        [OperationContract]
        [WebInvoke(Method = "POST",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/EgyGalambHozzaAdas/")
            ]
        Galamb EgyGalambPost();

        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.WrappedRequest,
            UriTemplate = "/GalambLista/")
            ]
        List<Galamb> GalambLista();

    }

    [DataContract]

    public class Record
    {
        [DataMember]
        public int? ID { get; set; }
    }

    [DataContract]

    public class Galamb:Record
    {
        [DataMember]

        public string Nev { get; set; }

        [DataMember]

        public string Gazda { get; set; }

        [DataMember]

        public byte Eletkor { get; set; }

        [DataMember]

        public string Fajta { get; set; }

        [DataMember(IsRequired = true)]
        
        public bool? Nem { get; set; }

        [DataMember]

        public byte LabakSzama  { get; set; }

    }
    
}
