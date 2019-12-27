﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using System.Text;
using SuperMap.Desktop ;
using SuperMap.Data;
using SuperMap.Mapping;


namespace SuperMap.Desktop.LayerControl
{
    class _CtrlActionLayerControl:CtrlAction 
    {  
        public _CtrlActionLayerControl(IBaseItem caller)
            :base (caller)
        {
        
        }
        //public TrackingLayer m_trackinglayer;
        //当当前地图窗口中不存在任何图层时，定位到按钮不可用

        //public override bool Enable()
        //{
        //    Boolean enable = false;
        //    try
        //    {
        //        //获取当前活动的地图窗口

        //        IFormMap mapwindow = FormClass as IFormMap;
        //        if (mapwindow.MapControl.Map.Layers.Count > 0)
        //        {
        //            enable = true;
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);

        //    }
        //    return enable;
        //}
        //触发定位到按钮，执行弹出定位到的窗口
        public override void Run()
        {
            try
            {
                _frmLayerControl frmLayerControl = new _frmLayerControl();
                frmLayerControl.Show();
            }
            catch (System.Exception ex)
            {
                SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

    }
}
