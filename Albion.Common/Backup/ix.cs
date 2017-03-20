// Decompiled with JetBrains decompiler
// Type: ix
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.ResourceDistribution;
using Albion.Common.Time;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

public class ix : iu
{
  private Dictionary<aae, HashSet<aaf>> b = new Dictionary<aae, HashSet<aaf>>((IEqualityComparer<aae>) new aac());
  private kq a;

  public ix(kq A_0)
  {
    this.a = A_0;
  }

  protected override void cs(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
    acb A_0_1 = this.a.b(A_0);
    if (A_0_1 == null)
      return;
    // ISSUE: reference to a compiler-generated method
    if (!A_0_1.z())
      A_2 = acf.e();
    this.c6(new kd(A_0_1, A_1, A_2, A_3, A_4));
  }

  protected override void ct(string A_0, acf A_1, acf A_2, acf A_3, Dictionary<string, Dictionary<string, string>> A_4)
  {
    kc kc = this.a.c(A_0);
    if (kc == null)
      return;
    // ISSUE: reference to a compiler-generated method
    foreach (kc.a a in kc.d())
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      ahk ahk = abh.b(acf.d(A_1, a.g()).o(), A_1.o(), A_2.l());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      acf A_1_1 = new acf(ahk.g(), a.g().l() + A_1.l(), ahk.h());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      acf A_2_1 = new acf(a.h().k(), (float) (((double) a.h().l() + (double) A_2.l()) % 360.0), a.h().m());
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.cs(a.f(), A_1_1, A_2_1, a.i(), a.b);
    }
  }

  protected virtual bool c6(kd A_0)
  {
    if (!A_0.ad())
      return true;
    if (A_0.o("harvestable"))
      return this.u(A_0);
    if (A_0.o("orb"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dr(A_0.p().o(), A_0.p("orb", "territoryguid"));
    }
    if (A_0.o("clustertargetmarker"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.n(A_0.p().o(), A_0.p("clustertargetmarker", "name", ""));
    }
    if (A_0.o("spellzone"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.m(A_0.p().o(), A_0.p("spellzone", "spell", ""));
    }
    if (A_0.o("teleportstone"))
      return this.y(A_0);
    if (A_0.o("monolith"))
      return this.r(A_0);
    if (A_0.o("watchtower"))
      return this.m(A_0, this.t(A_0.p("watchtower", "innerxml", "")));
    if (A_0.o("warcamp"))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.dq(A_0.p().o(), A_0.o("warcamp", "isattacker", false), A_0.p("warcamp", "territoryguid"), this.m(A_0.p("warcamp", "innerxml", ""), "spawnpositions", "position", "pos"), A_0.u().s());
    }
    if (A_0.o("exit"))
      return this.dx(A_0, this.m(A_0.p("exit", "innerxml", ""), "guards", "guard", "pos"));
    if (A_0.o("fasttravelpoint"))
      return this.v(A_0);
    if (A_0.o("islandaccesspoint"))
      return this.w(A_0);
    if (A_0.o("expeditionagent"))
      return this.dp(A_0);
    if (A_0.o("islandmanagement"))
      return this.x(A_0);
    if (A_0.o("realestate"))
      return this.de(A_0);
    if (A_0.o("respawnpoint"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.ds(A_0.p().o(), A_0.p("respawnpoint", "guid"), A_0.p("respawnpoint", "type", ""));
    }
    if (A_0.o("hellgatemobspawnpoint"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dm(A_0.p().o(), A_0.p("hellgatemobspawnpoint", "guid"));
    }
    if (A_0.o("hellgateexit"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.m(A_0.p().o(), A_0.r(), A_0.p("hellgateexit", "guid"), A_0.o("hellgateexit", "spawnpos", ahk.d()));
    }
    if (A_0.o("hellbossmobspawnpoint"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dn(A_0.p().o(), A_0.r(), A_0.p("hellbossmobspawnpoint", "mobname", ""), A_0.o("hellbossmobspawnpoint", "hellgatespawnpos", ahk.d()));
    }
    if (A_0.o("expeditionexit"))
      return this.dt(A_0);
    if (A_0.o("expeditionnarrator"))
      return this.du(A_0);
    if (A_0.o("siegecamp"))
      return this.s(A_0);
    if (A_0.o("clustermonolith"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.m(A_0.p().o(), A_0.p("clustermonolith", "territoryguid"), this.t(A_0.p("clustermonolith", "innerxml", "")));
    }
    if (A_0.o("minimapmarker"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dw(A_0.p().o(), A_0.p("minimapmarker", "type", ""));
    }
    if (A_0.o("unrestrictedpvpzone"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dz(A_0.p().o(), A_0.o("unrestrictedpvpzone", "radius", 0.0f));
    }
    if (A_0.o("mobspawnpoint"))
    {
      string A_0_1 = A_0.p("mobspawnpoint", "mobname", (string) null);
      string str = A_0.p("mobspawnpoint", "behavior", (string) null);
      string A_0_2 = A_0.p("mobspawnpoint", "spawnbehavior", (string) null);
      string A_0_3 = A_0.p("mobspawnpoint", "worldboss", (string) null);
      if (string.IsNullOrEmpty(A_0_1))
        return false;
      iw A_3;
      if (str == null)
      {
        A_3 = iw.d();
      }
      else
      {
        switch (str.ToUpper())
        {
          case "PATROL":
            kn A_0_4 = this.s(A_0.p("mobspawnpoint", "innerxml", (string) null));
            A_3 = A_0_4 == null || A_0_4.c() <= 0 ? iw.d() : iw.c(A_0_4);
            break;
          case "GUARD":
            A_3 = iw.c();
            break;
          default:
            A_3 = iw.d();
            break;
        }
      }
      if (!string.IsNullOrEmpty(A_0_2))
      {
        // ISSUE: reference to a compiler-generated method
        return this.dl(A_0_2, A_0.p().o(), A_0.r(), A_3);
      }
      if (!string.IsNullOrEmpty(A_0_3))
      {
        // ISSUE: reference to a compiler-generated method
        return this.@do(A_0_3, A_0.p().o(), A_0.r(), A_3);
      }
      // ISSUE: reference to a compiler-generated method
      return this.dk(A_0_1, A_0.p().o(), A_0.r(), A_3);
    }
    if (A_0.o("resourcenode"))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.m(A_0.p(), A_0.r(), A_0.s().k(), A_0.p("resourcenode", "nodetype", ""), A_0.p("resourcenode", "resourcetype", ""));
    }
    if (A_0.o("atmospherebubble"))
      return true;
    if (A_0.o("agent"))
    {
      // ISSUE: reference to a compiler-generated method
      return this.dy(A_0.p("agent", "guid"), A_0.p().o(), A_0.r());
    }
    if (A_0.o("treasurechest"))
      return this.t(A_0);
    if (A_0.o("building"))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return this.dv(A_0.p("building", "guid"), A_0.u().s(), A_0.p().o(), A_0.r());
    }
    return A_0.o("worldmapmarker") || A_0.o("expeditionstartpoint") || !A_0.o("roads") ? false : false;
  }

  protected ahk[] m(string A_0, string A_1, string A_2, string A_3)
  {
    if (string.IsNullOrEmpty(A_0))
      return (ahk[]) null;
    List<ahk> ahkList = new List<ahk>();
    XmlReader xmlReader = XmlReader.Create((TextReader) new StringReader(A_0));
    xmlReader.Read();
    if (xmlReader.Name == A_1)
    {
      xmlReader.Read();
      while (xmlReader.IsStartElement() && xmlReader.Name == A_2)
      {
        if (xmlReader.MoveToAttribute(A_3))
        {
          ahk ahk = aim.a(xmlReader.Value, ahk.d());
          ahkList.Add(ahk);
        }
        xmlReader.Read();
      }
    }
    return ahkList.ToArray();
  }

  public kn s(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (kn) null;
    return this.m(XmlReader.Create((TextReader) new StringReader(A_0)));
  }

  public kn m(XmlReader A_0)
  {
    kn kn = new kn();
    A_0.Read();
    if (A_0.IsStartElement() && !A_0.IsEmptyElement && A_0.Name == "path")
    {
      A_0.Read();
      while (A_0.IsStartElement() && A_0.Name == "waypoint")
      {
        if (A_0.HasAttributes)
        {
          ahk A_0_1 = ahk.d();
          bool A_2 = false;
          float A_1 = 0.0f;
          while (A_0.MoveToNextAttribute())
          {
            switch (A_0.Name)
            {
              case "pos":
                A_0_1 = aim.a(A_0.Value, ahk.d());
                continue;
              case "idle":
                A_1 = aim.a(A_0.Value, 0.0f);
                continue;
              case "pace":
                A_2 = A_0.Value == "RUN";
                continue;
              default:
                continue;
            }
          }
          kn.c(A_0_1, A_1, A_2);
        }
        A_0.Read();
      }
      A_0.ReadEndElement();
    }
    else
      A_0.Read();
    return kn;
  }

  protected List<ix.a> t(string A_0)
  {
    if (string.IsNullOrEmpty(A_0))
      return (List<ix.a>) null;
    A_0 = "<foo>" + A_0 + "</foo>";
    XmlReader A_0_1 = XmlReader.Create((TextReader) new StringReader(A_0));
    A_0_1.Read();
    A_0_1.Read();
    List<ix.a> aList = new List<ix.a>();
    while (A_0_1.IsStartElement() && A_0_1.Name == "guardspawnpoint")
    {
      ix.a a = new ix.a();
      bool isEmptyElement = A_0_1.IsEmptyElement;
      if (A_0_1.HasAttributes)
      {
        while (A_0_1.MoveToNextAttribute())
        {
          switch (A_0_1.Name)
          {
            case "pos":
              a.a = aim.a(A_0_1.Value, ahk.d());
              continue;
            case "roty":
              a.b = aim.a(A_0_1.Value, 0.0f);
              continue;
            case "mobname":
              a.c = A_0_1.Value;
              continue;
            case "guardtype":
              a.d = aim.a<ed.GuardType>(A_0_1.Value, ed.GuardType.BASIC, true);
              continue;
            case "behavior":
              a.e = A_0_1.Value;
              continue;
            default:
              continue;
          }
        }
        if (!isEmptyElement)
        {
          a.f = this.m(A_0_1);
          A_0_1.ReadEndElement();
        }
        else
          A_0_1.Read();
        aList.Add(a);
      }
    }
    return aList;
  }

  protected void m(string A_0, aie A_1, g8 A_2, GameTimeStamp A_3)
  {
    // ISSUE: reference to a compiler-generated method
    this.m(true);
    ka.ClusterNameInformation A_1_1;
    // ISSUE: reference to a compiler-generated method
    if (ka.b(A_1.aj(), out A_1_1))
    {
      int A_4 = aab.a(A_3, A_0);
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      Dictionary<string, HashSet<aaf>> dictionary = aab.a(A_2.bf(), A_2.bg(), A_1_1, A_1.an().br().y(), A_4, this.b);
      if (dictionary != null)
      {
        foreach (KeyValuePair<string, HashSet<aaf>> keyValuePair in dictionary)
        {
          foreach (aaf aaf in keyValuePair.Value)
          {
            acf A_1_2 = aaf.a;
            acf A_2_1 = new acf(0.0f, aaf.b, 0.0f);
            acf A_3_1 = new acf(aaf.c, aaf.c, aaf.c);
            if (this.a.c(keyValuePair.Key) != null)
            {
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              A_1_2 = new acf((float) (int) Math.Floor((double) A_1_2.k()), A_1_2.l(), (float) (int) Math.Floor((double) A_1_2.m()));
              this.ct(keyValuePair.Key, A_1_2, A_2_1, A_3_1, (Dictionary<string, Dictionary<string, string>>) null);
            }
            else
            {
              acb A_0_1 = this.a.b(keyValuePair.Key);
              if (A_0_1 != null)
              {
                kd.a A_2_2 = kd.o(aaf.b);
                ahk ahk = aca.m(A_0_1, A_1_2.o(), A_2_2);
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                A_1_2 = new acf(ahk.g(), A_1_2.l(), ahk.h());
              }
              this.cs(keyValuePair.Key, A_1_2, A_2_1, A_3_1, (Dictionary<string, Dictionary<string, string>>) null);
            }
          }
        }
      }
    }
    // ISSUE: reference to a compiler-generated method
    this.m(false);
  }

  protected override void cu()
  {
    this.b.Clear();
    base.cu();
  }

  protected virtual bool dk(string A_0, ahk A_1, float A_2, iw A_3)
  {
    return true;
  }

  protected virtual bool dl(string A_0, ahk A_1, float A_2, iw A_3)
  {
    return true;
  }

  protected virtual bool @do(string A_0, ahk A_1, float A_2, iw A_3)
  {
    return true;
  }

  protected virtual bool m(acf A_0, float A_1, float A_2, string A_3, string A_4)
  {
    ResourceNodeTypes A_0_1;
    switch (A_3.ToLower())
    {
      case "medium":
        A_0_1 = ResourceNodeTypes.medium;
        break;
      case "high":
        A_0_1 = ResourceNodeTypes.high;
        break;
      default:
        A_0_1 = ResourceNodeTypes.low;
        break;
    }
    aae key = new aae(A_0_1, A_4.ToUpper());
    HashSet<aaf> aafSet;
    if (!this.b.TryGetValue(key, out aafSet))
    {
      aafSet = new HashSet<aaf>((IEqualityComparer<aaf>) new aad());
      this.b.Add(key, aafSet);
    }
    aafSet.Add(new aaf(A_0, A_1, A_2));
    return false;
  }

  protected virtual bool dv(Guid A_0, string A_1, ahk A_2, float A_3)
  {
    return true;
  }

  protected virtual bool r(kd A_0)
  {
    return true;
  }

  protected virtual bool m(kd A_0, List<ix.a> A_1)
  {
    return true;
  }

  protected virtual bool m(ahk A_0, Guid A_1, List<ix.a> A_2)
  {
    return true;
  }

  protected virtual bool s(kd A_0)
  {
    return true;
  }

  protected virtual bool t(kd A_0)
  {
    return true;
  }

  protected virtual bool dr(ahk A_0, Guid A_1)
  {
    return true;
  }

  protected virtual bool dq(ahk A_0, bool A_1, Guid A_2, ahk[] A_3, string A_4)
  {
    return true;
  }

  protected virtual bool u(kd A_0)
  {
    return true;
  }

  protected virtual bool dx(kd A_0, ahk[] A_1)
  {
    return true;
  }

  protected virtual bool ds(ahk A_0, Guid A_1, string A_2)
  {
    return true;
  }

  protected virtual bool dm(ahk A_0, Guid A_1)
  {
    return true;
  }

  protected virtual bool m(ahk A_0, float A_1, Guid A_2, ahk A_3)
  {
    return true;
  }

  protected virtual bool dt(kd A_0)
  {
    return true;
  }

  protected virtual bool de(kd A_0)
  {
    return true;
  }

  protected virtual bool dw(ahk A_0, string A_1)
  {
    return true;
  }

  protected virtual bool dz(ahk A_0, float A_1)
  {
    return true;
  }

  protected virtual bool dn(ahk A_0, float A_1, string A_2, ahk A_3)
  {
    return true;
  }

  protected virtual bool v(kd A_0)
  {
    return true;
  }

  protected virtual bool w(kd A_0)
  {
    return true;
  }

  protected virtual bool x(kd A_0)
  {
    return true;
  }

  protected virtual bool y(kd A_0)
  {
    return true;
  }

  protected virtual bool m(ahk A_0, string A_1)
  {
    return true;
  }

  protected virtual bool n(ahk A_0, string A_1)
  {
    return true;
  }

  protected virtual bool dy(Guid A_0, ahk A_1, float A_2)
  {
    return true;
  }

  protected virtual bool dp(kd A_0)
  {
    return true;
  }

  protected virtual bool du(kd A_0)
  {
    return true;
  }

  public class a
  {
    public string e = "ROAM";
    public ahk a;
    public float b;
    public string c;
    public ed.GuardType d;
    public kn f;
  }
}
