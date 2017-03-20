// Decompiled with JetBrains decompiler
// Type: aah
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common.GameData;
using Albion.Common.SimulationObjects.AccessRights;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

public class aah<a> where a : struct, IConvertible
{
  protected Preset d = Preset.Custom;
  protected Dictionary<string, string> f = new Dictionary<string, string>();
  private Guid a;
  private Guid b;
  protected global::o i;

  public aah(global::o A_0)
  {
    if (!typeof (a).IsEnum)
      throw new ApplicationException("generic type must be enum");
    this.i = A_0;
    this.o();
    // ISSUE: reference to a compiler-generated method
    this.i(true);
    // ISSUE: reference to a compiler-generated method
    this.k(true);
  }

  [SpecialName]
  public virtual Guid c()
  {
    return this.a;
  }

  [SpecialName]
  public virtual void d(Guid A_0)
  {
    this.a = A_0;
    this.ea();
  }

  [SpecialName]
  public virtual Guid e()
  {
    return this.b;
  }

  [SpecialName]
  public virtual void f(Guid A_0)
  {
    this.b = A_0;
    this.eb();
  }

  public void l(Preset A_0, bool A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.c(A_1);
    this.c(A_0);
  }

  protected virtual void ea()
  {
  }

  protected virtual void eb()
  {
  }

  public bool m()
  {
    return this.i.h0<a>();
  }

  protected void o()
  {
    this.f[aai.a(UserGroup.Owner)] = "owner";
    if (!this.f.ContainsKey(aai.a(UserGroup.Guild)))
    {
      // ISSUE: reference to a compiler-generated method
      this.f[aai.a(UserGroup.Guild)] = !this.g() ? "noaccess" : "owner";
    }
    if (this.f.ContainsKey(aai.a(UserGroup.Everyone)))
      return;
    this.f[aai.a(UserGroup.Everyone)] = "noaccess";
  }

  public string c(UserGroup A_0)
  {
    string str = "noaccess";
    if (!this.f.TryGetValue(aai.a(A_0), out str))
      str = "noaccess";
    return str;
  }

  protected string e(string A_0)
  {
    string str;
    if (!this.f.TryGetValue(A_0, out str))
      str = "noaccess";
    return str;
  }

  protected List<string> g(string A_0)
  {
    List<string> stringList = new List<string>();
    GuildRole A_1_1;
    Guid guid = aai.a(A_0, out A_1_1);
    foreach (KeyValuePair<string, string> keyValuePair in this.f)
    {
      GuildRole A_1_2;
      if (aai.e(keyValuePair.Key) && aai.a(keyValuePair.Key, out A_1_2) == guid && A_1_1 >= A_1_2)
        stringList.Add(keyValuePair.Value);
    }
    if (stringList.Count == 0)
      stringList.Add("noaccess");
    return stringList;
  }

  protected bool c(Guid A_0, Guid A_1, GuildRole A_2)
  {
    foreach (string A_3 in this.i.h1<a>())
    {
      if (A_3 != "noaccess" && this.c(A_0, A_1, A_2, A_3))
        return true;
    }
    return false;
  }

  protected bool c(Guid A_0, Guid A_1, GuildRole A_2, string A_3)
  {
    if (A_3 == "noaccess")
      return true;
    if (A_3 == "owner")
      return false;
    // ISSUE: reference to a compiler-generated method
    if (A_0 == this.c() && this.i.hz<a>(this.c(UserGroup.Owner), A_3) || A_1 != Guid.Empty && A_1 == this.e() && (!this.g() || A_2 >= GuildRole.GUILDMASTER) && this.i.hz<a>(this.c(UserGroup.Guild), A_3) || this.i.hz<a>(this.e(aai.a(A_0)), A_3))
      return true;
    foreach (string A_0_1 in this.g(aai.a(A_1, A_2)))
    {
      if (A_1 != Guid.Empty && this.i.hz<a>(A_0_1, A_3))
        return true;
    }
    return this.i.hz<a>(this.c(UserGroup.Everyone), A_3);
  }

