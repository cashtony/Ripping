/* This file is generated by tdr. */
/* No manual modification is permitted. */

/* creation time: Tue Feb 10 15:13:53 2015 */
/* tdr version: 2.7.3, build at 20141126 */

using System;

namespace tsf4g_tdr_csharp
{


public interface IPackable
{
    TdrError.ErrorType pack(ref byte[] buffer, int size, ref int usedSize , uint cutVer);
}

public interface IUnpackable
{
    TdrError.ErrorType unpack(ref byte[] buffer, int size, ref int usedSize , uint cutVer);
}


}
