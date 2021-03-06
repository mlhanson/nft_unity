﻿using NftUnity.Converters;
using Polkadot.BinarySerializer;
using Polkadot.DataStructs;

namespace NftUnity.Models.Collection
{
    public class ChangeOwner
    {
        [Serialize(0)] 
        public ulong CollectionId;

        [Serialize(1)] 
        [AddressConverter]
        public Address NewOwner = null!;

        public ChangeOwner()
        {
        }

        public ChangeOwner(ulong collectionId, Address newOwner)
        {
            CollectionId = collectionId;
            NewOwner = newOwner;
        }
    }
}