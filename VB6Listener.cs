using System;
using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;

namespace vb6.net
{
    public class VB6Listener : VisualBasic6BaseListener
    {
		public override void EnterStartRule([NotNull] VisualBasic6Parser.StartRuleContext context) { }
		
		public override void ExitStartRule([NotNull] VisualBasic6Parser.StartRuleContext context) { }
		
		public override void EnterModule([NotNull] VisualBasic6Parser.ModuleContext context) { }
		
		public override void ExitModule([NotNull] VisualBasic6Parser.ModuleContext context) { }
		
		public override void EnterModuleReferences([NotNull] VisualBasic6Parser.ModuleReferencesContext context) { }
		
		public override void ExitModuleReferences([NotNull] VisualBasic6Parser.ModuleReferencesContext context) { }
		
		public override void EnterModuleReference([NotNull] VisualBasic6Parser.ModuleReferenceContext context) { }
		
		public override void ExitModuleReference([NotNull] VisualBasic6Parser.ModuleReferenceContext context) { }
		
		public override void EnterModuleReferenceValue([NotNull] VisualBasic6Parser.ModuleReferenceValueContext context) { }
		
		public override void ExitModuleReferenceValue([NotNull] VisualBasic6Parser.ModuleReferenceValueContext context) { }
		
		public override void EnterModuleReferenceComponent([NotNull] VisualBasic6Parser.ModuleReferenceComponentContext context) { }
		
		public override void ExitModuleReferenceComponent([NotNull] VisualBasic6Parser.ModuleReferenceComponentContext context) { }
		
		public override void EnterModuleHeader([NotNull] VisualBasic6Parser.ModuleHeaderContext context) { }
		
		public override void ExitModuleHeader([NotNull] VisualBasic6Parser.ModuleHeaderContext context) { }
		
		public override void EnterModuleConfig([NotNull] VisualBasic6Parser.ModuleConfigContext context) { }
		
		public override void ExitModuleConfig([NotNull] VisualBasic6Parser.ModuleConfigContext context) { }
		
		public override void EnterModuleConfigElement([NotNull] VisualBasic6Parser.ModuleConfigElementContext context) { }
		
		public override void ExitModuleConfigElement([NotNull] VisualBasic6Parser.ModuleConfigElementContext context) { }
		
		public override void EnterModuleAttributes([NotNull] VisualBasic6Parser.ModuleAttributesContext context) { }
		
		public override void ExitModuleAttributes([NotNull] VisualBasic6Parser.ModuleAttributesContext context) { }
		
		public override void EnterModuleOptions([NotNull] VisualBasic6Parser.ModuleOptionsContext context) { }
		
		public override void ExitModuleOptions([NotNull] VisualBasic6Parser.ModuleOptionsContext context) { }
		
		public override void EnterOptionBaseStmt([NotNull] VisualBasic6Parser.OptionBaseStmtContext context) { }
		
		public override void ExitOptionBaseStmt([NotNull] VisualBasic6Parser.OptionBaseStmtContext context) { }
		
		public override void EnterOptionCompareStmt([NotNull] VisualBasic6Parser.OptionCompareStmtContext context) { }
		
		public override void ExitOptionCompareStmt([NotNull] VisualBasic6Parser.OptionCompareStmtContext context) { }
		
		public override void EnterOptionExplicitStmt([NotNull] VisualBasic6Parser.OptionExplicitStmtContext context) { }
		
		public override void ExitOptionExplicitStmt([NotNull] VisualBasic6Parser.OptionExplicitStmtContext context) { }
		
		public override void EnterOptionPrivateModuleStmt([NotNull] VisualBasic6Parser.OptionPrivateModuleStmtContext context) { }
		
		public override void ExitOptionPrivateModuleStmt([NotNull] VisualBasic6Parser.OptionPrivateModuleStmtContext context) { }
		
		public override void EnterModuleBody([NotNull] VisualBasic6Parser.ModuleBodyContext context) { }
		
		public override void ExitModuleBody([NotNull] VisualBasic6Parser.ModuleBodyContext context) { }
		
		public override void EnterModuleBodyElement([NotNull] VisualBasic6Parser.ModuleBodyElementContext context) { }
		
		public override void ExitModuleBodyElement([NotNull] VisualBasic6Parser.ModuleBodyElementContext context) { }
		
		public override void EnterControlProperties([NotNull] VisualBasic6Parser.ControlPropertiesContext context) { }
		
		public override void ExitControlProperties([NotNull] VisualBasic6Parser.ControlPropertiesContext context) { }
		
		public override void EnterCp_Properties([NotNull] VisualBasic6Parser.Cp_PropertiesContext context) { }
		
		public override void ExitCp_Properties([NotNull] VisualBasic6Parser.Cp_PropertiesContext context) { }
		
		public override void EnterCp_SingleProperty([NotNull] VisualBasic6Parser.Cp_SinglePropertyContext context) { }
		
		public override void ExitCp_SingleProperty([NotNull] VisualBasic6Parser.Cp_SinglePropertyContext context) { }
		
		public override void EnterCp_PropertyName([NotNull] VisualBasic6Parser.Cp_PropertyNameContext context) { }
		
		public override void ExitCp_PropertyName([NotNull] VisualBasic6Parser.Cp_PropertyNameContext context) { }
		
		public override void EnterCp_PropertyValue([NotNull] VisualBasic6Parser.Cp_PropertyValueContext context) { }
		
		public override void ExitCp_PropertyValue([NotNull] VisualBasic6Parser.Cp_PropertyValueContext context) { }
		
		public override void EnterCp_NestedProperty([NotNull] VisualBasic6Parser.Cp_NestedPropertyContext context) { }
		
