// Decompiled with JetBrains decompiler
// Type: bs
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;
using System.Text;

internal class bs
{
  private const uint a = 16777619;
  private const uint b = 2166136261;
  private static byte c;
  private static uint d;

  static bs()
  {
    bs.a((byte) 32);
  }

  [SpecialName]
  public static byte a()
  {
    return bs.c;
  }

  [SpecialName]
  public static void a(byte A_0)
  {
    bs.c = A_0;
    bs.d = (uint) ((1 << (int) bs.c) - 1);
  }

  public static uint a(string A_0)
  {
    byte[] bytes = Encoding.UTF8.GetBytes(A_0.ToLower());
    uint num = 2166136261;
    for (int index = 0; index < bytes.Length; ++index)
      num = num * 16777619U ^ (uint) bytes[index];
    if ((int) bs.c == 32)
      return num;
    return num >> (int) bs.c ^ num & bs.d;
  }
}
