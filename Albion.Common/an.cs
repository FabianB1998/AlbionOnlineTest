// Decompiled with JetBrains decompiler
// Type: an
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class an : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.Gather;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cq(aim.a(A_0, "itemid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "resourcetype", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "mintier", 0));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "cluster", string.Empty));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    string A_0_1 = this.cs();
    ci.a a1;
    // ISSUE: reference to a compiler-generated method
    A_0.TryGetValue(this.cs(), out a1);
    if (a1 != null)
    {
      ct.a a2 = a1 as ct.a;
      if (a2 != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        A_0_1 = a2.j().ah();
      }
    }
    an an = new an();
    // ISSUE: reference to a compiler-generated method
    an.au(A_0_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    an.cq(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    an.au(this.cr());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    an.cp(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    an.cp(this.cu());
    return (s) an;
  }

  public override bool @as(List<ci> A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.cs()) || s.au(this.cs(), ci.VariableType.DynamicCluster, A_0))
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add("Mission " + (object) this.au() + ": Cluster Variable '" + this.cs() + "' not found in mission!");
    }
    return false;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cp()) && A_0 != null && (A_0.an() != null && A_0.an().hz(this.cp()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": ItemId '" + this.cp() + "' does not exist!");
      }
      flag = true;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cq()) && A_0 != null && (A_0.aw() != null && A_0.aw().h1(this.cq()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": ResourceType '" + this.cq() + "' does not exist!");
      }
      flag = true;
    }
    return !flag;
  }
}