		public override void ExitCp_NestedProperty([NotNull] VisualBasic6Parser.Cp_NestedPropertyContext context) { }
		
		public override void EnterCp_ControlType([NotNull] VisualBasic6Parser.Cp_ControlTypeContext context) { }
		
		public override void ExitCp_ControlType([NotNull] VisualBasic6Parser.Cp_ControlTypeContext context) { }
		
		public override void EnterCp_ControlIdentifier([NotNull] VisualBasic6Parser.Cp_ControlIdentifierContext context) { }
		
		public override void ExitCp_ControlIdentifier([NotNull] VisualBasic6Parser.Cp_ControlIdentifierContext context) { }
		
		public override void EnterModuleBlock([NotNull] VisualBasic6Parser.ModuleBlockContext context) { }
		
		public override void ExitModuleBlock([NotNull] VisualBasic6Parser.ModuleBlockContext context) { }
		
		public override void EnterAttributeStmt([NotNull] VisualBasic6Parser.AttributeStmtContext context) { }
		
		public override void ExitAttributeStmt([NotNull] VisualBasic6Parser.AttributeStmtContext context) { }
		
		public override void EnterBlock([NotNull] VisualBasic6Parser.BlockContext context) { }
		
		public override void ExitBlock([NotNull] VisualBasic6Parser.BlockContext context) { }
		
		public override void EnterBlockStmt([NotNull] VisualBasic6Parser.BlockStmtContext context) { }
		
		public override void ExitBlockStmt([NotNull] VisualBasic6Parser.BlockStmtContext context) { }
		
		public override void EnterAppActivateStmt([NotNull] VisualBasic6Parser.AppActivateStmtContext context) { }
		
		public override void ExitAppActivateStmt([NotNull] VisualBasic6Parser.AppActivateStmtContext context) { }
		
		public override void EnterBeepStmt([NotNull] VisualBasic6Parser.BeepStmtContext context) { }
		
		public override void ExitBeepStmt([NotNull] VisualBasic6Parser.BeepStmtContext context) { }
		
		public override void EnterChDirStmt([NotNull] VisualBasic6Parser.ChDirStmtContext context) { }
		
		public override void ExitChDirStmt([NotNull] VisualBasic6Parser.ChDirStmtContext context) { }
		
		public override void EnterChDriveStmt([NotNull] VisualBasic6Parser.ChDriveStmtContext context) { }
		
		public override void ExitChDriveStmt([NotNull] VisualBasic6Parser.ChDriveStmtContext context) { }
		
		public override void EnterCloseStmt([NotNull] VisualBasic6Parser.CloseStmtContext context) { }
		
		public override void ExitCloseStmt([NotNull] VisualBasic6Parser.CloseStmtContext context) { }
		
		public override void EnterConstStmt([NotNull] VisualBasic6Parser.ConstStmtContext context) { }
		
		public override void ExitConstStmt([NotNull] VisualBasic6Parser.ConstStmtContext context) { }
		
		public override void EnterConstSubStmt([NotNull] VisualBasic6Parser.ConstSubStmtContext context) { }
		
		public override void ExitConstSubStmt([NotNull] VisualBasic6Parser.ConstSubStmtContext context) { }
		
		public override void EnterDateStmt([NotNull] VisualBasic6Parser.DateStmtContext context) { }
		
		public override void ExitDateStmt([NotNull] VisualBasic6Parser.DateStmtContext context) { }
		
		public override void EnterDeclareStmt([NotNull] VisualBasic6Parser.DeclareStmtContext context) { }
		
		public override void ExitDeclareStmt([NotNull] VisualBasic6Parser.DeclareStmtContext context) { }
		
		public override void EnterDeftypeStmt([NotNull] VisualBasic6Parser.DeftypeStmtContext context) { }
		
		public override void ExitDeftypeStmt([NotNull] VisualBasic6Parser.DeftypeStmtContext context) { }
		
		public override void EnterDeleteSettingStmt([NotNull] VisualBasic6Parser.DeleteSettingStmtContext context) { }
		
		public override void ExitDeleteSettingStmt([NotNull] VisualBasic6Parser.DeleteSettingStmtContext context) { }
		
		public override void EnterDoLoopStmt([NotNull] VisualBasic6Parser.DoLoopStmtContext context) { }
		
		public override void ExitDoLoopStmt([NotNull] VisualBasic6Parser.DoLoopStmtContext context) { }
		
		public override void EnterEndStmt([NotNull] VisualBasic6Parser.EndStmtContext context) { }
		
		public override void ExitEndStmt([NotNull] VisualBasic6Parser.EndStmtContext context) { }
		
		public override void EnterEnumerationStmt([NotNull] VisualBasic6Parser.EnumerationStmtContext context) { }
		
		public override void ExitEnumerationStmt([NotNull] VisualBasic6Parser.EnumerationStmtContext context) { }
		
		public override void EnterEnumerationStmt_Constant([NotNull] VisualBasic6Parser.EnumerationStmt_ConstantContext context) { }
		
		public override void ExitEnumerationStmt_Constant([NotNull] VisualBasic6Parser.EnumerationStmt_ConstantContext context) { }
		
		public override void EnterEraseStmt([NotNull] VisualBasic6Parser.EraseStmtContext context) { }
		
		public override void ExitEraseStmt([NotNull] VisualBasic6Parser.EraseStmtContext context) { }
		
		public override void EnterErrorStmt([NotNull] VisualBasic6Parser.ErrorStmtContext context) { }
		
		public override void ExitErrorStmt([NotNull] VisualBasic6Parser.ErrorStmtContext context) { }
		
		public override void EnterEventStmt([NotNull] VisualBasic6Parser.EventStmtContext context) { }
		
