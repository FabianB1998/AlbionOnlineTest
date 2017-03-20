// Decompiled with JetBrains decompiler
// Type: cf
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public class cf
{
  public static int a = int.MaxValue;

  public static bool c(int A_0, int A_1)
  {
    if (A_0 == cf.a)
      return true;
    for (int index = Enum.GetValues(typeof (ce)).Length - 1; index >= 0; --index)
    {
      if (index == A_1 && (A_0 & (int) (byte) (1 << index)) != 0)
        return true;
    }
    return false;
  }

  public static bool b(int A_0, int A_1)
  {
    return (A_0 & (int) (byte) (1 << A_1)) != 0;
  }

  public static int a(int A_0, int A_1, bool A_2)
  {
    A_0 = !A_2 ? (A_0 &= (int) ~(byte) (1 << A_1)) : (A_0 |= (int) (byte) (1 << A_1));
    return A_0;
  }

  public static int a(int A_0, int A_1)
  {
    A_0 ^= (int) (byte) (1 << A_1);
    return A_0;
  }
}
