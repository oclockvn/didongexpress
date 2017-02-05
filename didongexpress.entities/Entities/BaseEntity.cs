using System;

namespace didongexpress.entities
{
    public class BaseEntity
    {
        /// <summary>
        /// auto incre
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// used as primary key
        /// </summary>
        public Guid Key { get; set; }

        public bool IsActive { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }        
    }
}
