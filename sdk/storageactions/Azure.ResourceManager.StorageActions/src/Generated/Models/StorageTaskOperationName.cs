// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageActions.Models
{
    /// <summary> The operation to be performed on the object. </summary>
    public readonly partial struct StorageTaskOperationName : IEquatable<StorageTaskOperationName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="StorageTaskOperationName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public StorageTaskOperationName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SetBlobTierValue = "SetBlobTier";
        private const string SetBlobTagsValue = "SetBlobTags";
        private const string SetBlobImmutabilityPolicyValue = "SetBlobImmutabilityPolicy";
        private const string SetBlobLegalHoldValue = "SetBlobLegalHold";
        private const string SetBlobExpiryValue = "SetBlobExpiry";
        private const string DeleteBlobValue = "DeleteBlob";
        private const string UndeleteBlobValue = "UndeleteBlob";

        /// <summary> SetBlobTier. </summary>
        public static StorageTaskOperationName SetBlobTier { get; } = new StorageTaskOperationName(SetBlobTierValue);
        /// <summary> SetBlobTags. </summary>
        public static StorageTaskOperationName SetBlobTags { get; } = new StorageTaskOperationName(SetBlobTagsValue);
        /// <summary> SetBlobImmutabilityPolicy. </summary>
        public static StorageTaskOperationName SetBlobImmutabilityPolicy { get; } = new StorageTaskOperationName(SetBlobImmutabilityPolicyValue);
        /// <summary> SetBlobLegalHold. </summary>
        public static StorageTaskOperationName SetBlobLegalHold { get; } = new StorageTaskOperationName(SetBlobLegalHoldValue);
        /// <summary> SetBlobExpiry. </summary>
        public static StorageTaskOperationName SetBlobExpiry { get; } = new StorageTaskOperationName(SetBlobExpiryValue);
        /// <summary> DeleteBlob. </summary>
        public static StorageTaskOperationName DeleteBlob { get; } = new StorageTaskOperationName(DeleteBlobValue);
        /// <summary> UndeleteBlob. </summary>
        public static StorageTaskOperationName UndeleteBlob { get; } = new StorageTaskOperationName(UndeleteBlobValue);
        /// <summary> Determines if two <see cref="StorageTaskOperationName"/> values are the same. </summary>
        public static bool operator ==(StorageTaskOperationName left, StorageTaskOperationName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="StorageTaskOperationName"/> values are not the same. </summary>
        public static bool operator !=(StorageTaskOperationName left, StorageTaskOperationName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="StorageTaskOperationName"/>. </summary>
        public static implicit operator StorageTaskOperationName(string value) => new StorageTaskOperationName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is StorageTaskOperationName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(StorageTaskOperationName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
