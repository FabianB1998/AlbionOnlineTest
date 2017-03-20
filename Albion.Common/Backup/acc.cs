// Decompiled with JetBrains decompiler
// Type: acc
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

internal struct acc
{
  private const float a = 1E-05f;
  public ahk b;
  public ahk c;

  public acc(ahk A_0, ahk A_1)
  {
    this.b = A_0;
    this.c = A_1;
  }

  public ahk a(ahk A_0)
  {
    return ahk.d(this.b, ahk.a(ahk.c(A_0, this.b).b(this.c), this.c));
  }

  public float d(ahk A_0)
  {
    ahk A_0_1 = ahk.c(A_0, this.b);
    return ahk.c(A_0_1, ahk.a(A_0_1.b(this.c), this.c)).k();
  }

  public float e(ahk A_0)
  {
    ahk A_0_1 = ahk.c(A_0, this.b);
    return ahk.c(A_0_1, ahk.a(A_0_1.b(this.c), this.c)).j();
  }
}
