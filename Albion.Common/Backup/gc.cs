// Decompiled with JetBrains decompiler
// Type: gc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class gc : fm
{
  public override void co(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a(A_0, "spell", ""));
    // ISSUE: reference to a compiler-generated method
    this.r(aim.b(A_0, "atleastcharges", 1));
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a(A_0, "casterchargesonly", false));
    // ISSUE: reference to a compiler-generated method
    this.r(aim.a<fm.Target>(A_0, "who", fm.Target.EffectTarget));
  }
}
