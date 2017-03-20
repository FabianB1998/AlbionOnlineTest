// Decompiled with JetBrains decompiler
// Type: dt
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class dt
{
  private const string a = "@AVATAR_NAME_";
  private static int b;

  [SpecialName]
  public string i()
  {
    // ISSUE: reference to a compiler-generated method
    return kr.b("@AVATAR_NAME_" + this.h());
  }

  public static void f()
  {
    dt.b = 0;
  }

  public bool f(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.f(dt.b++);
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "name", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "locked", false));
    // ISSUE: reference to a compiler-generated method
    this.f(dr.hz(A_0));
    return true;
  }
}