		public override void ExitEventStmt([NotNull] VisualBasic6Parser.EventStmtContext context) { }
		
		public override void EnterExitStmt([NotNull] VisualBasic6Parser.ExitStmtContext context) { }
		
		public override void ExitExitStmt([NotNull] VisualBasic6Parser.ExitStmtContext context) { }
		
		public override void EnterFilecopyStmt([NotNull] VisualBasic6Parser.FilecopyStmtContext context) { }
		
		public override void ExitFilecopyStmt([NotNull] VisualBasic6Parser.FilecopyStmtContext context) { }
		
		public override void EnterForEachStmt([NotNull] VisualBasic6Parser.ForEachStmtContext context) { }
		
		public override void ExitForEachStmt([NotNull] VisualBasic6Parser.ForEachStmtContext context) { }
		
		public override void EnterForNextStmt([NotNull] VisualBasic6Parser.ForNextStmtContext context) { }
		
		public override void ExitForNextStmt([NotNull] VisualBasic6Parser.ForNextStmtContext context) { }
		
		public override void EnterFunctionStmt([NotNull] VisualBasic6Parser.FunctionStmtContext context) { }
		
		public override void ExitFunctionStmt([NotNull] VisualBasic6Parser.FunctionStmtContext context) { }
		
		public override void EnterGetStmt([NotNull] VisualBasic6Parser.GetStmtContext context) { }
		
		public override void ExitGetStmt([NotNull] VisualBasic6Parser.GetStmtContext context) { }
		
		public override void EnterGoSubStmt([NotNull] VisualBasic6Parser.GoSubStmtContext context) { }
		
		public override void ExitGoSubStmt([NotNull] VisualBasic6Parser.GoSubStmtContext context) { }
		
		public override void EnterGoToStmt([NotNull] VisualBasic6Parser.GoToStmtContext context) { }
		
		public override void ExitGoToStmt([NotNull] VisualBasic6Parser.GoToStmtContext context) { }
		
		public override void EnterInlineIfThenElse([NotNull] VisualBasic6Parser.InlineIfThenElseContext context) { }
		
		public override void ExitInlineIfThenElse([NotNull] VisualBasic6Parser.InlineIfThenElseContext context) { }
		
		public override void EnterBlockIfThenElse([NotNull] VisualBasic6Parser.BlockIfThenElseContext context) { }
		
		public override void ExitBlockIfThenElse([NotNull] VisualBasic6Parser.BlockIfThenElseContext context) { }
		
		public override void EnterIfBlockStmt([NotNull] VisualBasic6Parser.IfBlockStmtContext context) { }
		
		public override void ExitIfBlockStmt([NotNull] VisualBasic6Parser.IfBlockStmtContext context) { }
		
		public override void EnterIfConditionStmt([NotNull] VisualBasic6Parser.IfConditionStmtContext context) { }
		
		public override void ExitIfConditionStmt([NotNull] VisualBasic6Parser.IfConditionStmtContext context) { }
		
		public override void EnterIfElseIfBlockStmt([NotNull] VisualBasic6Parser.IfElseIfBlockStmtContext context) { }
		
		public override void ExitIfElseIfBlockStmt([NotNull] VisualBasic6Parser.IfElseIfBlockStmtContext context) { }
		
		public override void EnterIfElseBlockStmt([NotNull] VisualBasic6Parser.IfElseBlockStmtContext context) { }
		
		public override void ExitIfElseBlockStmt([NotNull] VisualBasic6Parser.IfElseBlockStmtContext context) { }
		
		public override void EnterImplementsStmt([NotNull] VisualBasic6Parser.ImplementsStmtContext context) { }
		
		public override void ExitImplementsStmt([NotNull] VisualBasic6Parser.ImplementsStmtContext context) { }
		
		public override void EnterInputStmt([NotNull] VisualBasic6Parser.InputStmtContext context) { }
		
		public override void ExitInputStmt([NotNull] VisualBasic6Parser.InputStmtContext context) { }
		
		public override void EnterKillStmt([NotNull] VisualBasic6Parser.KillStmtContext context) { }
		
		public override void ExitKillStmt([NotNull] VisualBasic6Parser.KillStmtContext context) { }
		
		public override void EnterLetStmt([NotNull] VisualBasic6Parser.LetStmtContext context) { }
		
		public override void ExitLetStmt([NotNull] VisualBasic6Parser.LetStmtContext context) { }
		
		public override void EnterLineInputStmt([NotNull] VisualBasic6Parser.LineInputStmtContext context) { }
		
		public override void ExitLineInputStmt([NotNull] VisualBasic6Parser.LineInputStmtContext context) { }
		
		public override void EnterLoadStmt([NotNull] VisualBasic6Parser.LoadStmtContext context) { }
		
		public override void ExitLoadStmt([NotNull] VisualBasic6Parser.LoadStmtContext context) { }
		
		public override void EnterLockStmt([NotNull] VisualBasic6Parser.LockStmtContext context) { }
		
		public override void ExitLockStmt([NotNull] VisualBasic6Parser.LockStmtContext context) { }
		
		public override void EnterLsetStmt([NotNull] VisualBasic6Parser.LsetStmtContext context) { }
		
		public override void ExitLsetStmt([NotNull] VisualBasic6Parser.LsetStmtContext context) { }
		
		public override void EnterMacroIfThenElseStmt([NotNull] VisualBasic6Parser.MacroIfThenElseStmtContext context) { }
		
		public override void ExitMacroIfThenElseStmt([NotNull] VisualBasic6Parser.MacroIfThenElseStmtContext context) { }
		
		public override void EnterMacroIfBlockStmt([NotNull] VisualBasic6Parser.MacroIfBlockStmtContext context) { }
		
