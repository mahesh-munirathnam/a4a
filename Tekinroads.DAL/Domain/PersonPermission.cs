namespace Tekinroads.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PersonPermission")]
    public partial class PersonPermission
    {
        public long PersonPermissionId { get; set; }

        public long PersonId { get; set; }

        public long PermissionId { get; set; }

        public long CreatedBy { get; set; }

        public long ModifiedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual Permission Permission { get; set; }

        public virtual Person Person { get; set; }
    }
}