  protected bool c(Guid A_0, Guid A_1, GuildRole A_2, string A_3, string A_4)
  {
    // ISSUE: reference to a compiler-generated method
    if (!A_3.StartsWith("@") || A_3 == aai.a(UserGroup.Everyone) && !this.h() || !string.IsNullOrEmpty(A_4) && !this.i.h1<a>(A_4))
      return false;
    string A_3_1 = "noaccess";
    if (!this.f.TryGetValue(A_3, out A_3_1))
    {
      if (A_4 != "noaccess" && !this.c(A_0, A_1, A_2))
        return false;
      A_3_1 = "noaccess";
    }
    return this.c(A_0, A_1, A_2, A_3_1) && (string.IsNullOrEmpty(A_4) || this.c(A_0, A_1, A_2, A_4));
  }

  protected bool c(Guid A_0, Guid A_1, Preset A_2)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    if (!this.j() || !this.g() && A_0 != this.c() || this.g() && A_1 != this.e())
      return false;
    if (A_2 == Preset.Custom)
      return true;
    return this.i.h0<a>(A_2) != null;
  }

  public void c(UserGroup A_0, string A_1)
  {
    this.c(aai.a(A_0), A_1);
  }

  public void c(string A_0, string A_1)
  {
    if (string.IsNullOrEmpty(A_1))
      this.f.Remove(A_0);
    else
      this.f[A_0] = A_1;
  }

  public void c(Preset A_0)
  {
    this.d = A_0;
    this.f.Clear();
    this.o();
    if (A_0 == Preset.Custom)
      return;
    global::o.a a = this.i.h0<a>(A_0);
    if (a == null)
      return;
    this.c(UserGroup.Guild, a.b);
    this.c(UserGroup.Everyone, a.a);
  }

  public bool c(Guid A_0, Guid A_1, GuildRole A_2, a A_3)
  {
    // ISSUE: reference to a compiler-generated method
    return this.c(UserGroup.Everyone, A_3) || A_0 == this.c() && this.c(UserGroup.Owner, A_3) || A_1 != Guid.Empty && A_1 == this.e() && (!this.g() || A_2 >= GuildRole.GUILDMASTER) && this.c(UserGroup.Guild, A_3) || (this.c(aai.a(A_0), A_3) || A_1 != Guid.Empty && this.c(aai.a(A_1, A_2), A_3));
  }

  protected bool e(Guid A_0, Guid A_1, GuildRole A_2, string A_3)
  {
    // ISSUE: reference to a compiler-generated method
    return this.c(UserGroup.Everyone) == A_3 || A_0 == this.c() && this.c(UserGroup.Owner) == A_3 || A_1 != Guid.Empty && A_1 == this.e() && (!this.g() || A_2 >= GuildRole.GUILDMASTER) && this.c(UserGroup.Guild) == A_3 || (this.e(aai.a(A_0)) == A_3 || A_1 != Guid.Empty && this.g(aai.a(A_1, A_2)).Contains(A_3));
  }

  protected bool c(UserGroup A_0, a A_1)
  {
    return this.c(aai.a(A_0), A_1);
  }

  public bool c(string A_0, a A_1)
  {
    if (!A_0.StartsWith("@"))
      return false;
    if (aai.e(A_0))
    {
      GuildRole A_1_1;
      Guid guid = aai.a(A_0, out A_1_1);
      foreach (KeyValuePair<string, string> keyValuePair in this.f)
      {
        GuildRole A_1_2;
        if (aai.e(keyValuePair.Key) && aai.a(keyValuePair.Key, out A_1_2) == guid && (A_1_1 >= A_1_2 && this.i.hz<a>(keyValuePair.Value, A_1)))
          return true;
      }
      return this.i.hz<a>("noaccess", A_1);
    }
    string A_0_1;
    if (!this.f.TryGetValue(A_0, out A_0_1))
      A_0_1 = "noaccess";
    return this.i.hz<a>(A_0_1, A_1);
  }

  public Preset n()
  {
    return this.d;
  }
}
