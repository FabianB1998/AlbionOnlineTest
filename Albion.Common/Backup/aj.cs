// Decompiled with JetBrains decompiler
// Type: aj
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class aj : t
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.EnterCluster;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "value", 1L));
    // ISSUE: reference to a compiler-generated method
    this.cq(aim.a(A_0, "clusterdirect", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "cluster", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "clusterofagent", string.Empty));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    ci.a a1 = (ci.a) null;
    // ISSUE: reference to a compiler-generated method
    string A_0_1 = this.cp();
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cq()))
    {
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
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      if (!string.IsNullOrEmpty(this.cr()))
      {
        // ISSUE: reference to a compiler-generated method
        A_0.TryGetValue(this.cr(), out a1);
        if (a1 != null)
        {
          cs.a a2 = a1 as cs.a;
          if (a2 != null)
          {
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            A_0_1 = a2.j().l().ah();
          }
        }
      }
    }
    aj aj = new aj();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    aj.cp(this.cu());
    // ISSUE: reference to a compiler-generated method
    aj.cq(A_0_1);
    return (s) aj;
  }

  public override bool @as(List<ci> A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cq()) && !s.au(this.cq(), ci.VariableType.DynamicCluster, A_0))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Cluster Variable '" + this.cq() + "' not found in mission!");
      }
      return false;
    }
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.cr()) || s.au(this.cr(), ci.VariableType.DynamicAgent, A_0))
      return true;
    if (A_1 != null)
    {
      // ISSUE: reference to a compiler-generated method
      A_1.Add("Mission " + (object) this.au() + ": Agent Variable '" + this.cr() + "' not found in mission!");
    }
    return false;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (string.IsNullOrEmpty(this.cp()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (string.IsNullOrEmpty(this.cr()) && string.IsNullOrEmpty(this.cq()) && A_1 != null)
        A_1.Add("Mission " + (object) this.au() + ": cluster and clusterofagent is empty!");
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (A_0 != null && A_0.ax() != null && A_0.ax().h1(this.cp()) == null)
      {
        if (A_1 != null)
        {
          // ISSUE: reference to a compiler-generated method
          A_1.Add("Mission " + (object) this.au() + ": Cluster '" + this.cp() + "' not found in game!");
        }
        return false;
      }
    }
    return true;
  }
}