		public override void ExitMacroIfBlockStmt([NotNull] VisualBasic6Parser.MacroIfBlockStmtContext context) { }
		
		public override void EnterMacroElseIfBlockStmt([NotNull] VisualBasic6Parser.MacroElseIfBlockStmtContext context) { }
		
		public override void ExitMacroElseIfBlockStmt([NotNull] VisualBasic6Parser.MacroElseIfBlockStmtContext context) { }
		
		public override void EnterMacroElseBlockStmt([NotNull] VisualBasic6Parser.MacroElseBlockStmtContext context) { }
		
		public override void ExitMacroElseBlockStmt([NotNull] VisualBasic6Parser.MacroElseBlockStmtContext context) { }
		
		public override void EnterMidStmt([NotNull] VisualBasic6Parser.MidStmtContext context) { }
		
		public override void ExitMidStmt([NotNull] VisualBasic6Parser.MidStmtContext context) { }
		
		public override void EnterMkdirStmt([NotNull] VisualBasic6Parser.MkdirStmtContext context) { }
		
		public override void ExitMkdirStmt([NotNull] VisualBasic6Parser.MkdirStmtContext context) { }
		
		public override void EnterNameStmt([NotNull] VisualBasic6Parser.NameStmtContext context) { }
		
		public override void ExitNameStmt([NotNull] VisualBasic6Parser.NameStmtContext context) { }
		
		public override void EnterOnErrorStmt([NotNull] VisualBasic6Parser.OnErrorStmtContext context) { }
		
		public override void ExitOnErrorStmt([NotNull] VisualBasic6Parser.OnErrorStmtContext context) { }
		
		public override void EnterOnGoToStmt([NotNull] VisualBasic6Parser.OnGoToStmtContext context) { }
		
		public override void ExitOnGoToStmt([NotNull] VisualBasic6Parser.OnGoToStmtContext context) { }
		
		public override void EnterOnGoSubStmt([NotNull] VisualBasic6Parser.OnGoSubStmtContext context) { }
		
		public override void ExitOnGoSubStmt([NotNull] VisualBasic6Parser.OnGoSubStmtContext context) { }
		
		public override void EnterOpenStmt([NotNull] VisualBasic6Parser.OpenStmtContext context) { }
		
		public override void ExitOpenStmt([NotNull] VisualBasic6Parser.OpenStmtContext context) { }
		
		public override void EnterOutputList([NotNull] VisualBasic6Parser.OutputListContext context) { }
		
		public override void ExitOutputList([NotNull] VisualBasic6Parser.OutputListContext context) { }
		
		public override void EnterOutputList_Expression([NotNull] VisualBasic6Parser.OutputList_ExpressionContext context) { }
		
		public override void ExitOutputList_Expression([NotNull] VisualBasic6Parser.OutputList_ExpressionContext context) { }
		
		public override void EnterPrintStmt([NotNull] VisualBasic6Parser.PrintStmtContext context) { }
		
		public override void ExitPrintStmt([NotNull] VisualBasic6Parser.PrintStmtContext context) { }
		
		public override void EnterPropertyGetStmt([NotNull] VisualBasic6Parser.PropertyGetStmtContext context) { }
		
		public override void ExitPropertyGetStmt([NotNull] VisualBasic6Parser.PropertyGetStmtContext context) { }
		
		public override void EnterPropertySetStmt([NotNull] VisualBasic6Parser.PropertySetStmtContext context) { }
		
		public override void ExitPropertySetStmt([NotNull] VisualBasic6Parser.PropertySetStmtContext context) { }
		
		public override void EnterPropertyLetStmt([NotNull] VisualBasic6Parser.PropertyLetStmtContext context) { }
		
		public override void ExitPropertyLetStmt([NotNull] VisualBasic6Parser.PropertyLetStmtContext context) { }
		
		public override void EnterPutStmt([NotNull] VisualBasic6Parser.PutStmtContext context) { }
		
		public override void ExitPutStmt([NotNull] VisualBasic6Parser.PutStmtContext context) { }
		
		public override void EnterRaiseEventStmt([NotNull] VisualBasic6Parser.RaiseEventStmtContext context) { }
		
		public override void ExitRaiseEventStmt([NotNull] VisualBasic6Parser.RaiseEventStmtContext context) { }
		
		public override void EnterRandomizeStmt([NotNull] VisualBasic6Parser.RandomizeStmtContext context) { }
		
		public override void ExitRandomizeStmt([NotNull] VisualBasic6Parser.RandomizeStmtContext context) { }
		
		public override void EnterRedimStmt([NotNull] VisualBasic6Parser.RedimStmtContext context) { }
		
		public override void ExitRedimStmt([NotNull] VisualBasic6Parser.RedimStmtContext context) { }
		
		public override void EnterRedimSubStmt([NotNull] VisualBasic6Parser.RedimSubStmtContext context) { }
		
		public override void ExitRedimSubStmt([NotNull] VisualBasic6Parser.RedimSubStmtContext context) { }
		
		public override void EnterResetStmt([NotNull] VisualBasic6Parser.ResetStmtContext context) { }
		
		public override void ExitResetStmt([NotNull] VisualBasic6Parser.ResetStmtContext context) { }
		
		public override void EnterResumeStmt([NotNull] VisualBasic6Parser.ResumeStmtContext context) { }
		
		public override void ExitResumeStmt([NotNull] VisualBasic6Parser.ResumeStmtContext context) { }
		
		public override void EnterReturnStmt([NotNull] VisualBasic6Parser.ReturnStmtContext context) { }
		
		public override void ExitReturnStmt([NotNull] VisualBasic6Parser.ReturnStmtContext context) { }
		
