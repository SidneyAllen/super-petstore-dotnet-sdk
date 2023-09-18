// <copyright file="PetTypeEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace SuperPetstore.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Newtonsoft.Json;
    using SuperPetstore.Standard;
    using SuperPetstore.Standard.Utilities;

    /// <summary>
    /// PetTypeEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum PetTypeEnum
    {
        /// <summary>
        /// Dog.
        /// </summary>
        [EnumMember(Value = "dog")]
        Dog,

        /// <summary>
        /// Cat.
        /// </summary>
        [EnumMember(Value = "cat")]
        Cat
    }
}