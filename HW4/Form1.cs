using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW4
{
    public partial class Form1 : Form
    {
        public String SelectedDS = "DLL";
        public DLL carListDLL = new DLL();
        public FIFOQue carListQue = new FIFOQue();
        public MAXHeap carListMH = new MAXHeap();
        public BST carListBST = new BST();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (SelectDS.Text)
            {
                case "Double Linked-List":
                    SelectedDS = "DLL";
                    break;
                case "FIFO Queue":
                    SelectedDS = "Que";
                    break;
                case "Max-Heap":
                    SelectedDS = "MH";
                    break;
                case "Binary Search Tree":
                    SelectedDS = "BST";
                    break;
                default:
                    SelectedDS = "DLL";
                    break;
            }
        }

        private void ADDbtn_Click(object sender, EventArgs e)
        {
            switch (SelectedDS)
            {
                case "DLL":
                    if (newcarCheck())
                    {
                        Car newcar = new Car(newcarMake.Text.ToString(), newcarModel.Text.ToString(), int.Parse(newcarYear.Text), int.Parse(newcarMileage.Text), int.Parse(newcarPrice.Text));
                        carListDLL.AppendTail(newcar);
                    }
                    else
                    {
                        MessageBox.Show("Please fill all blanks.");
                    }
                    break;
                case "Que":
                    if (newcarCheck())
                    {
                        Car newcar = new Car(newcarMake.Text.ToString(), newcarModel.Text.ToString(), int.Parse(newcarYear.Text), int.Parse(newcarMileage.Text), int.Parse(newcarPrice.Text));
                        carListQue.Enqueue(newcar);
                    }
                    else
                    {
                        MessageBox.Show("Please fill all blanks.");
                    }
                    break;
                case "MH":
                    if (newcarCheck())
                    {
                        Car newcar = new Car(newcarMake.Text.ToString(), newcarModel.Text.ToString(), int.Parse(newcarYear.Text), int.Parse(newcarMileage.Text), int.Parse(newcarPrice.Text));
                        carListMH.heapInsert(newcar);
                    }
                    else
                    {
                        MessageBox.Show("Please fill all blanks.");
                    }
                    break;
                case "BST":
                    if (newcarCheck())
                    {
                        Car newcar = new Car(newcarMake.Text.ToString(), newcarModel.Text.ToString(), int.Parse(newcarYear.Text), int.Parse(newcarMileage.Text), int.Parse(newcarPrice.Text));
                        carListBST.BSTInsert(newcar);
                    }
                    else
                    {
                        MessageBox.Show("Please fill all blanks.");
                    }
                    break;
                default:
                    break;
            }

            newcarMake.Clear();
            newcarModel.Clear();
            newcarYear.Clear();
            newcarMileage.Clear();
            newcarPrice.Clear();
        }

        public bool newcarCheck()
        {
            if (newcarMake.Text != "" && newcarModel.Text != "" && newcarYear.Text != "" && newcarMileage.Text != "" && newcarPrice.Text != "")
            {
                return true;
            }

            return false;
        }

        private void PrintCurrCarList_Click(object sender, EventArgs e)
        {
            switch (SelectedDS)
            {
                case "DLL":
                    if (carListDLL == null)
                    {
                        MessageBox.Show("Empty List.");
                    }
                    else
                    {
                        currentcarlist.Items.Clear();

                        string[] values = carListDLL.Print().Split('\n');

                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
                                continue;
                            currentcarlist.Items.Add(value.Trim());
                        }       
                    }
                    break;
                case "Que":
                    if (carListQue == null)
                    {
                        MessageBox.Show("Empty List.");
                    }
                    else
                    {
                        currentcarlist.Items.Clear();

                        string[] values = carListQue.Print().Split('\n');

                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
                                continue;
                            currentcarlist.Items.Add(value.Trim());
                        }
                    }
                    break;
                case "MH":
                    if (carListMH == null)
                    {
                        MessageBox.Show("Empty List.");
                    }
                    else
                    {
                        currentcarlist.Items.Clear();

                        string[] values = carListMH.Print().Split('\n');

                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
                                continue;
                            currentcarlist.Items.Add(value.Trim());
                        }
                    }
                    break;
                case "BST":
                    if (carListBST == null)
                    {
                        MessageBox.Show("Empty List.");
                    }
                    else
                    {
                        currentcarlist.Items.Clear();

                        string[] values = carListBST.Print(carListBST.root).Split('\n');

                        foreach (string value in values)
                        {
                            if (value.Trim() == "")
                                continue;
                            currentcarlist.Items.Add(value.Trim());
                        }
                    }
                    break;
                default:
                    break;
            }
        }

        private void SEARCHbtn_Click(object sender, EventArgs e)
        {
            switch (SelectedDS)
            {
                case "DLL":
                    if (searchprice == null)
                    {
                        MessageBox.Show("Please input the price.");
                    }
                    else
                    {
                        int keyPrice = int.Parse(searchprice.Text);
                        if (carListDLL.Search(keyPrice) == null)
                        {
                            searchresult.Text = "Can not find car with the key price!";
                        }
                        else
                        {
                            searchresult.Text = carListDLL.Search(keyPrice).car.Print();
                        }
                    }
                    break;
                case "Que":
                    if (searchprice == null)
                    {
                        MessageBox.Show("Please input the price.");
                    }
                    else
                    {
                        int keyPrice = int.Parse(searchprice.Text);
                        if (carListQue.Search(keyPrice) == null)
                        {
                            searchresult.Text = "Can not find car with the key price!";
                        }
                        else
                        {
                            searchresult.Text = carListQue.Search(keyPrice).car.Print();
                        }
                    }
                    break;
                case "MH":
                    MessageBox.Show("By using Max-Heap, here only show the most expensive car in the list.");
                    searchresult.Text = carListMH.Print();
                    break;
                case "BST":
                    if (searchprice == null)
                    {
                        MessageBox.Show("Please input the price.");
                    }
                    else
                    {
                        int keyPrice = int.Parse(searchprice.Text);
                        if (carListBST.Search(keyPrice) == null)
                        {
                            searchresult.Text = "Can not find car with the key price!";
                        }
                        else
                        {
                            searchresult.Text = carListBST.Search(keyPrice).car.Print();
                        }
                    }
                    break;
                default:
                    break;
            } 
        }

        private void DELETEbtn_Click(object sender, EventArgs e)
        {
            switch (SelectedDS)
            {
                case "DLL":
                    if (currentcarlist.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the car you want to delete.");
                    }
                    else
                    {
                        string selectedcar = currentcarlist.SelectedItem.ToString();
                        string[] values = selectedcar.Split('-');
                        carListDLL.Delete(int.Parse(values[3]));
                        PrintCurrCarList_Click(sender, e);
                    }
                    break;
                case "Que":
                    MessageBox.Show("By using FIFOQue, every time only delete the first car in the list.");
                    carListQue.Dequeue();
                    PrintCurrCarList_Click(sender, e);
                    break;
                case "MH":
                    MessageBox.Show("By using Max-Heap, every time only delete the most expensive car in the list.");
                    PrintCurrCarList_Click(sender, e);
                    break;
                case "BST":
                    if (currentcarlist.SelectedItem == null)
                    {
                        MessageBox.Show("Please select the car you want to delete.");
                    }
                    else
                    {
                        string selectedcar = currentcarlist.SelectedItem.ToString();
                        string[] values = selectedcar.Split('-');
                        carListBST.Delete(int.Parse(values[3]));
                        PrintCurrCarList_Click(sender, e);
                    }
                    break;
                default:
                    break;

            }
        }
    }
}
