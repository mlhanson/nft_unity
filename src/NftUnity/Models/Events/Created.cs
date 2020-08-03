﻿using NftUnity.Models.Collection.CollectionModeEnum;
using Polkadot.BinaryContracts.Events;
using Polkadot.BinarySerializer;
using Polkadot.DataStructs;

namespace NftUnity.Models.Events
{
    public class Created : IEvent
    {
        [Serialize(0)]
        public ulong Id;

        [Serialize(1)]
        public CollectionMode Mode = null!;

        [Serialize(2)]
        public PublicKey Account = null!;

        public Created()
        {
        }

        public Created(ulong id, CollectionMode mode, PublicKey account)
        {
            Id = id;
            Account = account;
            Mode = mode;
        }
    }
}