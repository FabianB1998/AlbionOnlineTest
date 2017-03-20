// Decompiled with JetBrains decompiler
// Type: Albion.Common.SimulationObjects.ErrorCodes.InstallResourcesErrorCode
// Assembly: Albion.Common, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8E9CFC81-AA34-4410-9004-379A07925CAB
// Assembly location: C:\Program Files (x86)\AlbionOnline\game\Albion-Online_Data\Managed\Albion.Common.dll

namespace Albion.Common.SimulationObjects.ErrorCodes
{
  public enum InstallResourcesErrorCode : short
  {
    Invalid,
    Ok,
    OutOfRange,
    InvalidContainer,
    ItemNotInRequirements,
    ItemRequirementFull,
    NotEnoughResources,
    NotEnoughSilver,
    InvalidRights,
    InvalidItem,
    InvalidStack,
    InvalidRenovationType,
    PlayerNotRegistered,
    IsConstructing,
    NotUpgradeable,
    NotUpgradeableMaxTierOfCluster,
    NotAllowedWhileMounted,
  }
}
