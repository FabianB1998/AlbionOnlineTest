// Decompiled with JetBrains decompiler
// Type: af
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class af : w
{
  [SpecialName]
  public override s.MissionType au()
  {
    return s.MissionType.InstallSv;
  }

  public override void ar(XmlElement A_0)
  {
    base.ar(A_0);
    // ISSUE: reference to a compiler-generated method
    this.cp(aim.a(A_0, "build", false));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "repair", false));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "buildingtype", (string) null));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.b(A_0, "mintier", -1));
  }

  public override s av(Dictionary<string, ci.a> A_0, ah6 A_1)
  {
    af af = new af();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    af.au(this.cr());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    af.cp(this.cp());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    af.au(this.cs());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    af.au(this.cq());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    af.au(this.ct());
    return (s) af;
  }

  public override bool at(g8 A_0, List<string> A_1)
  {
    bool flag = false;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.cr()) && A_0 != null && (A_0.ap() != null && A_0.ap().hz(this.cr()) == null))
    {
      if (A_1 != null)
      {
        // ISSUE: reference to a compiler-generated method
        A_1.Add("Mission " + (object) this.au() + ": Building '" + this.cr() + "' does not exist!");
      }
      flag = true;
    }
    return !flag;
  }
}
