using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axiieflex.ensage2.UnsafeAPI
{
    class System
    {

        class IO
        {

            class File
            {

                //
                // Сводка:
                //     Determines whether the specified file exists.
                //
                // Параметры:
                //   path:
                //     The file to check.
                //
                // Возвращает:
                //     true if the caller has the required permissions and path contains the name
                //     of an existing file; otherwise, false. This method also returns false if
                //     path is null, an invalid path, or a zero-length string. If the caller does
                //     not have sufficient permissions to read the specified file, no exception
                //     is thrown and the method returns false regardless of the existence of path.
                public static bool Exists(string path)
                {
                    return true;
                }

                //
                // Сводка:
                //     Opens a file, appends the specified string to the file, and then closes the
                //     file. If the file does not exist, this method creates a file, writes the
                //     specified string to the file, then closes the file.
                //
                // Параметры:
                //   path:
                //     The file to append the specified string to.
                //
                //   contents:
                //     The string to append to the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, the directory doesn’t exist or
                //     it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     path specified a file that is read-only.-or- This operation is not supported
                //     on the current platform.-or- path specified a directory.-or- The caller does
                //     not have the required permission.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static void AppendAllText(string path, string contents)
                {
                    return;
                }

                //
                // Сводка:
                //     Moves a specified file to a new location, providing the option to specify
                //     a new file name.
                //
                // Параметры:
                //   sourceFileName:
                //     The name of the file to move. Can include a relative or absolute path.
                //
                //   destFileName:
                //     The new path and name for the file.
                //
                // Исключения:
                //   System.IO.IOException:
                //     The destination file already exists.-or-sourceFileName was not found.
                //
                //   System.ArgumentNullException:
                //     sourceFileName or destFileName is null.
                //
                //   System.ArgumentException:
                //     sourceFileName or destFileName is a zero-length string, contains only white
                //     space, or contains invalid characters as defined in System.IO.Path.InvalidPathChars.
                //
                //   System.UnauthorizedAccessException:
                //     The caller does not have the required permission.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The path specified in sourceFileName or destFileName is invalid, (for example,
                //     it is on an unmapped drive).
                //
                //   System.NotSupportedException:
                //     sourceFileName or destFileName is in an invalid format.
                public static void Move(string sourceFileName, string destFileName)
                {
                    return;
                }

                //
                // Сводка:
                //     Opens a binary file, reads the contents of the file into a byte array, and
                //     then closes the file.
                //
                // Параметры:
                //   path:
                //     The file to open for reading.
                //
                // Возвращает:
                //     A byte array containing the contents of the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     This operation is not supported on the current platform.-or- path specified
                //     a directory.-or- The caller does not have the required permission.
                //
                //   System.IO.FileNotFoundException:
                //     The file specified in path was not found.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static byte[] ReadAllBytes(string path)
                {
                    return new byte[0];
                }

                //
                // Сводка:
                //     Opens a text file, reads all lines of the file, and then closes the file.
                //
                // Параметры:
                //   path:
                //     The file to open for reading.
                //
                // Возвращает:
                //     A string array containing all lines of the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     path specified a file that is read-only.-or- This operation is not supported
                //     on the current platform.-or- path specified a directory.-or- The caller does
                //     not have the required permission.
                //
                //   System.IO.FileNotFoundException:
                //     The file specified in path was not found.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static string[] ReadAllLines(string path)
                {
                    return new string[0];
                }

                //
                // Сводка:
                //     Opens a text file, reads all lines of the file, and then closes the file.
                //
                // Параметры:
                //   path:
                //     The file to open for reading.
                //
                // Возвращает:
                //     A string containing all lines of the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     path specified a file that is read-only.-or- This operation is not supported
                //     on the current platform.-or- path specified a directory.-or- The caller does
                //     not have the required permission.
                //
                //   System.IO.FileNotFoundException:
                //     The file specified in path was not found.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static string ReadAllText(string path)
                {
                    return null;
                }

                //
                // Сводка:
                //     Creates a new file, writes the specified byte array to the file, and then
                //     closes the file. If the target file already exists, it is overwritten.
                //
                // Параметры:
                //   path:
                //     The file to write to.
                //
                //   bytes:
                //     The bytes to write to the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null or the byte array is empty.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     path specified a file that is read-only.-or- This operation is not supported
                //     on the current platform.-or- path specified a directory.-or- The caller does
                //     not have the required permission.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static void WriteAllBytes(string path, byte[] bytes)
                {
                    return;
                }

                //
                // Сводка:
                //     Creates a new file, writes the specified string to the file, and then closes
                //     the file. If the target file already exists, it is overwritten.
                //
                // Параметры:
                //   path:
                //     The file to write to.
                //
                //   contents:
                //     The string to write to the file.
                //
                // Исключения:
                //   System.ArgumentException:
                //     path is a zero-length string, contains only white space, or contains one
                //     or more invalid characters as defined by System.IO.Path.InvalidPathChars.
                //
                //   System.ArgumentNullException:
                //     path is null or contents is empty.
                //
                //   System.IO.PathTooLongException:
                //     The specified path, file name, or both exceed the system-defined maximum
                //     length. For example, on Windows-based platforms, paths must be less than
                //     248 characters, and file names must be less than 260 characters.
                //
                //   System.IO.DirectoryNotFoundException:
                //     The specified path is invalid (for example, it is on an unmapped drive).
                //
                //   System.IO.IOException:
                //     An I/O error occurred while opening the file.
                //
                //   System.UnauthorizedAccessException:
                //     path specified a file that is read-only.-or- This operation is not supported
                //     on the current platform.-or- path specified a directory.-or- The caller does
                //     not have the required permission.
                //
                //   System.NotSupportedException:
                //     path is in an invalid format.
                //
                //   System.Security.SecurityException:
                //     The caller does not have the required permission.
                public static void WriteAllText(string path, string contents)
                {
                    return;
                }

            }

        }

    }
}
