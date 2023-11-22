/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;

namespace Plotly.Blazor.LayoutLib.GeoLib
{
    /// <summary>
    ///     The LaTaxis class.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [Serializable]
    public class LaTaxis : IEquatable<LaTaxis>
    {
        /// <summary>
        ///     Sets the graticule&#39;s longitude/latitude tick step.
        /// </summary>
        [JsonPropertyName(@"dtick")]
        public decimal? DTick { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s stroke color.
        /// </summary>
        [JsonPropertyName(@"gridcolor")]
        public object GridColor { get; set;} 

        /// <summary>
        ///     Sets the dash style of lines. Set to a dash type string (<c>solid</c>, <c>dot</c>,
        ///     <c>dash</c>, <c>longdash</c>, <c>dashdot</c>, or <c>longdashdot</c>) or
        ///     a dash length list in px (eg <c>5px,10px,2px,2px</c>).
        /// </summary>
        [JsonPropertyName(@"griddash")]
        public string GridDash { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s stroke width (in px).
        /// </summary>
        [JsonPropertyName(@"gridwidth")]
        public decimal? GridWidth { get; set;} 

        /// <summary>
        ///     Sets the range of this axis (in degrees), sets the map&#39;s clipped coordinates.
        /// </summary>
        [JsonPropertyName(@"range")]
        public IList<object> Range { get; set;} 

        /// <summary>
        ///     Sets whether or not graticule are shown on the map.
        /// </summary>
        [JsonPropertyName(@"showgrid")]
        public bool? ShowGrid { get; set;} 

        /// <summary>
        ///     Sets the graticule&#39;s starting tick longitude/latitude.
        /// </summary>
        [JsonPropertyName(@"tick0")]
        public decimal? Tick0 { get; set;} 

        /// <inheritdoc />
        public override bool Equals(object obj)
        {
            if (!(obj is LaTaxis other)) return false;

            return ReferenceEquals(this, obj) || Equals(other);
        }

        /// <inheritdoc />
        public bool Equals([AllowNull] LaTaxis other)
        {
            if (other == null) return false;
            if (ReferenceEquals(this, other)) return true;

            return 
                (
                    DTick == other.DTick ||
                    DTick != null &&
                    DTick.Equals(other.DTick)
                ) && 
                (
                    GridColor == other.GridColor ||
                    GridColor != null &&
                    GridColor.Equals(other.GridColor)
                ) && 
                (
                    GridDash == other.GridDash ||
                    GridDash != null &&
                    GridDash.Equals(other.GridDash)
                ) && 
                (
                    GridWidth == other.GridWidth ||
                    GridWidth != null &&
                    GridWidth.Equals(other.GridWidth)
                ) && 
                (
                    Equals(Range, other.Range) ||
                    Range != null && other.Range != null &&
                    Range.SequenceEqual(other.Range)
                ) &&
                (
                    ShowGrid == other.ShowGrid ||
                    ShowGrid != null &&
                    ShowGrid.Equals(other.ShowGrid)
                ) && 
                (
                    Tick0 == other.Tick0 ||
                    Tick0 != null &&
                    Tick0.Equals(other.Tick0)
                );
        }

        /// <inheritdoc />
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (DTick != null) hashCode = hashCode * 59 + DTick.GetHashCode();
                if (GridColor != null) hashCode = hashCode * 59 + GridColor.GetHashCode();
                if (GridDash != null) hashCode = hashCode * 59 + GridDash.GetHashCode();
                if (GridWidth != null) hashCode = hashCode * 59 + GridWidth.GetHashCode();
                if (Range != null) hashCode = hashCode * 59 + Range.GetHashCode();
                if (ShowGrid != null) hashCode = hashCode * 59 + ShowGrid.GetHashCode();
                if (Tick0 != null) hashCode = hashCode * 59 + Tick0.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        ///     Checks for equality of the left LaTaxis and the right LaTaxis.
        /// </summary>
        /// <param name="left">Left LaTaxis.</param>
        /// <param name="right">Right LaTaxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator == (LaTaxis left, LaTaxis right)
        {
            return Equals(left, right);
        }

        /// <summary>
        ///     Checks for inequality of the left LaTaxis and the right LaTaxis.
        /// </summary>
        /// <param name="left">Left LaTaxis.</param>
        /// <param name="right">Right LaTaxis.</param>
        /// <returns>Boolean</returns>
        public static bool operator != (LaTaxis left, LaTaxis right)
        {
            return !Equals(left, right);
        }

        /// <summary>
        ///     Gets a deep copy of this instance.
        /// </summary>
        /// <returns>LaTaxis</returns>
        public LaTaxis DeepClone()
        {
            return this.Copy();
        }
    }
}