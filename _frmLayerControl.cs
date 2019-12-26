using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using SuperMap.Desktop;
using SuperMap.Mapping;
using SuperMap.Data;
using SuperMap.UI;

namespace SuperMap.Desktop.LayerControl
{
    public partial class _frmLayerControl : Form
    {

        public _frmLayerControl()
        {
            InitializeComponent();
        }

        //判断是layer还是layergroup，并进行相应操作
        private void LayerC(LayerGroup layerg,int layernum)
        {
            try
            {
                for (int i = 0; i < layernum; i++)
                {
                    if (layerg[i] is LayerGroup)
                    {
                        LayerGroup layer1 = layerg[i] as LayerGroup;
                        int layernum1 = layer1.Count;
                        LayerC(layer1,layernum1);
                    }
                    else
                    {
                        Layer layer1 = layerg[i];
                        QueryParameter queryParameter = new QueryParameter();

                        if (txtX.Text.Length == 0)
                        {
                            MessageBox.Show("过滤条件不能为空");
                            return;
                        }
                        else
                        {
                            queryParameter.AttributeFilter = txtX.Text;
                            layer1.DisplayFilter = queryParameter;
                        }
                    }
                }
            }
            catch (System.Exception ex)
            {
                SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }

        private void btnLayerControl_Click(object sender, EventArgs e)
        {
            try
            {                
                //获取当前活动的地图窗口
                IFormMap formMap = SuperMap.Desktop.Application.ActiveApplication.MainForm.FormManager.ActiveForm as IFormMap;

                int nlayerCount = formMap.MapControl.Map.Layers.Count;

                for (int j = 0; j < nlayerCount; j++)
                {
                    if (formMap.MapControl.Map.Layers[j] is LayerGroup)
                    {
                        LayerGroup layerg = formMap.MapControl.Map.Layers[j] as LayerGroup;
                        int layernum = layerg.Count;
                        LayerC(layerg,layernum);
                    }
                    else
                    {
                        Layer layer = formMap.MapControl.Map.Layers[j];
                        //设置图层过滤条件
                        QueryParameter queryParameter = new QueryParameter();

                        if (txtX.Text.Length == 0)
                        {
                            MessageBox.Show("过滤条件不能为空");
                            return;
                        }
                        else
                        {
                            queryParameter.AttributeFilter = txtX.Text;
                            layer.DisplayFilter = queryParameter;
                        }
                    }
                }   
                formMap.MapControl.Map.Refresh();
                formMap.MapControl.Refresh();
                this.Close();
            }
            catch (System.Exception ex)
            {
                SuperMap.Desktop.Application.ActiveApplication.Output.Output(ex.StackTrace);
            }
        }
    }
}