		public override void EnterRmdirStmt([NotNull] VisualBasic6Parser.RmdirStmtContext context) { }
		
		public override void ExitRmdirStmt([NotNull] VisualBasic6Parser.RmdirStmtContext context) { }
		
		public override void EnterRsetStmt([NotNull] VisualBasic6Parser.RsetStmtContext context) { }
		
		public override void ExitRsetStmt([NotNull] VisualBasic6Parser.RsetStmtContext context) { }
		
		public override void EnterSavepictureStmt([NotNull] VisualBasic6Parser.SavepictureStmtContext context) { }
		
		public override void ExitSavepictureStmt([NotNull] VisualBasic6Parser.SavepictureStmtContext context) { }
		
		public override void EnterSaveSettingStmt([NotNull] VisualBasic6Parser.SaveSettingStmtContext context) { }
		
		public override void ExitSaveSettingStmt([NotNull] VisualBasic6Parser.SaveSettingStmtContext context) { }
		
		public override void EnterSeekStmt([NotNull] VisualBasic6Parser.SeekStmtContext context) { }
		
		public override void ExitSeekStmt([NotNull] VisualBasic6Parser.SeekStmtContext context) { }
		
		public override void EnterSelectCaseStmt([NotNull] VisualBasic6Parser.SelectCaseStmtContext context) { }
		
		public override void ExitSelectCaseStmt([NotNull] VisualBasic6Parser.SelectCaseStmtContext context) { }
		
		public override void EnterSC_Case([NotNull] VisualBasic6Parser.SC_CaseContext context) { }
		
		public override void ExitSC_Case([NotNull] VisualBasic6Parser.SC_CaseContext context) { }
		
		public override void EnterCaseCondElse([NotNull] VisualBasic6Parser.CaseCondElseContext context) { }
		
		public override void ExitCaseCondElse([NotNull] VisualBasic6Parser.CaseCondElseContext context) { }
		
		public override void EnterCaseCondExpr([NotNull] VisualBasic6Parser.CaseCondExprContext context) { }
		
		public override void ExitCaseCondExpr([NotNull] VisualBasic6Parser.CaseCondExprContext context) { }
		
		public override void EnterCaseCondExprIs([NotNull] VisualBasic6Parser.CaseCondExprIsContext context) { }
		
		public override void ExitCaseCondExprIs([NotNull] VisualBasic6Parser.CaseCondExprIsContext context) { }
		
		public override void EnterCaseCondExprValue([NotNull] VisualBasic6Parser.CaseCondExprValueContext context) { }
		
		public override void ExitCaseCondExprValue([NotNull] VisualBasic6Parser.CaseCondExprValueContext context) { }
		
		public override void EnterCaseCondExprTo([NotNull] VisualBasic6Parser.CaseCondExprToContext context) { }
		
		public override void ExitCaseCondExprTo([NotNull] VisualBasic6Parser.CaseCondExprToContext context) { }
		
		public override void EnterSendkeysStmt([NotNull] VisualBasic6Parser.SendkeysStmtContext context) { }
		
		public override void ExitSendkeysStmt([NotNull] VisualBasic6Parser.SendkeysStmtContext context) { }
		
		public override void EnterSetattrStmt([NotNull] VisualBasic6Parser.SetattrStmtContext context) { }
		
		public override void ExitSetattrStmt([NotNull] VisualBasic6Parser.SetattrStmtContext context) { }
		
		public override void EnterSetStmt([NotNull] VisualBasic6Parser.SetStmtContext context) { }
		
		public override void ExitSetStmt([NotNull] VisualBasic6Parser.SetStmtContext context) { }
		
		public override void EnterStopStmt([NotNull] VisualBasic6Parser.StopStmtContext context) { }
		
		public override void ExitStopStmt([NotNull] VisualBasic6Parser.StopStmtContext context) { }
		
		public override void EnterSubStmt([NotNull] VisualBasic6Parser.SubStmtContext context) { }
		
		public override void ExitSubStmt([NotNull] VisualBasic6Parser.SubStmtContext context) { }
		
		public override void EnterTimeStmt([NotNull] VisualBasic6Parser.TimeStmtContext context) { }
		
		public override void ExitTimeStmt([NotNull] VisualBasic6Parser.TimeStmtContext context) { }
		
		public override void EnterTypeStmt([NotNull] VisualBasic6Parser.TypeStmtContext context) { }
		
		public override void ExitTypeStmt([NotNull] VisualBasic6Parser.TypeStmtContext context) { }
		
		public override void EnterTypeStmt_Element([NotNull] VisualBasic6Parser.TypeStmt_ElementContext context) { }
		
		public override void ExitTypeStmt_Element([NotNull] VisualBasic6Parser.TypeStmt_ElementContext context) { }
		
		public override void EnterTypeOfStmt([NotNull] VisualBasic6Parser.TypeOfStmtContext context) { }
		
		public override void ExitTypeOfStmt([NotNull] VisualBasic6Parser.TypeOfStmtContext context) { }
		
		public override void EnterUnloadStmt([NotNull] VisualBasic6Parser.UnloadStmtContext context) { }
		
		public override void ExitUnloadStmt([NotNull] VisualBasic6Parser.UnloadStmtContext context) { }
		
		public override void EnterUnlockStmt([NotNull] VisualBasic6Parser.UnlockStmtContext context) { }
		
		public override void ExitUnlockStmt([NotNull] VisualBasic6Parser.UnlockStmtContext context) { }
		
		public override void EnterVsStruct([NotNull] VisualBasic6Parser.VsStructContext context) { }
		
		public override void ExitVsStruct([NotNull] VisualBasic6Parser.VsStructContext context) { }
		
		public override void EnterVsAdd([NotNull] VisualBasic6Parser.VsAddContext context) { }
		
