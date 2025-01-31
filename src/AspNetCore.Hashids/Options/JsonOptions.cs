namespace Microsoft.AspNetCore.Mvc;

#if !NET5_0_OR_GREATER
public class JsonOptions
{
    /// <summary>
    /// Gets or sets a flag to determine whether error messages from JSON deserialization by the <see cref="Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter" /> will be added to the <see cref="Microsoft.AspNetCore.Mvc.ModelBinding.ModelStateDictionary" />. If false, a generic error message will be used instead.
    /// </summary>
    public bool AllowInputFormatterExceptionMessages { get; set; }

    /// <summary>
    /// Gets the <see cref="System.Text.Json.JsonSerializerOptions" /> used by <see cref="Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonInputFormatter" /> and <see cref="Microsoft.AspNetCore.Mvc.Formatters.SystemTextJsonOutputFormatter" />.
    /// </summary>
    public System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; }
}
#endif
