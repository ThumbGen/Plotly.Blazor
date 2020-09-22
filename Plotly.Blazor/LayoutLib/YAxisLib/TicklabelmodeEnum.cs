/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.YAxisLib
{
    /// <summary>
    ///     Determines where tick labels are drawn with respect to their corresponding
    ///     ticks and grid lines. Only has an effect for axes of <c>type</c> <c>date</c>
    ///     When set to <c>period</c>, tick labels are drawn in the middle of the period
    ///     between ticks.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", "1.0.0.0")]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickLabelModeEnum
    {
        [EnumMember(Value=@"instant")]
        Instant = 0,
        [EnumMember(Value=@"period")]
        Period
    }
}