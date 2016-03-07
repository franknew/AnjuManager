using SOAFramework.Client.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Anju.Fangke.Client.SDK;
using SOAFramework.Service.SDK.Core;
using MetroFramework.Controls;

namespace Anju.Fangke.Client.Forms
{
    public partial class AssetManagement : ChildForm
    {
        public AssetManagement()
        {
            InitializeComponent();
        }

        private TreeNode _selectedNode = null;

        private void tvBuilding_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void tvBuilding_Add(object sender, EventArgs e)
        {
            ContainerForm container = this.MdiParent as ContainerForm;
            AddBuilding form = new AddBuilding();
            form.SaveClickCallBack += AddSave_Callback;
            form.Token = this.Token;
            form.ShowDialog(this);
        }

        private void AddSave_Callback(object sender, EventArgs e)
        {
            AddBuilding form = sender as AddBuilding;
            if (form.Building == null) return;
            tvBuilding.TopNode.Nodes.Add(new TreeNode { Name = form.Building.ID, Text = form.Building.Name, Tag = form.Building });
        }

        private void EditSave_Callback(object sender, EventArgs e)
        {
            EditBuilding form = sender as EditBuilding;
            if (form.Building == null) return;
            _selectedNode.Tag = form.Building;
            _selectedNode.Text = form.Building.Name;
            tvBuilding_AfterSelect(sender, new TreeViewEventArgs(_selectedNode));
        }

        private void tvBuilding_Edit(object sender, EventArgs e)
        {
            EditBuilding form = new EditBuilding();
            form.SaveClickCallBack += EditSave_Callback;
            form.Building = _selectedNode.Tag as Building;
            form.Token = this.Token;
            form.ShowDialog(this);
        }

        private void tvBuilding_Delete(object sender, EventArgs e)
        {
            if (_selectedNode == null || _selectedNode.Tag == null) return;
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除该楼盘？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            Building building = _selectedNode.Tag as Building;
            DeleteBuildingRequest request = new DeleteBuildingRequest();
            request.token = this.Token;
            request.form = new BuildingQueryForm
            {
                ID = building.ID,
            };
            var response = SDKFactory.Client.Execute(request);
            if (response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, response.ResponseBody);
                return;
            }
            tvBuilding.TopNode.Nodes.Remove(_selectedNode);
            _selectedNode = null;
        }

        private void tvBuilding_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            tvBuilding.ContextMenu = new ContextMenu();
            MenuItem additem = new MenuItem("新增楼盘", tvBuilding_Add);
            tvBuilding.ContextMenu.MenuItems.Add(additem);
            if (e.Node != null && e.Node.Name != "nodeRoot")
            {
                _selectedNode = e.Node;
                MenuItem eidtitem = new MenuItem("编辑楼盘", tvBuilding_Edit);
                MenuItem deleteitem = new MenuItem("删除楼盘", tvBuilding_Delete);
                tvBuilding.ContextMenu.MenuItems.Add(eidtitem);
                tvBuilding.ContextMenu.MenuItems.Add(deleteitem);
            }
        }

        private void AssetManagement_Load(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.token = this.Token;
            request.form = new BuildingQueryForm();
            var response = SDKFactory.Client.Execute(request);
            if (response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, response.ResponseBody);
                return;
            }
            foreach (var buiding in response.List)
            {
                TreeNode node = new TreeNode
                {
                    Name = buiding.ID,
                    Text = buiding.Name,
                    Tag = buiding,
                };
                tvBuilding.TopNode.Nodes.Add(node);
            }
            tvBuilding.TopNode.ExpandAll();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void tvBuilding_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;
            Building building = e.Node.Tag as Building;
            tabFloor.TabPages.Clear();
            tabFloor.SelectedIndexChanged -= tabFloor_SelectedIndexChanged;
            for (int i = 0; i < building.FloorCount; i++)
            {
                int floor = i + 1;
                MetroTabPage page = new MetroTabPage();
                page.Text = string.Format("第{0}层", floor);
                page.Name = string.Format("pageFloor" + floor);
                page.Tag = floor;
                tabFloor.TabPages.Add(page);
            }
            tabFloor.SelectedIndexChanged += tabFloor_SelectedIndexChanged;
            if (tabFloor.TabPages.Count > 0)
            {
                tabFloor.TabPages[0].Select();
            }
            groupBox3.Text = building.Name;
        }

        private void tabFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tvBuilding.SelectedNode.Tag == null || tabFloor.SelectedTab == null) return;
            Building building = tvBuilding.SelectedNode.Tag as Building;
            QueryHouseRequest request = new QueryHouseRequest();
            request.token = this.Token;
            request.form = new HouseQueryForm
            {
                BuildingID = building.ID,
                Floor = (int)tabFloor.SelectedTab.Tag,
                
            };
            var response = SDKFactory.Client.Execute(request);
            if (response.IsError)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, response.ResponseBody);
                return;
            }
            dgvHouse.DataSource = response.List;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHouse.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选中一条数据！");
                return;
            }
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除该房间？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddHouse form = new AddHouse();
            form.Token = this.Token;

            form.ShowDialog(this);
        }
    }
}
