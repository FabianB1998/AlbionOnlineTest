// Decompiled with JetBrains decompiler
// Type: em
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Xml;

public class em : n
{
  private Dictionary<string, ec> az = new Dictionary<string, ec>();

  public ec hz(string A_0)
  {
    ec ec = (ec) null;
    this.az.TryGetValue(A_0, out ec);
    return ec;
  }

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "LootDefinition")
      throw new AlbionException("[LootData] LoadDataFromXml: XmlTag 'hints' not found! Invalid Xml File?");
    foreach (XmlNode childNode in A_0.ChildNodes)
    {
      XmlElement A_0_1 = childNode as XmlElement;
      if (A_0_1 != null && A_0_1.Name == "Lootlist")
      {
        string key = aim.h(A_0_1, "name");
        ec ec = new ec();
        ec.cb(A_0_1);
        this.az.Add(key, ec);
      }
    }
    return true;
  }

  public List<d5> hz(d5 A_0, kt A_1)
  {
    return this.hz(A_0, A_1, 1f, false);
  }

  public List<d5> hz(d5 A_0, kt A_1, float A_2, bool A_3)
  {
    List<d5> A_4 = new List<d5>();
    this.hz(A_0, A_1, A_2, A_3, A_4);
    return A_4;
  }

  protected void hz(d5 A_0, kt A_1, float A_2, bool A_3, List<d5> A_4)
  {
    float A_2_1 = A_3 ? 1f : A_2;
    if (A_0 is eb)
    {
      eb eb = (eb) A_0;
      // ISSUE: reference to a compiler-generated method
      float num1 = (float) A_1.cw(0.0, (double) eb.n());
      float num2 = 0.0f;
      // ISSUE: reference to a compiler-generated method
      if (eb.o() == null)
        return;
      // ISSUE: reference to a compiler-generated method
      foreach (d5 A_0_1 in eb.o())
      {
        // ISSUE: reference to a compiler-generated method
        num2 += A_0_1.s();
        if ((double) num1 <= (double) num2)
        {
          this.hz(A_0_1, A_1, A_2_1, A_3, A_4);
          break;
        }
      }
    }
    else if (A_0 is ec)
    {
      ec ec = (ec) A_0;
      // ISSUE: reference to a compiler-generated method
      if (ec.o() == null)
        return;
      // ISSUE: reference to a compiler-generated method
      using (List<d5>.Enumerator enumerator = ec.o().GetEnumerator())
      {
label_19:
        if (!enumerator.MoveNext())
          return;
        d5 current = enumerator.Current;
        // ISSUE: reference to a compiler-generated method
        float num = current.r() * A_2;
        // ISSUE: reference to a compiler-generated method
        if (!current.t())
          num = Math.Min(num, 1f);
        do
        {
          if ((double) num >= 1.0 || A_1.cz(num))
            this.hz(current, A_1, A_2_1, A_3, A_4);
          --num;
        }
        while ((double) num > 0.0);
        goto label_19;
      }
    }
    else if (A_0 is d9)
    {
      // ISSUE: reference to a compiler-generated method
      ec ec = this.hz(((d9) A_0).n());
      if (ec == null)
        return;
      this.hz((d5) ec, A_1, A_2_1, A_3, A_4);
    }
    else
      A_4.Add(A_0);
  }

  public List<d5> hz(d5 A_0)
  {
    List<d5> A_1 = new List<d5>();
    this.hz(A_0, A_1);
    return A_1;
  }

  protected void hz(d5 A_0, List<d5> A_1)
  {
    if (A_0 is ea)
    {
      // ISSUE: reference to a compiler-generated method
      foreach (d5 A_0_1 in ((ea) A_0).o())
        this.hz(A_0_1, A_1);
    }
    else if (A_0 is d9)
    {
      // ISSUE: reference to a compiler-generated method
      ec ec = this.hz(((d9) A_0).n());
      if (ec == null)
        return;
      this.hz((d5) ec, A_1);
    }
    else
      A_1.Add(A_0);
  }

  public List<d8> hz(d5 A_0, abc A_1)
  {
    return this.hz(A_0, A_1, 1f, false);
  }

  public List<d8> hz(d5 A_0, abc A_1, float A_2, bool A_3)
  {
    Dictionary<d5, int> A_5 = new Dictionary<d5, int>();
    List<d8> A_4 = new List<d8>();
    this.hz(A_0, A_1, A_2, A_3, A_4, A_5);
    return A_4;
  }

  protected void hz(d5 A_0, abc A_1, float A_2, bool A_3, List<d8> A_4, Dictionary<d5, int> A_5)
  {
    float A_2_1 = A_3 ? 1f : A_2;
    if (A_0 is eb)
    {
      d5 A_0_1 = this.hz((eb) A_0, A_1, A_5);
      if (A_0_1 == null)
        return;
      this.hz(A_0_1, A_1, A_2_1, A_3, A_4, A_5);
    }
    else if (A_0 is ec)
    {
      // ISSUE: reference to a compiler-generated method
      using (List<d5>.Enumerator enumerator = ((ea) A_0).o().GetEnumerator())
      {
label_9:
        if (!enumerator.MoveNext())
          return;
        d5 current = enumerator.Current;
        // ISSUE: reference to a compiler-generated method
        float val1 = current.r() * A_2;
        // ISSUE: reference to a compiler-generated method
        if (!current.t())
          val1 = Math.Min(val1, 1f);
        do
        {
          this.hz(current, A_1, A_2_1, A_3, A_4, A_5);
          --val1;
        }
        while ((double) val1 > 0.0);
        goto label_9;
      }
    }
    else if (A_0 is d9)
    {
      // ISSUE: reference to a compiler-generated method
      ec ec = this.hz(((d9) A_0).n());
      if (ec == null)
        return;
      this.hz((d5) ec, A_1, A_2_1, A_3, A_4, A_5);
    }
    else
    {
      if (!(A_0 is d8))
        return;
      A_4.Add(A_0 as d8);
    }
  }

  protected d5 hz(eb A_0, abc A_1, Dictionary<d5, int> A_2)
  {
    int num1 = 0;
    // ISSUE: reference to a compiler-generated method
    for (int index = 0; index < A_0.o().Count; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      int num2 = this.hz(A_0.o()[index], A_1, A_2);
      if (num2 > num1)
        num1 = num2;
    }
    return (d5) null;
  }

  protected int hz(d5 A_0, abc A_1, Dictionary<d5, int> A_2)
  {
    int num1 = 0;
    if (!A_2.TryGetValue(A_0, out num1))
    {
      if (A_0 is eb)
      {
        eb eb = A_0 as eb;
        // ISSUE: reference to a compiler-generated method
        for (int index = 0; index < eb.o().Count; ++index)
        {
          // ISSUE: reference to a compiler-generated method
          int num2 = this.hz(eb.o()[index], A_1, A_2);
          if (num2 > num1)
            num1 = num2;
        }
      }
      else if (A_0 is ec)
      {
        ec ec = A_0 as ec;
        // ISSUE: reference to a compiler-generated method
        for (int index = 0; index < ec.o().Count; ++index)
        {
          // ISSUE: reference to a compiler-generated method
          num1 += this.hz(ec.o()[index], A_1, A_2);
        }
      }
      else if (A_0 is d8)
      {
        d8 d8 = A_0 as d8;
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        b9 b9 = A_1.hz(d8.n(), d8.o());
        if (b9 != null)
        {
          c3 c3 = b9 as c3;
          // ISSUE: reference to a compiler-generated method
          num1 = c3 == null ? d8.q() : (int) Math.Ceiling((double) d8.q() / (double) c3.ek());
        }
      }
      A_2.Add(A_0, num1);
    }
    return num1;
  }
}
