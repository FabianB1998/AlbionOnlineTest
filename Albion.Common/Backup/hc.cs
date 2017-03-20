// Decompiled with JetBrains decompiler
// Type: hc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class hc
{
  private static int a;

  public static void e()
  {
    hc.a = 0;
  }

  public bool e(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.e(hc.a++);
    // ISSUE: reference to a compiler-generated method
    this.f(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "displayname", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.e(aim.a(A_0, "locked", false));
    return true;
  }
}
