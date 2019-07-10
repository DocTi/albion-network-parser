﻿// This is an open source non-commercial project. Dear PVS-Studio, please check it.
// PVS-Studio Static Code Analyzer for C, C++ and C#: http://www.viva64.com

namespace Albion.Common
{
    public enum OperationCodes : short
    {
        Unused,
        Ping,
        Join,
        CreateAccount,
        Login,
        SendCrashLog,
        CreateCharacter,
        DeleteCharacter,
        SelectCharacter,
        RedeemKeycode,
        GetGameServerByCluster,
        GetActiveSubscription,
        GetShopPurchaseUrl,
        GetBuyTrialDetails,
        GetReferralSeasonDetails,
        GetReferralLink,
        GetAvailableTrialKeys,
        GetShopTilesForCategory,
        Move,
        AttackStart,
        CastStart,
        CastCancel,
        TerminateToggleSpell,
        ChannelingCancel,
        AttackBuildingStart,
        InventoryDestroyItem,
        InventoryMoveItem,
        InventorySplitStack,
        GetClusterData,
        ChangeCluster,
        ConsoleCommand,
        ChatMessage,
        ReportClientError,
        RegisterToObject,
        UnRegisterFromObject,
        CraftBuildingChangeSettings,
        CraftBuildingTakeMoney,
        RepairBuildingChangeSettings,
        RepairBuildingTakeMoney,
        ActionBuildingChangeSettings,
        HarvestStart,
        HarvestCancel,
        TakeSilver,
        ActionOnBuildingStart,
        ActionOnBuildingCancel,
        ItemRerollQualityStart,
        ItemRerollQualityCancel,
        InstallResourceStart,
        InstallResourceCancel,
        InstallSilver,
        BuildingFillNutrition,
        BuildingChangeRenovationState,
        BuildingBuySkin,
        BuildingClaim,
        BuildingGiveup,
        BuildingNutritionSilverStorageDeposit,
        BuildingNutritionSilverStorageWithdraw,
        BuildingNutritionSilverRewardSet,
        ConstructionSiteCreate,
        PlaceableItemPlace,
        PlaceableItemPlaceCancel,
        PlaceableObjectPickup,
        FurnitureObjectUse,
        FarmableHarvest,
        FarmableFinishGrownItem,
        FarmableDestroy,
        FarmableGetProduct,
        FarmableFill,
        LaborerObjectPlace,
        LaborerObjectPlaceCancel,
        TearDownConstructionSite,
        CastleGateUse,
        AuctionCreateOffer,
        AuctionCreateRequest,
        AuctionGetOffers,
        AuctionGetRequests,
        AuctionBuyOffer,
        AuctionAbortAuction,
        AuctionModifyAuction,
        AuctionAbortOffer,
        AuctionAbortRequest,
        AuctionSellRequest,
        AuctionGetFinishedAuctions,
        AuctionFetchAuction,
        AuctionGetMyOpenOffers,
        AuctionGetMyOpenRequests,
        AuctionGetMyOpenAuctions,
        AuctionGetItemsAverage,
        AuctionGetItemAverageStats,
        AuctionGetItemAverageValue,
        ContainerOpen,
        ContainerClose,
        ContainerManageSubContainer,
        Respawn,
        Suicide,
        JoinGuild,
        LeaveGuild,
        CreateGuild,
        InviteToGuild,
        DeclineGuildInvitation,
        KickFromGuild,
        DuellingChallengePlayer,
        DuellingAcceptChallenge,
        DuellingDenyChallenge,
        ChangeClusterTax,
        ClaimTerritory,
        GiveUpTerritory,
        ChangeTerritoryAccessRights,
        GetMonolithInfo,
        GetClaimInfo,
        GetAttackInfo,
        GetTerritorySeasonPoints,
        GetAttackSchedule,
        ScheduleAttack,
        GetMatches,
        GetMatchDetails,
        JoinMatch,
        LeaveMatch,
        ChangeChatSettings,
        LogoutStart,
        LogoutCancel,
        ClaimOrbStart,
        ClaimOrbCancel,
        MatchLootChestOpeningStart,
        MatchLootChestOpeningCancel,
        DepositToGuildAccount,
        WithdrawalFromAccount,
        ChangeGuildPayUpkeepFlag,
        ChangeGuildTax,
        GetMyTerritories,
        MorganaCommand,
        GetServerInfo,
        InviteMercenaryToMatch,
        SubscribeToCluster,
        AnswerMercenaryInvitation,
        GetCharacterEquipment,
        GetCharacterSteamAchievements,
        GetCharacterStats,
        GetKillHistoryDetails,
        LearnMasteryLevel,
        ReSpecAchievement,
        ChangeAvatar,
        GetRankings,
        GetRank,
        GetGvgSeasonRankings,
        GetGvgSeasonRank,
        GetGvgSeasonHistoryRankings,
        GetGvgSeasonGuildMemberHistory,
        KickFromGvGMatch,
        GetChestLogs,
        GetAccessRightLogs,
        GetGuildAccountLogs,
        InviteToPlayerTrade,
        PlayerTradeCancel,
        PlayerTradeInvitationAccept,
        PlayerTradeAddItem,
        PlayerTradeRemoveItem,
        PlayerTradeAcceptTrade,
        PlayerTradeSetSilverOrGold,
        SendMiniMapPing,
        Stuck,
        BuyRealEstate,
        ClaimRealEstate,
        GiveUpRealEstate,
        ChangeRealEstateOutline,
        GetMailInfos,
        ReadMail,
        SendNewMail,
        DeleteMail,
        ClaimAttachmentFromMail,
        UpdateLfgInfo,
        GetLfgInfos,
        GetMyGuildLfgInfo,
        GetLfgDescriptionText,
        LfgApplyToGuild,
        AnswerLfgGuildApplication,
        GetClusterInfo,
        RegisterChatPeer,
        SendChatMessage,
        JoinChatChannel,
        LeaveChatChannel,
        SendWhisperMessage,
        Say,
        PlayEmote,
        StopEmote,
        GetClusterMapInfo,
        AccessRightsChangeSettings,
        Mount,
        MountCancel,
        BuyJourney,
        SetSaleStatusForEstate,
        ResolveGuildOrPlayerName,
        GetRespawnInfos,
        MakeHome,
        LeaveHome,
        ResurrectionReply,
        AllianceCreate,
        AllianceDisband,
        AllianceGetMemberInfos,
        AllianceInvite,
        AllianceAnswerInvitation,
        AllianceCancelInvitation,
        AllianceKickGuild,
        AllianceLeave,
        AllianceChangeGoldPaymentFlag,
        AllianceGetDetailInfo,
        GetIslandInfos,
        AbandonMyIsland,
        BuyMyIsland,
        BuyGuildIsland,
        AbandonGuildIsland,
        UpgradeMyIsland,
        UpgradeGuildIsland,
        MoveMyIsland,
        MoveGuildIsland,
        TerritoryFillNutrition,
        TeleportBack,
        PartyInvitePlayer,
        PartyAnswerInvitation,
        PartyLeave,
        PartyKickPlayer,
        PartyMakeLeader,
        PartyChangeLootSetting,
        PartyMarkObject,
        PartySetRole,
        GetGuildMOTD,
        SetGuildMOTD,
        ExitEnterStart,
        ExitEnterCancel,
        QuestGiverRequest,
        GoldMarketGetBuyOffer,
        GoldMarketGetBuyOfferFromSilver,
        GoldMarketGetSellOffer,
        GoldMarketGetSellOfferFromSilver,
        GoldMarketBuyGold,
        GoldMarketSellGold,
        GoldMarketCreateSellOrder,
        GoldMarketCreateBuyOrder,
        GoldMarketGetInfos,
        GoldMarketCancelOrder,
        GoldMarketGetAverageInfo,
        SiegeCampClaimStart,
        SiegeCampClaimCancel,
        TreasureChestUsingStart,
        TreasureChestUsingCancel,
        UseLootChest,
        UseShrine,
        LaborerStartJob,
        LaborerTakeJobLoot,
        LaborerDismiss,
        LaborerMove,
        LaborerBuyItem,
        LaborerUpgrade,
        BuyPremium,
        BuyTrial,
        RealEstateGetAuctionData,
        RealEstateBidOnAuction,
        GetSiegeCampCooldown,
        FriendInvite,
        FriendAnswerInvitation,
        FriendCancelnvitation,
        FriendRemove,
        InventoryStack,
        InventorySort,
        EquipmentItemChangeSpell,
        ExpeditionRegister,
        ExpeditionRegisterCancel,
        JoinExpedition,
        DeclineExpeditionInvitation,
        VoteStart,
        VoteDoVote,
        RatingDoRate,
        EnteringExpeditionStart,
        EnteringExpeditionCancel,
        ActivateExpeditionCheckPoint,
        ArenaRegister,
        ArenaRegisterCancel,
        ArenaLeave,
        JoinArenaMatch,
        DeclineArenaInvitation,
        EnteringArenaStart,
        EnteringArenaCancel,
        ArenaCustomMatch,
        ArenaCustomMatchCreate,
        UpdateCharacterStatement,
        BoostFarmable,
        GetStrikeHistory,
        UseFunction,
        UsePortalEntrance,
        ResetPortalBinding,
        QueryPortalBinding,
        ClaimPaymentTransaction,
        ChangeUseFlag,
        ClientPerformanceStats,
        ExtendedHardwareStats,
        ClientLowMemoryWarning,
        TerritoryClaimStart,
        TerritoryClaimCancel,
        RequestAppStoreProducts,
        VerifyProductPurchase,
        QueryGuildPlayerStats,
        TrackAchievements,
        SetAchievementsAutoLearn,
        DepositItemToGuildCurrency,
        WithdrawalItemFromGuildCurrency,
        AuctionSellSpecificItemRequest,
        FishingStart,
        FishingCasting,
        FishingCast,
        FishingCatch,
        FishingPull,
        FishingGiveLine,
        FishingFinish,
        FishingCancel,
        CreateGuildAccessTag,
        DeleteGuildAccessTag,
        RenameGuildAccessTag,
        FlagGuildAccessTagGuildPermission,
        AssignGuildAccessTag,
        RemoveGuildAccessTagFromPlayer,
        ModifyGuildAccessTagEditors,
        RequestPublicAccessTags,
        ChangeAccessTagPublicFlag,
        UpdateGuildAccessTag,
        SteamStartMicrotransaction,
        SteamFinishMicrotransaction,
        SteamIdHasActiveAccount,
        CheckEmailAccountState,
        LinkAccountToSteamId,
        BuyGvgSeasonBooster,
        ChangeFlaggingPrepare,
        OverCharge,
        OverChargeEnd,
        RequestTrusted,
        ChangeGuildLogo,
        PartyFinderRegisterForUpdates,
        PartyFinderUnregisterForUpdates,
        PartyFinderEnlistNewPartySearch,
        PartyFinderDeletePartySearch,
        PartyFinderChangePartySearch,
        PartyFinderChangeRole,
        PartyFinderApplyForGroup,
        PartyFinderAcceptOrDeclineApplyForGroup,
        PartyFinderGetEquipmentSnapshot,
        PartyFinderRegisterApplicants,
        PartyFinderUnregisterApplicants,
        PartyFinderFulltextSearch,
        PartyFinderRequestEquipmentSnapshot,
        GetPersonalSeasonTrackerData,
        UseConsumableFromInventory,
        ClaimPersonalSeasonReward,
        EasyAntiCheatMessageToServer,
        RetaliationAttackClaimTerritory,
        SetNextTutorialState,
        AddPlayerToMuteList,
        RemovePlayerFromMuteList,
        MakeTerritoryHome,
        LeaveTerritoryHome,
        ProductShopUserEvent,
        GetVanityUnlocks,
        BuyVanityUnlock,
        GetMountSkins,
        SetMountSkin,
        ChangeCustomization,
        SetFavoriteIsland
    }
}
