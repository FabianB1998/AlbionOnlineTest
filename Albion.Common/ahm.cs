// Decompiled with JetBrains decompiler
// Type: ahm
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml;

public abstract class ahm
{
  public ahm(aht A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.y(A_0);
  }

  [SpecialName]
  public abstract k2 c7();

  public abstract ahm c8(aht A_0);

  public abstract void dc(XmlElement A_0);

  public abstract float c9();

  public abstract ahm da(ace A_0);

  public abstract bool db(ab9 A_0);

  public virtual void dd(float A_0)
  {
  }

  public kz y(XmlElement A_0, string A_1)
  {
    return this.aa(aim.a(A_0, A_1, "0"));
  }

  public kz aa(string A_0)
  {
    if (A_0.Contains(";"))
    {
      k0.a A_0_1 = k0.a.b;
      bool flag = A_0.Contains("A");
      if (A_0.Contains("S"))
        A_0_1 = k0.a.c;
      else if (A_0.Contains("C"))
        A_0_1 = k0.a.a;
      A_0 = A_0.TrimStart('L', 'S', 'C', 'A');
      string[] strArray1 = A_0.Split(new char[1]{ ';' }, StringSplitOptions.RemoveEmptyEntries);
      k0 k0 = new k0(strArray1.Length);
      // ISSUE: reference to a compiler-generated method
      k0.k(A_0_1);
      foreach (string str in strArray1)
      {
        char[] separator = new char[1]{ ':' };
        int num = 1;
        string[] strArray2 = str.Split(separator, (StringSplitOptions) num);
        float result1;
        float result2;
        if (strArray2.Length != 2 || !float.TryParse(strArray2[0], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result1) || !float.TryParse(strArray2[1], NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result2))
          return (kz) new k1(0.0f);
        if (!flag)
        {
          // ISSUE: reference to a compiler-generated method
          // ISSUE: reference to a compiler-generated method
          result1 *= this.ag().u();
        }
        k0.k(result1, result2);
      }
      return (kz) k0;
    }
    int length = A_0.IndexOf('-', 1);
    if (length != -1)
    {
      string s1 = A_0.Substring(0, length);
      string s2 = A_0.Substring(length + 1);
      float result1;
      float result2;
      if (float.TryParse(s1, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result1) && float.TryParse(s2, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result2))
      {
        k0 k0 = new k0(2);
        // ISSUE: reference to a compiler-generated method
        k0.k(k0.a.b);
        k0.k(0.0f, result1);
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        k0.k(this.ag().u(), result2);
        return (kz) k0;
      }
    }
    else
    {
      float result;
      if (float.TryParse(A_0, NumberStyles.Float, (IFormatProvider) CultureInfo.InvariantCulture.NumberFormat, out result))
        return (kz) new k1(result);
    }
    return (kz) new k1(0.0f);
  }
}
