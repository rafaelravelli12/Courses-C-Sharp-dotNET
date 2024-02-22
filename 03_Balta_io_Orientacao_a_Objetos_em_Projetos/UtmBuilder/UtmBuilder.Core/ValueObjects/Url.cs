using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.ValueObjects
{
    public class Url : ValueObject
    {
        /// <summary>
        /// Create a new URL
        /// <param name="address">Address of URL (Website link)</param>
        /// </summary>
        public Url(string address)
        {
            Address = address;
            InvalidUrlException.ThrowIfInvalid(address);
        }

        public string Address { get; }
    }
}
