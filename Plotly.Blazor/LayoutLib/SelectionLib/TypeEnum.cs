/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.SelectionLib
{
    /// <summary>
    ///     Specifies the selection type to be drawn. If <c>rect</c>, a rectangle is
    ///     drawn linking (<c>x0</c>,<c>y0</c>), (<c>x1</c>,<c>y0</c>), (<c>x1</c>,<c>y1</c>)
    ///     and (<c>x0</c>,<c>y1</c>). If <c>path</c>, draw a custom SVG path using
    ///     <c>path</c>.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum TypeEnum
    {
        [EnumMember(Value=@"rect")]
        Rect,
        [EnumMember(Value=@"path")]
        Path
    }
}