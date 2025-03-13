using MyLib.Models;
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
        private Dictionary<string, Dishes> dishesInfo = new Dictionary<string, Dishes>();


        public treeView()
        {
            InitializeComponent();
            LoadTreeView();
            InitializeDishesInfo();

            // Подписываемся на событие DoubleClick
            MyTreeView.DoubleClick += MyTreeView_DoubleClick;

            
        }
        private void InitializeDishesInfo()
        {
            // Добавляем информацию о блюдах в коллекцию
            dishesInfo.Add("Грибной крем-суп", new Dishes("Грибной крем-суп", "300 руб.", "Грибной крем-суп", "шампиньоны\nсливки\nлук\nспеции", "300 г"));
            dishesInfo.Add("Куринный", new Dishes("Куринный суп", "250 руб.", "Куринный суп", "курица\nкартофель\nморковь\nлук\nзелень", "350 г"));
            dishesInfo.Add("Цезарь", new Dishes("Цезарь", "350 руб.", "Цезарь", "курица\nлистья салата\nсухарики\nсоус Цезарь", "250 г"));
            dishesInfo.Add("Оливье", new Dishes("Оливье", "200 руб.", "Оливье", "колбаса\nкартофель\nморковь\nогурцы\nмайонез", "300 г"));
            dishesInfo.Add("Греческий", new Dishes("Греческий салат", "400 руб.", "Греческий салат", "помидоры\nогурцы\nперец\nоливки\nсыр фета", "400 г"));
            dishesInfo.Add("Красное вино", new Dishes("Вино", "500 руб.", "Выдержанное красное вино", "Красное вино", "150 мл"));
            dishesInfo.Add("Коньяк", new Dishes("Коньяк", "700 руб.", "Коньяк", "Выдержанный коньяк", "50 мл"));
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
            alko.AddChildNode("Красное вино");
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
                // Получаем название блюда
                string dishName = selectedNode.Text;

                // Проверяем, есть ли информация о блюде в коллекции
                if (dishesInfo.ContainsKey(dishName))
                {
                    // Получаем информацию о блюде
                    Dishes dishInfo = dishesInfo[dishName];

                    // Добавляем информацию о блюде в таблицу
                    dataGridViewDishInfo.Rows.Add(
                        dishInfo.DishName,
                        dishInfo.Price,
                        dishInfo.Description,
                        dishInfo.Ingredients,
                        dishInfo.PortionWeight
                    );
                }
                else
                {
                    // Если информация о блюде отсутствует
                    dataGridViewDishInfo.Rows.Add(dishName, "-", "Информация о блюде отсутствует", "-", "-");
                }
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

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
