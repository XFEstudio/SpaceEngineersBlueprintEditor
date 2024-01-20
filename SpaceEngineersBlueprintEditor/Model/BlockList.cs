﻿namespace SpaceEngineersBlueprintEditor.Model;

public static class BlockList
{
    public static string[] NormalBlocks { get => normalBlocks; }
    public static string[] HeavyBlocks { get => heavyBlocks; }
    public static string[] SmallBlocks { get => smallBlocks; }
    public static string[] LargeBlocks { get => largeBlocks; }
    #region 内部列表
    private static readonly string[] normalBlocks =
                ["<SubtypeName>LargeBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorRoundSlope",
                    "<SubtypeName>LargeBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>LargeHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>LargeArmorPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorQuarterPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelLightLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelLightLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelLightRight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelLightRight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelLightInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelLightInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelTipLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedSidePanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransition</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorRoundSlope",
                    "<SubtypeName>SmallBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>HalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>HalfArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>SmallArmorPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorQuarterPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelLightLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelLightLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelLightRight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelLightRight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelLightInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelLightInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelTip</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedSidePanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransition</SubtypeName>"];
    private static readonly string[] heavyBlocks =
                ["<SubtypeName>LargeHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorRoundSlope",
                    "<SubtypeName>LargeHeavyBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>LargeArmorPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorQuarterPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelHeavyInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelHeavyInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelTipHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedSidePanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransition</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorRoundSlope",
                    "<SubtypeName>SmallHeavyBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>HeavyHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>HeavyHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>SmallArmorPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorQuarterPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelHeavyInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelHeavyInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelTipHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedSidePanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransition</SubtypeName>"];
    private static readonly string[] smallBlocks =
                ["<SubtypeName>SmallBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorRoundSlope",
                    "<SubtypeName>SmallBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>HalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>HalfArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>SmallArmorPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorQuarterPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelLightLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelLightLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelLightRight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelLightRight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelLightInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelLightInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelTip</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedSidePanelLight</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>SmallBlockArmorSlopeTransition</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorRoundSlope",
                    "<SubtypeName>SmallHeavyBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>HeavyHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>HeavyHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>SmallHeavyBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>SmallArmorPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorQuarterPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedTipPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1HalfSlopedPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>SmallArmorHalfSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelHeavyInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelHeavyInv</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideTipPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedSideBasePanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelTipHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmor2x1SlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedSidePanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallArmorSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>SmallBlockHeavyArmorSlopeTransition</SubtypeName>",
                    "<GridSizeEnum>Small</GridSizeEnum>"];
    private static readonly string[] largeBlocks =
                ["<SubtypeName>LargeBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorRoundSlope",
                    "<SubtypeName>LargeBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>LargeHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>LargeArmorPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorQuarterPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelLightLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelLightLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelLightRight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelLightRight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelLightInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelLightInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelTipLight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedSidePanelLight</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedPanelLight</SubtypeName>",
                    "<SubtypeName>LargeBlockArmorSlopeTransition</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorRoundSlope",
                    "<SubtypeName>LargeHeavyBlockArmorRoundCornerInv</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorRoundCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopedCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfCorner</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyHalfSlopeArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyHalfArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope2Tip</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorBlock</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorCornerSquareInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorCornerSquare</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCornerInv</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorSlope</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeInverted</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorHalfSlopeCornerInverted</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorInvCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorInvCorner2Base</SubtypeName>",
                    "<SubtypeName>LargeHeavyBlockArmorCorner2Tip</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionBase</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionTipMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionBaseMirrored</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransitionTip</SubtypeName>",
                    "<SubtypeName>LargeArmorPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorQuarterPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelHeavyLeft</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedTipPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1HalfSlopedPanelHeavyRight</SubtypeName>",
                    "<SubtypeName>LargeArmorHalfSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelHeavyInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelHeavyInv</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideTipPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedSideBasePanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelTipHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmor2x1SlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedSidePanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeArmorSlopedPanelHeavy</SubtypeName>",
                    "<SubtypeName>LargeBlockHeavyArmorSlopeTransition</SubtypeName>",
                    "<GridSizeEnum>Large</GridSizeEnum>"];
    #endregion
}