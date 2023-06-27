using System;
using System.Collections.Generic;

namespace openAPI.Models;

public partial class Embedding
{
    public string Index { get; set; } = null!;

    public string EmbeddingQuestion { get; set; } = null!;

    public string EmbeddingAnswer { get; set; } = null!;

    public string Qa { get; set; } = null!;

    public string EmbeddingVectors { get; set; } = null!;

    public string DataId { get; set; } = null!;

    public virtual Data Data { get; set; } = null!;
}
