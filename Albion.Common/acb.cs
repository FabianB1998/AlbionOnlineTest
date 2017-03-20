// Decompiled with JetBrains decompiler
// Type: acb
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;

public class acb
{
  private int a = cf.a;
  private Dictionary<string, Dictionary<string, string>> b;

  public acb(string A_0, string A_1, int A_2, int A_3, ahk A_4, bool A_5, string A_6, string A_7, string A_8, byte[] A_9)
    : this(A_0, A_1, A_2, A_3, A_4, A_5, A_6, A_7, A_8, A_9, (float[]) null, (byte[]) null)
  {
  }

  public acb(string A_0, string A_1, int A_2, int A_3, ahk A_4, bool A_5, string A_6, string A_7, string A_8, byte[] A_9, float[] A_10, byte[] A_11)
  {
    this.o(A_0, A_1, A_2, A_3, A_4, A_6, A_7, A_8, A_9, A_10, A_11, A_5);
  }

  [SpecialName]
  public bool aa()
  {
    // ISSUE: reference to a compiler-generated method
    return this.r() != null;
  }

  [SpecialName]
  public int ab()
  {
    return this.a;
  }

  protected void o(string A_0, string A_1, int A_2, int A_3, ahk A_4, string A_5, string A_6, string A_7, byte[] A_8, float[] A_9, byte[] A_10, bool A_11)
  {
    // ISSUE: reference to a compiler-generated method
    this.p(A_0);
    // ISSUE: reference to a compiler-generated method
    this.o(A_1);
    // ISSUE: reference to a compiler-generated method
    this.p(A_2);
    // ISSUE: reference to a compiler-generated method
    this.o(A_3);
    // ISSUE: reference to a compiler-generated method
    this.o(A_4);
    // ISSUE: reference to a compiler-generated method
    this.o((acb.TileType) Enum.Parse(typeof (acb.TileType), A_5));
    if (A_6 == "Fertile")
    {
      // ISSUE: reference to a compiler-generated method
      this.o(acb.TileGroundType.Fertile);
    }
    else if (A_6 == "BuildingArea")
    {
      // ISSUE: reference to a compiler-generated method
      this.o(acb.TileGroundType.BuildingArea);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      this.o(acb.TileGroundType.Normal);
    }
    // ISSUE: reference to a compiler-generated method
    this.p(A_8);
    // ISSUE: reference to a compiler-generated method
    this.o(A_9);
    // ISSUE: reference to a compiler-generated method
    this.o(A_10);
    // ISSUE: reference to a compiler-generated method
    this.o(A_11);
    // ISSUE: reference to a compiler-generated method
    this.p(false);
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (this.p() == null || this.p().Length == 0)
    {
      // ISSUE: reference to a compiler-generated method
      if (this.p() == null)
      {
        // ISSUE: reference to a compiler-generated method
        ab0.a("no collision tile:" + this.s());
      }
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      this.p(new byte[this.u() * this.v() * 2]);
      // ISSUE: reference to a compiler-generated method
      this.p(false);
    }
    else
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      if (this.p().Length != this.u() * this.v() * 2)
        throw new AlbionException("invalid collision size in " + A_0 + "(" + A_1 + ")");
      int index = 1;
      // ISSUE: reference to a compiler-generated method
      while (index < this.p().Length)
      {
        // ISSUE: reference to a compiler-generated method
        if ((int) this.p()[index] != 0)
        {
          // ISSUE: reference to a compiler-generated method
          this.p(true);
          break;
        }
        index += 2;
      }
    }
  }

  public byte o(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.p()[(A_1 * this.u() + A_0) * 2 + 1];
  }

  public acb.b p(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return (acb.b) this.p()[(A_1 * this.u() + A_0) * 2];
  }

  public float q(int A_0, int A_1)
  {
    return this.o(A_0, A_1, 0.0f);
  }

  public float o(int A_0, int A_1, float A_2)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.q() == null)
      return A_2;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.q()[A_0 + (this.v() - A_1 - 1) * this.u()];
  }

  public byte r(int A_0, int A_1)
  {
    // ISSUE: reference to a compiler-generated method
    if (this.r() == null)
      return 0;
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.r()[A_0 + (this.v() - A_1 - 1) * this.u()];
  }

  public void o(string A_0, string A_1, string A_2)
  {
    if (this.b == null)
      this.b = new Dictionary<string, Dictionary<string, string>>();
    if (!this.b.ContainsKey(A_0))
      this.b[A_0] = new Dictionary<string, string>();
    this.b[A_0].Add(A_1, A_2);
  }

  public bool ac()
  {
    if (this.b != null)
      return this.b.Count > 0;
    return false;
  }

  public bool q(string A_0)
  {
    if (this.b != null)
      return this.b.ContainsKey(A_0);
    return false;
  }

  public bool o(string A_0, string A_1)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      if (dictionary != null && dictionary.ContainsKey(A_1))
        return true;
    }
    return false;
  }

  public string p(string A_0, string A_1, string A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string str;
      if (dictionary != null && dictionary.TryGetValue(A_1, out str))
        return str;
    }
    return A_2;
  }

  public int o(string A_0, string A_1, int A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string s;
      if (dictionary != null && dictionary.TryGetValue(A_1, out s))
        return int.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    }
    return A_2;
  }

  public float o(string A_0, string A_1, float A_2)
  {
    if (this.b != null)
    {
      Dictionary<string, string> dictionary = this.b[A_0];
      string s;
      if (dictionary != null && dictionary.TryGetValue(A_1, out s))
        return float.Parse(s, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat);
    }
    return A_2;
  }

  public ahk o(string A_0, string A_1, ahk A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    string[] strArray = this.p(A_0, A_1, string.Format("{0} {1}", (object) A_2.g().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), (object) A_2.h().ToString((IFormatProvider) CultureInfo.InvariantCulture.NumberFormat))).Split(new string[1]{ " " }, StringSplitOptions.RemoveEmptyEntries);
    if (strArray.GetLength(0) != 2)
      return A_2;
    return new ahk(float.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat), float.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat));
  }

  [Flags]
  public enum a : byte
  {
    a = 0,
    b = 1,
    c = 2,
    d = 4,
    e = 16,
    f = 32,
    g = d | b,
    h = g | f,
    i = 255,
  }

  public enum b : byte
  {
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
    j,
    k,
  }

  public enum TileType
  {
    Ground,
    Road,
    Object,
    UnityGameObjectOnly,
    RealEstate,
  }

  public enum TileGroundType
  {
    Normal,
    Fertile,
    BuildingArea,
  }
}
