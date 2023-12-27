# Create zip files in .NET 8 without saving them to disk first ⬇

.NET 8 includes new overloads of ZipFile.CreateFromDirectory that allow you to collect all the files included in a directory and zip them, then store the resulting zip file into the provided stream.

These new APIs can be useful when disk space is constrained, because they avoid having to use the disk as an intermediate step.
