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
using SOAFramework.Client.Controls;
using SOAFramework.Library;

namespace Anju.Fangke.Client.Forms
{
    public partial class AssetManagement : ChildForm
    {
        public AssetManagement()
        {
            InitializeComponent();
            tabFloor.SelectedIndexChanged += tabFloor_SelectedIndexChanged;
            tvBuilding.AfterSelect += tvBuilding_AfterSelect;
            this.Shown += AssetManagement_Shown;
        }

        private TreeNode _selectedNode = null;
        private int _currentFloor = 1;
        private List<FullBuilding> _buildings = null;

        private void AssetManagement_Shown(object sender, EventArgs e)
        {
            QueryBuildingRequest request = new QueryBuildingRequest();
            request.token = this.Token;
            request.form = new BuildingQueryForm();
            var response = SDKSync<QueryBuildingResponse>.CreateInstance(this).Execute(request, FormShown_Callback);
        }

        private void FormShown_Callback(QueryBuildingResponse response)
        {
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
            _buildings = response.List;
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
            FullBuilding building = sender as FullBuilding;
            if (building == null) return;
            tvBuilding.TopNode.Nodes.Add(new TreeNode { Name = building.ID, Text = building.Name, Tag = building });
            _buildings.Add(building);
        }

        private void EditSave_Callback(object sender, EventArgs e)
        {
            FullBuilding building = sender as FullBuilding;
            if (building == null) return;
            _selectedNode.Tag = building;
            _selectedNode.Text = building.Name;
            var tmp = _buildings.Find(t => t.ID.Equals(building.ID));
            if (tmp != null) tmp = building;
            tvBuilding_AfterSelect(sender, new TreeViewEventArgs(_selectedNode));
        }

        private void tvBuilding_Edit(object sender, EventArgs e)
        {
            EditBuilding form = new EditBuilding();
            form.SaveClickCallBack += EditSave_Callback;
            form.Building = _selectedNode.Tag as FullBuilding;
            form.Token = this.Token;
            form.ShowDialog(this);
        }

        private void tvBuilding_Delete(object sender, EventArgs e)
        {
            if (_selectedNode == null || _selectedNode.Tag == null) return;
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除该楼盘？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            FullBuilding building = _selectedNode.Tag as FullBuilding;
            DeleteBuildingRequest request = new DeleteBuildingRequest();
            request.token = this.Token;
            request.form = new BuildingQueryForm
            {
                ID = building.ID,
            };
            var response = SDKSync<CommonResponse>.CreateInstance(this).Execute(request, DeleteBuilding_Callback);
        }

        private void DeleteBuilding_Callback(CommonResponse response)
        {
            tvBuilding.TopNode.Nodes.Remove(_selectedNode);
            var building = _selectedNode.Tag as FullBuilding;
            _buildings.Remove(building);
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

        private void btnEditRoom_Click(object sender, EventArgs e)
        {

        }

        private void tvBuilding_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Tag == null) return;
            FullBuilding building = e.Node.Tag as FullBuilding;
            _selectedNode = e.Node;
            if (!tabFloor.TabPages.ContainsKey("pageFloorAll"))
            {
                MetroTabPage pageAll = new MetroTabPage();
                pageAll.Text = "所有";
                pageAll.Name = "pageFloorAll";
                pageAll.Tag = -1;
                tabFloor.TabPages.Add(pageAll);
            }
            if (building.FloorCount >= tabFloor.TabPages.Count)
            {
                for (int i = tabFloor.TabPages.Count; i <= building.FloorCount; i++)
                {
                    int floor = i;
                    MetroTabPage page = new MetroTabPage();
                    page.Text = string.Format("第{0}层", floor);
                    page.Name = string.Format("pageFloor" + floor);
                    page.Tag = floor;
                    tabFloor.TabPages.Add(page);
                }
            }
            else if (building.FloorCount < tabFloor.TabPages.Count)
            {
                for (int i = tabFloor.TabPages.Count; i > building.FloorCount + 1; i--)
                {
                    int floor = i - 1;
                    tabFloor.TabPages.RemoveAt(floor);
                }
            }
            groupBox3.Text = building.Name;
            QuerySelfAndUnallocateHouseRequest request = new QuerySelfAndUnallocateHouseRequest();
            request.token = this.Token;
            request.form = new HouseQueryForm
            {
                BuildingID = building.ID,
            };
            var response = new SDKSync<QueryHouseResponse>(this).Execute(request, tvBuilding_AfterSelect_CallBack);
        }

