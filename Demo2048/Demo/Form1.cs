using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;
using System.Media;

namespace Demo
{
    public partial class Form1 : Form
    {
        private int KhoangCach = 5;

        private Random Rand = new Random();
        StreamReader doc = new StreamReader("LuuDiem.txt");
        private int Diem = 0;
        private Label[,] blockLabel = new Label[4, 4];
        int[,] block = new int[4, 4];
        Stack<int[,]> myStack_Undo = new Stack<int[,]>();
        Stack<int> PreScore = new Stack<int>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Load_Form()
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;
            lb_diem.Text = "0";
            lb_bestScore.Text = doc.ReadToEnd();
            doc.Close();
            if (lb_bestScore.Text == "")
                lb_bestScore.Text = "0";

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    blockLabel[i, j] = new Label();
                    blockLabel[i, j].Location = new Point(KhoangCach + i * (100 + KhoangCach), KhoangCach + j * (100 + KhoangCach));
                    blockLabel[i, j].Size = new Size(100, 100);
                    blockLabel[i, j].TabIndex = i * 4 + j;
                    blockLabel[i, j].Name = String.Format("lb%d%d", i, j);
                    blockLabel[i, j].BackColor = Color.FromName("ActiveBorder");
                    blockLabel[i, j].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                    blockLabel[i, j].TextAlign = ContentAlignment.MiddleCenter;
                    groupBox1.Controls.Add(blockLabel[i, j]);
                }
            }
            LoadO();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Form();
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (block[i, j] == 0)
                        blockLabel[i, j].Text = "";
                    else
                        blockLabel[i, j].Text = block[i, j].ToString();
                    setMauChoO(i, j);
                }
            }
            lb_diem.Text = Diem.ToString();
        }
        bool randomViTriHien()
        {
            bool isDo = false;
            List<int> test = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                if (block[i / 4, i % 4] == 0)
                {
                    test.Add(i);
                    isDo = true;
                }
            }
            if (test.Count > 0)
            {
                int set = test[Rand.Next(0, test.Count - 1)];
                while (block[set / 4, set % 4] != 0 && test.Count > 1)
                {
                    test.Remove(set);
                    set = test[Rand.Next(0, test.Count - 1)];
                }
                block[set / 4, set % 4] = Rand.Next(1, 100) > 90 ? 4 : 2;
            }
            return isDo;
        }
        private void drawGameOver()
        {
            gameOverPanel.Visible = true;
            gameOverPanel.Enabled = true;
        }
        #region Các phím điều hướng
        bool PhimLen()
        {
            Undo();
            bool isDo = false;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    for (int y1 = y + 1; y1 < 4; y1++)
                    {
                        if (block[x, y1] > 0)
                        {
                            if (block[x, y] == 0)
                            {

                                block[x, y] = block[x, y1];
                                block[x, y1] = 0;
                                y--;
                                isDo = true;
                            }
                            else if (block[x, y] == block[x, y1])
                            {

                                block[x, y] *= 2;
                                block[x, y1] = 0;
                                isDo = true;
                                Diem += block[x, y];
                            }
                            break;
                        }
                    }
                }
            }

            if (isDo)
                randomViTriHien();
            return isDo;
        }
        bool PhimXuong()
        {
            Undo();
            bool isDo = false;

            for (int x = 0; x < 4; x++)
            {
                for (int y = 3; y >= 1; y--)
                {
                    for (int y1 = y - 1; y1 >= 0; y1--)
                    {
                        if (block[x, y1] > 0)
                        {
                            if (block[x, y] == 0)
                            {
                                block[x, y] = block[x, y1];
                                block[x, y1] = 0;
                                y++;
                                isDo = true;
                            }
                            else if (block[x, y] == block[x, y1])
                            {

                                block[x, y] *= 2;
                                block[x, y1] = 0;
                                Diem += block[x, y];
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                randomViTriHien();
            return isDo;
        }
        bool PhimPhai()
        {
            Undo();
            bool isDo = false;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 3; x >= 1; x--)
                {
                    for (int x1 = x - 1; x1 >= 0; x1--)
                    {
                        if (block[x1, y] > 0)
                        {
                            if (block[x, y] == 0)
                            {
                                block[x, y] = block[x1, y];
                                block[x1, y] = 0;
                                x++;
                                isDo = true;
                            }
                            else if (block[x, y] == block[x1, y])
                            {

                                block[x, y] *= 2;
                                block[x1, y] = 0;
                                Diem += block[x, y];
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                randomViTriHien();
            return isDo;
        }
        bool PhimTrai()
        {
            Undo();
            bool isDo = false;

            for (int y = 0; y < 4; y++)
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int x1 = x + 1; x1 < 4; x1++)
                    {
                        if (block[x1, y] > 0)
                        {
                            if (block[x, y] == 0)
                            {
                                block[x, y] = block[x1, y];
                                block[x1, y] = 0;
                                x--;
                                isDo = true;
                            }
                            else if (block[x, y] == block[x1, y])
                            {

                                Diem += block[x, y];
                                block[x, y] *= 2;
                                block[x1, y] = 0;
                                isDo = true;
                            }
                            break;
                        }
                    }
                }
            }
            if (isDo)
                randomViTriHien();
            return isDo;
        }
        #endregion
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Up || e.KeyData == Keys.W)
                PhimLen();
            if (e.KeyData == Keys.Down || e.KeyData == Keys.S)
                PhimXuong();
            if (e.KeyData == Keys.Right || e.KeyData == Keys.D)
                PhimPhai();
            if (e.KeyData == Keys.Left || e.KeyData == Keys.A)
                PhimTrai();

            this.Refresh();
            if (CheckGameOver())
            {
                drawGameOver();
                tabUndo.Enabled = false;
                if (Convert.ToInt32(lb_diem.Text) > Convert.ToInt32(lb_bestScore.Text))
                {
                    lb_bestScore.Text = lb_diem.Text;
                    lbDiem_.Text = lb_diem.Text;
                    lbBestScore_.Text = lb_bestScore.Text;
                    doc.Close();
                    StreamWriter ghi = new StreamWriter("LuuDiem.txt");
                    ghi.WriteLine(lb_diem.Text);
                    ghi.Flush();
                    ghi.Close();
                }
                else
                {
                    lbDiem_.Text = lb_diem.Text;
                    lbBestScore_.Text = lb_bestScore.Text;
                }
                
            }
        }
        bool CheckGameOver()
        {
            for (int x = 0; x < 4; x++)
            {
                for (int y = 0; y < 4; y++)
                {
                    if (block[x, y] == 0 ||
                        (y < 3 && block[x, y] == block[x, y + 1]) ||
                        (x < 3 && block[x, y] == block[x + 1, y]))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        void LoadO()
        {
            Diem = 0;
            for (int x = 0; x < 4; x++)
                for (int y = 0; y < 4; y++)
                    block[x, y] = 0;
            randomViTriHien();
            randomViTriHien();
            this.Refresh();
        }
        void setMauChoO(int x, int y)
        {
            switch (block[x, y])
            {
                case 0: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#ccc0b3");
                        break;
                case 2: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#eee4da");
                        blockLabel[x, y].ForeColor = Color.Black;
                        blockLabel[x, y].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
                case 4: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#eddfc7");
                        blockLabel[x, y].ForeColor = Color.Black;
                        blockLabel[x, y].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
                case 8: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#f2b179");
                        blockLabel[x, y].ForeColor = Color.White;
                        break;
                case 16: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#f19342");
                         blockLabel[x, y].ForeColor = Color.White;
                         blockLabel[x, y].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                         break;
                case 32: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#f67c5f");
                         blockLabel[x, y].ForeColor = Color.White;
                         blockLabel[x, y].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                         break;
                case 64: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#f65e3b");
                         blockLabel[x, y].ForeColor = Color.White;
                         blockLabel[x, y].Font = new Font("FC BARCELONA", 40F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));

                    break;
                case 128: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#edcf72");
                        blockLabel[x, y].ForeColor = Color.White;
                         blockLabel[x, y].Font = new Font("FC BARCELONA", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
                case 256: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#e7bf42");
                        blockLabel[x, y].ForeColor = Color.White;
                        blockLabel[x, y].Font = new Font("FC BARCELONA", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                          break;
                case 512: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#edc850");
                          blockLabel[x, y].ForeColor = Color.White;
                          blockLabel[x, y].Font = new Font("FC BARCELONA", 30F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                         break;
                case 1024: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#edc53f");
                           blockLabel[x, y].ForeColor = Color.White;
                           blockLabel[x, y].Font = new Font("FC BARCELONA", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                           break;
                case 2048: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#edc22e");
                           blockLabel[x, y].ForeColor = Color.White;
                           blockLabel[x, y].Font = new Font("FC BARCELONA", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                           break;
                case 4096: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#6bca10");
                           blockLabel[x, y].ForeColor = Color.White;
                           blockLabel[x, y].Font = new Font("FC BARCELONA", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
                case 8192: blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#63be08");
                            blockLabel[x, y].ForeColor = Color.White;
                        blockLabel[x, y].Font = new Font("FC BARCELONA", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
                case 16384:
                        blockLabel[x, y].BackColor = ColorTranslator.FromHtml("#5aba00");
                        blockLabel[x, y].ForeColor = Color.White;
                        blockLabel[x, y].Font = new Font("FC BARCELONA", 20F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
                        break;
            }
        }
        private void tabNewGame_Click(object sender, EventArgs e)
        {
            gameOverPanel.Visible = false;
            gameOverPanel.Enabled = false;
            if (Convert.ToInt32(lb_diem.Text) > Convert.ToInt32(lb_bestScore.Text))
            {
                doc.Close();
                StreamWriter ghi = new StreamWriter("LuuDiem.txt");
                ghi.WriteLine(lb_diem.Text);
                ghi.Flush();
                ghi.Close();
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
            else
            {
                this.Hide();
                Form1 frm = new Form1();
                frm.Show();
            }
        }
        void Undo()
        {
            int[,] undo = new int[4, 4];
            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    undo[i, j] = block[i, j];
                }
            PreScore.Push(Diem);
            myStack_Undo.Push(undo);
        }
        private void tabExit_Click(object sender, EventArgs e)
        {
                Application.Exit();
        }

        private void tabUndo_Click(object sender, EventArgs e)
        {
            if (myStack_Undo.Count == 0)
                return;
            if (myStack_Undo != null)
            {
                int[,] tempUndo = new int[4, 4];
                tempUndo = myStack_Undo.Pop();
                Diem = PreScore.Pop();
                //PreScore.Clear();
                for (int i = 0; i < 4; i++)

                    for (int j = 0; j < 4; j++)
                    {
                        block[i, j] = tempUndo[i, j];
                    }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        if (block[i, j] == 0)
                            blockLabel[i, j].Text = "";
                        else
                            blockLabel[i, j].Text = block[i, j].ToString();
                        setMauChoO(i, j);
                    }
                }
                lb_diem.Text = Diem.ToString();

            }
            else
            {
                return;
            }
        }
       
        private void changeToRed(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.Red;
        }
        private void changeToGreen(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.Green;
        }
        private void changToDarkViolet2(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.DarkViolet;
        }
        private void changToDarkViolet1(object sender, EventArgs e)
        {
            btnNewGame.BackColor = Color.DarkViolet;
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Game 2048 - Sử dụng các nút điều hướng để di chuyển các khối vuông để trượt theo các hướng tương ứng \n" +
                "+ Phím A hay phím mũi tên trái để di chuyển sang trái.\n" +
                "+ Phím D hay phím mũi tên phải để di chuyển sang phải.\n" +
                "+ Phím S hay phím mũi tên xuống để di chuyển xuống dưới.\n" +
                "+ Phím S hay phím mũi tên xuống để di chuyển lên trên.\n", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
