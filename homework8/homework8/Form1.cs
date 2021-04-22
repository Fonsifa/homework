using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace homework8
{
    public partial class Form1 : Form
    {
        private ordertest.OrderService service=new ordertest.OrderService();
        private string Query_Way;
        private string message;
        public Form1()
        {
            InitializeComponent();
            //messagetextBox.DataBindings.Add("Text", this, message);
        }

        private void 创建订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.service = service;
            form2.Show();
            service = form2.service;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) => Query_Way = querywaycomboBox.Text;
        // 按ID查询// 按客户查询//按数量查询//按商品查询//查询全部


        private void querybutton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(this.message);
            switch (Query_Way)
            {
                case "按ID查询":this.orderbindingSource.DataSource = service.GetById(Convert.ToInt32(message));
                    if (service.GetById(Convert.ToInt32(message)) != null) this.detailbindingSource.DataSource = service.GetById(Convert.ToInt32(message)).Details;
                    else this.detailbindingSource.DataSource = null; break;
                case "按客户查询":this.orderbindingSource.DataSource = service.QueryByCustomerName(message);break;
                case "按数量查询":this.orderbindingSource.DataSource = service.QueryByTotalAmount(Convert.ToDouble(message));break;
                case "按商品查询":this.orderbindingSource.DataSource = service.QueryByGoodsName(message);break;
                case "查询全部":this.orderbindingSource.DataSource = service.QueryAll();break;
                default:break;
            }
            if (Query_Way != "按ID查询")
            {
                List<ordertest.Order> o = (List<ordertest.Order>)orderbindingSource.DataSource;
                List<ordertest.OrderDetail> de = new List<ordertest.OrderDetail>();

                if (o != null)
                {
                    foreach (var i in o)
                    {
                        List<ordertest.OrderDetail> p = i.Details;
                        foreach (var j in p)
                            de.Add(j);
                    }
                    detailbindingSource.DataSource = de;
                }
            }
        }

        private void 删除订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.service = service;
            form2.Show();
            service = form2.service;
        }

        private void 修改订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改订单 form2 = new 修改订单();
            form2.service = service;
            form2.Show();
            service = form2.service;
        }

        private void messagetextBox_TextChanged(object sender, EventArgs e)
        {
            message = messagetextBox.Text;
        }

        private void 导入订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xml*)|*.xml*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string file = fileDialog.FileName;//返回文件的完整路径            
                try
                {
                    service.Import(file);
                    MessageBox.Show("已导入");
                }
                catch
                {
                    throw new Exception("导入错误");
                }
            }
        }

        private void 导出订单ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);

                //theFolder 包含文件路径

                try
                {
                    string path = @theFolder.FullName + "\\order.xml";
                    Console.WriteLine(path);
                    if (service.orderList != null)
                        service.Export(path);
                    else Console.WriteLine("empty");
                    MessageBox.Show("导出成功");
                }
                catch
                {
                    throw new Exception("导出错误");
                }
            }
        }
    }
}
