// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;
using System.Runtime.InteropServices;

[ComVisible(false)]
[AttributeUsage(AttributeTargets.Assembly)]
public sealed class DotfuscatorAttribute : System.Attribute
{
  private string a;
  private int c;

  public string A
  {
    get
    {
      return this.a;
    }
  }

  public int C
  {
    get
    {
      return this.c;
    }
  }

  public DotfuscatorAttribute(string a, int c)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    string str = a;
    dotfuscatorAttribute.a = str;
    this.c = c;
  }

  public string a()
  {
    return this.a;
  }

  public int c()
  {
    return this.c;
  }
}
