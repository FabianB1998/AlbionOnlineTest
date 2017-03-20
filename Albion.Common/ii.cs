// Decompiled with JetBrains decompiler
// Type: ii
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class ii : fb
{
  public static readonly string ht = "healonhit";

  [SpecialName]
  public override string cl()
  {
    return ii.ht;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h4(aim.a(A_0, "chance", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "percentage", 0.0f));
    return true;
  }
}
