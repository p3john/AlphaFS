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
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   public static partial class File
   {
      /// <summary>[AlphaFS] Gets the date and time, in coordinated universal time (UTC) or local time, that the specified file or directory was last accessed.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file or directory for which to obtain access date and time information.</param>
      /// <param name="returnUtc"><c>true</c> gets the Coordinated Universal Time (UTC), <c>false</c> gets the local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <returns>
      ///   A <see cref="DateTime"/> structure set to the date and time that the specified file or directory was last accessed.
      ///   Depending on <paramref name="returnUtc"/> this value is expressed in UTC- or local time.
      /// </returns>
      [SecurityCritical]
      internal static DateTime GetLastAccessTimeCore(KernelTransaction transaction, string path, bool returnUtc, PathFormat pathFormat)
      {
         var lastAccessTime = GetAttributesExCore<NativeMethods.WIN32_FILE_ATTRIBUTE_DATA>(transaction, path, pathFormat, false).ftLastAccessTime;

         return returnUtc ? DateTime.FromFileTimeUtc(lastAccessTime) : DateTime.FromFileTime(lastAccessTime);
      }
   }
}
