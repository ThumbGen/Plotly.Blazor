/*
 * THIS FILE WAS GENERATED BY PLOTLY.BLAZOR.GENERATOR
*/

using System.Text.Json.Serialization;
using System.Runtime.Serialization;
#pragma warning disable 1591

namespace Plotly.Blazor.LayoutLib.XAxisLib
{
    /// <summary>
    ///     Determines how we handle tick labels that would overflow either the graph
    ///     div or the domain of the axis. The default value for inside tick labels
    ///     is &#39;hide past domain&#39;. Otherwise on <c>category</c> and <c>multicategory</c>
    ///     axes the default is <c>allow</c>. In other cases the default is &#39;hide
    ///     past div&#39;.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Plotly.Blazor.Generator", null)]
    [JsonConverter(typeof(EnumConverter))]
    public enum TickLabelOverflowEnum
    {
        [EnumMember(Value=@"allow")]
        Allow,
        [EnumMember(Value=@"hide past div")]
        HidePastDiv,
        [EnumMember(Value=@"hide past domain")]
        HidePastDomain
    }
}