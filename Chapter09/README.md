# Chapter 9 Summary

## Key Concepts

## Classes to Get Info About Files and Directories
| Class | Member |
|-------|--------|
| FileSystemInfo | **Fields:** FullPath, Original Path. **Properties:** Attributes, CreationTime, CreationTimeUtc, Exists, Extension, FullName, LastAccessTime, LastAccessTimeUtc, LastWriteTime, LastWriteTimeUtc, Name. **Methods:** Delete, GetObjectData, Refresh |
| DirectoryInfo | **Properties:** Parent, Root. **Methods:** Create, CreateSubdirectory, EnumerateDirectories, EnumerateFiles, EnumerateFileSystemInfos, GetAccessControl, GetDirectories, GetFiles, GetFileSystemInfos, MoveTo, SetAccessControl |
| FileInfo | **Properties:** Directory, DirectoryName, IsReadOnly, Length. **Methods:** AppendText, CopyTo, Create, CreateText, Decrypt, Encrypt, GetAccessControl, MoveTo, Open, OpenREad, OpenText, OpenWrite, Replace, SetAccessControl |

## Stream Class Members
| Member | Description |
|--------|-------------|
| CanRead, CanWrite | These properties determine if you can read from and write to the stream. |
| Length, Position | These properties determine the total number of bytes and the current position within the stream. These properties may throw a NotSupportedException for some types of streams, for example if CanSeek returns false. |
| Close, Dispose | This method closes the stream and releases its resources. You can all either method since the implementation of Dispose calls Close. |
| Flush | If the stream has a buffer, then this method writes the bytes in the buffer to the stream, and the buffer is cleared. |
| CanSeek | This property determines if the Seek method can be used. |
| Seek | This method moves the current position the the one specified in its parameter. |
| Read, ReadAsync | These methods read a specified number of bytes from the stream into a byte array and advance position. |
| ReadByte | This method reads the next byte from the stream and advances the position. |
| Write, WriteAsync | These methods write contents of a byte array into the stream. |
| WriteByte | This method writes a byte to the stream. |

## Storage Stream Classes
| Namespace | Class | Description |
|-----------|-------|-------------|
| System.IO | FileStream | Bytes stored in filesystem. |
| System.IO | MemoryStream | Bytes stored in memory in the current process. |
| System.Net.Sockets | NetworkStream | Bytes stored at a network location. |

## Function Stream Classes
| Namespace | Class | Description |
|-----------|-------|-------------|
| System.Security.Cryptography | CryptoStream | This encrypts and decrypts the stream. |
| System.IO.Compression | GZipStream, DeflateStream | These compress and decompress the stream. |
| System.Net.Security | AuthenticatedStream | This sends credentials across the stream. |

## Stream Helper Classes
| Namespace | Class | Description |
|-----------|-------|-------------|
| System.IO | StreamReader | This reads from the underlying stream as plain text. |
| System.IO | StreamWriter | This writes to the underlying stream as plain text. |
| System.IO | BinaryReader | This reads from streams as .NET types. For example, the ReadDecimal method reads the next 16 bytes from the underlying stream as a decimal value, and the ReadInt32 method reads the next 4 bytes as an int value. |
| System.IO | BinaryWriter | This writes to streams as .NET types. For example, the Write method with a decimal parameter writes 16 bytes to the underlying stream, and the Write method with an int parameter writes 4 bytes. |
| System.Xml | XmlReader | This reads from the underlying stream using the XML format. |
| System.Xml | XmlWriter | This writes to the underlying stream using the XML format. |

## Common Text Encodings
| Encoding | Description |
|----------|-------------|
| ASCII | This encodes a limited range of characters using the lower seven bits of a byte. |
| UTF-8 | This represents each Unicode code point as a sequence of one to four bytes. |
| UTF-7 | This is designed to be more efficient over 7-bi channels than UTF-8 but it has security and robustness issues, so UTF-8 is recommended over UTF-7. |
| UTF-16 | This represents each Unicode code point as a sequence of one or two 16-bit integers. |
| UTF-32 | This represents each Unicode code point as a 32-bit integer and is, therefore, a fixed-length encoding unlike the other Unicode encodings, which are all variable-length encodings. |
| ANSI/ISO encodings | This provides support for a variety of code pages that are used to support a specific language or group of languages. |


## Projects List
* WorkingWithFileSystem
* WorkingWithStreams

## Practice Questions
 
## My takeaways / Questions / Notes