        private void tvBuilding_AfterSelect_CallBack(QueryHouseResponse r)
        {
            FullBuilding buiding = tvBuilding.SelectedNode.Tag as FullBuilding;
            if (buiding == null) return;
            buiding.House = r.List;
            tabFloor_SelectedIndexChanged(this, null);
        }

        private void tabFloor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_selectedNode == null || tabFloor.SelectedTab == null) return;
            FullBuilding building = _selectedNode.Tag as FullBuilding;
            _currentFloor = tabFloor.SelectedIndex;
            var datasource = building.House;
            if (_currentFloor > 0)
                datasource = (from h in building.House
                              where h.House.Floor.Equals(_currentFloor)
                              select h).ToList();
            dgvHouse.DataSource = datasource;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHouse.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请先选择房间");
                return;
            }
            var building = _selectedNode.Tag as FullBuilding;
            EditHouse form = new EditHouse();
            form.Token = this.Token;
            form.Buildings = _buildings;
            var currentHouse = dgvHouse.SelectedRows[0].DataBoundItem as FullHouse;
            form.House = currentHouse;
            form.BuildingID = building.ID;
            form.Floor = _currentFloor;
            form.Update_Callback += EditHouse_Callback;
            form.ShowDialog(this);
            //tabFloor_SelectedIndexChanged(null, null);
        }

        private void EditHouse_Callback(object sender, EventArgs e)
        {
            dgvHouse.Reset();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvHouse.SelectedRows.Count == 0)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请选中一条数据！");
                return;
            }
            if (SOAFramework.Client.Controls.MessageBox.Show(this, "是否删除该房间？", "删除", MessageBoxButtons.YesNo) == DialogResult.No) return;
            FullHouse house = dgvHouse.SelectedRows[0].DataBoundItem as FullHouse;
            string id = house.House.ID;
            DeleteHouseRequest request = new DeleteHouseRequest();
            request.token = this.Token;
            request.form = new HouseQueryForm { ID = id };
            SDKSync<CommonResponse>.CreateInstance(this).Execute(request, Delete_Callback);
        }

        private void Delete_Callback(CommonResponse response)
        {
            //var datasource = dgvHouse.DataSource as List<FullHouse>;
            //datasource.Remove(dgvHouse.SelectedRows[0].DataBoundItem as FullHouse);
            //dgvHouse.Reset();
            dgvHouse.RemoveRow<FullHouse>(dgvHouse.SelectedRows[0].DataBoundItem as FullHouse);
            SOAFramework.Client.Controls.MessageBox.Show(this, "删除成功");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_selectedNode == null)
            {
                SOAFramework.Client.Controls.MessageBox.Show(this, "请先选择一个楼盘");
                return;
            }
            var building = _selectedNode.Tag as FullBuilding;
            AddHouse form = new AddHouse();
            form.Token = this.Token;
            form.Buildings = _buildings;
            form.BuildingID = building.ID;
            form.Floor = _currentFloor;
            form.Add_Callback += AddHouse_Callback;
            form.ShowDialog(this);
        }

        private void AddHouse_Callback(object sender, EventArgs e)
        {
            FullHouse house = sender as FullHouse;
            var datasource = dgvHouse.DataSource as List<FullHouse>;
            if (datasource == null) datasource = new List<FullHouse>();
            datasource.Add(house);
            dgvHouse.Reset();
        }

        private void dgvHouse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvHouse.CurrentRow == null) return;
            FullHouse house = dgvHouse.CurrentRow.DataBoundItem as FullHouse;
            switch (dgvHouse.Columns[e.ColumnIndex].Name)
            {
                case "业主信息":
                    ViewCustomer customer = new ViewCustomer();
                    customer.Customer = house.Customer;
                    customer.Show();
                    break;
                case "房间名称":
                    var building = _selectedNode.Tag as FullBuilding;
                    ViewHouse viewhouse = new ViewHouse();
                    viewhouse.Token = Token;
                    viewhouse.BuildingID = building.ID;
                    viewhouse.Buildings = _buildings;
                    viewhouse.House = house;
                    viewhouse.Show();
                    break;
            }
        }
    }
}
