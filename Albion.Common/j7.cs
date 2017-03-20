// Decompiled with JetBrains decompiler
// Type: j7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Xml;

public class j7
{
  private j7.a b = new j7.a();
  private Dictionary<string, j7.a> c = new Dictionary<string, j7.a>();
  private float d = 1f;
  private Dictionary<KeyValuePair<string, int>, float> e = new Dictionary<KeyValuePair<string, int>, float>();
  private string a;
  public static readonly j7 f;

  static j7()
  {
    j7 j7 = new j7();
    // ISSUE: reference to a compiler-generated method
    j7.ao("DEFAULT");
    // ISSUE: reference to a compiler-generated method
    j7.ao(it.c);
    // ISSUE: reference to a compiler-generated method
    j7.ao(8);
    // ISSUE: reference to a compiler-generated method
    j7.ap(kx.h);
    // ISSUE: reference to a compiler-generated method
    j7.ao(kx.h);
    // ISSUE: reference to a compiler-generated method
    j7.au(false);
    // ISSUE: reference to a compiler-generated method
    j7.aq(true);
    // ISSUE: reference to a compiler-generated method
    j7.at(false);
    // ISSUE: reference to a compiler-generated method
    j7.ar(false);
    // ISSUE: reference to a compiler-generated method
    j7.@as(true);
    // ISSUE: reference to a compiler-generated method
    j7.ap(true);
    // ISSUE: reference to a compiler-generated method
    j7.ao(true);
    // ISSUE: reference to a compiler-generated method
    j7.ap(new acf(100f, 100f, 100f));
    // ISSUE: reference to a compiler-generated method
    j7.ao(new acf(100f, 100f, 100f));
    j7.f = j7;
  }

  [SpecialName]
  public it.PvpRules ao()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().y();
  }

  [SpecialName]
  public bool ap()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().z();
  }

  [SpecialName]
  public bool aq()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().aa();
  }

  [SpecialName]
  public bool ar()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ab();
  }

  [SpecialName]
  public bool @as()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ad();
  }

  [SpecialName]
  public bool at()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ae();
  }

  [SpecialName]
  public bool au()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().af();
  }

  [SpecialName]
  public bool av()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ac();
  }

  [SpecialName]
  public ahy aw()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ag();
  }

  [SpecialName]
  public ahy ax()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ah();
  }

  [SpecialName]
  public it.UiPvpTypes ay()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ai();
  }

  [SpecialName]
  public it.PvpWarningLevel az()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().aj();
  }

  [SpecialName]
  public float a5()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ap();
  }

  [SpecialName]
  public kx a6()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().aq();
  }

  [SpecialName]
  public float bf()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ak();
  }

  [SpecialName]
  public float bg()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().al();
  }

  [SpecialName]
  public float bh()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().am();
  }

  [SpecialName]
  public float bi()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().an();
  }

  [SpecialName]
  public string bj()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().ao();
  }

  [SpecialName]
  public kx bm()
  {
    return this.bp().e;
  }

  [SpecialName]
  public kx bn()
  {
    return this.bp().d;
  }

  [SpecialName]
  public float bo()
  {
    return this.bp().c;
  }

  [SpecialName]
  public ab8.c bp()
  {
    // ISSUE: reference to a compiler-generated method
    return this.br().a;
  }

  [SpecialName]
  public float bq()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.br().@as();
  }

  public bool ax(bool A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return this.br().ae(A_0);
  }

  public j7.a ap(string A_0)
  {
    j7.a a;
    if (this.c.TryGetValue(A_0, out a))
      return a;
    return this.b;
  }

  public float aq(string A_0)
  {
    return this.ap(A_0).b;
  }

  public float ao(hh A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (A_0.i()[A_1 - 1].ag())
      return 1f;
    float num;
    // ISSUE: reference to a compiler-generated method
    if (this.e.TryGetValue(new KeyValuePair<string, int>(A_0.g(), A_1), out num) || this.e.TryGetValue(new KeyValuePair<string, int>("*", A_1), out num))
      return num;
    return this.d;
  }

  public bool ap(XmlElement A_0)
  {
    this.a = aim.h(A_0, "archetype");
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.h(A_0, "name"));
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.b(A_0, "maxbuildingtier", 8));
    // ISSUE: reference to a compiler-generated method
    this.ar(aim.a(A_0, "escapedungeonspellavailable", false));
    // ISSUE: reference to a compiler-generated method
    this.aw(aim.a(A_0, "furnitureobjectsallowed", true));
    // ISSUE: reference to a compiler-generated method
    this.av(aim.a(A_0, "isplayercity", false));
    // ISSUE: reference to a compiler-generated method
    this.ap(aim.c(A_0, "claimpricefactor", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.c(A_0, "realestatesalepricefactor", kx.h));
    // ISSUE: reference to a compiler-generated method
    this.au(aim.a(A_0, "isdungeon", false));
    // ISSUE: reference to a compiler-generated method
    this.aq(aim.a(A_0, "allowmounts", true));
    // ISSUE: reference to a compiler-generated method
    this.at(aim.a(A_0, "isstartarea", false));
    // ISSUE: reference to a compiler-generated method
    this.@as(aim.a(A_0, "persistsimulationtodatabase", true));
    // ISSUE: reference to a compiler-generated method
    this.ap(aim.a(A_0, "hellgatemobminimapvisible", false));
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.a(A_0, "hellgateclustermessage", false));
    // ISSUE: reference to a compiler-generated method
    this.ap(aim.a(A_0, "editorcolor", new acf(100f, 100f, 100f)));
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ao(aim.a(A_0, "editorcolor2", this.bk()));
    this.ao(A_0);
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("resourcespawns"))
    {
      this.d = aim.a(A_0_1, "defaulttimefactor", this.d);
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("resourcespawn"))
        this.e.Add(new KeyValuePair<string, int>(aim.h(A_0_2, "name"), aim.b(A_0_2, "tier", 1)), aim.a(A_0_2, "timefactor", 1f));
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("resourcetier"))
        this.e.Add(new KeyValuePair<string, int>("*", aim.b(A_0_2, "tier", 1)), aim.a(A_0_2, "timefactor", 1f));
    }
    return true;
  }

  private bool ao(XmlElement A_0)
  {
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("mobspawns"))
    {
      this.b.b = aim.a(A_0_1, "defaulttimefactor", this.b.b);
      this.b.c = aim.a(A_0_1, "defaultinitialchargemultiplicator", this.b.c);
      this.b.d = aim.a(A_0_1, "defaultmaxchargemultiplicator", this.b.d);
      foreach (XmlElement A_0_2 in A_0_1.GetElementsByTagName("mobspawn"))
      {
        string key = aim.h(A_0_2, "name");
        if (!string.IsNullOrEmpty(key))
        {
          j7.a a = new j7.a() { a = key, b = aim.a(A_0_2, "timefactor", this.b.b), c = aim.a(A_0_2, "initialchargemultiplicator", this.b.c), d = aim.a(A_0_2, "maxchargemultiplicator", this.b.d) };
          this.c.Add(key, a);
        }
      }
    }
    return true;
  }

  public void ao(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ao(A_0.a7().h0(this.a));
    // ISSUE: reference to a compiler-generated method
    if (this.br() != null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.ao(it.c);
  }

  public class a
  {
    public string a = "DEFAULT";
    public float b = 1f;
    public float c = -1f;
    public float d = -1f;
  }
}
