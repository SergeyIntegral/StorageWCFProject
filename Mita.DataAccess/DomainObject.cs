using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace Mita.DataAccess
{
    //[DataContract(IsReference = true)]
    public class DomainObject : IDomainObject, IEquatable<IDomainObject>
    {
        private static int _idCounter = 0;

        public DomainObject()
        {
            if (_idCounter < (int.MinValue + 100))
            {
                _idCounter = 0;
            }

            _idCounter--;
            Id = _idCounter;
        }
       // [DataMember]
        [Required]
        public virtual int Id { get; set; }
        //[DataMember]
        public virtual bool IsNew
        {
            get { return Id < 1; }
        }

        public override bool Equals(object obj)
        {
            var ido = obj as IDomainObject;
            return ido != null && Equals(ido);
        }

        public virtual bool Equals(IDomainObject other)
        {
            return other.GetType() == GetType() &&
                Id == other.Id;
        }

        public override int GetHashCode()
        {
            string hashString = string.Concat(GetType().FullName, "_", Id.ToString());
            return hashString.GetHashCode();
        }
    }
}
