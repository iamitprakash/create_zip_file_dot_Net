namspace Sytem.IO.Compression
{

public static partial class ZipFile
{
public static void CreateFromDirectory(string sourceDirectoryName, Stream Destination);

public static void CreateFromDirectory(string sourceDirectoryName, Stream Destination, CompressionLevel compressionlevel, bool includebaseDirectory);

public static void CreateFromDirectory(string sourceDirectoryName, Stream Destination, CompressionLevel compressionlevel, bool includebaseDirectory, Encoding? entrynameEncoding);
}

}
