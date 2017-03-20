// Decompiled with JetBrains decompiler
// Type: ahu
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Runtime.CompilerServices;

public abstract class ahu
{
  private ahv a;

  [SpecialName]
  public void b(ahv A_0)
  {
    this.a = A_0;
  }

  [SpecialName]
  public ahv @do()
  {
    return this.a;
  }

  public virtual bool hg(int A_0)
  {
    return true;
  }

  public virtual void na()
  {
  }

  public virtual void nb()
  {
  }

  public virtual void OnLeave()
  {
  }
}
