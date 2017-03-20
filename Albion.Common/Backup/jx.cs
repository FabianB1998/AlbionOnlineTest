// Decompiled with JetBrains decompiler
// Type: jx
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

public abstract class jx
{
  public abstract void gh();

  protected abstract void gg(r A_0, int A_1);

  public void d(r A_0, int A_1, g8 A_2)
  {
    // ISSUE: reference to a compiler-generated method
    this.d(A_0);
    // ISSUE: reference to a compiler-generated method
    this.d(A_1);
    // ISSUE: reference to a compiler-generated method
    this.d((v) null);
    if (A_1 >= 0 && A_1 < A_0.o())
    {
      // ISSUE: reference to a compiler-generated method
      if (A_0.l() != null)
      {
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        this.d(A_0.l()[A_1]);
      }
      else
      {
        // ISSUE: reference to a compiler-generated method
        if (A_0.n() != null)
        {
          // ISSUE: reference to a compiler-generated method
          this.d(A_0.h(A_1, A_2));
        }
      }
    }
    this.gg(A_0, A_1);
  }

  public bool g()
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    return this.e() < this.d().o() - 1;
  }
}
