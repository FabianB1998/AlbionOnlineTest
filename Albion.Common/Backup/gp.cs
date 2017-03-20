// Decompiled with JetBrains decompiler
// Type: gp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class gp : gm
{
  public override bool cp(XmlElement A_0)
  {
    base.cp(A_0);
    // ISSUE: reference to a compiler-generated method
    this.s(aim.a(A_0, "friendlyPrefab", "FX/ClientPrefabs/fx_combat_marker_blue"));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "hostilePrefab", "FX/ClientPrefabs/fx_combat_marker_red"));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "sizeOffset", 0.0f));
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "ignoresocketscale", true));
    return true;
  }
}
