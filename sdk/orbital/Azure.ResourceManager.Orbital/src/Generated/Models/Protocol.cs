// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Orbital.Models
{
    /// <summary> Protocol either UDP or TCP. </summary>
    public readonly partial struct Protocol : IEquatable<Protocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Protocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Protocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TCPValue = "TCP";
        private const string UDPValue = "UDP";

        /// <summary> TCP. </summary>
        public static Protocol TCP { get; } = new Protocol(TCPValue);
        /// <summary> UDP. </summary>
        public static Protocol UDP { get; } = new Protocol(UDPValue);
        /// <summary> Determines if two <see cref="Protocol"/> values are the same. </summary>
        public static bool operator ==(Protocol left, Protocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Protocol"/> values are not the same. </summary>
        public static bool operator !=(Protocol left, Protocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Protocol"/>. </summary>
        public static implicit operator Protocol(string value) => new Protocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Protocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Protocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
