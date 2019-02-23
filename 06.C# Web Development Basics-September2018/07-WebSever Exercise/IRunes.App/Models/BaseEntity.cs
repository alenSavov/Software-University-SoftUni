using System;
using System.Collections.Generic;
using System.Text;

namespace IRunes.App.Models
{
    public abstract class BaseEntity<TKeyIdentifier>
    {
        public TKeyIdentifier Id { get; set; }
    }
}
