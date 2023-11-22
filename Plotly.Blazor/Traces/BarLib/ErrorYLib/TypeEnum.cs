/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.BarLib.ErrorYLib
{
    /// <summary>
    ///     Determines the rule used to generate the error bars. If *constant`, the
    ///     bar lengths are of a constant value. Set this constant in <c>value</c>.
    ///     If <c>percent</c>, the bar lengths correspond to a percentage of underlying
    ///     data. Set this percentage in <c>value</c>. If <c>sqrt</c>, the bar lengths
    ///     correspond to the square of the underlying data. If <c>data</c>, the bar
    ///     lengths are set with data set <c>array</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"percent")]
        Percent,
        [EnumMember(Value=@"constant")]
        Constant,
        [EnumMember(Value=@"sqrt")]
        SqRt,
        [EnumMember(Value=@"data")]
        Data
    }
}