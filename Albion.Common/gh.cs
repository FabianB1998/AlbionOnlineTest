// Decompiled with JetBrains decompiler
// Type: gh
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class gh : fm
{
  public override void co(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a<gh.DamageTypes>(A_0, "type", gh.DamageTypes.Any));
  }

  public enum DamageTypes
  {
    Magic,
    Physical,
    Any,
  }
}
