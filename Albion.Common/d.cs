// Decompiled with JetBrains decompiler
// Type: d
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

public class d
{
  public static kx a = kx.g(10000000L);

  public static kx a(g8 A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return A_0.ar().i2().c["transactiontax"];
  }

  public static kx b(g8 A_0, kx A_1)
  {
    return abh.b<kx>(kx.g, kx.o(A_1, d.a(A_0)));
  }

  public static kx a(g8 A_0, kx A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return abh.b<kx>(A_0.ar().i2().c["minimumtax"], kx.o(A_0.ar().i2().c["setupfee"], A_1));
  }
}
