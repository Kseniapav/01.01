using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyTreeView
{
    public partial class treeView : Form
    {
        private List<RestoransNoteModel> treeData_ = new List<RestoransNoteModel>();

        public treeView()
        {
            InitializeComponent();
            LoadTreeView();

            // Подписываемся на событие DoubleClick
            MyTreeView.DoubleClick += MyTreeView_DoubleClick;
        }

        private void LoadTreeView()
        {
            treeData_.Add(new RestoransNoteModel("Ресторан Оникс"));
            var positions = treeData_[0];
            var hotDishes = positions.AddChildNode("Горячее");
            var sup = hotDishes.AddChildNode("Супы");
            sup.AddChildNode("Грибной крем-суп");
            sup.AddChildNode("Куринный");

            var salates = positions.AddChildNode("Салаты");
            salates.AddChildNode("Цезарь");
            salates.AddChildNode("Оливье");
            salates.AddChildNode("Греческий");

            var drinks = positions.AddChildNode("Напитки");
            var alko = drinks.AddChildNode("Алкогольные напитки");
            alko.AddChildNode("Вино");
            alko.AddChildNode("Коньяк");

            treeData_.Add(new RestoransNoteModel("Ресторан DeepHouse"));

            FillTreeNodeCollection(treeData_, MyTreeView.Nodes);
            MyTreeView.ExpandAll();
        }

        static private void FillTreeNodeCollection(List<RestoransNoteModel> sourceData, TreeNodeCollection targetData)
        {
            foreach (var node in sourceData)
            {
                var treeNode = new TreeNode(node.Name);
                targetData.Add(treeNode);

                if (node.Children != null && node.Children.Count > 0)
                {
                    FillTreeNodeCollection(node.Children, treeNode.Nodes);
                }
            }
        }

        private void MyTreeView_DoubleClick(object sender, EventArgs e)
        {
            TreeNode selectedNode = MyTreeView.SelectedNode;

            if (selectedNode != null)
            {
                string dishName = selectedNode.Text;
                string dishInfo = GetDishInfo(dishName);
                richTextBoxDishInfo.Text = dishInfo;
            }
        }

        private string GetDishInfo(string dishName)
        {
            switch (dishName)
            {
                case "Грибной крем-суп":
                    return "Грибной крем-суп\nЦена: 300 руб.\nСостав: шампиньоны, сливки, лук, специи.";
                case "Куринный":
                    return "Куринный суп\nЦена: 250 руб.\nСостав: курица, картофель, морковь, лук, зелень.";
                case "Цезарь":
                    return "Цезарь\nЦена: 350 руб.\nСостав: курица, листья салата, сухарики, соус Цезарь.";
                case "Оливье":
                    return "Оливье\nЦена: 200 руб.\nСостав: колбаса, картофель, морковь, огурцы, майонез.";
                case "Греческий":
                    return "Греческий салат\nЦена: 400 руб.\nСостав: помидоры, огурцы, перец, оливки, сыр фета.";
                case "Вино":
                    return "Вино\nЦена: 500 руб.\nКрасное или белое вино, отличный выбор к мясным блюдам.";
                case "Коньяк":
                    return "Коньяк\nЦена: 700 руб.\nВыдержанный коньяк, идеальный напиток для завершения трапезы.";
                default:
                    return "Информация о блюде отсутствует.";
            }
        }

        private void treeView_Load(object sender, EventArgs e) 
        { 

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
    }
}
