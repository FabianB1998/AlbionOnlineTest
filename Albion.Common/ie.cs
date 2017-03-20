// Decompiled with JetBrains decompiler
// Type: ie
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System.Xml;

public class ie
{
  public float d = 1f;
  public string a;
  public hk b;
  public string c;
  public bool e;

  public void f(XmlNode A_0)
  {
    this.a = aim.a(A_0 as XmlElement, "prefab", "MeleeHit/MeleeHit");
    this.c = aim.a(A_0 as XmlElement, "impactsocket", "");
    this.d = aim.a(A_0 as XmlElement, "size", 1f);
    this.e = aim.a(A_0 as XmlElement, "ignoresocketscale", false);
    this.b = hk.a(A_0 as XmlElement, hk.c());
  }
}
