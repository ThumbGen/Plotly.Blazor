/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.Traces.Scatter3DLib.ProjectionLib
{
    /// <summary>
    ///     The Z class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class Z : IEquatable<Z>
    {
        /// <summary>
        ///     Sets the projection color.
        /// </summary>
        [JsonPropertyName(@"opacity")]
        public decimal? Opacity { get; set;} 

        /// <summary>
        ///     Sets the scale factor determining the size of the projection marker points.
        /// </summary>
        [JsonPropertyName(@"scale")]
        public decimal? Scale { get; set;} 

        /// <summary>
        ///     Sets whether or not projections are shown along the z axis.
        /// </summary>
        [JsonPropertyName(@"show")]
        public bool? Show { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is Z other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] Z other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    Opacity == other.Opacity ||
                    Opacity != null &&
                    Opacity.Equals(other.Opacity)
                ) && 
                (
                    Scale == other.Scale ||
                    Scale != null &&
                    Scale.Equals(other.Scale)
                ) && 
                (
                    Show == other.Show ||
                    Show != null &&
                    Show.Equals(other.Show)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Opacity != null) hashCode = hashCode * 59 + Opacity.GetHashCode();
                if (Scale != null) hashCode = hashCode * 59 + Scale.GetHashCode();
                if (Show != null) hashCode = hashCode * 59 + Show.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (Z left, Z right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left Z and the right Z.
        /// </summary>
        /// <param name="left">Left Z.</param>
        /// <param name="right">Right Z.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (Z left, Z right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>Z</returns>
        public Z DeepClone()
        {
            return this.Copy();
        }
    }
}