// Decompiled with JetBrains decompiler
// Type: gy
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Xml;

public class gy : et
{
  public static readonly string fc = "reducethreatlevelbypercentage";

  [SpecialName]
  public override string cl()
  {
    return gy.fc;
  }

  public override es.a cm()
  {
    return es.a.a;
  }

  public override bool cj(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.h3(aim.a(A_0, "amountpercent", 10f));
    return base.cj(A_0);
  }
}
