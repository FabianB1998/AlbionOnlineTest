// Decompiled with JetBrains decompiler
// Type: ack
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class ack
{
  public const short a = 30;
  private static System.Type[] b;

  static ack()
  {
    // ISSUE: object of a compiler-generated type is created
    // ISSUE: variable of a compiler-generated type
    ack.a a = new ack.a();
    // ISSUE: reference to a compiler-generated field
    a.a = typeof (ack);
    // ISSUE: reference to a compiler-generated field
    // ISSUE: reference to a compiler-generated method
    ack.b = ((IEnumerable<System.Type>) Assembly.GetAssembly(a.a).GetTypes()).Where<System.Type>(new Func<System.Type, bool>(a.b)).ToArray<System.Type>();
  }

  public static string a(short A_0)
  {
    foreach (System.Type enumType in ack.b)
    {
      if (Enum.IsDefined(enumType, (object) A_0))
        return Enum.GetName(enumType, (object) A_0);
    }
    return "unknown error code (" + (object) A_0 + ")";
  }
}
