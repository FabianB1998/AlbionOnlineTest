// Decompiled with JetBrains decompiler
// Type: ahp
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class ahp : ahm
{
  public Dictionary<string, d1> l = new Dictionary<string, d1>();

  public ahp(aht A_0, int A_1)
    : base(A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.y(A_1);
  }

  [SpecialName]
  public override k2 c7()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.ah() == null)
      return k2.a();
    // ISSUE: reference to a compiler-generated method
    return this.ah().c7();
  }

  public override void dc(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.y(d1.a(A_0));
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null)
      {
        switch (A_0_1.Name)
        {
          case "beamvfx":
            g4 g4 = new g4();
            g4.cp(A_0_1);
            // ISSUE: reference to a compiler-generated method
            if (this.ad() == null)
            {
              // ISSUE: reference to a compiler-generated method
              this.y(new List<g4>());
            }
            // ISSUE: reference to a compiler-generated method
            this.ad().Add(g4);
            g4.i = "SpellEffectAreaInit";
            continue;
          case "spellvfx":
            gq gq = new gq();
            gq.p(A_0_1, true);
            // ISSUE: reference to a compiler-generated method
            if (this.ae() == null)
            {
              // ISSUE: reference to a compiler-generated method
              this.y(new List<gq>());
            }
            // ISSUE: reference to a compiler-generated method
            this.ae().Add(gq);
            gq.i = "SpellEffectAreaInit";
            continue;
          case "fofIndicator":
            gp gp = new gp();
            gp.cp(A_0_1);
            // ISSUE: reference to a compiler-generated method
            if (this.af() == null)
            {
              // ISSUE: reference to a compiler-generated method
              this.y(new List<gp>());
            }
            // ISSUE: reference to a compiler-generated method
            this.af().Add(gp);
            gp.i = "SpellEffectAreaInit";
            continue;
          default:
            continue;
        }
      }
    }
  }

  public void y(g8 A_0)
  {
    Dictionary<string, d1> dictionary = new Dictionary<string, d1>();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!string.IsNullOrEmpty(this.ab()) && A_0.ba().ab.ContainsKey(this.ab()))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (KeyValuePair<string, d1> keyValuePair in A_0.ba().ab[this.ab()])
      {
        // ISSUE: reference to a compiler-generated method
        string key = string.Format("{0:00}", (object) this.ac()) + "_" + keyValuePair.Key;
        if (!this.l.ContainsKey(key))
          this.l.Add(key, keyValuePair.Value);
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ad() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (g4 g4 in this.ad())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        g4.q(string.Format("{0:00}", (object) this.ac()) + "_" + g4.p());
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        g4.r(string.Format("{0:00}", (object) this.ac()) + "_" + g4.v());
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ae() != null)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (gq gq in this.ae())
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        gq.r(string.Format("{0:00}", (object) this.ac()) + "_" + gq.v());
      }
    }
    // ISSUE: reference to a compiler-generated method
    if (this.af() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (gp gp in this.af())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      gp.r(string.Format("{0:00}", (object) this.ac()) + "_" + gp.v());
    }
  }
}
