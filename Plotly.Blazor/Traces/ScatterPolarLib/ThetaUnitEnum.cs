/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ScatterPolarLib
{
    /// <summary>
    ///     Sets the unit of input <c>theta</c> values. Has an effect only when on <c>linear</c>
    ///     angular axes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum ThetaUnitEnum
    {
        [EnumMember(Value=@"degrees")]
        Degrees = 0,
        [EnumMember(Value=@"radians")]
        Radians,
        [EnumMember(Value=@"gradians")]
        Gradians
    }
}