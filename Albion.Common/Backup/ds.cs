// Decompiled with JetBrains decompiler
// Type: ds
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ds
{
  private const string a = "@AVATAR_NAME_";
  private static int b;

  [SpecialName]
  public string j()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b("@AVATAR_NAME_" + this.i());
  }

  public static void g()
  {
    ds.b = 0;
  }

  public bool g(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(ds.b++);
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "locked", false));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "hidden", false));
    // ISSUE: reference to a compiler-generated method
    this.g(dr.hz(A_0));
    return true;
  }
}
