using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8tasbulmcasi
{
    public partial class Form1 : Form
    {
        public int[] buttonsList = new int[9];
        public int[] finalState = new int[9];
        public int zeroIndex = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openForm formOpen = new openForm();
            formOpen.ShowDialog();
            for (int i = 0; i < formOpen.buttonsList.Count; i++)   // show first time buttons
            {
                buttonsList[i] = int.Parse(formOpen.buttonsList[i].ToString());
            }
            buttonsChanged(buttonsList);
            for (int i = 0; i < formOpen.finalstateList.Count; i++)
            {
                finalState[i] = int.Parse(formOpen.finalstateList[i].ToString());
            }
            finalStateSet(formOpen.finalstateList);
        }

        private void loadFormElements()
        {
            foreach (var button in this.Controls.OfType<Button>())
            {
                if (button.Text == "0")
                {
                    button.BackColor = Color.Green;
                }
                else
                    button.BackColor = Color.White;
                    
                button.Update();                
            }
            
        }  //buttons update

        private void puzzleSolve_Click(object sender, EventArgs e)
        {
            if (!isSolvable(buttonsList, finalState))
            {
                MessageBox.Show("Problem Çözülemez Yeni Değerler Giriniz!");
                Form1_Load(this,null);
            }
            else
            {
                openForm open = new openForm();
                for (int i = 0; i < open.finalstateList.Count; i++)
                {
                    finalState[0] = int.Parse(open.finalstateList[i].ToString());
                }

                node currentNode;
                List<node> openList = new List<node>();
                List<node> closedList = new List<node>();
                node _firstNode = new node(buttonsList);
                _firstNode.hValue(finalState);
                openList.Add(_firstNode);
                currentNode = _firstNode;
                int count = 1;

                while (openList.Count != 0)  //Main
                {
                    currentNode = minCalculate(openList);

                    if (İsFound(currentNode))
                    {
                        break;
                    }

                    closedList.Add(currentNode);
                    openList.Remove(currentNode);

                    Move(currentNode, closedList);  // move find child nodes

                    for (int i = 0; i < currentNode.childrenList.Count; i++)
                    {
                        openList.Add(currentNode.childrenList[i]);
                        currentNode.childrenList[i].hValue(finalState);
                    }
                    count++;
                }
                counttextBox.Text = closedList.Count.ToString();
                parentToParent(currentNode);
            }
        }


        private void buttonsChanged(int[] _buttonsList) // first time init set buttons text
        {
            button1.Text = _buttonsList[0].ToString();
            button2.Text = _buttonsList[1].ToString();
            button3.Text = _buttonsList[2].ToString();
            button4.Text = _buttonsList[3].ToString();
            button5.Text = _buttonsList[4].ToString();
            button6.Text = _buttonsList[5].ToString();
            button7.Text = _buttonsList[6].ToString();
            button8.Text = _buttonsList[7].ToString();
            button9.Text = _buttonsList[8].ToString();

        }

        private void finalStateSet(List<char> buttonsList) // first time init set goal buttons text
        {
            button19.Text = buttonsList[0].ToString();
            button18.Text = buttonsList[1].ToString();
            button17.Text = buttonsList[2].ToString();
            button16.Text = buttonsList[3].ToString();
            button15.Text = buttonsList[4].ToString();
            button14.Text = buttonsList[5].ToString();
            button13.Text = buttonsList[6].ToString();
            button12.Text = buttonsList[7].ToString();
            button11.Text = buttonsList[8].ToString();

        } // hedef butonlari degistir

        private void parentToParent(node _node)  // show real time path
        {
            List<node> list = new List<node>();
            while (_node.parent != null)
            {
                list.Add(_node);
                _node = _node.parent;
            }

            for (int i = list.Count-1; i >= 0; i--)
            {
                button1.Text = list[i].nodeState[0].ToString();
                button2.Text = list[i].nodeState[1].ToString();
                button3.Text = list[i].nodeState[2].ToString();
                button4.Text = list[i].nodeState[3].ToString();
                button5.Text = list[i].nodeState[4].ToString();
                button6.Text = list[i].nodeState[5].ToString();
                button7.Text = list[i].nodeState[6].ToString();
                button8.Text = list[i].nodeState[7].ToString();
                button9.Text = list[i].nodeState[8].ToString();
                loadFormElements();
                System.Threading.Thread.Sleep(Convert.ToInt32(numericUpDownSpeed.Value));
            }
            textBoxSolution.Text = (list.Count-1).ToString();

        }     

        private node minCalculate(List<node> openlist)
        {
            int selectIndex = 0;
            for (int i = 0; i <openlist.Count ; i++)
            {
                openlist[i].fValue();
                if (openlist[i].f < openlist[selectIndex].f)
                {
                    selectIndex = i;
                }
            }
            return openlist[selectIndex];
        }

        private bool İsFound(node _node)
        {
            for (int i = 0; i < 9; i++)
            {
                if(_node.nodeState[i] != finalState[i])
                {
                    return false;
                }              
            }
            return true;
        }

        private int findZeroIndex(int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++) // find zero -0- index
            {
                if (dizi[i] == 0)
                {
                    zeroIndex = i;
                }
            }
            return zeroIndex;
        }

        private void Move(node _node, List<node> _closedList)
        {
            zeroIndex=findZeroIndex(_node.nodeState);

            MoveRight(_node.nodeState, zeroIndex, _node,_closedList);
            MoveLeft(_node.nodeState, zeroIndex, _node, _closedList);
            MoveUp(_node.nodeState, zeroIndex, _node, _closedList);
            MoveDown(_node.nodeState, zeroIndex, _node, _closedList);
        }

        // _pNode = parentNode

        private void MoveRight(int[] nodeState, int zeroIndex,node _pNode, List<node> _closedList)
        {
            if ((zeroIndex % 3) < 2)
            {
                int[] nextState = new int[9];
                nodeState.CopyTo(nextState, 0);

                int temp = nextState[zeroIndex + 1];
                nextState[zeroIndex + 1] = nextState[zeroIndex];
                nextState[zeroIndex] = temp;

                bool childExist=false;
                foreach(node item in _closedList)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (nextState[i] != item.nodeState[i])
                        {
                            childExist = false;
                            break;
                        }
                        else
                            childExist = true;
                    }
                    if (childExist == true)
                        break;
                }

                if (childExist == false)
                {
                    node child = new node(nextState);
                    child.parent = _pNode;
                    child.g = _pNode.g + 1;
                    child.hValue(finalState);
                    _pNode.childrenList.Add(child);
                }

            }
        }

        private void MoveLeft(int[] nodeState, int zeroIndex, node _pNode, List<node> _closedList)
        {
            if ((zeroIndex % 3) > 0)
            {
                int[] nextState = new int[9];
                nodeState.CopyTo(nextState, 0);

                int temp = nextState[zeroIndex - 1];
                nextState[zeroIndex - 1] = nextState[zeroIndex];
                nextState[zeroIndex] = temp;

                bool childExist = false;

                foreach (node item in _closedList)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (nextState[i] != item.nodeState[i])
                        {
                            childExist = false;
                            break;
                        }
                        else
                            childExist = true;
                    }
                    if (childExist == true)
                        break;
                }

                if (childExist == false)
                {
                    node child = new node(nextState);
                    child.parent = _pNode;
                    child.g = _pNode.g + 1;
                    child.hValue(finalState);
                    _pNode.childrenList.Add(child);
                }
            }
        }

        private void MoveUp(int[] nodeState, int zeroIndex, node _pNode, List<node> _closedList)
        {
            if ((zeroIndex - 3) >= 0)
            {
                int[] nextState = new int[9];
                nodeState.CopyTo(nextState, 0);

                int temp = nextState[zeroIndex - 3];
                nextState[zeroIndex - 3] = nextState[zeroIndex];
                nextState[zeroIndex] = temp;

                bool childExist = false;
                foreach (node item in _closedList)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (nextState[i] != item.nodeState[i])
                        {
                            childExist = false;
                            break;
                        }
                        else
                            childExist = true;
                    }
                    if (childExist == true)
                        break;
                }

                if (childExist == false)
                {
                    node child = new node(nextState);
                    child.parent = _pNode;
                    child.g = _pNode.g + 1;
                    child.hValue(finalState);
                    _pNode.childrenList.Add(child);
                }
            }
        }

        private void MoveDown(int[] nodeState, int zeroIndex, node _pNode, List<node> _closedList)
        {
            if ((zeroIndex + 3) < 9)
            {
                int[] nextState = new int[9];
                nodeState.CopyTo(nextState, 0);

                int temp = nextState[zeroIndex + 3];
                nextState[zeroIndex + 3] = nextState[zeroIndex];
                nextState[zeroIndex] = temp;

                bool childExist = false;
                foreach (node item in _closedList)
                {
                    for (int i = 0; i < 9; i++)
                    {
                        if (nextState[i] != item.nodeState[i])
                        {
                            childExist = false;
                            break;
                        }
                        else
                            childExist = true;
                    }
                    if (childExist == true)
                        break;
                }

                if (childExist == false)
                {
                    node child = new node(nextState);
                    child.parent = _pNode;
                    child.g = _pNode.g + 1;
                    child.hValue(finalState);
                    _pNode.childrenList.Add(child);
                }
            }
        }

        private bool isSolvable(int[] _nodeState, int[] _finalState)
        {
            int inv_count = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = i + 1; j < 9; j++)
                {
                    for (int x = 0; x < Array.IndexOf(_finalState, _nodeState[i]); x++)
                    {
                        if (_finalState[x] == _nodeState[j] && _nodeState[i] != 0 && _nodeState[j] != 0)
                            inv_count++;
                    }
                }
            }
            if (inv_count % 2 == 0)
                return true;

            return false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form1_Load(this, null);
        }
    }
}
