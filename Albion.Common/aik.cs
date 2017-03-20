// Decompiled with JetBrains decompiler
// Type: aik
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Xml;

public class aik : n
{
  private Dictionary<string, aij> hu = new Dictionary<string, aij>();
  private Dictionary<string, List<aij>> hv = new Dictionary<string, List<aij>>();
  private Dictionary<string, aif> hw = new Dictionary<string, aif>();
  private Dictionary<string, aie> hx = new Dictionary<string, aie>();
  private Dictionary<string, ah9> hy = new Dictionary<string, ah9>();
  private Dictionary<string, Dictionary<string, aik.c>> hz = new Dictionary<string, Dictionary<string, aik.c>>();
  private Dictionary<string, Dictionary<string, aik.c>> h0 = new Dictionary<string, Dictionary<string, aik.c>>();
  private Dictionary<string, ah8> h1 = new Dictionary<string, ah8>();
  private Dictionary<string, ah5> h2 = new Dictionary<string, ah5>();
  private Dictionary<string, HashSet<aie>> h3 = new Dictionary<string, HashSet<aie>>();
  private Dictionary<string, j2> h4 = new Dictionary<string, j2>();

  [SpecialName]
  public IEnumerable<aie> h2()
  {
    return (IEnumerable<aie>) this.hx.Values;
  }

  public virtual void hz(string A_0)
  {
    this.h0(new StreamReader(A_0).ReadToEnd());
  }

  public virtual void h0(string A_0)
  {
    XmlDocument xmlDocument = new XmlDocument();
    xmlDocument.LoadXml(A_0);
    if (xmlDocument.DocumentElement.Name != "world")
      throw new AlbionException("invalid file format for world");
    this.aq(xmlDocument.DocumentElement);
  }

  public virtual void hz(XmlElement A_0)
  {
  }

  public virtual void h0(XmlElement A_0)
  {
  }

  public aie h1(string A_0)
  {
    if (A_0 == null)
      return (aie) null;
    aie aie;
    if (this.hx.TryGetValue(A_0, out aie))
      return aie;
    return (aie) null;
  }

  public aif h2(string A_0)
  {
    aif aif;
    this.hw.TryGetValue(A_0, out aif);
    return aif;
  }

  public aij h3(string A_0)
  {
    aij aij;
    this.hu.TryGetValue(A_0, out aij);
    return aij;
  }

  public aij hz(Guid A_0)
  {
    foreach (aij aij in this.hu.Values)
    {
      // ISSUE: reference to a compiler-generated method
      if (aij.n() == A_0)
        return aij;
    }
    return (aij) null;
  }

  public ah5 h4(string A_0)
  {
    ah5 ah5;
    this.h2.TryGetValue(A_0, out ah5);
    return ah5;
  }

  public Dictionary<string, ah5>.ValueCollection h4()
  {
    return this.h2.Values;
  }

  public Dictionary<string, aij>.ValueCollection h5()
  {
    return this.hu.Values;
  }

  public IEnumerable<aij> h5(string A_0)
  {
    List<aij> aijList;
    this.hv.TryGetValue(A_0, out aijList);
    return (IEnumerable<aij>) aijList;
  }

  public ah9 h6(string A_0)
  {
    ah9 ah9;
    this.hy.TryGetValue(A_0, out ah9);
    return ah9;
  }

  public ICollection<ah9> h6()
  {
    return (ICollection<ah9>) this.hy.Values;
  }

  public ICollection<ah8> h7()
  {
    return (ICollection<ah8>) this.h1.Values;
  }

  public ah8 h7(string A_0)
  {
    ah8 ah8;
    this.h1.TryGetValue(A_0, out ah8);
    return ah8;
  }

  public Dictionary<string, aik.c> hz(string A_0, bool A_1)
  {
    Dictionary<string, aik.c> dictionary;
    if (A_1)
      this.h0.TryGetValue(A_0, out dictionary);
    else
      this.hz.TryGetValue(A_0, out dictionary);
    return dictionary;
  }