		public override void ExitVsAdd([NotNull] VisualBasic6Parser.VsAddContext context) { }
		
		public override void EnterVsLt([NotNull] VisualBasic6Parser.VsLtContext context) { }
		
		public override void ExitVsLt([NotNull] VisualBasic6Parser.VsLtContext context) { }
		
		public override void EnterVsAddressOf([NotNull] VisualBasic6Parser.VsAddressOfContext context) { }
		
		public override void ExitVsAddressOf([NotNull] VisualBasic6Parser.VsAddressOfContext context) { }
		
		public override void EnterVsNew([NotNull] VisualBasic6Parser.VsNewContext context) { }
		
		public override void ExitVsNew([NotNull] VisualBasic6Parser.VsNewContext context) { }
		
		public override void EnterVsMult([NotNull] VisualBasic6Parser.VsMultContext context) { }
		
		public override void ExitVsMult([NotNull] VisualBasic6Parser.VsMultContext context) { }
		
		public override void EnterVsNegation([NotNull] VisualBasic6Parser.VsNegationContext context) { }
		
		public override void ExitVsNegation([NotNull] VisualBasic6Parser.VsNegationContext context) { }
		
		public override void EnterVsAssign([NotNull] VisualBasic6Parser.VsAssignContext context) { }
		
		public override void ExitVsAssign([NotNull] VisualBasic6Parser.VsAssignContext context) { }
		
		public override void EnterVsDiv([NotNull] VisualBasic6Parser.VsDivContext context) { }
		
		public override void ExitVsDiv([NotNull] VisualBasic6Parser.VsDivContext context) { }
		
		public override void EnterVsLike([NotNull] VisualBasic6Parser.VsLikeContext context) { }
		
		public override void ExitVsLike([NotNull] VisualBasic6Parser.VsLikeContext context) { }
		
		public override void EnterVsPlus([NotNull] VisualBasic6Parser.VsPlusContext context) { }
		
		public override void ExitVsPlus([NotNull] VisualBasic6Parser.VsPlusContext context) { }
		
		public override void EnterVsNot([NotNull] VisualBasic6Parser.VsNotContext context) { }
		
		public override void ExitVsNot([NotNull] VisualBasic6Parser.VsNotContext context) { }
		
		public override void EnterVsGeq([NotNull] VisualBasic6Parser.VsGeqContext context) { }
		
		public override void ExitVsGeq([NotNull] VisualBasic6Parser.VsGeqContext context) { }
		
		public override void EnterVsTypeOf([NotNull] VisualBasic6Parser.VsTypeOfContext context) { }
		
		public override void ExitVsTypeOf([NotNull] VisualBasic6Parser.VsTypeOfContext context) { }
		
		public override void EnterVsICS([NotNull] VisualBasic6Parser.VsICSContext context) { }

		public override void ExitVsICS([NotNull] VisualBasic6Parser.VsICSContext context) { }
		
		public override void EnterVsNeq([NotNull] VisualBasic6Parser.VsNeqContext context) { }
		
		public override void ExitVsNeq([NotNull] VisualBasic6Parser.VsNeqContext context) { }
		
		public override void EnterVsXor([NotNull] VisualBasic6Parser.VsXorContext context) { }
		
		public override void ExitVsXor([NotNull] VisualBasic6Parser.VsXorContext context) { }
		
		public override void EnterVsAnd([NotNull] VisualBasic6Parser.VsAndContext context) { }
		
		public override void ExitVsAnd([NotNull] VisualBasic6Parser.VsAndContext context) { }
		
		public override void EnterVsPow([NotNull] VisualBasic6Parser.VsPowContext context) { }
		
		public override void ExitVsPow([NotNull] VisualBasic6Parser.VsPowContext context) { }
		
		public override void EnterVsLeq([NotNull] VisualBasic6Parser.VsLeqContext context) { }
		
		public override void ExitVsLeq([NotNull] VisualBasic6Parser.VsLeqContext context) { }
		
		public override void EnterVsIs([NotNull] VisualBasic6Parser.VsIsContext context) { }
		
		public override void ExitVsIs([NotNull] VisualBasic6Parser.VsIsContext context) { }
		
		public override void EnterVsMod([NotNull] VisualBasic6Parser.VsModContext context) { }
		
		public override void ExitVsMod([NotNull] VisualBasic6Parser.VsModContext context) { }
		
		public override void EnterVsAmp([NotNull] VisualBasic6Parser.VsAmpContext context) { }
		
		public override void ExitVsAmp([NotNull] VisualBasic6Parser.VsAmpContext context) { }
		
		public override void EnterVsOr([NotNull] VisualBasic6Parser.VsOrContext context) { }
		
		public override void ExitVsOr([NotNull] VisualBasic6Parser.VsOrContext context) { }
		
		public override void EnterVsMinus([NotNull] VisualBasic6Parser.VsMinusContext context) { }

		public override void ExitVsMinus([NotNull] VisualBasic6Parser.VsMinusContext context) { }

		public override void EnterVsLiteral([NotNull] VisualBasic6Parser.VsLiteralContext context) { }

		public override void ExitVsLiteral([NotNull] VisualBasic6Parser.VsLiteralContext context) { }

		public override void EnterVsEqv([NotNull] VisualBasic6Parser.VsEqvContext context) { }

		public override void ExitVsEqv([NotNull] VisualBasic6Parser.VsEqvContext context) { }

		public override void EnterVsImp([NotNull] VisualBasic6Parser.VsImpContext context) { }

		public override void ExitVsImp([NotNull] VisualBasic6Parser.VsImpContext context) { }

		public override void EnterVsGt([NotNull] VisualBasic6Parser.VsGtContext context) { }

