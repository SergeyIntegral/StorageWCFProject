using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Storage.WCF
{
    public class ReferencePreservingProxyDataContractSerializerOperationBehavior
    : DataContractSerializerOperationBehavior
    {
        public ReferencePreservingProxyDataContractSerializerOperationBehavior(
          OperationDescription operationDescription)
            : base(operationDescription)
        { }
        public override XmlObjectSerializer CreateSerializer(
          Type type, string name, string ns, IList<Type> knownTypes)
        {
            return CreateDataContractSerializer(type, name, ns, knownTypes);
        }

        private static XmlObjectSerializer CreateDataContractSerializer(
          Type type, string name, string ns, IList<Type> knownTypes)
        {
            return CreateDataContractSerializer(type, name, ns, knownTypes);
        }

        public override XmlObjectSerializer CreateSerializer(
          Type type, XmlDictionaryString name, XmlDictionaryString ns,
          IList<Type> knownTypes)
        {
            return new DataContractSerializer(type, name, ns, knownTypes,
                0x7FFF /*maxItemsInObjectGraph*/,
                false/*ignoreExtensionDataObject*/,
                true/*preserveObjectReferences*/,
                null/*dataContractSurrogate*/,
                new ProxyDataContractResolver());
        }
    }

}
