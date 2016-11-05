using System;
using System.Windows.Forms;

namespace HW4
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DSbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectDS = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.newcarMake = new System.Windows.Forms.TextBox();
            this.newcarYear = new System.Windows.Forms.TextBox();
            this.newcarMileage = new System.Windows.Forms.TextBox();
            this.newcarPrice = new System.Windows.Forms.TextBox();
            this.PrintCurrCarList = new System.Windows.Forms.Button();
            this.currentcarlist = new System.Windows.Forms.ListBox();
            this.ADDbtn = new System.Windows.Forms.Button();
            this.DELETEbtn = new System.Windows.Forms.Button();
            this.SEARCHbtn = new System.Windows.Forms.Button();
            this.searchprice = new System.Windows.Forms.TextBox();
            this.searchresult = new System.Windows.Forms.TextBox();
            this.newcarModel = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DSbtn
            // 
            this.DSbtn.Location = new System.Drawing.Point(498, 176);
            this.DSbtn.Name = "DSbtn";
            this.DSbtn.Size = new System.Drawing.Size(127, 57);
            this.DSbtn.TabIndex = 0;
            this.DSbtn.Text = "Select";
            this.DSbtn.UseVisualStyleBackColor = true;
            this.DSbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(434, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please select the data structure:  ";
            // 
            // SelectDS
            // 
            this.SelectDS.FormattingEnabled = true;
            this.SelectDS.Items.AddRange(new object[] {
            "Double Linked-List",
            "FIFO Queue",
            "Max-Heap",
            "Binary Search Tree"});
            this.SelectDS.Location = new System.Drawing.Point(89, 177);
            this.SelectDS.Name = "SelectDS";
            this.SelectDS.Size = new System.Drawing.Size(352, 39);
            this.SelectDS.TabIndex = 2;
            this.SelectDS.Text = "Double Linked-List";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Car Information: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(113, 459);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 5;
            this.label4.Text = "Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(113, 506);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 6;
            this.label5.Text = "Mileage:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 552);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 32);
            this.label6.TabIndex = 7;
            this.label6.Text = "Price:";
            // 
            // newcarMake
            // 
            this.newcarMake.Location = new System.Drawing.Point(236, 350);
            this.newcarMake.Name = "newcarMake";
            this.newcarMake.Size = new System.Drawing.Size(138, 38);
            this.newcarMake.TabIndex = 8;
            // 
            // newcarYear
            // 
            this.newcarYear.Location = new System.Drawing.Point(236, 453);
            this.newcarYear.Name = "newcarYear";
            this.newcarYear.Size = new System.Drawing.Size(138, 38);
            this.newcarYear.TabIndex = 9;
            // 
            // newcarMileage
            // 
            this.newcarMileage.Location = new System.Drawing.Point(236, 503);
            this.newcarMileage.Name = "newcarMileage";
            this.newcarMileage.Size = new System.Drawing.Size(138, 38);
            this.newcarMileage.TabIndex = 10;
            // 
            // newcarPrice
            // 
            this.newcarPrice.Location = new System.Drawing.Point(236, 552);
            this.newcarPrice.Name = "newcarPrice";
            this.newcarPrice.Size = new System.Drawing.Size(138, 38);
            this.newcarPrice.TabIndex = 11;
            // 
            // PrintCurrCarList
            // 
            this.PrintCurrCarList.Location = new System.Drawing.Point(585, 268);
            this.PrintCurrCarList.Name = "PrintCurrCarList";
            this.PrintCurrCarList.Size = new System.Drawing.Size(361, 58);
            this.PrintCurrCarList.TabIndex = 12;
            this.PrintCurrCarList.Text = "Print Current Car List";
            this.PrintCurrCarList.UseVisualStyleBackColor = true;
            this.PrintCurrCarList.Click += new System.EventHandler(this.PrintCurrCarList_Click);
            // 
            // currentcarlist
            // 
            this.currentcarlist.FormattingEnabled = true;
            this.currentcarlist.ItemHeight = 31;
            this.currentcarlist.Location = new System.Drawing.Point(585, 350);
            this.currentcarlist.Name = "currentcarlist";
            this.currentcarlist.Size = new System.Drawing.Size(535, 190);
            this.currentcarlist.TabIndex = 13;
            // 
            // ADDbtn
            // 
            this.ADDbtn.Location = new System.Drawing.Point(119, 629);
            this.ADDbtn.Name = "ADDbtn";
            this.ADDbtn.Size = new System.Drawing.Size(202, 58);
            this.ADDbtn.TabIndex = 14;
            this.ADDbtn.Text = "Add new car";
            this.ADDbtn.UseVisualStyleBackColor = true;
            this.ADDbtn.Click += new System.EventHandler(this.ADDbtn_Click);
            // 
            // DELETEbtn
            // 
            this.DELETEbtn.Location = new System.Drawing.Point(585, 601);
            this.DELETEbtn.Name = "DELETEbtn";
            this.DELETEbtn.Size = new System.Drawing.Size(284, 70);
            this.DELETEbtn.TabIndex = 15;
            this.DELETEbtn.Text = "Delete selected car";
            this.DELETEbtn.UseVisualStyleBackColor = true;
            this.DELETEbtn.Click += new System.EventHandler(this.DELETEbtn_Click);
            // 
            // SEARCHbtn
            // 
            this.SEARCHbtn.Location = new System.Drawing.Point(89, 733);
            this.SEARCHbtn.Name = "SEARCHbtn";
            this.SEARCHbtn.Size = new System.Drawing.Size(335, 67);
            this.SEARCHbtn.TabIndex = 16;
            this.SEARCHbtn.Text = "Search car by the price:";
            this.SEARCHbtn.UseVisualStyleBackColor = true;
            this.SEARCHbtn.Click += new System.EventHandler(this.SEARCHbtn_Click);
            // 
            // searchprice
            // 
            this.searchprice.Location = new System.Drawing.Point(450, 759);
            this.searchprice.Name = "searchprice";
            this.searchprice.Size = new System.Drawing.Size(138, 38);
            this.searchprice.TabIndex = 17;
            // 
            // searchresult
            // 
            this.searchresult.Location = new System.Drawing.Point(77, 826);
            this.searchresult.Name = "searchresult";
            this.searchresult.Size = new System.Drawing.Size(678, 38);
            this.searchresult.TabIndex = 18;
            // 
            // newcarModel
            // 
            this.newcarModel.Location = new System.Drawing.Point(236, 400);
            this.newcarModel.Name = "newcarModel";
            this.newcarModel.Size = new System.Drawing.Size(138, 38);
            this.newcarModel.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 400);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 32);
            this.label7.TabIndex = 19;
            this.label7.Text = "Model:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1174, 1001);
            this.Controls.Add(this.newcarModel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.searchresult);
            this.Controls.Add(this.searchprice);
            this.Controls.Add(this.SEARCHbtn);
            this.Controls.Add(this.DELETEbtn);
            this.Controls.Add(this.ADDbtn);
            this.Controls.Add(this.currentcarlist);
            this.Controls.Add(this.PrintCurrCarList);
            this.Controls.Add(this.newcarPrice);
            this.Controls.Add(this.newcarMileage);
            this.Controls.Add(this.newcarYear);
            this.Controls.Add(this.newcarMake);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SelectDS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DSbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DSbtn;
        private Label label1;
        private ComboBox SelectDS;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox newcarMake;
        private TextBox newcarYear;
        private TextBox newcarMileage;
        private TextBox newcarPrice;
        private Button PrintCurrCarList;
        private ListBox currentcarlist;
        private Button ADDbtn;
        private Button DELETEbtn;
        private Button SEARCHbtn;
        private TextBox searchprice;
        private TextBox searchresult;
        private TextBox newcarModel;
        private Label label7;
    }

    public class Car
    {
        public string Make;
        public string Model;
        public int Year;
        public int Mileage;
        public int Price;

        public Car(string make, string model, int year, int mileage, int price)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
            Price = price;
        }

        public String Print()
        {
            return this.Make + "-" + this.Model + "-" + this.Year + "-" + this.Mileage + "-" + this.Price;
        }
    }

    public class Node
    {
        public Car car;
        public Node prev;
        public Node next;

        public Node()
        {
            car = new Car("", "", 0, 0, 0);
            prev = null;
            next = null;
        }

        public Node(Car newcar, Node forward, Node backward)
        {
            car = newcar;
            prev = forward;
            next = backward;
        }
    }

    public class DLL
    {
        public Node head;
        public Node tail;
        public int size;

        public DLL()
        {
            head = null;
            tail = null;
            size = 0;
        }

        public Node Search(int key)
        {
            Node curr = head;

            while (curr != null && !curr.car.Price.Equals(key))
            {
                curr = curr.next;
            }
            return curr;
        }

        public void Delete(int key)
        {
            Node tmp = Search(key);

            if (tmp == null)
            {
                MessageBox.Show("No such an item to delete.");
                return;
            }

            if (tmp != head && tmp != tail)
            {
                tmp.prev.next = tmp.next;
                tmp.next.prev = tmp.prev;
            }
            else if (tmp == head && tmp == tail)
            {
                head = null;
                tail = null;
            }
            else if (tmp == head && tmp != tail)
            {
                head = head.next;
                head.prev = null;
            }
            else
            {
                tmp.prev.next = null;
                tail = tmp.prev;
            }
            size--;
        }

        public void AppendHead(Car newcar)
        {
            Node tmp = new Node(newcar, null, null);

            if (head == null)
            {
                head = tmp;
                tail = tmp;
            }
            else
            {
                head.prev = tmp;
                tmp.next = head;
                head = tmp;
            }

            size++;
        }

        public void AppendTail(Car newcar)
        {
            Node tmp = new Node(newcar, null, null);

            if (head == null)
            {
                head = tmp;
                tail = tmp;
            }
            else
            {
                tmp.prev = tail;
                tail.next = tmp;
                tail = tmp;
            }

            size++;
        }

        public Node RemoveFromHead()
        {
            Node tmp = head;

            if (head != null)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null; 
                }
                else
                {
                    head = head.next;
                    head.prev = null;
                }
            }
            else
            {
                MessageBox.Show("Empty List.");
            }

            size--;
            return tmp;
        }

        public Node RemoveFromTail()
        {
            Node tmp = tail;

            if (tail != null)
            {
                if (head == tail)
                {
                    head = null;
                    tail = null;
                }
                else
                {
                    tail.prev.next = null;
                    tail = tail.prev;
                }
            }
            else
            {
                MessageBox.Show("Empty List.");
            }

            size--;
            return tmp;
        }

        public String Print()
        {
            Node curr = head;

            if (curr == null)
            {
                MessageBox.Show("Empty List.");
                return "";
            }
            else
            {
                String res = curr.car.Print();

                while (curr.next != null)
                {
                    curr = curr.next;
                    res = res + "\n" + curr.car.Print();
                }
                MessageBox.Show(res);
                return res;
            }            
        }

    }
    
    public class FIFOQue
    {
        public DLL dll;

        public FIFOQue()
        {
            dll = new DLL();
        }

        public void Enqueue(Car newcar)
        {
            dll.AppendTail(newcar);
        }

        public string Dequeue ()
        {
            return dll.RemoveFromHead().car.Make;
        }

        public Node Search(int key)
        {
            return dll.Search(key);
        }

        public string Print()
        {
            return dll.Print();
        }
    }

    public class MAXHeap
    {
        int size;
        Car[] heap;

        public MAXHeap()
        {
            heap = new Car[100];
            size = 0;
        }

        public void heapify(Car[] heap, int parent)
        {
            int Lson, Rson, largest;
            Car tmp;
            Lson = 2 * parent + 1;
            Rson = 2 * parent + 2;

            if (heap[Lson].Price > heap[parent].Price && Lson <= size - 1)
            {
                largest = Lson;
            }
            else
            {
                largest = parent;
            }

            if (heap[Rson].Price > heap[parent].Price && Rson <= size - 1)
            {
                largest = Rson;
            }

            if (largest != parent)
            {
                tmp = heap[parent];
                heap[parent] = heap[largest];
                heap[largest] = tmp;
                heapify(heap, largest);
            }
        }

        public void buildHeap()
        {
            for (int i = (size - 1) / 2; i >= 0; i--)
            {
                heapify(heap, i);
            }
        }

        public Car extracMax()
        {
            int max = heap[0].Price;
            heap[0] = heap[size - 1];
            size = size - 1;
            heapify(heap, 0);
            return heap[0];
        }

        public void heapInsert(Car newcar)
        {
            size = size + 1;
            int i = size - 1;
            int parent = (i - 1) / 2;

            while (i > 0 && heap[parent].Price < newcar.Price)
            {
                heap[i] = heap[parent];
                i = parent;
                parent = (i - 1) / 2;
            }

            heap[i] = newcar;
        }

        public string Print()
        {
            String res = "";

            for (int i = 0; i <= size - 1; i++)
            {
                res = res + "\n" + heap[i].Print();
            }

            return res;
        }
    }

    public class TreeNode
    {
        public Car car;
        public TreeNode left, right;

        public TreeNode(Car newcar)
        {
            car = newcar;
            left = null;
            right = null;
        }
    }

    public class BST
    {
        public TreeNode root;

        public BST()
        {
            root = null;
        }

        public void BSTInsert(Car newcar)
        {
            root = BSTInsert(root, newcar);
        }

        public TreeNode BSTInsert(TreeNode node, Car newcar)
        {
            if (node == null)
            {
                node = new TreeNode(newcar);
            }
            else
            {
                if (newcar.Price < node.car.Price)
                {
                    node.left = BSTInsert(node.left, newcar);
                }
                else
                {
                    node.right = BSTInsert(node.right, newcar);
                }
            }

            return node;
        }

        public TreeNode Search(int newcarprice)
        {
            TreeNode tmp = root;

            while (tmp != null && tmp.car.Price != newcarprice)
            {
                if (newcarprice < tmp.car.Price)
                {
                    tmp = tmp.left;
                }
                else
                {
                    tmp = tmp.right;
                }
            }

            return tmp;
        }

        public void Delete(int newcarprice)
        {
            if (root == null || Search(newcarprice) == null)
            {
                MessageBox.Show("No item found to delete.");
                return;
            }
            root = Delete(root, newcarprice);
        }

        public TreeNode Delete(TreeNode node, int newcarprice)
        {
            TreeNode tmp1, tmp2;

            if (node.car.Price == newcarprice)
            {
                if (node.left == null && node.right == null)
                {
                    return null;
                }
                else if (node.left == null)
                {
                    return node.right;
                }
                else if (node.right == null)
                {
                    return node.left;
                }
                else
                {
                    tmp1 = node.right;
                    tmp2 = tmp1;

                    while (tmp2.left != null)
                    {
                        tmp2 = tmp2.left;
                    }
                    tmp2.left = node.left;
                    return tmp1;
                }
            }
            else if (newcarprice < node.car.Price)
            {
                node.left = Delete(node.left, newcarprice);
            }
            else
            {
                node.right = Delete(node.right, newcarprice);
            }

            return node;
        }

        public string BSTprintres = ""; 
        public string Print(TreeNode root)
        {
            if (root != null)
            {
                Print(root.left);
                BSTprintres = root.car.Print() + "\n" + BSTprintres;
                Print(root.right);
            }
            return BSTprintres;
        }
    }
}

