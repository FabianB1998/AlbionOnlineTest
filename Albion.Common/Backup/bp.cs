// Decompiled with JetBrains decompiler
// Type: bp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class bp
{
  private static int a = 0;
  private static char[] b = new char[3]{ ' ', ',', ';' };

  [SpecialName]
  public int v()
  {
    // ISSUE: reference to a compiler-generated method
    return this.w().Count;
  }

  public static void l()
  {
    bp.a = 0;
  }

  public bool l(XmlElement A_0)
  {
    if (A_0.Name != "agent")
      throw new AlbionException("[AgentInfo] ParseFromXml: XmlTag 'Agent' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.m(bp.a++);
    // ISSUE: reference to a compiler-generated method
    this.p(aim.a(A_0, "uniquename", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.o(aim.a(A_0, "namegenerator", string.Empty));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.n(aim.a(A_0, "prefab", this.n()));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.a(A_0, "faction", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.a(A_0, "uiavatar", string.Empty));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.b(A_0, "level", int.MinValue));
    // ISSUE: reference to a compiler-generated method
    this.m(aim.b(A_0, "maxsilverpool", kx.j));
    // ISSUE: reference to a compiler-generated method
    this.l(aim.c(A_0, "secondspersilver", kx.j));
    this.m(A_0);
    return true;
  }

  protected void m(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.l(new List<string[]>(A_0.ChildNodes.Count));
    foreach (object childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "missionslot")
      {
        string[] strArray = (string[]) null;
        string str = aim.a(A_0_1, "tags", string.Empty);
        if (!string.IsNullOrEmpty(str))
          strArray = str.Split(bp.b, StringSplitOptions.RemoveEmptyEntries);
        // ISSUE: reference to a compiler-generated method
        this.w().Add(strArray);
      }
    }
  }

  public void l(g8 A_0)
  {
  }
}
