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
                var dishInfo = GetDishInfo(dishName);

                // Добавляем информацию о блюде в таблицу
                dataGridViewDishInfo.Rows.Add(dishInfo.DishName, dishInfo.Price, dishInfo.Description, dishInfo.Ingredients, dishInfo.PortionWeight);
            }
        }

        private (string DishName, string Price, string Description, string Ingredients, string PortionWeight) GetDishInfo(string dishName)
        {
            switch (dishName)
            {
                case "Грибной крем-суп":
                    return ("Грибной крем-суп", "300 руб.", "Грибной крем-суп", "шампиньоны, сливки, лук, специи", "300 г");
                case "Куринный":
                    return ("Куринный суп", "250 руб.", "Куринный суп", "курица, картофель, морковь, лук, зелень", "350 г");
                case "Цезарь":
                    return ("Цезарь", "350 руб.", "Цезарь", "курица, листья салата, сухарики, соус Цезарь", "250 г");
                case "Оливье":
                    return ("Оливье", "200 руб.", "Оливье", "колбаса, картофель, морковь, огурцы, майонез", "300 г");
                case "Греческий":
                    return ("Греческий салат", "400 руб.", "Греческий салат", "помидоры, огурцы, перец, оливки, сыр фета", "400 г");
                case "Вино":
                    return ("Вино", "500 руб.", "Вино", "Красное или белое вино", "150 мл");
                case "Коньяк":
                    return ("Коньяк", "700 руб.", "Коньяк", "Выдержанный коньяк", "50 мл");
                default:
                    return ("Информация о блюде отсутствует", "", "", "", "");
            }
        }

        private void treeView_Load(object sender, EventArgs e) 
        { 

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void dataGridViewDishInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
