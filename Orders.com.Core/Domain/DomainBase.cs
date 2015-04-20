﻿using Facile.Core;
using System;
using System.Runtime.Serialization;
//using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace Orders.com.Core
{
    public abstract class DomainBase<TKey> : IDomainObject<TKey>
    {
        // TODO: Include Newtonsoft.json??
        //[JsonIgnore, IgnoreDataMember]
        [IgnoreDataMember]
        public abstract TKey ID { get; set; }

        //[Required] - TODO: require on update only
        public byte[] Version { get; set; }

        public string Self { get; set; }

        [Editable(false)]
        public int? CreatedBy { get; set; }

        [Editable(false)]
        public DateTime CreatedDatetime { get; set; }

        [Editable(false)]
        public int? LastModifiedBy { get; set; }

        [Editable(false)]
        public DateTime? LastModifiedDatetime { get; set; }
    }
}