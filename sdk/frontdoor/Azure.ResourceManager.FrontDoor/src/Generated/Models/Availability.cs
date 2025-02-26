// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Indicates whether the name is available. </summary>
    public readonly partial struct Availability : IEquatable<Availability>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Availability"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Availability(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailableValue = "Available";
        private const string UnavailableValue = "Unavailable";

        /// <summary> Available. </summary>
        public static Availability Available { get; } = new Availability(AvailableValue);
        /// <summary> Unavailable. </summary>
        public static Availability Unavailable { get; } = new Availability(UnavailableValue);
        /// <summary> Determines if two <see cref="Availability"/> values are the same. </summary>
        public static bool operator ==(Availability left, Availability right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Availability"/> values are not the same. </summary>
        public static bool operator !=(Availability left, Availability right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Availability"/>. </summary>
        public static implicit operator Availability(string value) => new Availability(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Availability other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Availability other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
