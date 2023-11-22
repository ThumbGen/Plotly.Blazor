/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib
{
    /// <summary>
    ///     The UniformText class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class UniformText : IEquatable<UniformText>
    {
        /// <summary>
        ///     Sets the minimum text size between traces of the same type.
        /// </summary>
        [JsonPropertyName(@"minsize")]
        public decimal? MinSize { get; set;} 

        /// <summary>
        ///     Determines how the font size for various text elements are uniformed between
        ///     each trace type. If the computed text sizes were smaller than the minimum
        ///     size defined by <c>uniformtext.minsize</c> using <c>hide</c> option hides
        ///     the text; and using <c>show</c> option shows the text without further downscaling.
        ///     Please note that if the size defined by <c>minsize</c> is greater than the
        ///     font size defined by trace, then the <c>minsize</c> is used.
        /// </summary>
        [JsonPropertyName(@"mode")]
        public Plotly.Blazor.LayoutLib.UniformTextLib.ModeEnum? Mode { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is UniformText other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] UniformText other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    MinSize == other.MinSize ||
                    MinSize != null &&
                    MinSize.Equals(other.MinSize)
                ) && 
                (
                    Mode == other.Mode ||
                    Mode != null &&
                    Mode.Equals(other.Mode)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (MinSize != null) hashCode = hashCode * 59 + MinSize.GetHashCode();
                if (Mode != null) hashCode = hashCode * 59 + Mode.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left UniformText and the right UniformText.
        /// </summary>
        /// <param name="left">Left UniformText.</param>
        /// <param name="right">Right UniformText.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (UniformText left, UniformText right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left UniformText and the right UniformText.
        /// </summary>
        /// <param name="left">Left UniformText.</param>
        /// <param name="right">Right UniformText.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (UniformText left, UniformText right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>UniformText</returns>
        public UniformText DeepClone()
        {
            return this.Copy();
        }
    }
}