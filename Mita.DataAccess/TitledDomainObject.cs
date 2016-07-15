using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.Serialization;

namespace Mita.DataAccess
{
    //[DataContract(IsReference = true)]
    [DebuggerDisplay("[{Id}] {ProductName}")]

    public class TitledDomainObject : DomainObject
    {
        //[DataMember]
        [Required]
        public virtual string ProductName { get; set; }

        
        public override string ToString()
        {
            return ProductName;
        }
    }
}
