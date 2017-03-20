// Decompiled with JetBrains decompiler
// Type: ahz
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.Time;
using System;
using System.Reflection;
using System.Runtime.CompilerServices;

public class ahz
{
  public ahz.a a;
  public ahz.b b;
  private FieldInfo c;

  public ahz(FieldInfo A_0)
  {
    this.c = A_0;
    if (A_0.FieldType == typeof (kx))
    {
      this.a = new ahz.a(this.k);
      this.b = new ahz.b(this.k);
    }
    else if (A_0.FieldType == typeof (kx[]))
    {
      this.a = new ahz.a(this.j);
      this.b = new ahz.b(this.j);
    }
    else if (A_0.FieldType == typeof (Guid))
    {
      this.a = new ahz.a(this.i);
      this.b = new ahz.b(this.i);
    }
    else if (A_0.FieldType == typeof (Guid[]))
    {
      this.a = new ahz.a(this.h);
      this.b = new ahz.b(this.h);
    }
    else if (A_0.FieldType == typeof (GameTimeStamp))
    {
      this.a = new ahz.a(this.g);
      this.b = new ahz.b(this.g);
    }
    else if (A_0.FieldType == typeof (GameTimeStamp[]))
    {
      this.a = new ahz.a(this.f);
      this.b = new ahz.b(this.f);
    }
    else if (A_0.FieldType == typeof (ahy))
    {
      this.a = new ahz.a(this.e);
      this.b = new ahz.b(this.e);
    }
    else if (A_0.FieldType == typeof (ahy[]))
    {
      this.a = new ahz.a(this.d);
      this.b = new ahz.b(this.d);
    }
    else
    {
      this.a = new ahz.a(this.l);
      this.b = new ahz.b(this.l);
    }
  }

  [SpecialName]
  public string d()
  {
    return this.c.Name;
  }

  private object l(object A_0)
  {
    return this.c.GetValue(A_0);
  }

  private void l(object A_0, object A_1)
  {
    this.c.SetValue(A_0, A_1);
  }

  private object k(object A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return (object) ((kx) this.c.GetValue(A_0)).i();
  }

  private void k(object A_0, object A_1)
  {
    this.c.SetValue(A_0, (object) kx.f((long) A_1));
  }

  private object j(object A_0)
  {
    kx[] kxArray = (kx[]) this.c.GetValue(A_0);
    if (kxArray == null)
      return (object) null;
    long[] numArray = new long[kxArray.Length];
    for (int index = 0; index < kxArray.Length; ++index)
    {
      // ISSUE: reference to a compiler-generated method
      numArray[index] = kxArray[index].i();
    }
    return (object) numArray;
  }

  private void j(object A_0, object A_1)
  {
    long[] numArray = (long[]) A_1;
    if (numArray == null)
    {
      A_0 = (object) null;
    }
    else
    {
      kx[] kxArray = new kx[numArray.Length];
      for (int index = 0; index < numArray.Length; ++index)
        kxArray[index] = kx.f(numArray[index]);
      this.c.SetValue(A_0, (object) kxArray);
    }
  }

  private object i(object A_0)
  {
    return (object) ((Guid) this.c.GetValue(A_0)).ToByteArray();
  }

  private void i(object A_0, object A_1)
  {
    this.c.SetValue(A_0, (object) new Guid((byte[]) A_1));
  }

  private object h(object A_0)
  {
    Guid[] guidArray = (Guid[]) this.c.GetValue(A_0);
    if (guidArray == null)
      return (object) null;
    byte[][] numArray = new byte[guidArray.Length][];
    for (int index = 0; index < guidArray.Length; ++index)
      numArray[index] = guidArray[index].ToByteArray();
    return (object) numArray;
  }

  private void h(object A_0, object A_1)
  {
    byte[][] numArray = (byte[][]) A_1;
    if (numArray == null)
    {
      A_0 = (object) null;
    }
    else
    {
      Guid[] guidArray = new Guid[numArray.Length];
      for (int index = 0; index < numArray.Length; ++index)
        guidArray[index] = new Guid(numArray[index]);
      this.c.SetValue(A_0, (object) guidArray);
    }
  }

  private object g(object A_0)
  {
    return (object) ((GameTimeStamp) this.c.GetValue(A_0)).Ticks;
  }

  private void g(object A_0, object A_1)
  {
    this.c.SetValue(A_0, (object) new GameTimeStamp((long) A_1));
  }

  private object f(object A_0)
  {
    GameTimeStamp[] gameTimeStampArray = (GameTimeStamp[]) this.c.GetValue(A_0);
    if (gameTimeStampArray == null)
      return (object) null;
    long[] numArray = new long[gameTimeStampArray.Length];
    for (int index = 0; index < gameTimeStampArray.Length; ++index)
      numArray[index] = gameTimeStampArray[index].Ticks;
    return (object) numArray;
  }

  private void f(object A_0, object A_1)
  {
    long[] numArray = (long[]) A_1;
    if (numArray == null)
    {
      A_0 = (object) null;
    }
    else
    {
      GameTimeStamp[] gameTimeStampArray = new GameTimeStamp[numArray.Length];
      for (int index = 0; index < numArray.Length; ++index)
        gameTimeStampArray[index] = new GameTimeStamp(numArray[index]);
      this.c.SetValue(A_0, (object) gameTimeStampArray);
    }
  }

  private object e(object A_0)
  {
    return (object) ((ahy) this.c.GetValue(A_0)).o;
  }

  private void e(object A_0, object A_1)
  {
    this.c.SetValue(A_0, (object) new ahy((long) A_1));
  }

  private object d(object A_0)
  {
    ahy[] ahyArray = (ahy[]) this.c.GetValue(A_0);
    if (ahyArray == null)
      return (object) null;
    long[] numArray = new long[ahyArray.Length];
    for (int index = 0; index < ahyArray.Length; ++index)
      numArray[index] = ahyArray[index].o;
    return (object) numArray;
  }

  private void d(object A_0, object A_1)
  {
    long[] numArray = (long[]) A_1;
    if (numArray == null)
    {
      A_0 = (object) null;
    }
    else
    {
      ahy[] ahyArray = new ahy[numArray.Length];
      for (int index = 0; index < numArray.Length; ++index)
        ahyArray[index] = new ahy(numArray[index]);
      this.c.SetValue(A_0, (object) ahyArray);
    }
  }

  public delegate object a(object A_0);

  public delegate void b(object A_0, object A_1);
}
