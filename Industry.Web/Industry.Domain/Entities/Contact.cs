﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Industry.Domain.Entities
{
    public class Contact : EntityCatalog
    {
        public Contact()
        {
            IsActive = true;
        }

        [Required] [MaxLength(100)]
        public string Name { get; set; }

        [MaxLength(100)]
        public string LastName { get; set; }

        [MaxLength(100)]
        public string MiddleName { get; set; }
        public DateTime? BirthDate { get; set; }

        [MaxLength(100)]
        public string Position { get; set; }

        public byte[] Image { get; set; }

        [MaxLength(150)]
        public string Descr { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<ContactInfo> ContactInfos { get; set; }
    }
}
