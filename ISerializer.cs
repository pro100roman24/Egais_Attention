namespace Serialization
{
    public interface ISerializer
    {
        string Serialize<TObject>(TObject @object);
        TObject Deserialize<TObject>(string @string);
    }
}