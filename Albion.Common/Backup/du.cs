// Decompiled with JetBrains decompiler
// Type: du
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class du
{
  private static int a;

  public static void g()
  {
    du.a = 0;
  }

  public bool g(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.g(du.a++);
    // ISSUE: reference to a compiler-generated method
    this.i(aim.a(A_0, "uniquename", (string) null));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.h(aim.a(A_0, "displayname", this.i()));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "description", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.a(A_0, "locked", false));
    // ISSUE: reference to a compiler-generated method
    this.g(aim.b(A_0, "goldcost", kx.g));
    return true;
  }
}
