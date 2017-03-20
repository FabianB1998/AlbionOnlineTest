// Decompiled with JetBrains decompiler
// Type: pn
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

[aci(2)]
public class pn : i1, IEquatable<pn>
{
  public long rw;
  public float[] rx;
  public float ry;
  public float rz;
  public float[] r0;
  public long r1;

  public bool Equals(pn other)
  {
    if (ahk.b(ahk.a(this.rx), ahk.a(other.rx)) && (double) this.ry == (double) other.ry && ((double) this.rz == (double) other.rz && this.r1 == other.r1))
      return ahk.b(ahk.a(this.r0), ahk.a(other.r0));
    return false;
  }
}
