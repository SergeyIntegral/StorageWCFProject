using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Mita.DataAccess
{
    [DebuggerDisplay("[{Id}] {Number}")]
    //[DataContract(IsReference = true)]
    public class NamedDomainObject : DomainObject
    {
        //[DataMember]
        [Required]
        public virtual int Number { get; set; }

        
    }
}
