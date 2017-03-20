// Decompiled with JetBrains decompiler
// Type: bz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class bz
{
  public static int a = 4;
  public static int b = 8;
  public static int c = 1;
  public static int d = 3;
  public static bz.Aspect e = bz.Aspect.Red;
  public static bz.Aspect f = bz.Aspect.All;

  public static string a(int A_0, int A_1, bz.Aspect A_2)
  {
    return A_0.ToString() + "_" + (object) A_1 + "_" + (object) A_2;
  }

  public interface a
  {
    [SpecialName]
    string a7();

    [SpecialName]
    Dictionary<string, bz.b> a8();
  }

  public enum Aspect
  {
    Invalid,
    Red,
    Blue,
    Green,
    All,
  }

  public class b
  {
    public int a;
    public int b;
    public bz.Aspect c;
    public string d;
    public int e;
    public List<bz.b.a> f;

    public class a
    {
      public string a;
      public b8 b;
      public int c;
    }
  }
}
