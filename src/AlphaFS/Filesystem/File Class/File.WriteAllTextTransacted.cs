/*  Copyright (C) 2008-2018 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using System;
using System.IO;
using System.Security;
using System.Text;

namespace Alphaleonis.Win32.Filesystem
{
   public static partial class File
   {
      #region .NET

      /// <summary>[AlphaFS] Creates a new file as part of a transaction, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <remarks>This method uses UTF-8 encoding without a Byte-Order Mark (BOM)</remarks>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="ArgumentOutOfRangeException"/>
      /// <exception cref="FileNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="SecurityException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <exception cref="PlatformNotSupportedException">The operating system is older than Windows Vista.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The string to write to the file.</param>
      [SecurityCritical]
      public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents)
      {
         WriteAppendAllLinesCore(transaction, path, new[] {contents}, new UTF8Encoding(false, true), false, false, PathFormat.RelativePath);
      }


      /// <summary>[AlphaFS] Creates a new file as part of a transaction, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="ArgumentOutOfRangeException"/>
      /// <exception cref="FileNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="SecurityException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <exception cref="PlatformNotSupportedException">The operating system is older than Windows Vista.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The string to write to the file.</param>
      /// <param name="encoding">The <see cref="Encoding"/> applied to the contents of the file.</param>
      [SecurityCritical]
      public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding)
      {
         WriteAppendAllLinesCore(transaction, path, new[] {contents}, encoding, false, false, PathFormat.RelativePath);
      }

      #endregion // .NET


      /// <summary>[AlphaFS] Creates a new file as part of a transaction, write the contents to the file, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <remarks>This method uses UTF-8 encoding without a Byte-Order Mark (BOM)</remarks>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="ArgumentOutOfRangeException"/>
      /// <exception cref="FileNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="SecurityException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <exception cref="PlatformNotSupportedException">The operating system is older than Windows Vista.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The string to write to the file.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, PathFormat pathFormat)
      {
         WriteAppendAllLinesCore(transaction, path, new[] {contents}, new UTF8Encoding(false, true), false, false, pathFormat);
      }


      /// <summary>[AlphaFS] Creates a new file as part of a transaction, writes the specified string to the file using the specified encoding, and then closes the file. If the target file already exists, it is overwritten.</summary>
      /// <exception cref="ArgumentNullException"/>
      /// <exception cref="ArgumentException"/>
      /// <exception cref="NotSupportedException"/>
      /// <exception cref="ArgumentOutOfRangeException"/>
      /// <exception cref="FileNotFoundException"/>
      /// <exception cref="IOException"/>
      /// <exception cref="SecurityException"/>
      /// <exception cref="DirectoryNotFoundException"/>
      /// <exception cref="UnauthorizedAccessException"/>
      /// <exception cref="PlatformNotSupportedException">The operating system is older than Windows Vista.</exception>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file to write to.</param>
      /// <param name="contents">The string to write to the file.</param>
      /// <param name="encoding">The <see cref="Encoding"/> applied to the contents of the file.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void WriteAllTextTransacted(KernelTransaction transaction, string path, string contents, Encoding encoding, PathFormat pathFormat)
      {
         WriteAppendAllLinesCore(transaction, path, new[] {contents}, encoding, false, false, pathFormat);
      }
   }
}
