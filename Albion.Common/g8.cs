// Decompiled with JetBrains decompiler
// Type: g8
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using Albion.Common.GameData;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

public class g8
{
  private Dictionary<string, string> b = new Dictionary<string, string>();
  private string a;

  public void am(string A_0, string A_1)
  {
    this.b.Add(A_0, A_1);
  }

  public void bp()
  {
    this.am((string) null, (string) null, false, false, false);
  }

  public void bq()
  {
    this.am((string) null, (string) null, false, true, true);
  }

  public void an(string A_0, string A_1)
  {
    this.am(A_0, A_1, false, true, false);
  }

  public void an(string A_0)
  {
    if (!Directory.Exists(A_0))
      Console.WriteLine("ERROR: Root-Directory for GameData-Xmls doesn't exists " + A_0);
    if (!string.IsNullOrEmpty(A_0))
      this.am(A_0, Path.Combine(A_0, "cluster"), true);
    else
      this.am((string) null, (string) null, true);
  }

  public void ao(string A_0, string A_1)
  {
    this.am(A_0, A_1, false, false, false);
  }

  public void am(string A_0, string A_1, bool A_2)
  {
    this.am(A_0, A_1, false, A_2, A_2);
  }

  public void am(string A_0, string A_1, bool A_2, bool A_3, bool A_4)
  {
    this.am(A_0, A_1, A_2, A_3, A_4, true);
  }

  public void am(string A_0, string A_1, bool A_2, bool A_3, bool A_4, bool A_5)
  {
    this.a = A_0;
    try
    {
      this.bb(A_0);
      this.bc(A_0);
      this.ba(A_0);
      this.a9(A_0);
      this.ao(A_0);
      this.ap(A_0);
      this.aq(A_0);
      this.ar(A_0);
      this.@as(A_0);
      this.at(A_0);
      this.au(A_0);
      this.av(A_0);
      this.aw(A_0);
      this.ax(A_0);
      this.am(A_1, A_2);
      this.ay(A_0);
      this.az(A_0);
      this.a0(A_0);
      this.a1(A_0);
      this.a2(A_0);
      this.a3(A_0);
      this.a4(A_0);
      this.a5(A_0);
      this.a6(A_0);
      this.a7(A_0);
      this.a8(A_0);
      this.bf(A_0);
      this.bg(A_0);
      this.bh(A_0);
      this.bi(A_0);
      this.bj(A_0);
      this.bk(A_0);
      this.bl(A_0);
      this.bm(A_0);
      this.bn(A_0);
      if (A_3)
        this.bd(A_0);
      if (A_4)
        this.be(A_0);
      if (A_5)
        this.bs();
      this.bt();
    }
    catch (Exception ex)
    {
      this.bu();
      throw ex;
    }
    this.bu();
  }

  public void br()
  {
    // ISSUE: reference to a compiler-generated method
    this.am(this.a, "spells.xml", (global::n) this.ao(), true);
    // ISSUE: reference to a compiler-generated method
    this.am(this.a, "mobs.xml", (global::n) this.@as(), true);
    // ISSUE: reference to a compiler-generated method
    this.am(this.a, "items.xml", (global::n) this.an(), true);
    // ISSUE: reference to a compiler-generated method
    this.am(this.a, "spellanimmappings.xml", (global::n) this.bc(), true);
    // ISSUE: reference to a compiler-generated method
    this.an().hz(this);
    // ISSUE: reference to a compiler-generated method
    this.@as().hz(this);
    // ISSUE: reference to a compiler-generated method
    this.ao().hz(this);
    this.bu();
  }

