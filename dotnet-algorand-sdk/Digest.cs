﻿using Newtonsoft.Json;
using System;
using System.Linq;

namespace Algorand
{
    /// <summary>
    /// A serializable class representing a SHA512-256 Digest
    /// </summary>
    [JsonConverter(typeof(BytesConverter))]
    public class Digest
    {
        private static int DIG_LEN_BYTES = 32;
        public byte[] Bytes { get; private set; }
        /// <summary>
        /// Create a new digest.
        /// </summary>
        /// <param name="bytes">a length 32 byte array</param>
        [JsonConstructor]
        public Digest(byte[] bytes)
        {
            if (bytes == null)
            {
                return;
            }
            if (bytes.Length != DIG_LEN_BYTES)
            {
                throw new ArgumentException("digest wrong length");
            }
            Bytes = bytes;
        }
        /// <summary>
        /// default values for serializer to ignore
        /// </summary>
        public Digest()
        {
            Bytes = new byte[DIG_LEN_BYTES];
        }

        public override bool Equals(object obj)
        {
            if (obj is Digest && Enumerable.SequenceEqual(this.Bytes, ((Digest)obj).Bytes)) {
                return true;
            } else {
                return false;
            }
        }
        public override int GetHashCode()
        {
            return this.Bytes.GetHashCode();
        }
    }    
}