		public override void ExitVsGt([NotNull] VisualBasic6Parser.VsGtContext context) { }

		public override void EnterVsEq([NotNull] VisualBasic6Parser.VsEqContext context) { }

		public override void ExitVsEq([NotNull] VisualBasic6Parser.VsEqContext context) { }

		public override void EnterVsMid([NotNull] VisualBasic6Parser.VsMidContext context) { }

		public override void ExitVsMid([NotNull] VisualBasic6Parser.VsMidContext context) { }

		public override void EnterVariableStmt([NotNull] VisualBasic6Parser.VariableStmtContext context) { }

		public override void ExitVariableStmt([NotNull] VisualBasic6Parser.VariableStmtContext context) { }

		public override void EnterVariableListStmt([NotNull] VisualBasic6Parser.VariableListStmtContext context) { }

		public override void ExitVariableListStmt([NotNull] VisualBasic6Parser.VariableListStmtContext context) { }

		public override void EnterVariableSubStmt([NotNull] VisualBasic6Parser.VariableSubStmtContext context) { }

		public override void ExitVariableSubStmt([NotNull] VisualBasic6Parser.VariableSubStmtContext context) { }

		public override void EnterWhileWendStmt([NotNull] VisualBasic6Parser.WhileWendStmtContext context) { }

		public override void ExitWhileWendStmt([NotNull] VisualBasic6Parser.WhileWendStmtContext context) { }

		public override void EnterWidthStmt([NotNull] VisualBasic6Parser.WidthStmtContext context) { }

		public override void ExitWidthStmt([NotNull] VisualBasic6Parser.WidthStmtContext context) { }

		public override void EnterWithStmt([NotNull] VisualBasic6Parser.WithStmtContext context) { }

		public override void ExitWithStmt([NotNull] VisualBasic6Parser.WithStmtContext context) { }

		public override void EnterWriteStmt([NotNull] VisualBasic6Parser.WriteStmtContext context) { }

		public override void ExitWriteStmt([NotNull] VisualBasic6Parser.WriteStmtContext context) { }

		public override void EnterExplicitCallStmt([NotNull] VisualBasic6Parser.ExplicitCallStmtContext context) { }

		public override void ExitExplicitCallStmt([NotNull] VisualBasic6Parser.ExplicitCallStmtContext context) { }

		public override void EnterECS_ProcedureCall([NotNull] VisualBasic6Parser.ECS_ProcedureCallContext context) { }

		public override void ExitECS_ProcedureCall([NotNull] VisualBasic6Parser.ECS_ProcedureCallContext context) { }

		public override void EnterECS_MemberProcedureCall([NotNull] VisualBasic6Parser.ECS_MemberProcedureCallContext context) { }

		public override void ExitECS_MemberProcedureCall([NotNull] VisualBasic6Parser.ECS_MemberProcedureCallContext context) { }

		public override void EnterImplicitCallStmt_InBlock([NotNull] VisualBasic6Parser.ImplicitCallStmt_InBlockContext context) { }

		public override void ExitImplicitCallStmt_InBlock([NotNull] VisualBasic6Parser.ImplicitCallStmt_InBlockContext context) { }

		public override void EnterICS_B_ProcedureCall([NotNull] VisualBasic6Parser.ICS_B_ProcedureCallContext context) { }

		public override void ExitICS_B_ProcedureCall([NotNull] VisualBasic6Parser.ICS_B_ProcedureCallContext context) { }

		public override void EnterICS_B_MemberProcedureCall([NotNull] VisualBasic6Parser.ICS_B_MemberProcedureCallContext context) { }

		public override void ExitICS_B_MemberProcedureCall([NotNull] VisualBasic6Parser.ICS_B_MemberProcedureCallContext context) { }

		public override void EnterImplicitCallStmt_InStmt([NotNull] VisualBasic6Parser.ImplicitCallStmt_InStmtContext context) { }

		public override void ExitImplicitCallStmt_InStmt([NotNull] VisualBasic6Parser.ImplicitCallStmt_InStmtContext context) { }

		public override void EnterICS_S_VariableOrProcedureCall([NotNull] VisualBasic6Parser.ICS_S_VariableOrProcedureCallContext context) { }

		public override void ExitICS_S_VariableOrProcedureCall([NotNull] VisualBasic6Parser.ICS_S_VariableOrProcedureCallContext context) { }

		public override void EnterICS_S_ProcedureOrArrayCall([NotNull] VisualBasic6Parser.ICS_S_ProcedureOrArrayCallContext context) { }

		public override void ExitICS_S_ProcedureOrArrayCall([NotNull] VisualBasic6Parser.ICS_S_ProcedureOrArrayCallContext context) { }

		public override void EnterICS_S_NestedProcedureCall([NotNull] VisualBasic6Parser.ICS_S_NestedProcedureCallContext context) { }

		public override void ExitICS_S_NestedProcedureCall([NotNull] VisualBasic6Parser.ICS_S_NestedProcedureCallContext context) { }

		public override void EnterICS_S_MembersCall([NotNull] VisualBasic6Parser.ICS_S_MembersCallContext context) { }

		public override void ExitICS_S_MembersCall([NotNull] VisualBasic6Parser.ICS_S_MembersCallContext context) { }

		public override void EnterICS_S_MemberCall([NotNull] VisualBasic6Parser.ICS_S_MemberCallContext context) { }

		public override void ExitICS_S_MemberCall([NotNull] VisualBasic6Parser.ICS_S_MemberCallContext context) { }

		public override void EnterICS_S_DictionaryCall([NotNull] VisualBasic6Parser.ICS_S_DictionaryCallContext context) { }

		public override void ExitICS_S_DictionaryCall([NotNull] VisualBasic6Parser.ICS_S_DictionaryCallContext context) { }

