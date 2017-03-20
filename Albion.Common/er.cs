// Decompiled with JetBrains decompiler
// Type: er
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using System;

public abstract class er
{
  protected static char[] a = new char[3]{ '.', '[', ']' };
  protected static char[] b = new char[2]{ '[', ']' };

  public string h7(string A_0, er.a A_1)
  {
    er.a A_0_1 = er.h4(A_0, A_1);
    if (A_0_1 == null)
      return (string) null;
    return this.ck(A_0_1);
  }

  public string h6(er.a A_0)
  {
    if (string.IsNullOrEmpty(A_0.c))
      return (string) null;
    er.a A_0_1 = er.h4(A_0.c, A_0);
    if (A_0_1 == null)
      return (string) null;
    return this.ck(A_0_1);
  }

  protected virtual string ck(er.a A_0)
  {
    return (string) null;
  }

  protected static string h6(string A_0, er.a A_1)
  {
    string A_1_1;
    string A_0_1 = er.h3(A_0, out A_1_1);
    if (string.IsNullOrEmpty(A_0_1))
      return (string) null;
    A_1.c = A_1_1;
    return er.h5(A_0_1, A_1);
  }

  protected static string h5(string A_0, er.a A_1)
  {
    if (A_1.d == null)
      return (string) null;
    // ISSUE: reference to a compiler-generated method
    gr gr = A_1.d.ao().hz(A_0);
    if (gr == null)
      return (string) null;
    return gr.h7(A_1.c, A_1);
  }

  protected static string h3(string A_0, out string A_1)
  {
    A_1 = A_0;
    if (A_0.Contains(" "))
      return (string) null;
    string str = (string) null;
    int length = A_0.IndexOfAny(er.a);
    if (length >= 0 && length < A_0.Length)
    {
      str = A_0.Substring(0, length);
      A_1 = A_0.Substring(length + 1);
    }
    return str;
  }

  protected static er.a h4(string A_0, er.a A_1)
  {
    if (string.IsNullOrEmpty(A_0))
      return (er.a) null;
    if (A_0.Contains(" "))
      return (er.a) null;
    A_1.a = A_0;
    A_1.b = 0;
    int length = A_0.IndexOf('.');
    if (length >= 0 && length < A_0.Length)
    {
      A_1.a = A_0.Substring(0, length);
      A_1.c = A_0.Substring(length + 1);
    }
    string[] strArray = A_1.a.Split(er.b, 3, StringSplitOptions.RemoveEmptyEntries);
    if (strArray != null && strArray.Length == 2)
    {
      int.TryParse(strArray[1], out A_1.b);
      A_1.a = strArray[0];
    }
    return A_1;
  }

  public static string h3(Enum A_0)
  {
    return kr.a(A_0);
  }

  public static string h3(string A_0, er.a A_1)
  {
    if (A_1 == null || A_1.d == null)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    b8 b8 = A_1.d.an().hz(A_0);
    if (b8 == null)
      return A_0;
    // ISSUE: reference to a compiler-generated method
    return b8.f().e;
  }

  public static string h3(ahy A_0)
  {
    if (A_0.o < 600000000L)
    {
      string str = kr.b("@GENERIC_TIME_SECONDS_SHORT");
      return string.Format("{0:0.##}{1}", (object) A_0.t(), (object) str);
    }
    if (A_0.o < 36000000000L)
    {
      string str1 = kr.b("@GENERIC_TIME_SECONDS_SHORT");
      string str2 = kr.b("@GENERIC_TIME_MINUTES_SHORT");
      return string.Format("{0:0}{1} {2:00}{3}", (object) A_0.m(), (object) str2, (object) A_0.n(), (object) str1);
    }
    string str3 = kr.b("@GENERIC_TIME_SECONDS_SHORT");
    string str4 = kr.b("@GENERIC_TIME_MINUTES_SHORT");
    string str5 = kr.b("@GENERIC_TIME_HOURS_SHORT");
    return string.Format("{0:0}{1} {2:00}{3} {4:00}{5}", (object) (A_0.l() + A_0.k() * 24L), (object) str5, (object) A_0.m(), (object) str4, (object) A_0.n(), (object) str3);
  }

  public static string h4(float A_0)
  {
    return string.Format("{0:0.##}{1}", (object) A_0, (object) kr.b("@GENERIC_UNIT_METER"));
  }

  public static string h3(float A_0)
  {
    return string.Format("{0:0.###}%", (object) (float) ((double) Math.Abs(A_0) * 100.0));
  }

  public static string h3(PlayerAttribute A_0, float A_1, er.a A_2, bool A_3)
  {
    if (p3.b(A_0))
      return er.h3(A_1);
    // ISSUE: reference to a compiler-generated method
    return string.Format("{0:0}", (object) (int) p3.a(A_0, A_1, A_2.d.ar(), A_2.e, A_3));
  }

  public static string h3(float A_0, er.a A_1, bool A_2, bool A_3, bool A_4, bool A_5, bool A_6)
  {
    float A_0_1 = A_0;
    if (A_2)
      return er.h3(A_0_1);
    if (A_3 && (double) A_0_1 < 0.0)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_1 = p3.d(A_0_1, A_1.d.ar(), A_1.e, A_6);
    }
    else if (A_3 && (double) A_0_1 > 0.0)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_1 = p3.e(A_0_1, A_1.d.ar(), A_1.e, A_6);
    }
    else if (A_4)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_1 = p3.c(A_0_1, A_1.d.ar(), A_1.e, A_6);
    }
    else if (A_5)
    {
      // ISSUE: reference to a compiler-generated method
      A_0_1 = p3.a(A_0_1, A_1.d.ar(), A_1.e, A_6);
    }
    return string.Format("{0:0.##}", (object) Math.Abs((int) (float) Math.Round((double) A_0_1)));
  }

  public static string h3(ahy A_0, et A_1, er.a A_2)
  {
    if (es.h3(A_1))
    {
      // ISSUE: reference to a compiler-generated method
      // ISSUE: reference to a compiler-generated method
      A_0 = p3.a(A_0, A_2.d.ar(), A_2.e, A_1.i3());
    }
    return er.h3(A_0);
  }

  public class a
  {
    public string a = string.Empty;
    public int b = -1;
    public string c = string.Empty;
    public g8 d;
    public float e;
    public aam f;
  }
}
