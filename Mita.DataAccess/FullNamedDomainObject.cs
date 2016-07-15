using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Serialization;
using Mita.Core;

namespace Mita.DataAccess
{
    //[DebuggerDisplay("[{Id}] {FullName}")]
    //[DataContract(IsReference = true)]
    public class FullNamedDomainObject : DomainObject
    {
       // [DataMember]
        [Required]
        public virtual string Adress { get; set; }
       // [DataMember]
        public virtual string Name { get; set; }
        //[DataMember]
        [Required]
        public virtual string PostIndex { get; set; }

        
    }
}
