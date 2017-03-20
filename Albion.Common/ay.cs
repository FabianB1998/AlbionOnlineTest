// Decompiled with JetBrains decompiler
// Type: ay
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ay : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.KillMob;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "mobid", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "cluster", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "mintier", 0));
    if (!A_0.HasChildNodes)
      return;
    this.au(A_0);
  }

  private void au(XmlElement A_0)
  {
    List<string> stringList = new List<string>(A_0.ChildNodes.Count);
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "equipitem")
      {
        string str = aim.a(A_0_1, "id", string.Empty);
        if (!string.IsNullOrEmpty(str))
          stringList.Add(str);
      }
    }
    if (stringList.Count <= 0)
      return;
    // ISSUE: reference to a compiler-generated method
    this.au(stringList.ToArray());
  }

  public override s av(Dictionary<string, global::ci.a> A_0, ah6 A_1)
  {
    // ISSUE: reference to a compiler-generated method
    string A_0_1 = this.cq();
    global::ci.a a1;
    // ISSUE: reference to a compiler-generated method
    A_0.TryGetValue(this.cq(), out a1);
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
    ay ay = new ay();
    // ISSUE: reference to a compiler-generated method
    ay.au(A_0_1);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ay.au(this.cs());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ay.au(this.cr());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ay.cp(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ay.cp(this.cu());
    return (s) ay;
  }

  public override bool @as(List<global::ci> A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.cq()) || s.au(this.cq(), global::ci.VariableType.DynamicCluster, A_0))
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add("Mission " + (object) this.au() + ": Cluster Variable '" + this.cq() + "' not found in mission!");
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
    if (!string.IsNullOrEmpty(this.cq()) && A_0 != null && (A_0.ax() != null && A_0.ax().h1(this.cq()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Cluster '" + this.cq() + "' does not exist!");
      }
      flag = true;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cp()) && A_0 != null && (A_0.@as() != null && A_0.@as().hz(this.cp()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Mob '" + this.cp() + "' does not exist!");
      }
      flag = true;
    }
    return !flag;
  }
}
