using Newtonsoft.Json.Linq;
using ReactNative.UIManager;
using ReactNative.UIManager.Annotations;
using System;
using System.Collections.Generic;
using Windows.Foundation;
using Windows.UI;
#if WINDOWS_UWP
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;
#else
using System.Windows;
#endif

namespace ReactNativeSVG
{
    public abstract class ShapeViewManager<TFrameworkElement, TLayoutShadowNode> : BaseViewManager<TFrameworkElement, TLayoutShadowNode>
        where TFrameworkElement : Shape
        where TLayoutShadowNode : LayoutShadowNode
    {
        [ViewManagerProperty("stroke", CustomType = "Color", DefaultUInt32 = 0xff000000)]
        public void SetStroke(Shape view, uint? iColor)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeProperty, iColor);
            UpdateShape(view, viewModel, "stroke");
        }

        [ViewManagerProperty("strokeWidth", DefaultDouble = 1f)]
        public void SetStrokeWidth(Shape view,double thickness)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeThicknessProperty, thickness);
            UpdateShape(view, viewModel, "strokeWidth");
        }

        [ViewManagerProperty("strokeOpacity", DefaultDouble = 1f)]
        public void SetStrokeOpacity(Shape view, double strokeOpacity)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeOpacityProperty, strokeOpacity);
            UpdateShape(view, viewModel, "strokeOpacity");
        }

        [ViewManagerProperty("strokeLinecap")]
        public void SetStrokeLinecap(Shape view, string strokeLinecap)
        {
            List<string> strokeLinecapArray = new List<string>(){ "butt", "square", "round" };
            int iStrokeLinecap = strokeLinecapArray.IndexOf(strokeLinecap);
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeLinecapProperty, iStrokeLinecap);
            UpdateShape(view, viewModel, "strokeLinecap");
        }

        [ViewManagerProperty("strokeLinejoin")]
        public void SetStrokeLinejoin(Shape view, string strokeLinejoin)
        {
            List<string> strokeLinejoinArray = new List<string>() { "miter", "bevel", "round" };
            int iStrokeLinejoin = strokeLinejoinArray.IndexOf(strokeLinejoin);
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeLinejoinProperty, iStrokeLinejoin);
            UpdateShape(view, viewModel, "strokeLinejoin");
        }

        [ViewManagerProperty("strokeDasharray")]
        public void setStrokeDasharray(Shape view, JArray strokeDasharray)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeDashArrayProperty, strokeDasharray);
            UpdateShape(view, viewModel, "strokeDasharray");
        }

        [ViewManagerProperty("strokeDashoffset", DefaultDouble = 0f)]
        public void setStrokeDashoffset(Shape view, double strokeDashOffset)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeDashOffsetProperty, strokeDashOffset);
            UpdateShape(view, viewModel, "strokeDashoffset");
        }


        [ViewManagerProperty("strokeMiterlimit", DefaultDouble = 0f)]
        public void setStrokeMiterlimit(Shape view, double strokeMiterlimit)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.StrokeMiterlimitProperty, strokeMiterlimit);
            UpdateShape(view, viewModel, "strokeMiterlimit");
        }

        [ViewManagerProperty("fill", CustomType = "Color")]
        public void SetFill(Shape view, uint? iColor)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.FillProperty, iColor);
            UpdateShape(view, viewModel, "fill");
        }

        [ViewManagerProperty("fillOpacity", DefaultDouble = 1f)]
        public void SetFillOpacity(Shape view, double fillOpacity)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.FillOpacityProperty, fillOpacity);
            UpdateShape(view, viewModel, "fillOpacity");
        }

        [ViewManagerProperty("scale", DefaultDouble = 1f)]
        public void SetScale(Shape view, double scale)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.ScaleProperty, scale);
            UpdateShape(view, viewModel, "scale");
        }

        [ViewManagerProperty("rotate", DefaultDouble = 0f)]
        public void SetRotate(Shape view, double rotate)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.RotateProperty, rotate);
            UpdateShape(view, viewModel, "rotate");
        }

        [ViewManagerProperty("originX", DefaultDouble = 0f)]
        public void SetOriginX(Shape view, double originX)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            Point origin = viewModel.Origin;
            origin.X = originX;
            viewModel.SetValue(ShapeViewModel.OriginProperty, origin);
            UpdateShape(view, viewModel, "originX");
        }

        [ViewManagerProperty("originY", DefaultDouble = 0f)]
        public void SetOriginY(Shape view, double originY)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            Point origin = viewModel.Origin;
            origin.Y = originY;
            viewModel.SetValue(ShapeViewModel.OriginProperty, origin);
            UpdateShape(view, viewModel, "originY");
        }

        [ViewManagerProperty("origin", CustomType = "Point")]
        public void SetOriginY(Shape view, Point origin)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.OriginProperty, origin);
            UpdateShape(view, viewModel, "origin");
        }

        [ViewManagerProperty("x", DefaultDouble = 0f)]
        public void SetX(Shape view, double x)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.XProperty, x);
            UpdateShape(view, viewModel, "x");
        }

        [ViewManagerProperty("y", DefaultDouble = 0f)]
        public void SetY(Shape view, double y)
        {
            ShapeViewModel viewModel = (ShapeViewModel)view.DataContext;
            viewModel.SetValue(ShapeViewModel.YProperty, y);
            UpdateShape(view, viewModel,"y");
        }

        private void UpdateShape(Shape view, ShapeViewModel viewModel, string updateKey)
        {
            ShapeViewModel.UpdateShape(view, viewModel, updateKey);
        }

        /// <summary>
        /// Sets the dimensions of the view.
        /// </summary>
        /// <param name="view">The view.</param>
        /// <param name="dimensions">The output buffer.</param>
        public void SetDimensions(Shape view, Dimensions dimensions)
        {
            // do nothing
        }
    }
}
