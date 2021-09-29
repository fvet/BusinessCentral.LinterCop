﻿using Microsoft.Dynamics.Nav.CodeAnalysis.Diagnostics;
using System;

namespace BusinessCentral.LinterCop
{
  public static class DiagnosticDescriptors
    {
        public static readonly DiagnosticDescriptor Rule0001FlowFieldsShouldNotBeEditable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0001", (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditable", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0001FlowFieldsShouldNotBeEditableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0002CommitMustBeExplainedByComment = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0002", (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByComment", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0002CommitMustBeExplainedByCommentDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0003DoNotUseObjectIDsInVariablesOrProperties = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0003", (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrProperties", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0003DoNotUseObjectIDsInVariablesOrPropertiesDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0004LookupPageIdAndDrillDownPageId = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0004", (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0004LookupPageIdAndDrillDownPageIdDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0005VariableCasingShouldNotDIfferFromDeclaration = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0005", (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0005VariableCasingShouldNotDIfferFromDeclarationDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0006FieldNotAutoIncrementInTemporaryTable = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0006", (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Error, true, (LocalizableString)new LocalizableResourceString("Rule0006FieldNotAutoIncrementInTemporaryTableDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0007DataPerCompanyShouldAlwaysBeSet = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0007", (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Hidden, false, (LocalizableString)new LocalizableResourceString("Rule0007DataPerCompanyShouldAlwaysBeSetDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0008NoFilterOperatorsInSetRange = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0008", (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Warning, true, (LocalizableString)new LocalizableResourceString("Rule0008NoFilterOperatorsInSetRangeDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
        public static readonly DiagnosticDescriptor Rule0009CodeMetricsInfo = new DiagnosticDescriptor(LinterCopAnalyzers.AnalyzerPrefix + "0009", (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoTitle", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoFormat", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), "Design", DiagnosticSeverity.Info, false, (LocalizableString)new LocalizableResourceString("Rule0009CodeMetricsInfoDescription", LinterCopAnalyzers.ResourceManager, typeof(LinterCopAnalyzers)), (string)null, Array.Empty<string>());
    }
}
