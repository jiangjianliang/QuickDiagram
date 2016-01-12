﻿using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace Codartis.SoftVis.UI.Wpf.View
{
    partial class DiagramViewportControl
    {
        public double MinZoom
        {
            get { return (double)GetValue(MinZoomProperty); }
            set { SetValue(MinZoomProperty, value); }
        }

        public double MaxZoom
        {
            get { return (double)GetValue(MaxZoomProperty); }
            set { SetValue(MaxZoomProperty, value); }
        }

        public double LargeZoomIncrement
        {
            get { return (double)GetValue(LargeZoomIncrementProperty); }
            set { SetValue(LargeZoomIncrementProperty, value); }
        }

        public double ExponentialZoom
        {
            get { return (double)GetValue(ExponentialZoomProperty); }
            set { SetValue(ExponentialZoomProperty, value); }
        }

        public double LinearZoom
        {
            get { return (double)GetValue(LinearZoomProperty); }
            set { SetValue(LinearZoomProperty, value); }
        }

        public double ViewportCenterX
        {
            get { return (double)GetValue(ViewportCenterXProperty); }
            set { SetValue(ViewportCenterXProperty, value); }
        }

        public double ViewportCenterY
        {
            get { return (double)GetValue(ViewportCenterYProperty); }
            set { SetValue(ViewportCenterYProperty, value); }
        }

        public Transform ViewportTransform
        {
            get { return (Transform)GetValue(ViewportTransformProperty); }
            set { SetValue(ViewportTransformProperty, value); }
        }

        public Rect DiagramContentRect
        {
            get { return (Rect)GetValue(DiagramContentRectProperty); }
            set { SetValue(DiagramContentRectProperty, value); }
        }

        public ICommand WidgetPanCommand
        {
            get { return (ICommand)GetValue(WidgetPanCommandProperty); }
            set { SetValue(WidgetPanCommandProperty, value); }
        }

        public ICommand FitToViewCommand
        {
            get { return (ICommand)GetValue(FitToViewCommandProperty); }
            set { SetValue(FitToViewCommandProperty, value); }
        }

        public ICommand MousePanCommand
        {
            get { return (ICommand)GetValue(MousePanCommandProperty); }
            set { SetValue(MousePanCommandProperty, value); }
        }

        public ICommand MouseZoomCommand
        {
            get { return (ICommand)GetValue(MouseZoomCommandProperty); }
            set { SetValue(MouseZoomCommandProperty, value); }
        }

        public ICommand KeyboardPanCommand
        {
            get { return (ICommand)GetValue(KeyboardPanCommandProperty); }
            set { SetValue(KeyboardPanCommandProperty, value); }
        }

        public ICommand KeyboardZoomCommand
        {
            get { return (ICommand)GetValue(KeyboardZoomCommandProperty); }
            set { SetValue(KeyboardZoomCommandProperty, value); }
        }

    }
}