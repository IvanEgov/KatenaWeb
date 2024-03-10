namespace Katena.Domain.Repositories.Abstruct
{
    public interface IImage
    {
        ImageType ImageType { get; }

        string Folder { get; }

        int Width { get; }

        int Height { get; }

        int MaxSizeBytes { get; }

        IEnumerable<string> AllowedExtensions { get; }
    }
}
