using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PersonalAccounting.Domain.Entity
{
    /// <summary>
    /// Base class for entities
    /// </summary>
    public partial class BaseEntity
    {
        /// <summary>
        /// Gets or sets the entity identifier
        /// </summary>
        public int Id { get; set; }
        public int? CreatedBy { get; set; }
        [ForeignKey("CreatedBy")]
        public virtual User SelfUser { get; protected set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? LastUpdate { get; set; }
        public int? UpdateBy { get; set; }
        [ForeignKey("UpdateBy")]
        public virtual User UpdateUser { get; protected set; }
        [DefaultValue(false)]
        public bool? IsDeleted { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }

        [ConcurrencyCheck]
        public byte[] Concurrency { get; set; }


        public override bool Equals(object obj)
        {
            return Equals(obj as BaseEntity);
        }
        private static bool IsTransient(BaseEntity obj)
        {
            return obj != null && Equals(obj.Id, default(int));
        }
        private Type GetUnProxiedType()
        {
            return GetType();
        }
        public virtual bool Equals(BaseEntity other)
        {
            if (other == null)
                return false;

            if (ReferenceEquals(this, other))
                return true;

            if (!IsTransient(this) &&
                !IsTransient(other) &&
                Equals(Id, other.Id))
            {
                var otherType = other.GetUnProxiedType();
                var thisType = GetUnProxiedType();
                return thisType.IsAssignableFrom(otherType) ||
                       otherType.IsAssignableFrom(thisType);
            }
            return false;
        }
        public override int GetHashCode()
        {
            if (Equals(Id, default(int)))
                // ReSharper disable BaseObjectGetHashCodeCallInGetHashCode
                return base.GetHashCode();
            // ReSharper restore BaseObjectGetHashCodeCallInGetHashCode
            return Id.GetHashCode();
        }
        public static bool operator ==(BaseEntity x, BaseEntity y)
        {
            return Equals(x, y);
        }
        public static bool operator !=(BaseEntity x, BaseEntity y)
        {
            return !(x == y);
        }
    }
}
