// Decompiled with JetBrains decompiler
// Type: ad
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ad : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.FarmHarvest;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "itemid", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "mintier", -1));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    global::ad ad = new global::ad();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ad.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ad.au(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ad.cp(this.cu());
    return (s) ad;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cp()) && A_0 != null && A_0.an() != null)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      b8 b8 = A_0.an().hz(this.cp());
      if (b8 == null)
      {
        if (A_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          A_1.Add("Mission " + (object) this.au() + ": ItemId '" + this.cp() + "' does not exist!");
        }
        flag = true;
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        if (!(b8.f() is c7))
        {
          if (A_1 != null)
          {
            // ISSUE: reference to a compiler-generated method
            A_1.Add("Mission " + (object) this.au() + ": ItemId '" + this.cp() + "' is no farmable item!");
          }
          flag = true;
        }
      }
    }
    return !flag;
  }
}
