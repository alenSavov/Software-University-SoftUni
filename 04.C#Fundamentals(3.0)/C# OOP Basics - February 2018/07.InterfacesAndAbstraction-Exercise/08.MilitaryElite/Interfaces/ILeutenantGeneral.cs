using System;
using System.Collections.Generic;
using System.Text;


public interface ILeutenantGeneral : IPrivate
{
    IList<IPrivate> Privates { get; }
}