  protected void ao(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new abc());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "items.xml", (global::n) this.an());
  }

  protected void ap(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new h2());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "spells.xml", (global::n) this.ao());
  }

  protected void aq(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new aa7());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "buildings.xml", (global::n) this.ap());
  }

  protected void ar(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new b4());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "emotes.xml", (global::n) this.aq());
  }

  protected void @as(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new ab8());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "gamedata.xml", (global::n) this.ar());
  }

  protected void at(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new ed());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "mobs.xml", (global::n) this.@as());
  }

  protected void au(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new em());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "loot.xml", (global::n) this.at());
  }

  protected void av(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new d3());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "characters.xml", (global::n) this.au());
  }

  protected void aw(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new ha());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "guildlogos.xml", (global::n) this.av());
  }

  protected void ax(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new hi());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "resources.xml", (global::n) this.aw());
  }

  protected void am(string A_0, bool A_1)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new aik());
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.ax().hz(A_1);
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "world.xml", (global::n) this.ax());
  }

  protected void ay(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new global::q());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "achievements.xml", (global::n) this.ay());
  }

  protected void az(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new dr());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "avatars.xml", (global::n) this.az());
  }

  protected void a0(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new c9());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "missions.xml", (global::n) this.a0());
  }

  protected void a1(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new b6());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "factions.xml", (global::n) this.a1());
  }

  protected void a2(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bo());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "agents.xml", (global::n) this.a2());
  }

  protected void a3(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new hd());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "hints.xml", (global::n) this.a3());
  }

  protected void a4(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new eh());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "clustertexts.xml", (global::n) this.a4());
  }

  protected void a5(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new global::o());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "accessrights.xml", (global::n) this.a5());
  }

  protected void a6(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new g5());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "territorytypes.xml", (global::n) this.a6());
  }

  protected void a7(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new j8());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "worldsettings.xml", (global::n) this.a7());
  }

  protected void a8(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new ej());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "chatsettings.xml", (global::n) this.a8());
  }

  protected void a9(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new cy());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "spellanimmappings.xml", (global::n) this.bc());
  }

  protected void ba(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new dq());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "audio.xml", (global::n) this.a9());
  }

  protected void bb(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new ib());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "assetvfx.xml", (global::n) this.bb());
  }

  protected void bc(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new dp());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "sockets.xml", (global::n) this.ba());
  }

  protected void bd(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new cd());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "namegenerators.xml", (global::n) this.bm());
  }

  protected void be(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bq());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "agentreferences.xml", (global::n) this.bn());
  }

  protected void bf(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new h6());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "treasures.xml", (global::n) this.bd());
  }

  protected void bg(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new h8());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "worldbosses.xml", (global::n) this.be());
  }

  protected void bh(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.am(new dk(this.aw()));
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "resourcedistpresets.xml", (global::n) this.bf());
  }

  protected void bi(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.am(new dj(this.aw()));
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "resourceprefabmappings.xml", (global::n) this.bg());
  }

  protected void bj(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bg());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "expeditioncategories.xml", (global::n) this.bh());
  }

  protected void bk(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bl());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "expeditions.xml", (global::n) this.bi());
  }

  protected void bl(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bn());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "expeditionagents.xml", (global::n) this.bj());
  }

  protected void bm(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new db());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "randomspawnbehaviors.xml", (global::n) this.bl());
  }

  protected void bn(string A_0)
  {
    // ISSUE: reference to a compiler-generated method
    this.am(new bj());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, "itemroles.xml", (global::n) this.bk());
  }

  protected void am(MemoryStream A_0, global::n A_1)
  {
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    A_0.Write(A_1.j0(), 0, A_1.j0().Length);
  }

  protected void bs()
  {
    MemoryStream A_0 = new MemoryStream();
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.ar());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.ap());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.au());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.@as());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.ao());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.an());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.a5());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.a7());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.ax());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.ay());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.a2());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.a1());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.a0());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.aq());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.bi());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.bh());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.bj());
    // ISSUE: reference to a compiler-generated method
    this.am(A_0, (global::n) this.bk());
    // ISSUE: reference to a compiler-generated method
    this.am(MD5.Create().ComputeHash(A_0.ToArray()));
  }

  protected void bt()
  {
    // ISSUE: reference to a compiler-generated method
    if (this.a5() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.a5().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.an() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.an().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.aw() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.aw().h0(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ap() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ap().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ay() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ay().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ax() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ax().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.@as() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.@as().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.au() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.au().h0(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.ao() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.ao().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.a0() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.a0().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.a7() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.a7().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.bh() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.bh().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.bj() != null)
    {
      // ISSUE: reference to a compiler-generated method
      this.bj().hz(this);
    }
    // ISSUE: reference to a compiler-generated method
    if (this.bi() == null)
      return;
    // ISSUE: reference to a compiler-generated method
    this.bi().hz(this);
  }

  public void bu()
  {
    this.b.Clear();
  }

  protected void am(string A_0, string A_1, global::n A_2)
  {
    this.am(A_0, A_1, A_2, false);
  }

  protected virtual void am(string A_0, string A_1, global::n A_2, bool A_3)
  {
    string A_0_1;
    if (this.b.TryGetValue(A_1, out A_0_1))
    {
      A_2.h1(A_0_1, A_3);
    }
    else
    {
      if (A_0 == null)
        throw new AlbionException("GameData: missing root path for file: " + A_1);
      string A_0_2 = Path.Combine(A_0, A_1);
      A_2.h0(A_0_2, A_3);
    }
  }

  public static PlayerAttribute am(string A_0)
  {
    switch (A_0)
    {
      case "magiccasttimereduction":
        return PlayerAttribute.MagicCastTimeReductionRaw;
      case "magiccooldownreduction":
        return PlayerAttribute.MagicCoolDownReductionRaw;
      default:
        return (PlayerAttribute) Enum.Parse(typeof (PlayerAttribute), A_0, true);
    }
  }
}