  private static string hz(string A_0, Dictionary<string, List<XmlElement>> A_1)
  {
    foreach (KeyValuePair<string, List<XmlElement>> keyValuePair in A_1)
    {
      string key = keyValuePair.Key;
      foreach (XmlElement A_0_1 in keyValuePair.Value)
      {
        if (aim.h(A_0_1, "id") == A_0)
          return key;
      }
    }
    return (string) null;
  }

  protected override bool aq(XmlElement A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.a(A_0, "boundsmin", ahk.d()));
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.a(A_0, "boundsmax", ahk.d()));
    Dictionary<string, List<XmlElement>> A_1_1 = new Dictionary<string, List<XmlElement>>();
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.a(A_0, "scale", 0.25f));
    XmlNodeList elementsByTagName1 = A_0.GetElementsByTagName("clusters");
    if (elementsByTagName1.Count <= 0)
      return false;
    XmlElement xmlElement1 = (XmlElement) elementsByTagName1[0];
    foreach (XmlElement A_0_1 in xmlElement1.GetElementsByTagName("cluster"))
    {
      string attribute1 = A_0_1.GetAttribute("id");
      string attribute2 = A_0_1.GetAttribute("file");
      string A_2_1 = A_0_1.GetAttribute("displayname");
      if (A_2_1 == string.Empty)
        A_2_1 = attribute1;
      bool A_0_2 = aim.a(A_0_1, "enabled", false);
      // ISSUE: reference to a compiler-generated method
      if (A_0_2 || this.h3())
      {
        aie aie = (aie) null;
        if (!string.IsNullOrEmpty(attribute1))
        {
          this.hz(A_0_1);
          string A_3 = aim.a(A_0_1, "type", "DEFAULT");
          string A_10 = aim.h(A_0_1, "timeregion");
          string A_5 = aim.a(A_0_1, "clustertexttag", "");
          string A_4 = aim.a(A_0_1, "speciallocation", "");
          string A_9 = aim.a(A_0_1, "categoryname", "");
          string A_11 = aim.h(A_0_1, "marketplacegroup");
          ahk ahk1 = aim.a(A_0_1, "origin", ahk.d());
          ahk ahk2 = aim.a(A_0_1, "size", ahk.d());
          ahk A_8 = aim.a(A_0_1, "editoroffset", ahk.d());
          aie = new aie(attribute1, attribute2, A_2_1, A_3, A_4, A_5, ahk1, ahk2, A_8, A_9, A_10, A_11);
          // ISSUE: reference to a compiler-generated method
          aie.ah(A_0_2);
          // ISSUE: reference to a compiler-generated method
          aie.ak(aim.a(A_0_1, "minimapBoundsMin", ahk1));
          // ISSUE: reference to a compiler-generated method
          aie.al(aim.a(A_0_1, "minimapBoundsMax", ahk.d(ahk1, ahk2)));
          this.hx.Add(attribute1, aie);
          XmlNodeList elementsByTagName2 = A_0_1.GetElementsByTagName("distribution");
          if (elementsByTagName2.Count > 0)
          {
            XmlElement A_0_3 = (XmlElement) elementsByTagName2[0];
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            aie.aq().c(aim.b(A_0_3, "realestates", 0));
            foreach (XmlElement A_0_4 in A_0_3.GetElementsByTagName("resource"))
            {
              string A_0_5 = aim.a(A_0_4, "name", "");
              int A_1_2 = aim.b(A_0_4, "tier", 0);
              int A_2_2 = aim.b(A_0_4, "count", 0);
              if (!string.IsNullOrEmpty(A_0_5))
              {
                // ISSUE: reference to a compiler-generated method
                aie.aq().c(A_0_5, A_1_2, A_2_2);
              }
            }
          }
        }
        XmlNodeList elementsByTagName3 = A_0_1.GetElementsByTagName("minimapmarkers");
        if (elementsByTagName3.Count > 0)
        {
          foreach (XmlElement A_0_3 in elementsByTagName3[0])
          {
            string A_0_4 = aim.a(A_0_3, "type", string.Empty);
            ahk A_1_2 = aim.a(A_0_3, "pos", ahk.d());
            // ISSUE: reference to a compiler-generated method
            aie.ay().Add(new aic(A_0_4, A_1_2));
          }
        }
        XmlNodeList elementsByTagName4 = A_0_1.GetElementsByTagName("worldmapmarkers");
        if (elementsByTagName4.Count > 0)
        {
          foreach (XmlElement A_0_3 in elementsByTagName4[0])
          {
            string A_0_4 = aim.a(A_0_3, "type", string.Empty);
            ahk A_1_2 = aim.a(A_0_3, "pos", ahk.d());
            // ISSUE: reference to a compiler-generated method
            aie.az().Add(new aib(A_0_4, A_1_2));
          }
        }
        XmlNodeList elementsByTagName5 = A_0_1.GetElementsByTagName("exits");
        if (elementsByTagName5.Count > 0)
        {
          XmlElement xmlElement2 = (XmlElement) elementsByTagName5[0];
          List<XmlElement> xmlElementList = new List<XmlElement>();
          foreach (XmlElement xmlElement3 in xmlElement2.GetElementsByTagName("exit"))
            xmlElementList.Add(xmlElement3);
          A_1_1[attribute1] = xmlElementList;
        }
        XmlNodeList elementsByTagName6 = A_0_1.GetElementsByTagName("hellgatemobspawnpoints");
        if (elementsByTagName6.Count > 0)
        {
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName6[0]).GetElementsByTagName("hellgatemobspawnpoint"))
          {
            ah5 ah5 = new ah5(A_0_3, this, aie);
            this.h2.Add(ah5.f(), ah5);
          }
        }
        XmlNodeList elementsByTagName7 = A_0_1.GetElementsByTagName("territories");
        if (elementsByTagName7.Count > 0)
        {
          List<aij> A_0_3 = new List<aij>();
          foreach (XmlElement A_0_4 in ((XmlElement) elementsByTagName7[0]).GetElementsByTagName("territory"))
          {
            if (aim.h(A_0_4, "id").Length > 0)
            {
              aij aij = new aij(A_0_4, aie);
              this.hu.Add(aij.m(), aij);
              A_0_3.Add(aij);
              this.h0(A_0_4);
            }
          }
          // ISSUE: reference to a compiler-generated method
          aie.ah(A_0_3);
          this.hv.Add(attribute1, A_0_3);
        }
        XmlNodeList elementsByTagName8 = A_0_1.GetElementsByTagName("travelpoints");
        if (elementsByTagName8 != null && elementsByTagName8.Count > 0)
        {
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName8[0]).GetElementsByTagName("travelpoint"))
          {
            if (!string.IsNullOrEmpty(aim.h(A_0_3, "id")))
            {
              ah9 ah9 = new ah9(A_0_3, aie);
              this.hy.Add(ah9.e(), ah9);
            }
          }
        }
        XmlNodeList elementsByTagName9 = A_0_1.GetElementsByTagName("expeditionstartpoints");
        if (elementsByTagName9 != null && elementsByTagName9.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          aie.ah(new List<j2>());
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName9[0]).GetElementsByTagName("expeditionstartpoint"))
          {
            if (!string.IsNullOrEmpty(aim.h(A_0_3, "id")))
            {
              j2 j2 = new j2(A_0_3, this, aie);
              // ISSUE: reference to a compiler-generated method
              aie.a5().Add(j2);
              this.h4.Add(j2.h(), j2);
            }
          }
        }
        XmlNodeList elementsByTagName10 = A_0_1.GetElementsByTagName("islandaccesspoints");
        if (elementsByTagName10 != null && elementsByTagName10.Count > 0)
        {
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName10[0]).GetElementsByTagName("islandaccesspoint"))
          {
            if (!string.IsNullOrEmpty(aim.h(A_0_3, "id")))
            {
              ah8 ah8 = new ah8(A_0_3, this, aie);
              this.h1.Add(ah8.e(), ah8);
            }
          }
        }
        XmlNodeList elementsByTagName11 = A_0_1.GetElementsByTagName("hellgateexits");
        if (elementsByTagName11 != null && elementsByTagName11.Count > 0)
        {
          List<Guid> A_0_3 = new List<Guid>();
          foreach (XmlElement A_0_4 in ((XmlElement) elementsByTagName11[0]).GetElementsByTagName("hellgateexit"))
          {
            string g = aim.h(A_0_4, "id");
            if (!string.IsNullOrEmpty(g))
              A_0_3.Add(new Guid(g));
          }
          // ISSUE: reference to a compiler-generated method
          aie.ah(A_0_3);
        }
        XmlNodeList elementsByTagName12 = A_0_1.GetElementsByTagName("treasurechests");
        if (elementsByTagName12 != null && elementsByTagName12.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          aie.ah(new List<ah4>());
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName12[0]).GetElementsByTagName("treasurechest"))
          {
            ah4 ah4 = new ah4(A_0_3, aie);
            // ISSUE: reference to a compiler-generated method
            aie.a3().Add(ah4);
          }
        }
        XmlNodeList elementsByTagName13 = A_0_1.GetElementsByTagName("worldbosses");
        if (elementsByTagName13 != null && elementsByTagName13.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          aie.ah(new List<ah3>());
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName13[0]).GetElementsByTagName("worldboss"))
          {
            ah3 ah3 = new ah3(A_0_3, aie);
            // ISSUE: reference to a compiler-generated method
            aie.a4().Add(ah3);
          }
        }
        XmlNodeList elementsByTagName14 = A_0_1.GetElementsByTagName("agents");
        if (elementsByTagName14 != null && elementsByTagName14.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          aie.ah(new List<ah6>());
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName14[0]).GetElementsByTagName("agent"))
          {
            ah6 ah6 = new ah6(A_0_3, aie);
            // ISSUE: reference to a compiler-generated method
            aie.a2().Add(ah6);
          }
        }
        XmlNodeList elementsByTagName15 = A_0_1.GetElementsByTagName("mobcounts");
        if (elementsByTagName15 != null && elementsByTagName15.Count > 0)
        {
          // ISSUE: reference to a compiler-generated method
          aie.ah(new Dictionary<string, int>());
          foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName15[0]).GetElementsByTagName("mob"))
          {
            string key = aim.a(A_0_3, "name", string.Empty);
            int num = aim.b(A_0_3, "count", 0);
            if (num > 0)
            {
              // ISSUE: reference to a compiler-generated method
              aie.a6().Add(key, num);
            }
          }
        }
        XmlElement A_0_6 = aim.e(A_0_1, "roads");
        if (A_0_6 != null)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          aie.bd().c(aim.g(A_0_6, "nodes"));
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          aie.bd().c(aim.f(A_0_6, "links"));
        }
      }
    }
    foreach (KeyValuePair<string, List<XmlElement>> keyValuePair in A_1_1)
    {
      string key1 = keyValuePair.Key;
      aie A_0_1 = this.hx[key1];
      // ISSUE: reference to a compiler-generated method
      A_0_1.ah(new List<aif>());
      foreach (XmlElement A_0_2 in keyValuePair.Value)
      {
        string g1 = aim.h(A_0_2, "id");
        string[] strArray = aim.h(A_0_2, "targetid").Split('@');
        string str = strArray[0];
        string key2 = strArray.Length > 1 ? strArray[1] : aik.hz(str, A_1_1);
        if (string.IsNullOrEmpty(key2))
        {
          int num = new Guid(str) != Guid.Empty ? 1 : 0;
        }
        string g2 = aim.h(A_0_2, "territory");
        bool A_5 = aim.a(A_0_2, "restricted", false);
        ahk A_6 = aim.a(A_0_2, "pos", ahk.d());
        aif.Kind A_2_1 = aif.Kind.Cluster;
        aif.Kind A_7 = aim.a<aif.Kind>(A_0_2, "targettype", A_2_1);
        Guid A_1_2 = new Guid(g1);
        aie A_2_2;
        aif aif = string.IsNullOrEmpty(key2) || !this.hx.TryGetValue(key2, out A_2_2) ? new aif(A_0_1, A_1_2, (aie) null, new Guid(str), new Guid(g2), A_5, A_6, A_7) : new aif(A_0_1, A_1_2, A_2_2, new Guid(str), new Guid(g2), A_5, A_6, A_7);
        // ISSUE: reference to a compiler-generated method
        A_0_1.ax().Add(aif);
        this.hw[g1 + "@" + key1] = aif;
      }
    }
    foreach (XmlElement A_0_1 in xmlElement1.GetElementsByTagName("cluster"))
    {
      // ISSUE: reference to a compiler-generated method
      if (aim.a(A_0_1, "enabled", false) || this.h3())
      {
        string attribute = A_0_1.GetAttribute("name");
        if (!string.IsNullOrEmpty(attribute))
        {
          XmlNodeList elementsByTagName2 = A_0_1.GetElementsByTagName("territories");
          if (elementsByTagName2.Count != 0)
          {
            foreach (XmlElement A_0_2 in ((XmlElement) elementsByTagName2[0]).GetElementsByTagName("territory"))
            {
              string str1 = aim.h(A_0_2, "id");
              aij aij;
              if (!string.IsNullOrEmpty(str1) && this.hu.TryGetValue(str1 + "@" + attribute, out aij))
              {
                XmlNodeList elementsByTagName3 = A_0_2.GetElementsByTagName("connections");
                if (elementsByTagName3.Count != 0)
                {
                  foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName3[0]).GetElementsByTagName("connection"))
                  {
                    string str2 = aim.h(A_0_3, "to");
                    string str3 = aim.h(A_0_3, "type");
                    if (!string.IsNullOrEmpty(str2) && !str2.Contains("@"))
                    {
                      aih.Direction A_1_2 = (aih.Direction) Enum.Parse(typeof (aih.Direction), str3);
                      if (this.hu.ContainsKey(str2 + "@" + attribute))
                      {
                        aih aih = new aih(str2 + "@" + attribute, A_1_2);
                        // ISSUE: reference to a compiler-generated method
                        aij.l().Add(aih);
                      }
                      else
                      {
                        foreach (KeyValuePair<string, aij> keyValuePair in this.hu)
                        {
                          if (keyValuePair.Key.StartsWith(str2))
                          {
                            aih aih = new aih(keyValuePair.Key, A_1_2);
                            // ISSUE: reference to a compiler-generated method
                            aij.l().Add(aih);
                            break;
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
            XmlNodeList elementsByTagName4 = A_0_1.GetElementsByTagName("travelpoints");
            if (elementsByTagName4 != null && elementsByTagName4.Count > 0)
            {
              foreach (XmlElement A_0_2 in ((XmlElement) elementsByTagName4[0]).GetElementsByTagName("travelpoint"))
              {
                string str1 = aim.h(A_0_2, "id");
                if (str1.Length != 0)
                {
                  XmlNodeList elementsByTagName3 = A_0_2.GetElementsByTagName("connections");
                  ah9 ah9;
                  if (elementsByTagName3.Count != 0 && this.hy.TryGetValue(str1 + "@" + attribute, out ah9))
                  {
                    foreach (XmlElement A_0_3 in ((XmlElement) elementsByTagName3[0]).GetElementsByTagName("connection"))
                    {
                      string str2 = aim.h(A_0_3, "to");
                      if (!string.IsNullOrEmpty(str1) && !str2.Contains("@"))
                      {
                        float A_1_2 = aim.a(A_0_3, "costmodifier", 1f);
                        bool A_2 = aim.a(A_0_3, "noluggage", false);
                        if (this.hy.ContainsKey(str2 + "@" + attribute))
                        {
                          ah7 ah7 = new ah7(str2 + "@" + attribute, A_1_2, A_2);
                          // ISSUE: reference to a compiler-generated method
                          ah9.h().Add(ah7);
                        }
                        else
                        {
                          foreach (KeyValuePair<string, ah9> keyValuePair in this.hy)
                          {
                            if (keyValuePair.Key.StartsWith(str2))
                            {
                              ah7 ah7 = new ah7(keyValuePair.Key, A_1_2, A_2);
                              // ISSUE: reference to a compiler-generated method
                              ah9.h().Add(ah7);
                              break;
                            }
                          }
                        }
                      }
                    }
                  }
                }
              }
            }
          }
        }
      }
    }
    foreach (aij aij in this.hu.Values)
    {
      List<string> stringList = new List<string>();
      // ISSUE: reference to a compiler-generated method
      foreach (aih aih in aij.l())
      {
        // ISSUE: reference to a compiler-generated method
        if (this.h3(aih.c()) == null)
        {
          // ISSUE: reference to a compiler-generated method
          stringList.Add(aih.c());
        }
      }
      foreach (string str in stringList)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (aih aih in aij.l())
        {
          // ISSUE: reference to a compiler-generated method
          if (aih.c() == str)
          {
            // ISSUE: reference to a compiler-generated method
            aij.l().Remove(aih);
            break;
          }
        }
      }
    }
    return true;
  }

  public void hz(g8 A_0)
  {
    foreach (aie aie in this.hx.Values)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aie.ah(A_0.a7().h1(aie.ao()));
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      aie.ah(A_0.a7().hz(aie.am()));
      // ISSUE: reference to a compiler-generated method
      if (aie.an() == null)
      {
        // ISSUE: reference to a compiler-generated method
        aie.ah(j7.f);
      }
      // ISSUE: reference to a compiler-generated method
      if (aie.a2() != null)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (ah6 ah6 in aie.a2())
          ah6.k(A_0);
      }
      // ISSUE: reference to a compiler-generated method
      if (aie.a3() != null)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (ah4 ah4 in aie.a3())
          ah4.e(A_0);
      }
      // ISSUE: reference to a compiler-generated method
      if (aie.a4() != null)
      {
        // ISSUE: reference to a compiler-generated method
        foreach (ah3 ah3 in aie.a4())
          ah3.d(A_0);
      }
    }
    foreach (aij aij in this.hu.Values)
      aij.l(A_0);
    foreach (ah9 ah9 in this.hy.Values)
      ah9.e(A_0);
    foreach (ah9 A_0_1 in this.hy.Values)
    {
      Dictionary<string, aik.c> dictionary1 = this.hz(A_0_1, true);
      Dictionary<string, aik.c> dictionary2 = this.hz(A_0_1, false);
      this.hz.Add(A_0_1.e(), dictionary1);
      this.h0.Add(A_0_1.e(), dictionary2);
    }
  }

  private Dictionary<string, aik.c> hz(ah9 A_0, bool A_1)
  {
    g<aik.c, float> g = new g<aik.c, float>();
    Dictionary<string, aik.c> dictionary = new Dictionary<string, aik.c>(1000);
    foreach (ah9 A_0_1 in this.hy.Values)
    {
      aik.c A_0_2 = new aik.c();
      // ISSUE: reference to a compiler-generated method
      A_0_2.d(A_0_1);
      if (A_0_1 != A_0)
      {
        // ISSUE: reference to a compiler-generated method
        A_0_2.d(float.MaxValue);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        A_0_2.d(0.0f);
      }
      // ISSUE: reference to a compiler-generated method
      A_0_2.d((aik.c) null);
      // ISSUE: reference to a compiler-generated method
      g.c(A_0_2, -A_0_2.e());
      dictionary.Add(A_0_1.e(), A_0_2);
    }
    while (!g.e())
    {
      aik.c A_0_1 = g.g();
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      foreach (ah7 ah7 in A_0_1.d().h())
      {
        aik.c A_0_2;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        if (ah7.h() != null && (!A_1 || !ah7.g()) && dictionary.TryGetValue(ah7.h().e(), out A_0_2))
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          float A_0_3 = A_0_1.e() + ah7.f();
          // ISSUE: reference to a compiler-generated method
          if ((double) A_0_3 < (double) A_0_2.e())
          {
            // ISSUE: reference to a compiler-generated method
            g.c(A_0_2, -A_0_2.e(), -A_0_3);
            // ISSUE: reference to a compiler-generated method
            A_0_2.d(A_0_3);
            // ISSUE: reference to a compiler-generated method
            A_0_2.d(A_0_1);
          }
        }
      }
    }
    return dictionary;
  }

  public bool hz(string A_0, string A_1, out bool A_2, out kx A_3, out kx A_4, out kx A_5, kx A_6, g8 A_7)
  {
    bool[] flagArray = new bool[2]{ false, true };
    foreach (bool A_1_1 in flagArray)
    {
      Dictionary<string, aik.c> dictionary = this.hz(A_0, A_1_1);
      if (dictionary != null)
      {
        aik.c c = (aik.c) null;
        dictionary.TryGetValue(A_1, out c);
        // ISSUE: reference to a compiler-generated method
        if (c != null && (double) c.e() != 3.40282346638529E+38)
        {
          // ISSUE: reference to a compiler-generated method
          float num = c.e();
          // ISSUE: reference to a compiler-generated method
          A_3 = kx.o(kx.f((double) num), A_7.ar().ea).q();
          A_4 = A_1_1 ? kx.g : kx.o(kx.f((double) num), A_6).q();
          A_5 = kx.q(A_3, A_4);
          A_2 = A_1_1;
          return true;
        }
      }
    }
    A_2 = false;
    A_3 = kx.g;
    A_4 = kx.g;
    A_5 = kx.g;
    return false;
  }

  public HashSet<aie> hz(string A_0, int A_1, int A_2)
  {
    if (A_2 > this.hx.Count)
      A_2 = this.hx.Count;
    lock (this.h3)
    {
      string local_1 = A_0 + "#" + (object) A_1 + "#" + (object) A_2;
      HashSet<aie> local_0;
      if (this.h3.TryGetValue(local_1, out local_0))
        return local_0;
      HashSet<aie> local_0_1 = new HashSet<aie>();
      List<string> local_2 = new List<string>();
      HashSet<string> local_3 = new HashSet<string>();
      local_2.Add(A_0);
      int local_4 = 0;
      while (local_2.Count > 0)
      {
        foreach (string item_0 in local_2)
        {
          local_3.Add(item_0);
          aie local_6 = this.h1(item_0);
          if (local_6 != null && local_4 >= A_1 && local_4 <= A_2)
            local_0_1.Add(local_6);
        }
        ++local_4;
        if (local_4 <= A_2)
        {
          List<string> local_7 = new List<string>((IEnumerable<string>) local_2);
          local_2.Clear();
          foreach (string item_2 in local_7)
          {
            // ISSUE: reference to a compiler-generated method
            foreach (aif item_1 in this.h1(item_2).ax())
            {
              aif local_11 = this.h2(item_1.q());
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              // ISSUE: reference to a compiler-generated method
              if (local_11 != null && local_11.l().ah() != item_2 && (!local_3.Contains(local_11.l().ah()) && !local_2.Contains(local_11.l().ah())))
              {
                // ISSUE: reference to a compiler-generated method
                // ISSUE: reference to a compiler-generated method
                local_2.Add(local_11.l().ah());
              }
            }
          }
        }
        else
          break;
      }
      this.h3.Add(local_1, local_0_1);
      return local_0_1;
    }
  }

  public enum a
  {
    a,
    b,
  }

  public enum b
  {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
  }

  public class c : IComparable<aik.c>
  {
    public int CompareTo(aik.c other)
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if ((double) this.e() > (double) other.e())
        return 1;
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      return (double) this.e() == (double) other.e() ? 0 : -1;
    }
  }
}