		public override void EnterArgsCall([NotNull] VisualBasic6Parser.ArgsCallContext context) { }

		public override void ExitArgsCall([NotNull] VisualBasic6Parser.ArgsCallContext context) { }

		public override void EnterArgCall([NotNull] VisualBasic6Parser.ArgCallContext context) { }

		public override void ExitArgCall([NotNull] VisualBasic6Parser.ArgCallContext context) { }

		public override void EnterDictionaryCallStmt([NotNull] VisualBasic6Parser.DictionaryCallStmtContext context) { }

		public override void ExitDictionaryCallStmt([NotNull] VisualBasic6Parser.DictionaryCallStmtContext context) { }

		public override void EnterArgList([NotNull] VisualBasic6Parser.ArgListContext context) { }

		public override void ExitArgList([NotNull] VisualBasic6Parser.ArgListContext context) { }

		public override void EnterArg([NotNull] VisualBasic6Parser.ArgContext context) { }

		public override void ExitArg([NotNull] VisualBasic6Parser.ArgContext context) { }

		public override void EnterArgDefaultValue([NotNull] VisualBasic6Parser.ArgDefaultValueContext context) { }

		public override void ExitArgDefaultValue([NotNull] VisualBasic6Parser.ArgDefaultValueContext context) { }

		public override void EnterSubscripts([NotNull] VisualBasic6Parser.SubscriptsContext context) { }

		public override void ExitSubscripts([NotNull] VisualBasic6Parser.SubscriptsContext context) { }

		public override void EnterSubscript([NotNull] VisualBasic6Parser.SubscriptContext context) { }

		public override void ExitSubscript([NotNull] VisualBasic6Parser.SubscriptContext context) { }

		public override void EnterAmbiguousIdentifier([NotNull] VisualBasic6Parser.AmbiguousIdentifierContext context) { }

		public override void ExitAmbiguousIdentifier([NotNull] VisualBasic6Parser.AmbiguousIdentifierContext context) { }

		public override void EnterAsTypeClause([NotNull] VisualBasic6Parser.AsTypeClauseContext context) { }

		public override void ExitAsTypeClause([NotNull] VisualBasic6Parser.AsTypeClauseContext context) { }

		public override void EnterBaseType([NotNull] VisualBasic6Parser.BaseTypeContext context) { }

		public override void ExitBaseType([NotNull] VisualBasic6Parser.BaseTypeContext context) { }

		public override void EnterCertainIdentifier([NotNull] VisualBasic6Parser.CertainIdentifierContext context) { }

		public override void ExitCertainIdentifier([NotNull] VisualBasic6Parser.CertainIdentifierContext context) { }

		public override void EnterComparisonOperator([NotNull] VisualBasic6Parser.ComparisonOperatorContext context) { }

		public override void ExitComparisonOperator([NotNull] VisualBasic6Parser.ComparisonOperatorContext context) { }

		public override void EnterComplexType([NotNull] VisualBasic6Parser.ComplexTypeContext context) { }

		public override void ExitComplexType([NotNull] VisualBasic6Parser.ComplexTypeContext context) { }

		public override void EnterFieldLength([NotNull] VisualBasic6Parser.FieldLengthContext context) { }

		public override void ExitFieldLength([NotNull] VisualBasic6Parser.FieldLengthContext context) { }

		public override void EnterLetterrange([NotNull] VisualBasic6Parser.LetterrangeContext context) { }

		public override void ExitLetterrange([NotNull] VisualBasic6Parser.LetterrangeContext context) { }

		public override void EnterLineLabel([NotNull] VisualBasic6Parser.LineLabelContext context) { }

		public override void ExitLineLabel([NotNull] VisualBasic6Parser.LineLabelContext context) { }

		public override void EnterLiteral([NotNull] VisualBasic6Parser.LiteralContext context) { }

		public override void ExitLiteral([NotNull] VisualBasic6Parser.LiteralContext context) { }

		public override void EnterPublicPrivateVisibility([NotNull] VisualBasic6Parser.PublicPrivateVisibilityContext context) { }

		public override void ExitPublicPrivateVisibility([NotNull] VisualBasic6Parser.PublicPrivateVisibilityContext context) { }

		public override void EnterPublicPrivateGlobalVisibility([NotNull] VisualBasic6Parser.PublicPrivateGlobalVisibilityContext context) { }

		public override void ExitPublicPrivateGlobalVisibility([NotNull] VisualBasic6Parser.PublicPrivateGlobalVisibilityContext context) { }

		public override void EnterType([NotNull] VisualBasic6Parser.TypeContext context) { }

		public override void ExitType([NotNull] VisualBasic6Parser.TypeContext context) { }

		public override void EnterTypeHint([NotNull] VisualBasic6Parser.TypeHintContext context) { }

		public override void ExitTypeHint([NotNull] VisualBasic6Parser.TypeHintContext context) { }

		public override void EnterVisibility([NotNull] VisualBasic6Parser.VisibilityContext context) { }

		public override void ExitVisibility([NotNull] VisualBasic6Parser.VisibilityContext context) { }

		public override void EnterAmbiguousKeyword([NotNull] VisualBasic6Parser.AmbiguousKeywordContext context) { }
		
		public override void ExitAmbiguousKeyword([NotNull] VisualBasic6Parser.AmbiguousKeywordContext context) { }
		
		public override void EnterEveryRule([NotNull] ParserRuleContext context) { }
		
		public override void ExitEveryRule([NotNull] ParserRuleContext context) { }
		
		public override void VisitTerminal([NotNull] ITerminalNode node) { }
		
		public override void VisitErrorNode([NotNull] IErrorNode node) { }
	}
}