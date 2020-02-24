﻿using ReactNative.Modules.Core;
using System;
using System.Collections.Generic;
using ReactNative.Bridge;
using Microsoft.ReactNative.Managed;

namespace ReactNativeSVG
{
    public class SVGReactPackage : IReactPackage
    {
        public IReadOnlyList<INativeModule> CreateNativeModules(ReactContext reactContext)
        {
            return new List<INativeModule>(0);
        }

        public IReadOnlyList<Type> CreateJavaScriptModulesConfig()
        {
            return new List<Type>(0);
        }

        public IReadOnlyList<IViewManager> CreateViewManagers(
            ReactContext reactContext)
        {
            return new List<IViewManager> {
                new ReactSVGManager(),
                new ReactGroupManager(),
                new ReactRectManager(),
                new ReactLineManager(),
                new ReactCircleManager(),
                new ReactEllipseManager(),
                new ReactPathManager(),
                new ReactPolygonManager(),
                new ReactPolylineManager(),
            };
        }
    }
}
