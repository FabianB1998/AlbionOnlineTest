// Decompiled with JetBrains decompiler
// Type: g5
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using Albion.Common;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;

public class g5 : n
{
  private Dictionary<string, g5.b> az = new Dictionary<string, g5.b>();

  protected override bool aq(XmlElement A_0)
  {
    if (A_0.Name != "territorytypes")
      throw new AlbionException("[TerritoryTypeData] LoadDataFromXml: XmlTag 'territorytypes' not found! Invalid Xml File?");
    // ISSUE: reference to a compiler-generated method
    this.h0(aim.b(A_0, "upkeepwarningchecktimespaninhours", 24));
    // ISSUE: reference to a compiler-generated method
    this.hz(aim.b(A_0, "upkeepwarningintervalinmin", 60));
    // ISSUE: reference to a compiler-generated method
    this.h1(aim.b(A_0, "upkeeptimerinmin", 120));
    foreach (XmlElement A_0_1 in A_0.GetElementsByTagName("territorytype"))
    {
      g5.b b = new g5.b();
      // ISSUE: reference to a compiler-generated method
      b.ar(aim.h(A_0_1, "name"));
      // ISSUE: reference to a compiler-generated method
      b.ar(aim.b(A_0_1, "claimcost", kx.g(500L)));
      // ISSUE: reference to a compiler-generated method
      b.@as(aim.b(A_0_1, "upkeepcost", kx.g(300L)));
      // ISSUE: reference to a compiler-generated method
      b.ar(aim.b(A_0_1, "mintimebetweenmatchesperconnectioninmin", 1440));
      // ISSUE: reference to a compiler-generated method
      b.@as(aim.b(A_0_1, "maxdefensepoints", 3));
      // ISSUE: reference to a compiler-generated method
      b.at(aim.b(A_0_1, "defensepointschangeafterprimetime", 1));
      // ISSUE: reference to a compiler-generated method
      b.au(aim.b(A_0_1, "maxdefensebonus", 40));
      // ISSUE: reference to a compiler-generated method
      b.av(aim.b(A_0_1, "mindefensebonus", -10));
      // ISSUE: reference to a compiler-generated method
      b.aw(aim.b(A_0_1, "defensebonuschangeafterprimetime", -10));
      // ISSUE: reference to a compiler-generated method
      b.ax(aim.b(A_0_1, "defensebonuschangeafterloosingabattle", 10));
      // ISSUE: reference to a compiler-generated method
      b.ar(aim.a(A_0_1, "weightlimit", 10001f));
      // ISSUE: reference to a compiler-generated method
      b.ay(aim.b(A_0_1, "vaultsize", 60));
      // ISSUE: reference to a compiler-generated method
      b.az(aim.b(A_0_1, "battlevaultsize", 30));
      // ISSUE: reference to a compiler-generated method
      b.at(aim.c(A_0_1, "nutritionstorage", kx.g(33601L)));
      // ISSUE: reference to a compiler-generated method
      b.au(aim.c(A_0_1, "secondspernutrition", kx.g(17L)));
      // ISSUE: reference to a compiler-generated method
      b.av(aim.c(A_0_1, "claimnutrition", kx.g(2501L)));
      // ISSUE: reference to a compiler-generated method
      b.aw(aim.c(A_0_1, "conquernutrition", kx.g(2501L)));
      XmlNodeList elementsByTagName1 = A_0_1.GetElementsByTagName("GuardSettings");
      if (elementsByTagName1.Count > 0)
      {
        XmlElement A_0_2 = (XmlElement) elementsByTagName1[0];
        // ISSUE: reference to a compiler-generated method
        b.a0(aim.b(A_0_2, "respawntimeseconds", 0));
      }
      IEnumerator enumerator1 = A_0_1.GetElementsByTagName("Tower").GetEnumerator();
      try
      {
        if (enumerator1.MoveNext())
        {
          XmlElement current = (XmlElement) enumerator1.Current;
          // ISSUE: reference to a compiler-generated method
          b.a8().i(current);
        }
      }
      finally
      {
        IDisposable disposable = enumerator1 as IDisposable;
        if (disposable != null)
          disposable.Dispose();
      }
      XmlNodeList elementsByTagName2 = A_0_1.GetElementsByTagName("MatchSettings");
      if (elementsByTagName2.Count > 0)
      {
        XmlElement A_0_2 = (XmlElement) elementsByTagName2[0];
        // ISSUE: reference to a compiler-generated method
        b.a3(aim.b(A_0_2, "respawntimeseconds", 18));
        // ISSUE: reference to a compiler-generated method
        b.ay(aim.c(A_0_2, "winningpayoutfactor", kx.f(0.100000001490116)));
        // ISSUE: reference to a compiler-generated method
        if (kx.k(b.bg(), kx.h))
        {
          // ISSUE: reference to a compiler-generated method
          b.ay(kx.h);
        }
        // ISSUE: reference to a compiler-generated method
        b.a1(aim.b(A_0_2, "timeuntilretaliationmustbedeclaredinmin", 9));
        // ISSUE: reference to a compiler-generated method
        b.a2(aim.b(A_0_2, "mindefenderticketsleftforcounterattack", 99));
        // ISSUE: reference to a compiler-generated method
        b.a4(aim.b(A_0_2, "matchtimerespawnmultiplier", 6));
        // ISSUE: reference to a compiler-generated method
        b.a5(aim.b(A_0_2, "maxplayerperteam", 5));
        // ISSUE: reference to a compiler-generated method
        b.ax(aim.b(A_0_2, "conquercost", kx.g));
        // ISSUE: reference to a compiler-generated method
        b.a7(aim.b(A_0_2, "ticketreductionorbclaim", 1));
        // ISSUE: reference to a compiler-generated method
        b.a6(aim.b(A_0_2, "ticketreductionbydeath", 1));
        // ISSUE: reference to a compiler-generated method
        b.a8(aim.b(A_0_2, "attackerticketdefault", 10));
        // ISSUE: reference to a compiler-generated method
        b.a9(aim.b(A_0_2, "defenderticketdefault", 10));
        // ISSUE: reference to a compiler-generated method
        b.ba(aim.b(A_0_2, "battledurationinminutes", 10));
        // ISSUE: reference to a compiler-generated method
        b.bb(aim.b(A_0_2, "battlerounddurationinseconds", 5));
        // ISSUE: reference to a compiler-generated method
        b.bc(aim.b(A_0_2, "mintimeuntilbattleinminutes", 0));
        // ISSUE: reference to a compiler-generated method
        b.be(aim.b(A_0_2, "timeslotspaninminutes", 30));
        // ISSUE: reference to a compiler-generated method
        b.bf(aim.b(A_0_2, "timeslotspansblocked", 2));
        // ISSUE: reference to a compiler-generated method
        b.bd(aim.b(A_0_2, "orbclaimtimeinseconds", 10));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        b.@as(aim.a(A_0_2, "orblcaimfx", b.bx()));
        IEnumerator enumerator2 = A_0_2.GetElementsByTagName("Orb").GetEnumerator();
        try
        {
          if (enumerator2.MoveNext())
          {
            XmlElement current = (XmlElement) enumerator2.Current;
            // ISSUE: reference to a compiler-generated method
            b.bs().i(current);
          }
        }
        finally
        {
          IDisposable disposable = enumerator2 as IDisposable;
          if (disposable != null)
            disposable.Dispose();
        }
        IEnumerator enumerator3 = A_0_2.GetElementsByTagName("Warcamp").GetEnumerator();
        try
        {
          if (enumerator3.MoveNext())
          {
            XmlElement current = (XmlElement) enumerator3.Current;
            // ISSUE: reference to a compiler-generated method
            b.bt().i(current);
          }
        }
        finally
        {
          IDisposable disposable = enumerator3 as IDisposable;
          if (disposable != null)
            disposable.Dispose();
        }
        SortedDictionary<int, int> sortedDictionary1 = new SortedDictionary<int, int>();
        foreach (XmlElement A_0_3 in A_0_2.GetElementsByTagName("OrbReductionLookUp"))
        {
          int key = aim.b(A_0_3, "orbdifference", 1);
          int num = aim.b(A_0_3, "ticketreduction", 1);
          sortedDictionary1.Add(key, num);
        }
        // ISSUE: reference to a compiler-generated method
        b.ar(new int[sortedDictionary1.Count]);
        // ISSUE: reference to a compiler-generated method
        sortedDictionary1.Values.CopyTo(b.bl(), 0);
        XmlNodeList elementsByTagName3 = A_0_1.GetElementsByTagName("TimeSlots");
        if (elementsByTagName3.Count > 0)
        {
          XmlElement A_0_3 = (XmlElement) elementsByTagName3[0];
          DateTime dateTime1 = aim.a(A_0_3, "blockedmatchtimestampstart", new DateTime());
          DateTime A_0_4 = new DateTime(1, 1, 1, 0, 0, 0);
          A_0_4 += dateTime1.TimeOfDay;
          // ISSUE: reference to a compiler-generated method
          b.ar(A_0_4);
          DateTime dateTime2 = aim.a(A_0_3, "blockedmatchtimestampend", new DateTime());
          DateTime A_0_5 = new DateTime(1, 1, 1, 0, 0, 0);
          A_0_5 += dateTime2.TimeOfDay;
          // ISSUE: reference to a compiler-generated method
          b.@as(A_0_5);
          SortedDictionary<int, DateTime> sortedDictionary2 = new SortedDictionary<int, DateTime>();
          foreach (XmlElement A_0_6 in A_0_3.GetElementsByTagName("TimeSlot"))
          {
            int key = aim.b(A_0_6, "id", 1);
            DateTime dateTime3 = aim.a(A_0_6, "time", new DateTime());
            DateTime dateTime4 = new DateTime(1, 1, 1, 0, 0, 0);
            dateTime4 += dateTime3.TimeOfDay;
            sortedDictionary2.Add(key, dateTime4);
          }
          // ISSUE: reference to a compiler-generated method
          b.ar(new DateTime[sortedDictionary2.Count]);
          // ISSUE: reference to a compiler-generated method
          sortedDictionary2.Values.CopyTo(b.bu(), 0);
        }
      }
      // ISSUE: reference to a compiler-generated method
      this.az.Add(b.ar(), b);
    }
    return true;
  }

  public g5.b hz(string A_0)
  {
    g5.b b;
    this.az.TryGetValue(A_0, out b);
    return b;
  }

  public enum a
  {
    a,
    b,
    c,
  }

  public enum ResourceTerritoryType
  {
    Resource,
    Farm,
  }

  public class b
  {
    public b()
    {
      // ISSUE: reference to a compiler-generated method
      this.at(new b3());
      // ISSUE: reference to a compiler-generated method
      this.@as(new b3());
      // ISSUE: reference to a compiler-generated method
      this.ar(new b3());
      // ISSUE: reference to a compiler-generated method
      this.@as(string.Empty);
    }
  }
}
