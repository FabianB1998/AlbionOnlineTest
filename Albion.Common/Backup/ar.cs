// Decompiled with JetBrains decompiler
// Type: ar
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class ar : w
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.HaveFame;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "action", (string) null));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    ar ar = new ar();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ar.au(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    ar.au(this.ct());
    return (s) ar;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    try
    {
      // ISSUE: reference to a compiler-generated method
      Enum.Parse(typeof (ar.ActionFilter), this.cp());
    }
    catch
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Action '" + this.cp() + "' not available!");
      }
      flag = true;
    }
    return !flag;
  }

  public enum ActionFilter
  {
    any,
    pve,
    pvp,
    gathering,
    crafting,
  }
}
