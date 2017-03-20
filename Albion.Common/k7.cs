// Decompiled with JetBrains decompiler
// Type: k7
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

public abstract class k7
{
  protected byte a = 1;

  public abstract bool dh(System.Type A_0, byte A_1, Func<object, byte[]> A_2, Func<byte[], object> A_3);

  public virtual void a()
  {
    this.dh(typeof (ahk), this.a++, new Func<object, byte[]>(this.b), new Func<byte[], object>(this.b));
  }

  public byte[] a(object A_0)
  {
    byte[] numArray = new byte[16];
    byte[] byteArray = ((Guid) A_0).ToByteArray();
    for (int index = 8; index < 16; ++index)
      numArray[index] = byteArray[index];
    numArray[3] = byteArray[0];
    numArray[2] = byteArray[1];
    numArray[1] = byteArray[2];
    numArray[0] = byteArray[3];
    numArray[5] = byteArray[4];
    numArray[4] = byteArray[5];
    numArray[6] = byteArray[7];
    numArray[7] = byteArray[6];
    return numArray;
  }

  public object a(byte[] A_0)
  {
    byte[] b = new byte[16];
    for (int index = 8; index < 16; ++index)
      b[index] = A_0[index];
    b[3] = A_0[0];
    b[2] = A_0[1];
    b[1] = A_0[2];
    b[0] = A_0[3];
    b[5] = A_0[4];
    b[4] = A_0[5];
    b[6] = A_0[7];
    b[7] = A_0[6];
    return (object) new Guid(b);
  }

  public byte[] b(object A_0)
  {
    ahk ahk = (ahk) A_0;
    byte[] numArray = new byte[8];
    // ISSUE: reference to a compiler-generated method
    BitConverter.GetBytes(ahk.g()).CopyTo((Array) numArray, 0);
    // ISSUE: reference to a compiler-generated method
    BitConverter.GetBytes(ahk.h()).CopyTo((Array) numArray, 4);
    return numArray;
  }

  public object b(byte[] A_0)
  {
    return (object) new ahk(BitConverter.ToSingle(A_0, 0), BitConverter.ToSingle(A_0, 4));
  }

  public byte[] c(object A_0)
  {
    // ISSUE: reference to a compiler-generated method
    return BitConverter.GetBytes(((kx) A_0).i());
  }

  public object c(byte[] A_0)
  {
    return (object) kx.f(BitConverter.ToInt64(A_0, 0));
  }
}
