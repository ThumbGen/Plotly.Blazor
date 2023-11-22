/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.Traces.ParCatsLib
{
    /// <summary>
    ///     Sets the path sorting algorithm. If <c>forward</c>, sort paths based on
    ///     dimension categories from left to right. If <c>backward</c>, sort paths
    ///     based on dimensions categories from right to left.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum SortPathsEnum
    {
        [EnumMember(Value=@"forward")]
        Forward = 0,
        [EnumMember(Value=@"backward")]
        Backward
    }
}