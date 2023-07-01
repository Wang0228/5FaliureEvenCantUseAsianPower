namespace openAPI.Models;

public partial class Data
{
    public string DataId { get; set; } = null!;

    public string DataType { get; set; } = null!;

    public string DataPath { get; set; } = null!;

    public string ApplicationId { get; set; } = null!;

    public virtual Application Application { get; set; } = null!;

    public virtual ICollection<Embedding> Embeddings { get; set; } = new List<Embedding>();
}
