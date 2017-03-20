// Decompiled with JetBrains decompiler
// Type: Albion.Common.Auction.AuctionDTO
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

using System;

namespace Albion.Common.Auction
{
  public class AuctionDTO
  {
    public long Id { get; set; }

    public long UnitPriceSilver { get; set; }

    public long TotalPriceSilver { get; set; }

    public virtual int Amount { get; set; }

    public virtual int Tier { get; set; }

    public bool IsFinished { get; set; }

    public string AuctionType { get; set; }

    public bool HasBuyerFetched { get; set; }

    public bool HasSellerFetched { get; set; }

    public string SellerCharacterId { get; set; }

    public string SellerName { get; set; }

    public string BuyerCharacterId { get; set; }

    public string BuyerName { get; set; }

    public string ItemTypeId { get; set; }

    public string ItemGroupTypeId { get; set; }

    public int EnchantmentLevel { get; set; }

    public string CraftedBy { get; set; }

    public int QualityLevel { get; set; }

    public DateTime Expires { get; set; }
  }
}
