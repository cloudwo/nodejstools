﻿/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation. 
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the Apache License, Version 2.0, please send an email to 
 * vspython@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

// Guids.cs
// MUST match guids.h
using System;

namespace Microsoft.NodejsTools
{
    static class GuidList
    {
        public const string guidNodePkgString = "4219f2a8-fbf9-4659-a222-b7580a60eebb";
        public const string guidNodeCmdSetString = "695e37e2-c6df-4e0a-8833-f688e4c65f1f";
        public const string guidNodeEditorFactoryString = "88941496-93F4-4E37-83AF-AFE087415334";
        public const string guidNodeEditorFactoryStringPromptEncoding = "C8576E92-EFB6-4414-8F63-C84D474A539E";
        public const string guidNodejsLanguageInfo = "ABD5E8A5-5A35-4BE9-BCAF-E10C1212CB40";
        public const string guidNodejsDebugLanguageStr = "{65791609-BA29-49CF-A214-DBFF8AEC3BC2}";

        public static readonly Guid guidNodeCmdSet = new Guid(guidNodeCmdSetString);
        public static readonly Guid guidNodeEditorFactory = new Guid(guidNodeEditorFactoryString);

        public static readonly Guid guidVenusCmdId = new Guid("c7547851-4e3a-4e5b-9173-fa6e9c8bd82c");
        public static readonly Guid guidEureka = new Guid("30947ebe-9147-45f9-96cf-401bfc671a82");  //  Microsoft.VisualStudio.Web.Eureka.dll package, includes page inspector
        public static readonly Guid guidWebPackgeCmdId = new Guid("822e3603-e573-47d2-acf0-520e4ce641c2");
        public static readonly Guid guidWebPackageGuid = new Guid("d9a342d1-a429-4059-808a-e55ee6351f7f");
        public static readonly Guid guidWebAppCmdId = new Guid("CB26E292-901A-419c-B79D-49BD45C43929");
        public static readonly Guid guidNodejsDebugLanguage = new Guid(guidNodejsDebugLanguageStr);
    };
}